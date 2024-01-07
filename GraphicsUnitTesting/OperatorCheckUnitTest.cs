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
    public class OperatorCheckUnitTest
    {
        [TestMethod]
        public void TestOperatorGreaterThan()
        {
            //Arrange
            Parser parser = new Parser(Graphics.FromImage(new Bitmap(1,1)));

            parser.variables.Add("OperatorTest", 1);

            string[] command = {"if", "OperatorTest", ">", "0" };    
            //Act
            bool result = parser.operatorCheck(command, 0, 1);
            
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestOperatorGreaterThanFalse()
        {
            //Arrange
            Parser parser = new Parser(Graphics.FromImage(new Bitmap(1, 1)));

            parser.variables.Add("OperatorTest", 1);

            string[] command = { "if", "OperatorTest", ">", "2" };
            //Act
            bool result = parser.operatorCheck(command, 0, 1);
            //Assert

            Assert.IsFalse(result);
        }
    }
}
