using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.ConditionalStatements.ConditionalStatements
{
    [TestClass]
    public class ConditionalStatements_While
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }       

        /// <summary>
        /// Reapeats a statement or group of statements while the condition is true
        /// </summary>
        [TestMethod]
        public void ConditionalSatements_While()
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int dayNumber = (int)DateTime.Now.DayOfWeek;
            string day = DateTime.Now.DayOfWeek.ToString();

            int currentDaynumber=0;

            while (currentDaynumber != dayNumber)
            {
                currentDaynumber++;
            }

            Console.WriteLine("Today is " + daysOfWeek[currentDaynumber -1]);
            Assert.AreEqual(day, daysOfWeek[currentDaynumber -1]);
        }
       
    }
}
