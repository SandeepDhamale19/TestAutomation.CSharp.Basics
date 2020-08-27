using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.ConditionalStatements.ConditionalStatements
{
    [TestClass]
    public class ConditionalStatements_Switch
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
               
        [TestMethod]
        public void ConditionalSatements_Switch()
        {
            int dayNumber = (int)DateTime.Now.DayOfWeek;
            string day = DateTime.Now.DayOfWeek.ToString();

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Today is Monday");
                    Assert.AreEqual("Monday", day);
                    break;
                case 2:
                    Console.WriteLine("Today is Tuesday");
                    Assert.AreEqual("Tuesday", day);
                    break;
                case 3:                    
                    Console.WriteLine("Today is Wednesday");
                    Assert.AreEqual("Wednesday", day);
                    break;
                case 4:
                    Console.WriteLine("Today is Thursday");
                    Assert.AreEqual("Thursday", day);
                    break;
                case 5:
                    Console.WriteLine("Today is Friday");
                    Assert.AreEqual("Friday", day);
                    break;
                case 6:
                    Console.WriteLine("Today is Saturday");
                    Assert.AreEqual("Saturday", day);
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday");
                    Assert.AreEqual("Sunday", day);
                    break;
            }
        }
    }
}
