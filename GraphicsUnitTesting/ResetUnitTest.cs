using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GraphicsAssignment;

namespace GraphicsUnitTesting
{
    [TestClass]
    public class ResetUnitTest
    {
        [TestMethod]
        public void TestResetCursor()
        {

            //Arrange
            Point startPos = new Point(0, 0);           
            Bitmap myBitmap = new Bitmap(640, 480);
            Graphics bitmapG = Graphics.FromImage(myBitmap);
            MoveTo move = new MoveTo();
            move.Move(bitmapG, 10, 10);
            //Act
            move.ResetCursor(bitmapG);
            //Assert
            Assert.AreEqual(move.currentPosition, startPos);
        }
        
    }
}
