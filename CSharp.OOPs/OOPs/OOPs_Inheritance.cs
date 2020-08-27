using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.OOPs.OOPs
{
    [TestClass]
    public class OOPs_Inheritance
    {
        [TestMethod]
        public void OOPs_InheritanceImplementaion()
        {
            derived_Rectangle rect = new derived_Rectangle();

            rect.setWidth(5);
            rect.setHeight(7);
            // Print the area of the object.
            Console.WriteLine("Total area of rectangle: {0}", rect.getArea());
            Assert.AreEqual(35, rect.getArea());


            derived_Circle circle = new derived_Circle();

            circle.setRadius(5);
            // Print the area of the object.
            Console.WriteLine("Total area of rectangle: {0}", circle.getArea());
            Assert.AreEqual(78.5, circle.getArea());
        }
    }

    // Base class
    class base_Shape
    {
        protected int width;
        protected int height;
        protected int radius;
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }

        public void setRadius(int r)
        {
            radius = r;
        }
    }

    // Derived class
    class derived_Rectangle : base_Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }

    // Derived class
    class derived_Circle : base_Shape
    {
        public double getArea()
        {
            return (3.14 * radius * radius);
        }
    }
}
