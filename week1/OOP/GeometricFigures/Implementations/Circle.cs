using System;
using System.Text.RegularExpressions;
using GeometricFigures.Interfaces;

namespace GeometricFigures.Implementations
{
    public class Circle : IShape
    {
        private double _radius;
        public double Radius
        {
            get => _radius;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius cannot be less or equal to zero! " + 
                                                         "Probably, you forget to set radius explicitly.", nameof(Radius));
                }

                _radius = value;
            }
        }
        public Circle() 
            : this(1) 
        { }
        
        public Circle(double radius) 
            => (Radius) = (radius);
        public double GetSquare()
            => Math.PI * Math.Pow(Radius, 2);

        public double GetPerimeter()
            => 2 * Math.PI * Radius;

        public override string ToString()
            => $"Type: {typeof(Circle)} | Radius: {Radius} | Square: {GetSquare()} | Perimeter: {GetPerimeter()}";
    }
}