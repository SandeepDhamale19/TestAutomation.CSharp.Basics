using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Exceptions.Exceptions
{
    [TestClass]
    public class Exceptions_Handling
    {
        [TestMethod]
        public void Exceptions_HandlingExceptions()
        {
            try
            {
                Console.WriteLine("Enter a number: ");

                var num = int.Parse(Console.ReadLine());

                Console.WriteLine($"Squre of {num} is {num * num}");
            }
            catch
            {
                Console.Write("Error occurred.");
            }
            finally
            {
                Console.Write("Re-try with a different number.");
            }
        }

        [TestMethod]
        public void Exceptions_HandlingFilters()
        {
            Console.Write("Please enter a number to divide 100: ");

            try
            {
                int num = int.Parse(Console.ReadLine());

                int result = 100 / num;

                Console.WriteLine("100 / {0} = {1}", num, result);
            }
            catch (DivideByZeroException ex)
            {
                Console.Write("Cannot divide by zero. Please try again.");
            }
            catch (InvalidOperationException ex)
            {
                Console.Write("Invalid operation. Please try again.");
            }
            catch (FormatException ex)
            {
                Console.Write("Not a valid format. Please try again.");
            }
            catch (Exception ex)
            {
                Console.Write("Error occurred! Please try again.");
            }
        }

        [TestMethod]
        public void Exceptions_Finally()
        {
            FileInfo file = null;

            try
            {
                Console.Write("Enter a file name to write: ");
                string fileName = Console.ReadLine();
                file = new FileInfo(fileName);
                file.AppendText();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: {0}", ex.Message);
            }
            finally
            {
                // clean up file object here;
                file = null;
            }
        }
    }
}
