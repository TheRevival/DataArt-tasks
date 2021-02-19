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
        /// <summary>
        /// Returns true, if sum of any two sides of triangle are greater, than the third one.
        /// Otherwise, returns false.
        /// Keep it virtual for overriding in inherited entities of Triangle-family.
        /// </summary>
        protected virtual bool IsCorrectTriangle()
        {
            return FirstSide + SecondSide > ThirdSide 
                   && FirstSide + ThirdSide > SecondSide 
                   && SecondSide + ThirdSide > FirstSide;
        }
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (IsCorrectTriangle())
            {
                (FirstSide, SecondSide, ThirdSide) = (firstSide, secondSide, thirdSide);
            }
            else
            {
                throw new ArgumentException("Non-correct triangle sides value: sum of any " +
                                            "two triangle sides must be more than the third one!", nameof(Triangle));
            }
        }
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