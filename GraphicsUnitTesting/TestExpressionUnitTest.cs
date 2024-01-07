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
        public void TestExpressionplus()
        {
            //Arrange        
            Parser parser = new Parser(Graphics.FromImage(new Bitmap(640, 480)));
            //Act
            parser.parseCommand("TestCommand2 = 10 + 20", 1);
            //Assert
            Assert.AreEqual(30, parser.variables["TestCommand2"]);
            Assert.IsTrue(parser.variables.ContainsKey("TestCommand2"));
        }
        [TestMethod]
        public void TestExpressionminus()
        {
            //Arrange        
            Parser parser = new Parser(Graphics.FromImage(new Bitmap(640, 480)));
            //Act
            parser.parseCommand("TestCommand3 = 20 - 10", 1);
            //Assert
            Assert.AreEqual(10, parser.variables["TestCommand3"]);
            Assert.IsTrue(parser.variables.ContainsKey("TestCommand3"));
        }
        [TestMethod]
        public void TestExpressionmultiply()
        {
            //Arrange        
            Parser parser = new Parser(Graphics.FromImage(new Bitmap(640, 480)));
            //Act
            parser.parseCommand("TestCommand4 = 10 * 20", 1);
            //Assert
            Assert.AreEqual(200, parser.variables["TestCommand4"]);
            Assert.IsTrue(parser.variables.ContainsKey("TestCommand4"));
        }
        [TestMethod]
        public void TestExpressiondivide()
        {
            //Arrange        
            Parser parser = new Parser(Graphics.FromImage(new Bitmap(640, 480)));
            //Act
            parser.parseCommand("TestCommand5 = 20 / 10", 1);
            //Assert
            Assert.AreEqual(2, parser.variables["TestCommand5"]);
            Assert.IsTrue(parser.variables.ContainsKey("TestCommand5"));
        }
    }
}
