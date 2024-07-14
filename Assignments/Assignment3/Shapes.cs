using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Shapes
    {
        public double CalculateArea(double length, double width)
        {
            return length * width;
        }

        
        public double CalculateArea(double baseLength, double height,String tri)
        {
            
               return 0.5 * baseLength * height;
            
            
        }

        public double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double CalculateArea(int sideLength)
        {
            return sideLength * sideLength;
        }
  
        static void Main(string[] args)
        {
            Shapes shapes = new Shapes();

            double rectArea = shapes.CalculateArea(5.0, 3.0);
            Console.WriteLine($"Area of the rectangle: {rectArea}");

           
            double triangleArea = shapes.CalculateArea(4.0, 6.0,"tri");
            Console.WriteLine($"Area of the triangle: {triangleArea}");

            double circleArea = shapes.CalculateArea(7.0);
            Console.WriteLine($"Area of the circle: {circleArea}");

            double squareArea = shapes.CalculateArea(4);
            Console.WriteLine($"Area of the square: {squareArea}");
        }
    }
}
