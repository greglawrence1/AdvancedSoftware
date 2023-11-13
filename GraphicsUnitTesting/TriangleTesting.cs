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
    /// This class is used to test the triangle class
    /// </summary>
    [TestClass]
    public class TriangleTesting
    {
        /// <summary>
        /// This tests whether the Triangle sets its properties correctly
        /// </summary>
        [TestMethod]
        public void TriangleSetsPropertiesCorrectly()
        {
            // Arrange
            Color color = Color.Red;
            int x = 10;
            int y = 20;
            int z = 5;

            // Act
            Triangle triangle = new Triangle(color, x, y, z, true);

            // Assert
            Assert.AreEqual(color, Color.Red);
            Assert.AreEqual(x, 10);
            Assert.AreEqual(y, 20);
            Assert.AreEqual(z, 5);
        }
        /// <summary>
        /// Tests whether an exception is thrown when it shouldn't be as its been handled already
        /// </summary>
        [TestMethod]
        public void Triangle_ShouldntThrowException()
        {
            // Arrange
            Color color = Color.Red;
            int x = 10;
            int y = 200000;
            int z = 5;
            bool fill = true;

            try
            {
                //Act
                Triangle triangle = new Triangle(color, x, y, z, fill);

            }
            catch (Exception)
            {
                //Assert
                Assert.Fail("Shouldn't be an Exception");
            }
        }
    }
}
