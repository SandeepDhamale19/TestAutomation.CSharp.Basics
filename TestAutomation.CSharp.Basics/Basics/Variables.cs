using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.CSharp.Basics.Basics
{
    public class Variables
    {
        // Syntax: <data type> <variable name> = <value>;

        //C# Variable
        int num = 100;

        // C# Variables
        int number = 100;
        float rate = 10.2f;
        decimal amount = 100.50M;
        char code = 'C';
        bool isValid = true;
        string name = "Steve";

        // Late Initialization
        void LateInitialization()
        {
            int numLate;
            numLate = 100;
        }

        //Multiple Variables in a Single Line
        int i, j = 10, k = 100;

        // Multi-Line Declarations
        int a = 0,
            b = 10,
            c = 100;

        // Implicitly Typed Local Variable
        void ImplicitlyTypedVaraibles()
        {
            var d = 100; // implicitly typed local variable

            // var from expression
            int e = 10;
            var j = e + 1; // compiles as int

            var i = 10;
            Console.WriteLine("Type of i is {0}", i.GetType());

            var str = "Hello World!!";
            Console.WriteLine("Type of str is {0}", str.GetType());

            var dbl = 100.50d;
            Console.WriteLine("Type of dbl is {0}", dbl.GetType());

            var isValid = true;
            Console.WriteLine("Type of isValid is {0}", isValid.GetType());

            var ano = new { name = "Steve" };
            Console.WriteLine("Type of ano is {0}", ano.GetType());

            var arr = new[] { 1, 10, 20, 30 };
            Console.WriteLine("Type of arr is {0}", arr.GetType());

            var file = new FileInfo("MyFile");
            Console.WriteLine("Type of file is {0}", file.GetType());

        }
    }
}

