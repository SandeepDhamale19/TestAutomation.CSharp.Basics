using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Exceptions.Exceptions
{
    [TestClass]
    public class Exceptions_BuiltIn
    {
        [TestMethod]
        public void Exceptions_BuiltInExceptions()
        {
            // ArgumentException:           Raised when a non - null argument that is passed to a method is invalid.
            // ArgumentNullException:       Raised when null argument is passed to a method.
            // ArgumentOutOfRangeException: Raised when the value of an argument is outside the range of valid values.
            // DivideByZeroException:       Raised when an integer value is divide by zero.
            // FileNotFoundException:       Raised when a physical file does not exist at the specified location.
            // FormatException:             Raised when a value is not in an appropriate format to be converted from a string by a conversion method such as Parse.
            // IndexOutOfRangeException:    Raised when an array index is outside the lower or upper bounds of an array or collection.
            // InvalidOperationException:   Raised when a method call is invalid in an object's current state.
            // KeyNotFoundException:        Raised when the specified key for accessing a member in a collection is not exists.
            // NotSupportedException:       Raised when a method or operation is not supported.
            // NullReferenceException:      Raised when program access members of null object.
            // OverflowException:           Raised when an arithmetic, casting, or conversion operation results in an overflow.
            // OutOfMemoryException:        Raised when a program does not get enough memory to execute the code.
            // StackOverflowException:      Raised when a stack in memory overflows.
            // TimeoutException:            The time interval allotted to an operation has expired.
        }
    }
}
