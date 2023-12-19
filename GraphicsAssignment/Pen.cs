using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAssignment
{
    /// <summary>
    /// Class created to sort pens colour and width
    /// </summary>
    public class PenSort
    {
        /// <summary>
        /// Method to get the pen colour and width
        /// </summary>
        /// <param name="colour"></param>
        /// <param name="width"></param>
        /// <returns>The new pen with colour and width</returns>
        
         public static Pen GetPen(Color colour, int width)
        {
            return new Pen(colour, width);
        }
        /// <summary>
        /// Creates a starterpen so that a pen is always available
        /// </summary>
        /// <returns>The starter pen</returns>
        public static Pen GetStarterPen()
        {
            return new Pen(Color.AliceBlue, 2);
        }

    }
}
