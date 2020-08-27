using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Exceptions.Exceptions
{
    [TestClass]
    public class Exceptions_Custom
    {
        [TestMethod]
        public void Exceptions_CreateCustomExceptions()
        {
        }

        //[TestMethod]
        //public void Exceptions_ThrowCustomExceptions()
        //{
        //    Student newStudent = null;

        //    try
        //    {
        //        newStudent = new Student();
        //        newStudent.StudentName = "James007";

        //        ValidateStudent(newStudent);
        //    }
        //    catch (InvalidStudentNameException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

        //    Console.ReadKey();
        //}

        private static void ValidateStudent(Student std)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(std.StudentName))
                throw new InvalidStudentNameException(std.StudentName);
        }
    }
    

    [Serializable]
    class InvalidStudentNameException : Exception
    {
        public InvalidStudentNameException()
        {

        }

        public InvalidStudentNameException(string name)
            : base(String.Format("Invalid Student Name: {0}", name))
        {

        }

    }
}
