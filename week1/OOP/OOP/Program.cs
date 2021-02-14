using System;
using System.Collections.Generic;
using System.Linq;
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
            
            var kek = Kek(shapes); 
           
            Console.WriteLine($"{kek}\nTotal perimeter sum: {totalPerimeterSum}\ntotal square sum: {totalSquareSum}");
            
            Console.ReadKey();
        }

        public static string Kek(ShapeCollectionWrapper shapes)
        {
            if (shapes.Shapes.Count == 0)
            {
                return "";
            }
            var kekLength = shapes.Shapes.Select(shape => shape.ToString())
                .OrderByDescending(x => x.Length)
                .First()
                .Length;
            
            var kek = new char[kekLength];
            for (var i = 0; i < kekLength; ++i)
            {
                kek[i] = '-';
            }
            
            return new string(kek);
        }
    }
}