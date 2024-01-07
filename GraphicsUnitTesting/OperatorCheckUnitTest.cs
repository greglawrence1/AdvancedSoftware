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
            Parser parser = new Parser(Graphics.FromImage(new Bitmap(1,1)));

            parser.variables.Add("OperatorTest", 1);

            string[] command = {"if", "OperatorTest", ">", "0" };    

            bool result = parser.operatorCheck(command, 0, 1);
            
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestOperatorGreaterThanFalse()
        {
            Parser parser = new Parser(Graphics.FromImage(new Bitmap(1, 1)));

            parser.variables.Add("OperatorTest", 1);

            string[] command = { "if", "OperatorTest", ">", "2" };

            bool result = parser.operatorCheck(command, 0, 1);

            Assert.IsFalse(result);
        }
    }
}
