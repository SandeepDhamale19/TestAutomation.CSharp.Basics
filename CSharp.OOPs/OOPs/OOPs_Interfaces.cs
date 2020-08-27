using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.CSharp.OOPs
{
    public class Interfaces
    {
        // An interface includes the declarations of related functionalities.
        // The entities that implement the interface must provide the implementation of declared functionalities.

        // An Inteface example: TestAutomation.CSharp.Basics.OOPs >> InterfaceExample.cs
        // An Inteface implementation example: See below: IntefaceImplementation
    }

    public class FileInfo : IFile
    {
        public void ReadFile()
        {
            Console.WriteLine("Reading File");
        }

        public void WriteFile(string text)
        {
            Console.WriteLine("Writing to file");
        }

        public void InterfaceImplement()
        {
            IFile file1 = new FileInfo();
            FileInfo file2 = new FileInfo();

            file1.ReadFile();
            file1.WriteFile("content");

            file2.ReadFile();
            file2.WriteFile("content");
        }
    }
}
