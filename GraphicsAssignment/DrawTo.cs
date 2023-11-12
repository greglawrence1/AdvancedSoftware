using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAssignment
{
    public class DrawTo
    {
        private int xPos;
        private int yPos;
        public DrawTo(int x, int y)
        {
            this.xPos = x;
            this.yPos = y;
        }
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
