using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Types.Types
{
    [TestClass]
    public class Types_Boolean
    {
        [TestMethod]
        public void Types_BooleanCheck()
        {
            int x = 10;
            int y = 9;
            Console.WriteLine(x > y);

            Assert.IsTrue(x > y);
        }
    }
}
