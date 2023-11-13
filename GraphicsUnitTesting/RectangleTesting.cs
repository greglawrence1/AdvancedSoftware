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
    public class RectangleTesting
    {
        [TestMethod]
        public void RectanleSetsPropertiesCorrectly()
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
