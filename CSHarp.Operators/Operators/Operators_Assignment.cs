using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Operators
{
    [TestClass]
    public class OperatorsTests_Assignment
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }       

        
        #region Assignment Operators
        [TestMethod]
        public void AssignmentOperators_Assignemnt()
        {
            Num1 = 5;
            Num2 = 2;
            var result = 7;
            Console.WriteLine($"Operator '=' (assignmnet): {(result)}={(Num1)} + {(Num2)} where {(result)} contains value: {Num1 + Num2}");
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void AssignmentOperators_AddAssignemnt()
        {
            Num1 = 5;
            var result = 7;
            Console.WriteLine($"Operator '+=' (add and assign): {(result)}+={(Num1)}  where {(result)} contains value: {result += Num1}");
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void AssignmentOperators_SubstractAssignemnt()
        {
            Num1 = 5;
            var result = 7;
            Console.WriteLine($"Operator '-=' (substract and assign): {(result)}-={(Num1)}  where {(result)} contains value: {result -= Num1}");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void AssignmentOperators_MultiplyAssignemnt()
        {
            Num1 = 5;
            var result = 7;
            Console.WriteLine($"Operator '*=' (multiply and assign): {(result)}*={(Num1)}  where {(result)} contains value: {result *= Num1}");
            Assert.AreEqual(35, result);
        }

        [TestMethod]
        public void AssignmentOperators_DivisionAssignemnt()
        {
            Num1 = 5;
            var result = 10;
            Console.WriteLine($"Operator '/=' (divide and assign): {(result)}/={(Num1)}  where {(result)} contains value: {result /= Num1}");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void AssignmentOperators_ModulusAssignemnt()
        {
            Num1 = 5;
            var result = 8;
            Console.WriteLine($"Operator '%=' (modulus and assign): {(result)}%={(Num1)}  where {(result)} contains value: {result %= Num1}");
            Assert.AreEqual(3, result);
        }

        #endregion
    }
}
