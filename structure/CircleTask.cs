using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure
{
    internal class CircleTask
    {
        public struct Point
        {
            public double X;
            public double Y;
        }
        public struct Circle
        {
            public Point Center;
            public double Radius;
        }

        public static void Run()
        {
            Circle[] circles = new Circle[10];
            for (int i = 0; i < circles.Length; i++)
            {
                Console.WriteLine("Enter the circle center coordinates and radius:");
                Console.Write("X: ");
                circles[i].Center.X = double.Parse(Console.ReadLine());
                Console.Write("Y: ");
                circles[i].Center.Y = double.Parse(Console.ReadLine());
                Console.Write("Radius: ");
                circles[i].Radius = double.Parse(Console.ReadLine());
            }
            Circle maxCircle = circles[0];
            for (int i = 1; i < circles.Length; i++)
            {
                if (circles[i].Radius > maxCircle.Radius)
                {
                    maxCircle = circles[i];
                }
            }
            Console.WriteLine("The circle with the largest radius is:");
            Console.WriteLine($"Center: ({maxCircle.Center.X}, {maxCircle.Center.Y})");
            Console.ReadKey();
        }
    }
}

