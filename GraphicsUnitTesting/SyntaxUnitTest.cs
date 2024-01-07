using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicsAssignment;

namespace GraphicsUnitTesting
{
    [TestClass]
    public class SyntaxUnitTest
    {
        [TestMethod]
        public void TestErrorsEmpty()
        {
            // Arrange
            errorCheck errorCheck = new errorCheck();
            string commands = "circle 100\nrectangle 100 100";

            // Act
            errorCheck.checkSyntax(commands);

            // Assert
            Assert.AreEqual(0, errorCheck.errors.Count);
           
        }
        
        [TestMethod]
        public void TestErrorsNotEmpty()
        {
            // Arrange
            errorCheck errorCheck = new errorCheck();
            string commands = "circle x\nrectangle 100 100\n";
            // Act
            errorCheck.checkSyntax(commands);
            // Assert
            Assert.AreNotEqual(0, errorCheck.errors.Count);
        }
    }
}
