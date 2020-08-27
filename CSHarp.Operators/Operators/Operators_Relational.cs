using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Operators
{
    [TestClass]
    public class Operators_Relational
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }       

        /// <summary>
        /// Relational operators returns boolean values
        /// Use IsTure/ IsFalse while asserting values
        /// </summary>
        /// 
        #region Relational Operators
        [TestMethod]
        public void RelationalOperators_Equal()
        {
            Num1 = 7;
            Num2 = 7;
            Console.WriteLine($"Operator '==' (equal): {(Num1)} == {(Num2)} = {Num1 == Num2}");
            Assert.AreEqual(Num1, Num2);
        }

        [TestMethod]
        public void RelationalOperators_NotEqual()
        {
            Num1 = 7;
            Num2 = 3;
            Console.WriteLine($"Operator '!=' (notequal): {(Num1)}!= {(Num2)} = {Num1 != Num2}");
            Assert.IsTrue(Num1 != Num2);
        }

        [TestMethod]
        public void RelationalOperators_GreaterThan()
        {
            Num1 = 7;
            Num2 = 3;
            Console.WriteLine($"Operator '>' (greater than): {(Num1)} > {(Num2)} = {Num1 > Num2}");
            Assert.IsTrue(Num1 > Num2);
        }

        [TestMethod]
        public void RelationalOperators_LessThan()
        {
            Num1 = 3;
            Num2 = 7;
            Console.WriteLine($"Operator '<' (less than): {nameof(Num1)} < {nameof(Num2)} = {Num1 < Num2}");
            Assert.IsTrue(Num1 < Num2);
        }

        [TestMethod]
        public void RelationalOperators_GreaterThanOrEqual()
        {
            Num1 = 7;
            Num2 = 3;
            Console.WriteLine($"Operator '>=' (greater than or equal): {(Num1)} >= {(Num2)} = {Num1 >= Num2}");
            Assert.IsTrue(Num1 >= Num2);
        }

        [TestMethod]
        public void RelationalOperators_LessThanOrEqual()
        {
            Num1 = 3;
            Num2 = 7;
            Console.WriteLine($"Operator '<=' (less than or equal): {nameof(Num1)} <= {nameof(Num2)} = {Num1 <= Num2}");
            Assert.IsTrue(Num1 <= Num2);
        }
        #endregion
    }
}
