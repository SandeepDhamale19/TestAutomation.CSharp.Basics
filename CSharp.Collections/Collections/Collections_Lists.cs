using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Collections
{
    [TestClass]
    public class Collections_Lists
    {
        [TestMethod]
        public void Lists_CreateLists()
        {
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1); // adding elements using add() method
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add(null);// nulls are allowed for reference type list

            //adding elements using collection-initializer syntax
            var bigCities = new List<string>()
                    {
                        "New York",
                        "London",
                        "Mumbai",
                        "Chicago"
                    };

            ////Add Custom Class Objects in List
            //var students = new List<Student>() {
            //    new Student(){ Id = 1, Name="Bill"},
            //    new Student(){ Id = 2, Name="Steve"},
            //    new Student(){ Id = 3, Name="Ram"},
            //    new Student(){ Id = 4, Name="Abdul"}
            //};
        }

        [TestMethod]
        public void Lists_AccessListValues()
        {
            List<int> numbers = new List<int>() { 1, 2, 5, 7, 8, 10 };
            Console.WriteLine(numbers[0]); // prints 1
            Console.WriteLine(numbers[1]); // prints 2
            Console.WriteLine(numbers[2]); // prints 5
            Console.WriteLine(numbers[3]); // prints 7

            // using foreach LINQ method
            numbers.ForEach(num => Console.WriteLine(num + ", "));//prints 1, 2, 5, 7, 8, 10,

            // using for loop
            for (int i = 0; i < numbers.Count; i++)
                Console.WriteLine(numbers[i]);
        }

        [TestMethod]
        public void Lists_AccessListValuesLinq()
        {
            var students = new List<Student>() {
                new Student(){ Id = 1, Name="Bill"},
                new Student(){ Id = 2, Name="Steve"},
                new Student(){ Id = 3, Name="Ram"},
                new Student(){ Id = 4, Name="Abdul"}
            };

            //get all students whose name is Bill
            var result = from s in students
                         where s.Name == "Bill"
                         select s;

            foreach (var student in result)
                Console.WriteLine(student.Id + ", " + student.Name);
        }

        [TestMethod]
        public void Lists_InsertValuesToList()
        {
            var numbers = new List<int>() { 10, 20, 30, 40 };

            numbers.Insert(1, 11);// inserts 11 at 1st index: after 10.

            foreach (var num in numbers)
                Console.Write(num);
        }

        [TestMethod]
        public void Lists_RemoveValuesToList()
        {
            var numbers = new List<int>() { 10, 20, 30, 40, 10 };

            numbers.Remove(10); // removes the first 10 from a list

            numbers.RemoveAt(2); //removes the 3rd element (index starts from 0)

            //numbers.RemoveAt(10); //throws ArgumentOutOfRangeException

            foreach (var el in numbers)
                Console.Write(el); //prints 20 30
        }

        [TestMethod]
        public void Lists_Contains()
        {
            var numbers = new List<int>() { 10, 20, 30, 40 };
            Assert.IsTrue(numbers.Contains(10)); // returns true
            Assert.IsFalse(numbers.Contains(11)); // returns false
            Assert.IsTrue(numbers.Contains(20)); // returns true
        }

        [TestMethod]
        public void Lists_SortedLists()
        {
            SortedList<string, string> cities = new SortedList<string, string>()
                                    {
                                        {"London", "UK"},
                                        {"New York", "USA"},
                                        { "Mumbai", "India"},
                                        {"Johannesburg", "South Africa"}
                                    };

            foreach (KeyValuePair<string, string> kvp in cities)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
        }

        [TestMethod]
        public void Lists_UpdateSortedLists()
        {
            SortedList<int, string> numberNames = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {5, "Five"},
                                        {1, "One"}
                                    };

            Console.WriteLine("---Initial key-values--");

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

            numberNames.Add(6, "Six");
            numberNames.Add(2, "Two");
            numberNames.Add(4, "Four");

            Console.WriteLine("---After adding new key-values--");

            int prevValue = 0;
            foreach (var kvp in numberNames)
            {
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
                Assert.IsTrue(prevValue < kvp.Key);
                prevValue = kvp.Key;
            }
                
        }

    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
