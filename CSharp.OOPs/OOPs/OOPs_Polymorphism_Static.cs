using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.OOPs.OOPs
{
    [TestClass]
    public class OOPs_Polymorphism_Static
    {
        Printdata p = new Printdata();

        [TestMethod]
        public void OOPs_Polymorhism_Static_MethodOverloading()
        {
            // Call print to print integer
            p.print(5);

            // Call print to print float
            p.print(500.263);

            // Call print to print string
            p.print("Hello C#");

            // Call print to print string1, string2
            p.print("Hello C#", "Hello .NET");

            // A: Call print to print string, int
            p.print(5, "Hello .NET");

            // B: Call print to print int, strings
            p.print("Hello C#", 5);
        }
    }

    public class Printdata
    {
        public void print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }
        public void print(double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }
        public void print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }

        // By passing different number of arguments
        public void print(string sa, string sb)
        {
            Console.WriteLine("Printing strings: {0}, {1}", sa, sb);
        }

        // A: by swapping arguments with different types
        public void print(int i, string s)
        {
            Console.WriteLine("Printing values: {0}, {1}", i, s);
        }

        // B: by swapping arguments with different types
        public void print(string s, int i)
        {
            Console.WriteLine("Printing values: {0}, {1}", s, i);
        }
    }
}
