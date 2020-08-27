using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Operators
{
    [TestClass]
    public class Operators_Logical
    {
        public bool bln1 { get; set; }
        public bool bln2 { get; set; }       

        /// <summary>
        /// Logical Operators operates on boolean values
        /// Logical Operators returns boolean values
        /// </summary>
        #region Logical Operators
        [TestMethod]
        public void LogicalOperators_AND()
        {
            bln1 = true;
            bln2 = false;
            Console.WriteLine($"Operator '&&' (AND): {(bln1)} && {(bln2)} = {bln1 && bln2}");
            Assert.IsFalse(bln1 && bln2);
        }

        [TestMethod]
        public void LogicalOperators_OR()
        {
            bln1 = true;
            bln2 = false;
            Console.WriteLine($"Operator '||' (OR): {(bln1)} || {(bln2)} = {bln1 || bln2}");
            Assert.IsTrue(bln1 || bln2);
        }

        [TestMethod]
        public void LogicalOperators_Not()
        {
            bln1 = true;
            bln2 = false;
            Console.WriteLine($"Operator '!' (NOT): {(bln1)} ! {(bln2)} = {!(bln1 && bln2)}");
            Assert.IsTrue(!(bln1 && bln2));
        }

        #endregion
    }
}
