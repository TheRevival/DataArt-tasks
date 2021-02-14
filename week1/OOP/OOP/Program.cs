using System;
using GeometricFigures;
using GeometricFigures.Implementations;
using GeometricFigures.Interfaces;

namespace OOP
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var shapes = new ShapeCollectionWrapper();
            shapes.Add(new Circle(100));
            shapes.Add(new Rectangle(10, 10));
            shapes.AddRange(
                new IShape[] 
                { 
                    new Circle(20), 
                    new Rectangle(1, 1), 
                    new Trapezoid(1, 1, 1, 1, 1),
                    new Square(20), 
                    new Triangle(3, 4, 5), 
                });
            
            shapes.DisplayShapesInfo();

            var totalPerimeterSum = shapes.TotalShapesPerimeter();
            var totalSquareSum = shapes.TotalShapesSquare();

            Console.WriteLine($"Total perimeter sum: {totalPerimeterSum}\ntotal square sum: {totalSquareSum}");
            
            Console.ReadKey();
        }
    }
}