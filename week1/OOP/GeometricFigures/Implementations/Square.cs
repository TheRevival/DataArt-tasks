using System;
using GeometricFigures.Interfaces;

namespace GeometricFigures.Implementations
{
    public class Square : IShape
    {
        private double _side;

        public double Side
        {
            get => _side;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Side cannot be less or equal to zero! " + 
                                                "Probably, you forget to set side explicitly.", nameof(Side));
                }

                _side = value;
            }
        }

        public Square(double side)
            => Side = side;
        
        public Square() 
            : this(1) 
        { }

        public double GetSquare()
            => Math.Pow(Side, 2);

        public double GetPerimeter()
            => Side * 4;
        public override string ToString()
            => $"Type: {typeof(Square)} | Side: {Side} | Square: {GetSquare()} | Perimeter: {GetPerimeter()}";
    }
}