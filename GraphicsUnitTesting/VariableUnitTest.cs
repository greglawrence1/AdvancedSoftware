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
    public class VariableUnitTest
    {
        Graphics g;

        [TestMethod]
        public void TestVariableAssigment()
        {
            // Arrange        
            Parser parser = new Parser(Graphics.FromImage(new Bitmap(640, 480)));
            //Act
            parser.parseCommand("TestCommand = 10", 1);
            //Assert
            Assert.AreEqual(10, parser.variables["TestCommand"]);
            Assert.IsTrue(parser.variables.ContainsKey("TestCommand"));
        }
    }
}
