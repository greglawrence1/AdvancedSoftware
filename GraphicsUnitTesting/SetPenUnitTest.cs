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
    public class SetPenUnitTest
    {
        [TestMethod]
        public void SetPenTesting()
        {
            // Arrange
           // Bitmap myBitmap = new Bitmap(600, 500);
            //Graphics bmG;
            //bmG = Graphics.FromImage(myBitmap);
           // Parser parser = new Parser(bmG);
            Color expectedColour = Color.Red;
            int expectedWidth = 2;
            Pen p = new Pen(expectedColour, expectedWidth);
            
            // Act
            //parser.parserCommand("setpen red");
            Pen pen = PenSort.GetPen(expectedColour, expectedWidth);
            // Assert
            Assert.AreEqual(expectedColour, pen.Color);
            Assert.AreEqual(expectedWidth, pen.Width);

        }   
    }
}
