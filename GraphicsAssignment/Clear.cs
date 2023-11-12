using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAssignment
{
    public class Clear
    {
        Graphics g;
        public Clear(Graphics g)
        {
            this.g = g;
        }
        public void ClearImage()
        {
            g.Clear(Color.DarkGray);
        }
    }
}
