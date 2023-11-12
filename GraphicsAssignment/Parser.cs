using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicsAssignment
{
    public class Parser
    {
        Graphics g;
        private bool Fill;

        public Parser(Graphics g)
        {
            this.g = g;
        }
        public bool Filled
        {
            get { return Fill; }
            set { Fill = value; }
        }

        public void parserCommand(string commands)
        {
            String[] commandList = commands.Split('\n');
            for (int i = 0; i < commandList.Length; i++)
            {
                parseCommand(commandList[i]);
            }
        }
        public void parseCommand(string command)
        {
            command.Trim().ToLower();
            String[] commands = command.Split(' ');
            ValidateCommands validate = new ValidateCommands();
            String firstcommand = commands[0];
            try
            {
                if (validate.IsAcceptedCommand(firstcommand) == false)
                {

                    throw new InvalidOperationException("You have entered an incorrect command");
                }
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("You have entered an incorrect command");
            }
            if (commands[0] == "fillon")
            {
                Filled = true;
            }
            if (commands[0] == "filloff")
            {
                Filled = false;
            }
            if (commands[0] == "circle")
            {
                int i = int.Parse(commands[1]);
                int f = int.Parse(commands[2]);
                int e = int.Parse(commands[3]);
                Circle c = new Circle(Color.Blue, i, f, e, Filled);
                c.draw(g);
            }
            if (commands[0] == "rectangle")
            {
                int q1 = int.Parse(commands[1]);
                int q2 = int.Parse(commands[2]);
                int q3 = int.Parse(commands[3]);
                int q4 = int.Parse(commands[4]);
                Rectangle r = new Rectangle(Color.AliceBlue, q1, q2, q3, q4, Filled);
                r.draw(g);
            }
        }
    }
}
