using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsUnitTesting
{
    [TestClass]
    public class SaveUnitTest
    {
        [TestMethod]
        public void SaveUnitTestPractise() 
        {
            // Arrange
            string expected = "hello world";
            string file = "C:\\Users\\greg_\\Documents\\projects\\GraphicsAssignment\\Savepractise.txt";
            // Act
            File.WriteAllText(expected, file);
           
            // Assert
            Assert.AreEqual(expected, File.ReadAllText(file));
        }

    }
}
