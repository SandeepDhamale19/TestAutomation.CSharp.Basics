using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.ConditionalStatements.ConditionalStatements
{
    [TestClass]
    public class ConditionalStatements_ForEach
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }        

        /// <summary>
        /// Executes a statement or group of statements for number of times as per condition
        /// </summary>
        [TestMethod]
        public void ConditionalSatements_Foreach()
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int dayNumber = (int)DateTime.Now.DayOfWeek;
            string day = DateTime.Now.DayOfWeek.ToString();

            string today = string.Empty;

            foreach (var currentDay in daysOfWeek)
            {
                Console.WriteLine(currentDay);
                if (currentDay.Equals(day))
                { 
                    today = currentDay;
                    break;
                }
                
            }
            Assert.AreEqual(day, today);
        }
    }
}
