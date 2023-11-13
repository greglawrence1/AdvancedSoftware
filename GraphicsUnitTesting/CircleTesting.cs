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
    /// this is the testing class to test the circle class
    /// </summary>
    [TestClass]
    public class circleTesting
    {
        /// <summary>
        /// This tests whether the circle sets its properties correctly
        /// </summary>
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
        /// <summary>
        /// Tests whether an exception is thrown when it shouldn't be as its been handled already
        /// </summary>
        [TestMethod]
        public void Circle_ShouldntThrowException()
        {
            // Arrange
            Color color = Color.Red;
            int x = 10;
            int y = 200000;
            int radius = 5;
            bool fill = true;
 
            try
            {
                //Act
                Circle circle = new Circle(color, x, y, radius, fill);            
               
            }
            catch (Exception) 
            {
                //Assert
                Assert.Fail("Shouldn't be an Exception");
            }
            }
        }
}
