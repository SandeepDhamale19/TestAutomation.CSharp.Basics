using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Types.Types
{
    [TestClass]
    public class Types_ExplicitConversions
    {
        [TestMethod]
        public void Types_ExplicitConversion_Cast()
        {
            int num1 = 10;
            int num2 = 4;
            double num3 = (double)num1 / num2;

            Console.WriteLine($"Impicit conversion:int to double using oerator '/' (division): {num1} / {num2} = {num1 / num2}");
            Assert.AreEqual(2.5, num3);
        }

        [TestMethod]
        public void Types_ExplicitConversion_ConvertTo()
        {
            int num1 = 10;
            int num2 = 4;
            double num3 = Convert.ToDouble(num1) / Convert.ToDouble(num2);

            Console.WriteLine($"Impicit conversion:int to double using oerator '/' (division): {num1} / {num2} = {num1 / num2}");
            Assert.AreEqual(2.5, num3);
        }

        [TestMethod]
        public void Types_ExplicitConversion_DoubleToInteger()
        {
            double num1 = 10;
            double num2 = 4;
            int num3 = (int)(num1/num2);
                        
            Assert.AreEqual(2, num3);
        }

        [TestMethod]
        public void Types_ExplicitConversion_StringToInteger()
        {
            int num1;
            string num2 = "10";
            num1 = Convert.ToInt32(num2);

            Assert.AreEqual(10, num1);
        }

        [TestMethod]
        public void Types_ExplicitConversion_ToBoolean()
        {
            var checkTrue = Convert.ToBoolean(5 + 2);

            Assert.IsTrue(checkTrue);

            var checkFalse = Convert.ToBoolean(2 - 2);

            Assert.IsFalse(checkFalse);

            sbyte[] byteVal = { 92, 111, 115 };
            char charVal;
            foreach (sbyte b in byteVal)
            {
                charVal = Convert.ToChar(b);
                Console.WriteLine("{0} converted to '{1}'", b, charVal);
            }
        }

        [TestMethod]
        public void Types_ExplicitConversion_ToChar()
        {
            sbyte[] byteVal = { 92, 111, 115 };
            char charVal;
            foreach (sbyte b in byteVal)
            {
                charVal = Convert.ToChar(b);
                Console.WriteLine("{0} converted to '{1}'", b, charVal);
            }
        }

        [TestMethod]
        public void Types_ExplicitConversion_ToDecimal()
        {
            decimal decimalVal;
            string stringVal = "2,345.26";
            decimalVal = Convert.ToDecimal(stringVal);
            Console.WriteLine("String converted to decimal = {0} ", decimalVal);

        }

        [TestMethod]
        public void Types_ExplicitConversion_ToDateTime()
        {
            string dateString = "05/01/1996";
            ConvertToDateTime(dateString);
            dateString = "Tue Apr 28, 2009";
            ConvertToDateTime(dateString);
            dateString = "Wed Apr 28, 2009";
            ConvertToDateTime(dateString);
            dateString = "06 July 2008 7:32:47 AM";
            ConvertToDateTime(dateString);
            dateString = "17:32:47.003";
            ConvertToDateTime(dateString);
            // Convert a string returned by DateTime.ToString("R").
            dateString = "Sat, 10 May 2008 14:32:17 GMT";
            ConvertToDateTime(dateString);
            // Convert a string returned by DateTime.ToString("o").
            dateString = "2009-05-01T07:54:59.9843750-04:00";

        }

        private static void ConvertToDateTime(string value)
        {
            DateTime convertedDate;
            try
            {
                convertedDate = Convert.ToDateTime(value);
                Console.WriteLine("'{0}' converts to {1} {2} time.",
                                  value, convertedDate,
                                  convertedDate.Kind.ToString());
            }
            catch (FormatException)
            {
                Console.WriteLine("'{0}' is not in the proper format.", value);
            }
        }

    }
}
