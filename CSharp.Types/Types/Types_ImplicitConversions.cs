using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Types.Types
{
    [TestClass]

    ///Implicit conversions are performed by C# in a type-safe manner. For example, are conversions from smaller to larger integral types and conversions from derived classes to base classes.
    public class Types_ImplicitConversions
    {
        [TestMethod]
        public void Types_ImplicitConversion_IntToDouble()
        {
            int num1 = 10;
            double num2 = 15.8;
            var num3 = num1 + num2;

            Console.WriteLine($"Impicit conversion:int to double using oerator '+' (add): {num1} + {num2} = {num1 + num2}");
            Console.WriteLine("Type of num3 is: " + num3.GetType().Name);

            Assert.AreEqual("Double", num3.GetType().Name);
        }

        [TestMethod]
        public void Types_ImplicitConversion_IntToString()
        {
            int age = 30;
            Console.WriteLine($"My age is {age}");
        }

        [TestMethod]
        public void Types_ImplicitConversion_DoubleTrouble()
        {
            int num1 = 10;
            int num2 = 4;
            double num3 = num1 / num2;

            Console.WriteLine($"Impicit conversion:int to double using oerator '/' (division): {num1} / {num2} = {num1 / num2}");
            Console.WriteLine($"Expected 2.5 but actaul val is 2!");
            Assert.AreEqual(2.5, num3);

            //The compiler calculates the right side expression first and only then converts that result into double.
            //So, the right side expression num1 / num2 consist of integer numbers, thus the result is an integer number as well, 
            //in this example, it is 2 (the value is truncated). 
            //After that calculation, compiler converts result into a double and assigns the value to the num3 variable
        }

        
    }
}
