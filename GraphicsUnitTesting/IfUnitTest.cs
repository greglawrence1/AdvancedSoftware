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
    public class IfUnitTest
    {
        [TestMethod]
        public void TestIfNotEqual()
        {
            //Arrange
            Parser parser = new Parser(Graphics.FromImage(new Bitmap(1,1)));

            //Act
            parser.parseCommand("x = 10\n if x == 100\n x = 1\n endif ", 0);

            //Assert
            Assert.AreNotEqual(1, parser.variables["x"]);
           
        }
    }
}
