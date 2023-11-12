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
        }
    }
}
