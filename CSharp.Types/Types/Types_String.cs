using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Types.Types
{
    [TestClass]
    public class Types_String
    {
        [TestMethod]
        public void Types_NormalString()
        {
            string message = "Hello World!";
            Console.WriteLine(message);
        }

        [TestMethod]
        public void Types_StringWithQuotes()
        {
            string message = "\"Hello, Captain America!\"";
            Console.WriteLine(message);
        }

        /// <summary>
        /// Concatenates one or more instances of String, or the String representations of the values of one or more instances of Object.
        /// </summary>
        [TestMethod]
        public void Types_StringConcatenation()
        {
            string message = "Hello, Captain America!";
            string messageGreet = "Hello,";
            string messageName = "Captain America!";
            Console.WriteLine(messageGreet + " " + messageName);

            Assert.AreEqual(message, messageGreet + " " + messageName);
        }

        /// <summary>
        /// Concatenates the elements of a specified array or the members of a collection, using the specified separator between each element or member.
        /// </summary>
        [TestMethod]
        public void Types_StringJoin()
        {
            string message = "Hello, Captain America!";

            string[] messages = { "Hello,", "Captain America!" };

            Assert.AreEqual(message, string.Join(" ", messages));
        }

        /// <summary>
        /// Returns a string array that contains the substrings in this instance that are delimited by elements of a specified string or Unicode character array.
        /// </summary>
        [TestMethod]
        public void Types_StringSplit()
        {
            string message = "Hello, Ironman!";
            string messageGreet = "Hello,";
            string messageName = "Ironman!";

            string[] words = message.Split(' ');

            foreach (var word in words)
            {
                System.Console.WriteLine($"<{word}>");
            }

            Assert.AreEqual(words[0], messageGreet);
            Assert.AreEqual(words[1], messageName);
        }

        /// <summary>
        /// Converts the value of objects to strings based on the formats specified and inserts them into another string.
        /// </summary>
        [TestMethod]
        public void Types_StringFormat()
        {
            Decimal pricePerOunce = 17.36m;
            string foramttedString = string.Format("The current price is {0} per ounce.",
                                     pricePerOunce);
            Console.WriteLine(foramttedString);

            Assert.AreEqual("The current price is 17.36 per ounce.", foramttedString);

            // Currency Formatting
            foramttedString = string.Format("The current price is {0:C2} per ounce.",
                                     pricePerOunce);
            Console.WriteLine(foramttedString);
            Assert.AreEqual("The current price is $17.36 per ounce.", foramttedString);

            // Implicit conversion
            foramttedString = string.Format("At {0}, the temperature is {1}°C.", DateTime.Now, 20.4);
            Console.WriteLine(foramttedString);

            // Date and time formatting
            foramttedString = string.Format("It is now {0:d} at {0:t}", DateTime.Now);
            Console.WriteLine(foramttedString);

            //more fromt examples: https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=netcore-3.1
        }

        /// <summary>
        /// Returns a value indicating whether a specified character occurs within this string, using the specified comparison rules.
        /// </summary>
        [TestMethod]
        public void Types_StringContains()
        {
            string message = "Hello, Captain America!";
            Assert.IsTrue(message.Contains("Hello"));
        }

        /// <summary>
        /// Determines whether the beginning of this string instance matches a specified string.
        /// </summary>
        [TestMethod]
        public void Types_StringStartsWith()
        {
            string message = "Hello, Captain America!";
            Assert.IsTrue(message.StartsWith("Hello"));
        }

        /// <summary>
        /// Determines whether the end of this string instance matches a specified string.
        /// </summary>
        [TestMethod]
        public void Types_StringEndsWith()
        {
            string message = "Hello, Captain America!";
            Assert.IsTrue(message.EndsWith("America!"));
        }

        /// <summary>
        /// Reports the zero-based index of the first occurrence of a specified Unicode character or string within this instance. The method returns -1 if the character or string is not found in this instance.
        /// </summary>
        [TestMethod]
        public void Types_StringIndexOf()
        {
            string message = "Hello, Captain America!";
            int indexOfCaptain = message.IndexOf("Captain");
            Assert.AreEqual(7, indexOfCaptain);
        }

        /// <summary>
        /// Reports the index of the first occurrence in this instance of any character in a specified array of Unicode characters. The method returns -1 if the characters in the array are not found in this instance.
        /// </summary>
        [TestMethod]
        public void Types_StringIndexOfAny()
        {
            char[] chars = { 'a', 'e', 'i', 'o', 'u', 'y',
                       'A', 'E', 'I', 'O', 'U', 'Y' };

            string message = "Hello, Captain America!";
            int indexOfChar = message.IndexOfAny(chars);
            Assert.AreEqual(1, indexOfChar);
        }

        /// <summary>
        /// Returns a new string in which a specified string is inserted at a specified index position in this instance.
        /// </summary>
        [TestMethod]
        public void Types_StringInsert()
        {
            string stringToAdd = "Mr. ";

            string message = "Hello, Captain America!";
            string newMessage = message.Insert(7, stringToAdd);
            Console.WriteLine(newMessage);

            Assert.AreEqual("Hello, Mr. Captain America!", newMessage);
        }

        /// <summary>
        /// Indicates whether the specified string is null or an empty string ("").
        /// </summary>
        [TestMethod]
        public void Types_StringIsNullOrEmpty()
        {
            string message = "Hello, Captain America!";

            Assert.IsFalse(string.IsNullOrEmpty(message));
        }

        /// <summary>
        /// Returns a new string in which a specified number of characters from the current string are deleted.
        /// </summary>
        [TestMethod]
        public void Types_StringRemove()
        {
            string message = "Hello, Mr. Captain America!";
            string newMessage = message.Remove(7, 4);
            Assert.AreEqual("Hello, Captain America!", newMessage);
        }

        /// <summary>
        /// Returns a new string in which all occurrences of a specified Unicode character or String in the current string are replaced with another specified Unicode character or String.
        /// </summary>
        [TestMethod]
        public void Types_StringReplace()
        {
            string message = "Hello, Mr. Captain America!";
            string newMessage = message.Replace("Captain America", "Ironman");
            Assert.AreEqual("Hello, Mr. Ironman!", newMessage);
        }

        /// <summary>
        /// Retrieves a substring from this instance.
        /// </summary>
        [TestMethod]
        public void Types_StringSubstring()
        {
            string message = "Hello, Mr. Captain America!";
            int startIndex = 7;
            int length = 3;
            string newMessage = message.Substring(startIndex, length);
            Assert.AreEqual("Mr.", newMessage);
        }

        /// <summary>
        /// Copies the characters in this instance to a Unicode character array.
        /// </summary>
        [TestMethod]
        public void Types_StringToCharArray()
        {
            string message = "Hello, Mr. Captain America!";
            char[] arr;

            arr = message.ToCharArray(7, 3);
            foreach (char c in arr)
                Console.WriteLine(c);

            string newMessage = string.Join("", arr);
            Assert.AreEqual("Mr.", newMessage);
        }

        /// <summary>
        /// Returns a copy of this string converted to lowercase.
        /// </summary>
        [TestMethod]
        public void Types_StringToLower()
        {
            string message = "Hello, Mr. Captain America!";
            string newMessage = message.ToLower();
            Assert.AreEqual("hello, mr. captain america!", newMessage);
        }

        /// <summary>
        /// Returns a copy of this string converted to uppercase.
        /// </summary>
        [TestMethod]
        public void Types_StringToUpper()
        {
            string message = "Hello, Mr. Captain America!";
            string newMessage = message.ToUpper();
            Assert.AreEqual("HELLO, MR. CAPTAIN AMERICA!", newMessage);
        }

        /// <summary>
        /// Returns a new string in which all leading and trailing occurrences of a set of specified characters from the current string are removed.
        /// </summary>
        [TestMethod]
        public void Types_StringTrim()
        {
            string message = "Hello, Mr. Captain America!";
            char[] charsToTrim = { '.', ' ', '!' };
            string newMessage = message.Trim(charsToTrim);

            Assert.AreEqual("Hello, Mr. Captain America", newMessage);
        }

        /// <summary>
        /// Removes all the leading white-space characters from the current string.
        /// </summary>
        [TestMethod]
        public void Types_StringTrimStart()
        {
            string message = "   Hello, Mr. Captain America!";
            string newMessage = message.TrimStart();

            Assert.AreEqual("Hello, Mr. Captain America!", newMessage);
        }

        /// <summary>
        /// Removes all the trailing white-space characters from the current string.
        /// </summary>
        [TestMethod]
        public void Types_StringTrimEnd()
        {
            string message = "Hello, Mr. Captain America!   ";
            string newMessage = message.TrimEnd();

            Assert.AreEqual("Hello, Mr. Captain America!", newMessage);
        }

        [TestMethod]
        public void Types_StringInterpolation()
        {
            var name = "Captain America";
            Console.WriteLine($"Hello, {name}. It's a pleasure to meet you!");

            Assert.AreEqual($"Hello, {name}. It's a pleasure to meet you!", "Hello, Captain America. It's a pleasure to meet you!");
        }

        [TestMethod]
        public void Types_StringInterpolationWithDataTypes()
        {
            var item = (Name: "eggplant", Price: 1.99m, perPackage: 3);
            var date = DateTime.Now;
            Console.WriteLine($"On {date}, the price of {item.Name} was {item.Price} per {item.perPackage} items.");

            Console.WriteLine($"On {date:d}, the price of {item.Name} was {item.Price:C2} per {item.perPackage} items");
        }
        [TestMethod]
        public void Types_StringInterpolationForStringFormatting()
        {
            var inventory = new Dictionary<string, int>()
            {
                ["hammer, ball pein"] = 18,
                ["hammer, cross pein"] = 5,
                ["screwdriver, Phillips #2"] = 14
            };

            Console.WriteLine($"Inventory on {DateTime.Now:d}");
            Console.WriteLine(" ");
            Console.WriteLine($"|{"Item",-25}|{"Quantity",10}|");
            foreach (var item in inventory)
                Console.WriteLine($"|{item.Key,-25}|{item.Value,10}|");
        }
    }
}
