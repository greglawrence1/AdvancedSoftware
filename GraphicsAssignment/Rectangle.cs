using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAssignment
{
    /// <summary>
    /// Represents a Rectangle that can be drawn on a windows form which inherits 
    /// from the Shape class
    /// </summary>
    public class Rectangle : Shape
    {
        protected int width, height;
        protected bool fill;
        /// <summary>
        /// Initizalises the Rectangle Class
        /// </summary>
        /// <param name="colour">this is the colour of the rectangle</param>
        /// <param name="x">this is the first coordinate of the rectangle</param>
        /// <param name="y">this is the second coordinate of the rectangle</param>
        /// <param name="width">this is the width of the rectangle</param>
        /// <param name="height">this is the height of the rectangle</param>
        /// <param name="fill">this dictates whether the triangle should be filled or not, if true then filled</param>
        public Rectangle(Color colour, int x, int y, int width, int height, bool fill) : base(colour, x, y)
        {

            this.width = width; //the only thingthat is different from shape
            this.height = height;
            this.fill = fill;
        }

        /// <summary>
        /// This does the drawing of the rectangle onto the graphic
        /// </summary>
        /// <param name="g">this is the graphic</param>
        public override void draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            SolidBrush b = new SolidBrush(colour);
            if (x > 0 && x < 640 && y > 0 && y < 640 && height > 0 && height < 200 && width > 0 && width < 200)
            {
                if (fill)
                {
                    g.FillRectangle(b, x, y, width, height);
                }
                else
                {
                    g.DrawRectangle(p, x, y, width, height);
                }
            }
            else
            {
                Console.WriteLine("Numbers are out of Range");
            }
        }
    }
}
