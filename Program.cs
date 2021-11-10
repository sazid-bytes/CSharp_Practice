using System;

namespace GitDemo1
{
    class Circle
    {
        static float PI;
        int _radius;

        static Circle()
        {
            PI = 3.14f;
        }
        public Circle(int radius)
        {
            _radius = radius;
        }
        public double Area()
        {
            return PI*_radius*_radius;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            Console.WriteLine("Area is: {0}", c1.Area());

            Circle c2 = new Circle(20);
            Console.WriteLine("Area is {0}", c2.Area());
        }
        
    }
}
