using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Operators
{
    [TestClass]
    public class Operators_OperatorPrecedence
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Num3 { get; set; }
        public int Num4 { get; set; }
        
        #region Operator Precedence
        [TestMethod]
        public void OperatorsPrecedence()
        {
            Num1 = 2;
            Num2 = 3;
            Num3 = 10;
            Num4 = 5;
            int result = Num1 + Num2 * Num3 / Num4;
            Console.WriteLine($"Num1 + Num2 * Num3/Num4 = {result}");
            Assert.AreEqual(8, result);
            result = Num1 + Num2 * (Num3 / Num4);
            Console.WriteLine($"Num1 + Num2 * (Num3/Num4) = {result}");
            Assert.AreEqual(8, result);
            result = (Num1 + (Num2 * Num3)) / Num4;
            Console.WriteLine($"(Num1 + (Num2 * Num3)) /Num4 = {result}");
            Assert.AreEqual(6, result);
            result = (Num1 + Num2) * Num3 / Num4;
            Console.WriteLine($"(Num1 + Num2) * Num3/Num4 = {result}");
            Assert.AreEqual(10, result);
        }

        

        #endregion
    }
}
