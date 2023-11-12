using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAssignment
{
    public class Circle : Shape
    {
        protected int radius;
        protected bool fill;
        public Circle(Color colour, int x, int y, int radius, bool fill) : base(colour, x, y)
        {

            this.radius = radius; //the only thingthat is different from shape
            this.fill = fill;
        }
        public override void draw(Graphics g)
        {
            
                if (x > 0 && x < 640 && y > 0 && y < 640 && radius > 0 && radius < 30)
                {
                    Pen p = new Pen(Color.Black, 2);
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
