using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAssignment
{
    /// <summary>
    /// Represents an abstract class which other classes can inerit from to draw a shape
    /// </summary>
    public abstract class Shape
    {
        protected Color colour;
        protected int x;
        protected int y;
        public Shape(Color colour, int x, int y)
        {

            this.colour = colour; //shape's colour
            this.x = x; //its x pos
            this.y = y; //its y pos
            //can't provide anything else as "shape" is too general
        }

        public abstract void draw(Graphics g, Pen p); //any derrived class must implement this method

        public override string ToString()
        {
            return base.ToString() + "    " + this.x + "," + this.y + " : ";
        }
    }
}
