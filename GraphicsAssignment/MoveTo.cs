using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAssignment
{
    public class MoveTo
    {
        private int startX;
        private int startY;
        private Cursor cursor;

        public MoveTo(int startX, int startY)
        {
            this.startX = startX;
            this.startY = startY;
            this.cursor = new Cursor();
        }
        public void moveTo(Graphics g, int x, int y)
        {
            startX = x;
            startY = y;
            cursor.UpdateCursor(g, x, y);
            cursor.ClearPreviousCursor(g);
        }
    }
}
