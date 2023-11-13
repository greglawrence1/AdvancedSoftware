using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicsAssignment;

namespace GraphicsUnitTesting
{
    /// <summary>
    /// unit test to test the moveTo class
    /// </summary>
    [TestClass]
    public class MoveToTesting
    {
        /// <summary>
        /// this unit tests checks the bounds, an exception shouldn't be thrown as the error is handled in the code
        /// </summary>
        [TestMethod]
        public void MoveTo_ShouldntThrowException()
        {
            // Arrange
            Color color = Color.Red;
            int x = 10;
            int y = 200000;
            Bitmap bitmap = new Bitmap(640, 480);
            Graphics g;
            g = Graphics.FromImage(bitmap);
            try
            {
                //Act
                MoveTo move = new MoveTo();
                move.moveTo(g, x, y);
            }
            catch (Exception)
            {
                //Assert
                Assert.Fail("Shouldn't be an Exception");
            }
        }
    }
}
