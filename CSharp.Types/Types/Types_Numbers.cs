using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Types.Types
{
    [TestClass]
    public class Types_Numbers
    {
        [TestMethod]
        public void Types_Integers()
        {
            int num1 = 1000;
            Console.WriteLine(num1.GetType().Name);

            Assert.AreEqual("Int32", num1.GetType().Name);
        }

        [TestMethod]
        public void Types_Long()
        {
            long num1 = 15000000000L;
            Console.WriteLine(num1.GetType().Name);

            Assert.AreEqual("Int64", num1.GetType().Name);
        }

        [TestMethod]
        public void Types_Float()
        {
            float num1 = 5.75F;
            Console.WriteLine(num1.GetType().Name);

            Assert.AreEqual("Single", num1.GetType().Name);
        }

        [TestMethod]
        public void Types_Double()
        {
            double num1 = 19.99D;
            Console.WriteLine(num1.GetType().Name);

            Assert.AreEqual("Double", num1.GetType().Name);
        }

        [TestMethod]
        public void Types_Decimal()
        {
            decimal num1 = 50.5M;
            Console.WriteLine(num1.GetType().Name);

            Assert.AreEqual("Decimal", num1.GetType().Name);
        }
    }
}
