using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicsAssignment;

namespace GraphicsUnitTesting
{
    [TestClass]
    public class FillUnitTest
    {
        [TestMethod]
        public void FillUnitTestPractise()
        {
            // Arrange
            Bitmap bitmap = new Bitmap(640, 480);
            Graphics bitmapG = Graphics.FromImage(bitmap);
            Parser p = new Parser(bitmapG);
            // Act
            p.Filled = true;
            bool expected = true;
           
            // Assert
            Assert.AreEqual(expected, p.Filled);
        }
    }
}
