using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.ConditionalStatements.ConditionalStatements
{
    [TestClass]
    public class ConditionalStatements_If
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        [TestMethod]
        public void ConditionalStatement_If()
        {
            Num1 = 4;
            if (Num1 < 5)
            {
                Console.WriteLine("You are a kid.");
                Assert.IsTrue(Num1 < 5);
            }
            else if (Num1 >= 5 && Num1 < 18)
            {
                Console.WriteLine("You are a child.");
                Assert.IsTrue(Num1 >= 5 && Num1 < 18);
            }
            else if (Num1 >= 18 && Num1 < 60)
            {
                Console.WriteLine("You are an adult.");
                Assert.IsTrue(Num1 >= 18 && Num1 < 60);
            }
            else
            {
                Console.WriteLine("You are a Senoir Person.");
                Assert.IsTrue(Num1 > 60);
            }
        }

        [TestMethod]
        public void ConditionalStatements_NestedIf()
        {
            int candidateExp = 4;
            string candidatePrevOccupation = "IT Tester";

            if (candidatePrevOccupation == "IT Tester")
            {
                Assert.IsTrue(candidatePrevOccupation == "IT Tester");
                if (candidateExp >= 5)
                {
                    Console.WriteLine("Candidate is qualified for job.");
                    Assert.IsTrue(candidateExp >= 5);
                }
                else
                {
                    Console.WriteLine("Candidate is not qualified for job");
                    Assert.IsTrue(candidateExp < 5);
                }
            }           
            else
            {
                Console.WriteLine("Candidate is not qualified for job");
                Assert.IsTrue(candidatePrevOccupation != "IT Tester");
            }
        }        
        
    }
}
