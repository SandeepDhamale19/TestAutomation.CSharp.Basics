using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Operators
{
    [TestClass]
    public class Operators_Bitwise
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        
        #region Bitwise Operators
        [TestMethod]
        public void BitwiseOperators_OR()
        {
            Num1 = 6;
            Num2 = 4;
            var bln1 = ConvertToBinaryEightBits(Num1); //8-bit
            var bln2 = ConvertToBinaryEightBits(Num2); //8-bit
            Console.WriteLine($"Binary of {Num1} = {bln1}");
            Console.WriteLine($"Binary of {Num2} = {bln2}");
            Console.WriteLine($"Operator '|' (OR): {(Num1)} | {(Num2)} = {Num1 | Num2}");
            Console.WriteLine($"In Binary: {bln1} | {bln2} = {ConvertToBinaryEightBits(Num1 | Num2)}");

            Assert.AreEqual(Num1, ConvertToInteger(ConvertToBinaryEightBits(Num1 | Num2)));
        }
        
        [TestMethod]
        public void BitwiseOperators_AND()
        {
            Num1 = 6;
            Num2 = 4;
            var bln1 = ConvertToBinaryEightBits(Num1); //8-bit
            var bln2 = ConvertToBinaryEightBits(Num2); //8-bit
            Console.WriteLine($"Binary of {Num1} = {bln1}");
            Console.WriteLine($"Binary of {Num2} = {bln2}");
            Console.WriteLine($"Operator '&' (AND): {(Num1)} & {(Num2)} = {Num1 & Num2}");
            Console.WriteLine($"In Binary: {bln1} & {bln2} = {ConvertToBinaryEightBits(Num1 & Num2)}");

            Assert.AreEqual(Num2, ConvertToInteger(ConvertToBinaryEightBits(Num1 & Num2)));
        }


        [TestMethod]
        public void BitwiseOperators_XOR()
        {
            Num1 = 6;
            Num2 = 4;
            var bln1 = ConvertToBinaryEightBits(Num1); //8-bit
            var bln2 = ConvertToBinaryEightBits(Num2); //8-bit
            Console.WriteLine($"Binary of {Num1} = {bln1}");
            Console.WriteLine($"Binary of {Num2} = {bln2}");
            Console.WriteLine($"Operator '^' (XOR): {(Num1)} ^ {(Num2)} = {Num1 ^ Num2}");
            Console.WriteLine($"In Binary: {bln1} ^ {bln2} = {ConvertToBinaryEightBits(Num1 ^ Num2)}");

            Assert.AreEqual(2, ConvertToInteger(ConvertToBinaryEightBits(Num1 ^ Num2)));
        }

        [TestMethod]
        public void BitwiseOperators_Complement()
        {
            Num1 = 6;
            Num2 = 4;
            var bln1 = ConvertToBinaryEightBits(Num1); //8-bit
            Console.WriteLine($"Binary of {Num1} = {bln1}");
            Console.WriteLine($"Operator '~' (COMPLEMENT): ~{Num1} = {~Num1}");
            Console.WriteLine($"In Binary: ~{bln1} = {ConvertToBinaryEightBits(~Num1)}");

            Assert.AreEqual(-7, ConvertToInteger(ConvertToBinaryEightBits(~Num1)));
        }

        [TestMethod]
        public void BitwiseOperators_ShiftLeft()
        {
            Num1 = 6;
            Num2 = 4;
            var bln1 = ConvertToBinaryEightBits(Num1); //8-bit
            Console.WriteLine($"Binary of {Num1} = {bln1}");
            Console.WriteLine($"Operator '<<' (Shift Left): {Num1}<<1 = {Num1 << 1}");
            Console.WriteLine($"In Binary: {bln1}<<1 = {ConvertToBinaryEightBits(Num1 << 1)}");

            Assert.AreEqual(12, ConvertToInteger(ConvertToBinaryEightBits(Num1 << 1)));
        }

        [TestMethod]
        public void BitwiseOperators_ShiftRight()
        {
            Num1 = 6;
            Num2 = 4;
            var bln1 = ConvertToBinaryEightBits(Num1); //8-bit
            Console.WriteLine($"Binary of {Num1} = {bln1}");
            Console.WriteLine($"Operator '>>' (Shift Left): {Num1}>>1 = {Num1 >> 1}");
            Console.WriteLine($"In Binary: {bln1}>>1 = {ConvertToBinaryEightBits(Num1 >> 1)}");

            Assert.AreEqual(3, ConvertToInteger(ConvertToBinaryEightBits(Num1 >> 1)));
        }

        #endregion

        private string ConvertToBinaryEightBits(int number) => Convert.ToString(number, 2).PadLeft(8, '0');
        private int ConvertToInteger(string bit) => Convert.ToInt32(bit, 2);
    }
}
