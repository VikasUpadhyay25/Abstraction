using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Shape               // abstract base class
    {
        public abstract void draw();             // abstract method with no body therefore use ;
    }

    public class Rectangle : Shape          // derived class : base class
    {
        public override void draw()                  // same method name with override keyword
        {
            Console.WriteLine(" Drawing Rectangle");
            Console.ReadLine();
        }
    }

    public class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Circle");
            Console.ReadLine();
        }
    }
    public class TestAbstract
    {
        public static void Main(string[] args)
        {
            Shape s;
            s = new Rectangle();
            s.draw();
            s = new Circle();
            s.draw();
        }
    }
}
