using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.ConditionalStatements.ConditionalStatements
{
    [TestClass]
    public class ConditionalStatements_For
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }        

        /// <summary>
        /// Executes a statement or group of statements for number of times as per condition
        /// </summary>
        [TestMethod]
        public void ConditionalSatements_For()
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int dayNumber = (int)DateTime.Now.DayOfWeek;
            string day = DateTime.Now.DayOfWeek.ToString();

            string today = string.Empty;

            for(int currentDayNum =1; currentDayNum<=dayNumber; currentDayNum++)
            {
                Console.WriteLine(daysOfWeek[currentDayNum - 1]);
                today = daysOfWeek[currentDayNum - 1];
            }

            Assert.AreEqual(day, today);
        }

       
    }
}
