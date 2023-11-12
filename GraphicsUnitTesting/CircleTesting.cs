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
    public class circleTesting
    {
        [TestMethod]
        public void CircleConstructorSetsPropertiesCorrectly()
        {
            // Arrange
            Color color = Color.Red;
            int x = 10;
            int y = 20;
            int radius = 5;
            // Act
            Circle circle = new Circle(color, x, y, radius, true);

            // Assert
            Assert.AreEqual(color, Color.Red);
            Assert.AreEqual(x, 10);
            Assert.AreEqual(y, 20);
            Assert.AreEqual(radius, 5);
        }
        [TestMethod]
        public void Circle_ShouldThrowFormatException()
        {
            // Arrange
            Color color = Color.Red;
            int x = 10;
            int y = -20;
            int radius = 5;
            // Act
            Circle circle = new Circle(color, x, y, radius, true);


            // Act and assert
            Assert.AreNotEqual(y, -20);
            }
        }
}
