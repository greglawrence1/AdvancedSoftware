using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAssignment
{
    /// <summary>
    /// This is class for drawing lines on a windows form
    /// </summary>
    public class DrawTo
    {
        private int xPos;
        private int yPos;
        /// <summary>
        /// Initializes a new instance of the DrawTo class
        /// </summary>
        /// <param name="x"> this is the inital x co ordinate</param>
        /// <param name="y"> this is the inital y co ordinate</param>
        public DrawTo(int x, int y)
        {
            this.xPos = x;
            this.yPos = y;
        }
        /// <summary>
        /// draws a line on the graphics bitmap from the current position to the new position
        /// </summary>
        /// <param name="g">the graphics on what it is drawn</param>
        /// <param name="x">the ending x co ordinate</param>
        /// <param name="y">the ending y co ordinate</param>
        public void drawTo(Graphics g, int x, int y)
        {
            Pen p = new Pen(Color.Black, 2);
            if (x > 0 && x < 640 && y > 0 && y < 480)
            {
                g.DrawLine(p, xPos, yPos, x, y);

                xPos = x;
                yPos = y;
            }
            else
            {
                Console.WriteLine("Error in numbers");
            }
        }
    }
}
