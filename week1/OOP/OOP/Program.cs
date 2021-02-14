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
            shapes.Shapes.Add(new Circle(10));
            shapes.Shapes.Add(new Rectangle(20, 10));

            foreach (var shape in shapes.Shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}