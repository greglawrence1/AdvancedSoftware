using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsUnitTesting
{
    [TestClass]
    public class LoadUnitTest
    {
        [TestMethod]
        public void LoadTesting()
        {
            string test = " ";
            string expected = "C:\\Users\\greg_\\Documents\\projects\\GraphicsAssignment\\Savepractise.txt";

            test = File.ReadAllText(expected);

            Assert.AreEqual("hello world", test);
        }
    }
}
