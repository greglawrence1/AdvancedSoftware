using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicsAssignment
{
    /// <summary>
    /// This is the class for parsing my commands
    /// </summary>
    public class Parser
    {
        private MoveTo moveto;
        private Point currentPosition;
        Pen p;
        /// <summary>
        /// the graphics object used for drawing
        /// </summary>
        Graphics g;
        /// <summary>
        /// Indicates whether to fill shapes for drawing
        /// </summary>
        private bool Fill;
        /// <summary>
        /// Object used for positioning
        /// </summary>
        private DrawTo h;
        /// <summary>
        /// Initializes the parser class
        /// </summary>
        /// <param name="g"> the graphic used for drawing</param>
        public Parser(Graphics g)
        {
            this.g = g;
            this.moveto = new MoveTo();
            this.currentPosition = new Point(0, 0);
            p = PenSort.GetStarterPen();
            h = new DrawTo(0, 0);
        }
        /// <summary>
        /// Dictates Whether Shapes should be filled by getting a value of true or false
        /// </summary>
        public bool Filled
        {
            get { return Fill; }
            set { Fill = value; }
        }
        public void setPen(Color colour, int width)
        {
            p = PenSort.GetPen(colour, width);
        }
        /// <summary>
        /// Parses the commands
        /// </summary>
        /// <param name="commands">what gets parsed and is split when a new line occurs</param>
        public void parserCommand(string commands)
        {
            String[] commandList = commands.Split('\n');
            for (int i = 0; i < commandList.Length; i++)
            {
                parseCommand(commandList[i]);
            }
        }
        /// <summary>
        /// Parses a single command
        /// </summary>
        /// <param name="command">command gets parsed split with a space</param>
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
            if (commands[0] == "setpen")
            {
                try
                {
                    if (commands[1] == "black")
                    {
                        setPen(Color.Black, 2); 
                    }
                    if (commands[1] == "red")
                    {
                        setPen(Color.Red, 2);
                    }
                    if (commands[1] == "blue")
                    {
                        setPen(Color.Blue, 2);
                    }
                }
                               catch (FormatException)
                {
                    Console.WriteLine("You need to choose either black, red or blue for your pen");
                }
            }
            if (commands[0] == "circle")
            {
                try
                {
                    //int i = int.Parse(commands[1]);
                    //int f = int.Parse(commands[2]);
                    int e = int.Parse(commands[1]);
                    Circle c = new Circle(Color.Snow, currentPosition.X, currentPosition.Y, e, Filled);
                    c.draw(g, p);
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
                    Rectangle r = new Rectangle(Color.AliceBlue, currentPosition.X, currentPosition.Y, q1, q2, Filled);
                    r.draw(g,p);
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
                    t.draw(g, p);
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
                currentPosition = new Point(m1, m2);
                moveto.moveTo(g, m1, m2);
                //MoveTo m = new MoveTo();
                //Cursor c = new Cursor();
                //m.moveTo(g, m1, m2);
                //c.ClearPreviousCursor(g);
                              
            }
        }
    }
}
