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
    public class ClearUnitTest
    {
        [TestMethod]
        public void ClearImage_Seeifitisthesamecolour() 
        {           
            //Arrange
            Bitmap myBitmap1 = new Bitmap(640, 480);
            Graphics bitmapG1 = Graphics.FromImage(myBitmap1);
            bitmapG1.Clear(Color.AliceBlue);
            Bitmap myBitmap = new Bitmap(640, 480);
            Graphics bitmapG = Graphics.FromImage(myBitmap);
            bitmapG.Clear(Color.AliceBlue);
            //Act
            Clear clear = new Clear(bitmapG);
            clear.ClearImage();
            //Assert
            Assert.AreNotEqual(bitmapG1, bitmapG);

            
        }
    }
}
