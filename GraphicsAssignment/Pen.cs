using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAssignment
{
    public class PenSort
    {
        
         public static Pen GetPen(Color colour, int width)
        {
            return new Pen(colour, width);
        }
        public static Pen GetStarterPen()
        {
            return new Pen(Color.AliceBlue, 2);
        }

    }
}
