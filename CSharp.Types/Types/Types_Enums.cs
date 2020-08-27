using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Types.Types
{
    [TestClass]
    public class Types_Enums
    {
        [TestMethod]
        public void Types_DefaultEnums()
        {
            Console.WriteLine(WeekDays.Monday); // Monday
            Assert.AreEqual("Monday", WeekDays.Monday.ToString());

            Console.WriteLine(WeekDays.Tuesday); // Tuesday
            Assert.AreEqual("Tuesday", WeekDays.Tuesday.ToString());
        }

        [TestMethod]
        public void Types_EnumConversoins()
        {
            Console.WriteLine(WeekDays.Friday); //output: Friday 
            Assert.AreEqual("Friday", WeekDays.Friday.ToString());

            int day = (int)WeekDays.Friday; // enum to int conversion
            Console.WriteLine(day); //output: 4 
            Assert.AreEqual(4, day);

            var wd = (WeekDays)5; // int to enum conversion
            Console.WriteLine(wd);//output: Saturday
            Assert.AreEqual("Saturday", wd.ToString());
        }
    }
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
