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
        //private Cursor cursor;
        private Point startPos;
        private Point currentPos;
        public Point currentPosition
        {
            get { return currentPos; }
        }
        
        /// <summary>
        /// this initializes the moveto class
        /// </summary>
        public MoveTo()
        {
            startPos = new Point(0, 0);
            currentPos = startPos;
            //this.cursor = new Cursor();
        }
        /// <summary>
        /// moves the cursor to the specificed place on the graphics
        /// </summary>
        /// <param name="g">the surface where the moveto is done</param>
        /// <param name="x">the coordinate of the new x position</param>
        /// <param name="y">the coordinate of the new y position</param>
        
        public void Move(Graphics g, int x, int y) 
        {
            ClearPrevious(g);
            UpdatePosition(x, y);
            DrawCursor(g);
        }

        public void UpdatePosition(int x, int y)
        {
            currentPos = new Point(x, y);
        }

        public void ClearPrevious(Graphics g)
        {
            Pen p = new Pen(Color.DarkGray, 2);
            g.DrawRectangle(p, currentPos.X, currentPos.Y, 4, 4);
        }

        public void ResetCursor(Graphics g)
        {
            ClearPrevious(g);
            currentPos = startPos;
            DrawCursor(g);
        }   

        public void DrawCursor(Graphics g)
        {
            Pen p = new Pen(Color.Red, 2);
            g.DrawRectangle(p, currentPos.X, currentPos.Y, 4, 4);
        }

        public void InitialCursor(Graphics g) 
        {
            Pen p = new Pen(Color.Red, 2);
            g.DrawRectangle(p, startPos.X, startPos.Y, 4, 4);
        }
    }
}
