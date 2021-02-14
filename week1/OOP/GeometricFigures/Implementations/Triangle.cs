using System;
using GeometricFigures.Interfaces;

namespace GeometricFigures.Implementations
{
    public class Triangle : IShape
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        public double FirstSide
        {
            get => _firstSide;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("FirstSide cannot be less or equal to zero! " + 
                                                "Probably, you forget to set first side explicitly.", nameof(FirstSide));
                }

                _firstSide = value;
            }
        }
        public double SecondSide
        {
            get => _secondSide;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("SecondSide cannot be less or equal to zero! " + 
                                                "Probably, you forget to set second side explicitly.", nameof(SecondSide));
                }

                _secondSide = value;
            }
        }
        public double ThirdSide
        {
            get => _thirdSide;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("ThirdSide cannot be less or equal to zero! " + 
                                                "Probably, you forget to set third side explicitly.", nameof(ThirdSide));
                }

                _thirdSide = value;
            }
        }

        public Triangle(double firstSide, double secondSide, double thirdSide)
            => (FirstSide, SecondSide, ThirdSide) = (firstSide, secondSide, thirdSide);
            
        public Triangle()
            : this(1, 1, 1)
        { }
        public double GetSquare()
        {
            var halfPerimeter = GetPerimeter() / 2;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - FirstSide) * (halfPerimeter - SecondSide) *
                             (halfPerimeter - ThirdSide));
        }
        public double GetPerimeter()
            => FirstSide + SecondSide + ThirdSide;

        public override string ToString()
            => $"Type: {typeof(Triangle)} | FirstSide: {FirstSide} | SecondSide: {SecondSide} " +
               $"| ThirdSide: {ThirdSide} | Square: {GetSquare()} | Perimeter: {GetPerimeter()}";
    }
}