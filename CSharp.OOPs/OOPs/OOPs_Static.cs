using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.OOPs.OOPs
{
    [TestClass]
    public class OOPs_Static
    {
        static int counter = 0;
        string name = "Demo Program";

        [TestMethod]
        public void Static_AccessStaticClass()
        {
            var result = Calculator.Sum(10, 25); // calling static method
            Calculator.Store(result);

            var calcType = Calculator.Type; // accessing static variable
            Calculator.Type = "Scientific"; // assign value to static variable
        }

        [TestMethod]
        public void Static_AccessStaticFields()
        {
            StopWatch sw1 = new StopWatch();
            StopWatch sw2 = new StopWatch();
            Console.WriteLine(StopWatch.NoOfInstances);

            StopWatch sw3 = new StopWatch();
            StopWatch sw4 = new StopWatch();
            Console.WriteLine(StopWatch.NoOfInstances);
        }

        [TestMethod]
        public void Static_Methods()
        {
            StaticMethodExample();
        }

        static void StaticMethodExample()
        {
            counter++; // can access static fields
            Display("Hello World!"); // can call static methods

            //name = "New Demo Program"; //Error: cannot access non-static members
            //SetRootFolder("C:\\MyProgram"); //Error: cannot call non-static method
        }

        static void Display(string text)
        {
            Console.WriteLine(text);
        }

        public void SetRootFolder(string path) { }
    }

    public static class Calculator
    {
        private static int _resultStorage = 0;

        public static string Type = "Arithmetic";

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void Store(int result)
        {
            _resultStorage = result;
        }
    }

    public class StopWatch
    {
        public static int NoOfInstances = 0;

        public StopWatch()
        {
            StopWatch.NoOfInstances++;
        }
    }
}
