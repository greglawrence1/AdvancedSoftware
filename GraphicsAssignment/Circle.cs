using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAssignment
{
    /// <summary>
    /// Represents a Circle that can be drawn on a windows form which inherits 
    /// from the Shape class
    /// </summary>
    public class Circle : Shape
    {
        protected int radius;
        protected bool fill;

        /// <summary>
        /// Initizalises the Rectangle Class
        /// </summary>
        /// <param name="colour">this is the colour of the circle</param>
        /// <param name="x">this is the first coordinate of the circle</param>
        /// <param name="y">this is the second coordinate of the circle</param>
        /// <param name="radius">this is the width of the circle</param>
        /// <param name="fill">this dictates whether the circle should be filled or not, if true then filled</param>
        public Circle(Color colour, int x, int y, int radius, bool fill) : base(colour, x, y)
        {

            this.radius = radius; //the only thingthat is different from shape
            this.fill = fill;
        }
        /// <summary>
        /// This does the drawing of the circle onto the graphic
        /// </summary>
        /// <param name="g">this is the graphic</param>
        public override void draw(Graphics g, Pen p)
        {
            
                if (x > 0 && x < 640 && y > 0 && y < 640 && radius > 0 && radius < 30)
                {
                    //Pen p = new Pen(Color.Black, 2);
                    SolidBrush b = new SolidBrush(colour);
                    if (fill)
                    {
                        g.FillEllipse(b, x, y, radius * 2, radius * 2);
                    }
                    else
                    {
                        g.DrawEllipse(p, x, y, radius * 2, radius * 2);
                    }
                }
                else 
                {
                Console.WriteLine("Numbers are out of Range");
                }

        }

        public override string ToString() //all classes inherit from object and ToString() is abstract in object
        {
            return base.ToString() + "  " + this.radius;
        }
    }
}
