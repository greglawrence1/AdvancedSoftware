using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAssignment
{
    public class Cursor
    {
        private int previousX;
        private int previousY;
        public Cursor()
        {
            previousX = 0;
            previousY = 0;
        }
        public void UpdateCursor(Graphics g, int x, int y)
        {
            ClearPreviousCursor(g);
            Pen p = new Pen(Color.Blue, 2);
            g.DrawRectangle(p, x, y, 4, 4);
            previousX = x;
            previousY = y;
        }
        public void ClearPreviousCursor(Graphics g)
        {
            // Clear the previous cursor using the stored previous coordinates
            Brush clearBrush = new SolidBrush(Color.DarkGray);
            g.FillRectangle(clearBrush, previousX, previousY, 4, 4);
        }
    }
}
