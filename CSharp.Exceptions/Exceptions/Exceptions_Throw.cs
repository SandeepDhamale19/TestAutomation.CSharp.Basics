using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Exceptions.Exceptions
{
    [TestClass]
    public class Exceptions_Throw
    {
        [TestMethod]
        public void Exception_ThrowExceptions()
        {
            Student std = null;

            try
            {
                PrintStudentName(std);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        private static void PrintStudentName(Student std)
        {
            if (std == null)
                throw new NullReferenceException("Student object is null.");

            Console.WriteLine(std.StudentName);
        }
    }

    internal class Student
    {
        public int Id { get; set; }

        public string StudentName { get; set; }
    }
}
