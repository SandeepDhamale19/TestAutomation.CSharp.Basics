using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Operators
{
    [TestClass]
    public class Operators_Arithmatic
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        #region Arithmatic Operators

        [TestMethod]
        public void ArithmeticOperators_Addition()
        {
            Num1 = 7;
            Num2 = 3;
            Console.WriteLine($"Operator '+' (add): {Num1} + {Num2} = {Num1 + Num2}");
            Assert.AreEqual(10, Num1 + Num2);
        }

        [TestMethod]
        public void ArithmeticOperators_Substraction()
        {
            Num1 = 8;
            Num2 = 5;
            Console.WriteLine($"Operator '-' (substract): {Num1} - {Num2} = {Num1 - Num2}");
            Assert.AreEqual(3, Num1 - Num2);
        }

        [TestMethod]
        public void ArithmeticOperators_Multiplication()
        {
            Num1 = 2;
            Num2 = 3;
            Console.WriteLine($"Operator '*' (multiply): {Num1} * {Num2} = {Num1 * Num2}");
            Assert.AreEqual(6, Num1 * Num2);
        }

        [TestMethod]
        public void ArithmeticOperators_Division()
        {
            Num1 = 8;
            Num2 = 2;
            Console.WriteLine($"Operator '/' (division): {Num1} / {Num2} = {Num1 / Num2}");
            Assert.AreEqual(4, Num1 / Num2);
        }

        [TestMethod]
        public void ArithmeticOperators_Modulus()
        {
            Num1 = 7;
            Num2 = 3;
            Console.WriteLine($"Operator '%' (modulus): {Num1} % {Num2} = {Num1 % Num2}");
            Assert.AreEqual(1, Num1 % Num2);
        }

        [TestMethod]
        public void ArithmeticOperators_PreIncrement()
        {
            Num1 = 7;
            Console.WriteLine($"Operator '++' (increment): pre-increment: ++{Num1} = {++Num1}");
            Assert.AreEqual(8, Num1);
        }

        [TestMethod]
        public void ArithmeticOperators_PostIncrement()
        {
            Num1 = 7;
            Console.WriteLine($"Operator '++' (increment): post-increment: {Num1}++ = {Num1++}");
            Assert.AreEqual(8, Num1);
        }

        [TestMethod]
        public void ArithmeticOperators_PreDecrement()
        {
            Num1 = 7;
            Console.WriteLine($"Operator '--' (decrement): pre-increment: --{Num1} = {--Num1}");
            Assert.AreEqual(6, Num1);
        }

        [TestMethod]
        public void ArithmeticOperators_PostDecrement()
        {
            Num1 = 7;
            Console.WriteLine($"Operator '--' (decrement): post-increment: {Num1}-- = {Num1--}");
            Assert.AreEqual(6, Num1);
        }

        #endregion

        
    }
}
