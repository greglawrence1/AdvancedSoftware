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
    public class DrawToTesting
    {
        [TestMethod]
        public void DrawTo_CorrectCoordinates() 
        {
            DrawTo draw = new DrawTo(10, 10);

        }
        [TestMethod]
        public void DrawTo_ShouldntThrowException()
        {
            // Arrange
            Color color = Color.Red;
            int x = 10;
            int y = 200000;
            try
            {
                //Act
                DrawTo draw = new DrawTo(x, y);

            }
            catch (Exception)
            {
                //Assert
                Assert.Fail("Shouldn't be an Exception");
            }
        }
    }
}
