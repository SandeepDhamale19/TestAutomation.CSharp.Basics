using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Abstraction;

namespace CSharp.OOPs.OOPs
{
    [TestClass]
    public class OOPs_Abstraction
    {
        [TestMethod]
        public void OOPs_AbstractionImplementation()
        {
            Rectangle r = new Rectangle(10, 7);
            double a = r.area();
            Console.WriteLine("Area: {0}", a);
            Assert.AreEqual(70, r.area());
        }
    }
}

namespace Abstraction
{
    abstract class Shape
    {
        public abstract int area();
    }

    class Rectangle : Shape
    {
        private int length;
        private int width;

        public Rectangle(int a = 0, int b = 0)
        {
            length = a;
            width = b;
        }
        public override int area()
        {
            Console.WriteLine("Rectangle class area :");
            return (width * length);
        }
    }    
}
