using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    interface IShape       // interface - a class with pubic & abstract property
    {
        void draw();       // interface method have public & abstract
    }

    public class Rectangle : IShape       // derived class : interface class
    {
        public void draw()                 // derived class method
        {
            Console.WriteLine("Drawing Rectangle");
            Console.ReadLine();
        }
    }

    public class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Drawing Circle");
            Console.ReadLine();
        }
    }

    public class TestInterface
    {
        public static void Main(string[] args)
        {
            IShape s;                   // interface object created
            s = new Rectangle();        // object = derived class
            s.draw();
            s = new Circle();
            s.draw();
        }
    }
}
