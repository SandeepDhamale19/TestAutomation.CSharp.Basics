using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.OOPs.OOPs
{
    [TestClass]
    public class OOPs_Class
    {
        // Objects: Instantiating class
        MyClass myClass = new MyClass();
        
        [TestMethod]
        public void OOPs_Class_Field()
        { 
            Assert.AreEqual(myClass.myField, string.Empty);
        }

        [TestMethod]
        public void OOPs_Class_Constructor()
        {
            Assert.AreEqual(myClass.constructorField, "Initialised when object is created");
        }

        [TestMethod]
        public void OOPs_Class_Method()
        {
            Assert.AreEqual(myClass.MyMethod(5, "Five"), "First Parameter 5, second parameter Five");
        }

        [TestMethod]
        public void OOPs_Class_CustomProperty()
        {
            myClass.MyProperty = "MyPropertyValue";
            Assert.AreEqual(myClass.MyProperty, "MyPropertyValue");
        }
    }

    public class MyClass
    {
        // Data member/ field
        public string myField = string.Empty;
        public string constructorField = string.Empty;

        // Constructor
        public MyClass()
        {
            constructorField = "Initialised when object is created";
        }

        // Method
        public string MyMethod(int parameter1, string parameter2)
        {
            string myString = ($"First Parameter {parameter1}, second parameter {parameter2}");
            Console.WriteLine(myString);

            return myString;
        }

        // Property
        public int MyAutoImplementedProperty { get; set; }

        private string myPropertyVar;

        // Custom Property
        public string MyProperty
        {
            get { return myPropertyVar; }
            set { myPropertyVar = value; }
        }
    }
}
