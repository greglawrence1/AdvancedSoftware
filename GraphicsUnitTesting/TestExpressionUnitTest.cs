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
    public class TestExpressionUnitTest
    {
        [TestMethod]
        public void TestExpression()
        {
            // Arrange        
            Parser parser = new Parser(Graphics.FromImage(new Bitmap(640, 480)));
            //Act
            parser.parseCommand("TestCommand2 = 10 + 20", 1);
            //Assert
            Assert.AreEqual(30, parser.variables["TestCommand2"]);
            Assert.IsTrue(parser.variables.ContainsKey("TestCommand2"));
        }
    }
}
