using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.ConditionalStatements.ConditionalStatements
{
    [TestClass]
    public class ConditionalStatements_DoWhile
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }


        /// <summary>
        /// Reapeats a statement or group of statements while the condition is true, where condition is tested at end
        /// </summary>
        [TestMethod]
        public void ConditionalSatements_DoWhile()
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int dayNumber = (int)DateTime.Now.DayOfWeek;
            string day = DateTime.Now.DayOfWeek.ToString();

            int currentDaynumber = 0;
            do
            {
                currentDaynumber++;
            }
            while (currentDaynumber != dayNumber);

            Console.WriteLine("Today is " + daysOfWeek[currentDaynumber - 1]);
            Assert.AreEqual(day, daysOfWeek[currentDaynumber - 1]);
        }
       
    }
}
