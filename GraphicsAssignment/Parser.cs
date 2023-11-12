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
        private DrawTo h;

        public Parser(Graphics g)
        {
            this.g = g;
            h = new DrawTo(0, 0);
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
                try
                {
                    int i = int.Parse(commands[1]);
                    int f = int.Parse(commands[2]);
                    int e = int.Parse(commands[3]);
                    Circle c = new Circle(Color.Blue, i, f, e, Filled);
                    c.draw(g);
                } catch (FormatException) 
                {
                    Console.WriteLine("You Need to insert a Number in Circle");
                }
            }
            if (commands[0] == "rectangle")
            {
                try
                {
                    int q1 = int.Parse(commands[1]);
                    int q2 = int.Parse(commands[2]);
                    int q3 = int.Parse(commands[3]);
                    int q4 = int.Parse(commands[4]);
                    Rectangle r = new Rectangle(Color.AliceBlue, q1, q2, q3, q4, Filled);
                    r.draw(g);
                } catch(FormatException) 
                {
                    Console.WriteLine("You need to insert numbers for your Rectangle");
                }
            }
            if (commands[0] == "triangle")
            {
                try
                {
                    int t1 = int.Parse(commands[1]);
                    int t2 = int.Parse(commands[2]);
                    int t3 = int.Parse(commands[3]);

                    Triangle t = new Triangle(Color.AliceBlue, t1, t2, t3, Filled);
                    t.draw(g);
                }
                catch (FormatException) 
                {
                    Console.WriteLine("You need to insert numbers for your triangle");
                }
            }
            if (commands[0] == "clear")
            {
                Clear clear = new Clear(g);
                clear.ClearImage();
            }
            if (commands[0] == "drawto")
            {
                try
                {
                    int i = int.Parse(commands[1]);
                    int f = int.Parse(commands[2]);
                    h.drawTo(g, i, f);
                }
                catch (FormatException) 
                {
                   Console.WriteLine("You need to insert numbers following your drawline");
                }
            }
            if (commands[0] == "moveto")
            {
                int m1 = int.Parse(commands[1]);
                int m2 = int.Parse(commands[2]);
                MoveTo m = new MoveTo(m1, m2);
                Cursor c = new Cursor();
                m.moveTo(g, m1, m2);
                c.ClearPreviousCursor(g);
                              
            }
        }
    }
}
