using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAssignment
{
    /// <summary>
    /// This class wipes a graphics surface and replaces it with a specfic colour
    /// </summary>
    public class Clear
    {
       
        Graphics g;
        /// <summary>
        /// initialises a new instance of clear
        /// </summary>
        /// <param name="g">What is going to be cleared</param>
        public Clear(Graphics g)
        {
            this.g = g;
        }
        /// <summary>
        /// Clears the image and replaces it with the colour specified
        /// </summary>
        public void ClearImage()
        {
            g.Clear(Color.DarkGray);
        }
    }
}
