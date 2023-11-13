using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAssignment
{
    /// <summary>
    /// this is a class for moving the cursor around on the windows form
    /// </summary>
    public class MoveTo
    {
        private Cursor cursor;
        /// <summary>
        /// this initializes the moveto class
        /// </summary>
        public MoveTo()
        {
           
            this.cursor = new Cursor();
        }
        /// <summary>
        /// moves the cursor to the specificed place on the graphics
        /// </summary>
        /// <param name="g">the surface where the moveto is done</param>
        /// <param name="x">the coordinate of the new x position</param>
        /// <param name="y">the coordinate of the new y position</param>
        public void moveTo(Graphics g, int x, int y)
        {
            cursor.UpdateCursor(g, x, y);
            cursor.ClearPreviousCursor(g);
        }
    }
}
