using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAssignment
{
    public class Triangle : Shape
    {

        protected int z;
        protected bool fill;
        public Triangle(Color colour, int x, int y, int z, bool fill) : base(colour, x, y)
        {
            this.z = z;
            this.fill = fill;
        }
        public override void draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            SolidBrush b = new SolidBrush(colour);
            if (fill)
            {
                g.FillPolygon(b, new Point[] { new Point(x, y), new Point(y, z), new Point(z, x) });
            }
            else
            {
                g.DrawPolygon(p, new Point[] { new Point(x, y), new Point(y, z), new Point(z, x) });
            }
        }
    }
}
