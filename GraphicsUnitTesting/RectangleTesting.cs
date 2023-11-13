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
    /// A test class for testing the rectangle class 
    /// </summary>
    [TestClass]
    public class RectangleTesting
    {
        /// <summary>
        /// Test whether the rectangle class sets properties correctly
        /// </summary>
        [TestMethod]
        public void RectangleSetsPropertiesCorrectly()
        {
            // Arrange
            Color color = Color.Red;
            int x = 10;
            int y = 20;
            int height = 5;
            int width = 10;
            bool fill = true;
            // Act
            GraphicsAssignment.Rectangle rect = new GraphicsAssignment.Rectangle(color, x, y, width, height, fill);

            // Assert
            Assert.AreEqual(color, Color.Red);
            Assert.AreEqual(x, 10);
            Assert.AreEqual(y, 20);
            Assert.AreEqual(height, 5);
            Assert.AreEqual(width, 10);
            Assert.AreEqual(fill, true);
        }
        /// <summary>
        /// Tests whether an exception should be thrown when it should be handled already
        /// </summary>
        [TestMethod]
        public void Rectangle_ShouldntThrowException()
        {
            // Arrange
            Color color = Color.Red;
            int x = 10;
            int y = 200000;
            int height = 5;
            int width = 10;
            bool fill = true;

            try
            {
                //Act
                GraphicsAssignment.Rectangle rectangle = new GraphicsAssignment.Rectangle(color, x, y, width, height, fill);

            }
            catch (Exception)
            {
                //Assert
                Assert.Fail("Shouldn't be an Exception");
            }
        }
    }
}
