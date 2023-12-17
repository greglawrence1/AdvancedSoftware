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

            Color expectedColour = Color.Red;
            int expectedWidth = 2;
            Pen p = new Pen(expectedColour, expectedWidth);
            
            // Act
            
            Pen pen = PenSort.GetPen(expectedColour, expectedWidth);
            // Assert
            Assert.AreEqual(expectedColour, pen.Color);
            Assert.AreEqual(expectedWidth, pen.Width);

        }   
    }
}
