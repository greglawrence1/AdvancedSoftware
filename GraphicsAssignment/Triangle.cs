using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAssignment
{
    /// <summary>
    /// Represents a triangle that can be drawn on a windows form which inherits 
    /// from the Shape class
    /// </summary>
    public class Triangle : Shape
    {

        protected int z;
        protected bool fill;

        /// <summary>
        /// Initizalises the Triangle Class
        /// </summary>
        /// <param name="colour">this is the colour of the triangle</param>
        /// <param name="x">this is the first coordinate of the triangle</param>
        /// <param name="y">this is the second coordinate of the triangle</param>
        /// <param name="z">this is the third coordinate of the triangle</param>
        /// <param name="fill">this dictates whether the triangle should be filled or not, if true then filled </param>
        public Triangle(Color colour, int x, int y, int z, bool fill) : base(colour, x, y)
        {
            this.z = z;
            this.fill = fill;
        }
        /// <summary>
        /// This does the drawing of the triangle onto the graphic
        /// </summary>
        /// <param name="g">this is the graphic</param>
        public override void draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            SolidBrush b = new SolidBrush(colour);
            if (x > 0 && x < 640 && y > 0 && y < 640 && z > 0 && z < 480)
            {
                if (fill)
                {
                    g.FillPolygon(b, new Point[] { new Point(x, y), new Point(y, z), new Point(z, x) });
                }
                else
                {
                    g.DrawPolygon(p, new Point[] { new Point(x, y), new Point(y, z), new Point(z, x) });
                }
            }
            else
            {
                Console.WriteLine("Numbers are out of Range");
            }
        }
    }
}
