using System;
using GeometricFigures.Interfaces;

namespace GeometricFigures.Implementations
{
    public class Trapezoid : IShape
    {
        private double _height;
        private double _topBase;
        private double __bottomBase;
        private double _leftSide;
        private double _rigthSide;

        public double LeftSide
        {
            get => _leftSide;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("LeftSide cannot be less or equal to zero! " + 
                                                "Probably, you forget to set left side explicitly.", nameof(LeftSide));
                }
                _leftSide = value;
            }
        }
        public double RightSide
        {
            get => _rigthSide;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("RightSide cannot be less or equal to zero! " + 
                                                "Probably, you forget to set right side explicitly.", nameof(RightSide));
                }
                _rigthSide = value;
            }
        }
        public double TopBase
        {
            get => _topBase;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("TopBase cannot be less or equal to zero! " + 
                                                "Probably, you forget to set top base explicitly.", nameof(TopBase));
                }

                _topBase = value;
            }
        }
        public double BottomBase
        {
            get => __bottomBase;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("BottomBase cannot be less or equal to zero! " + 
                                                "Probably, you forget to set bottom base explicitly.", nameof(BottomBase));
                }

                __bottomBase = value;
            }
        }
        public double Height
        {
            get => _height;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be less or equal to zero! " + 
                                                "Probably, you forget to set height explicitly.", nameof(Height));
                }

                _height = value;
            }
        }

        public Trapezoid(double height, double bottomBase, double topBase, double leftSide, double rightSide)
            => (Height, BottomBase, TopBase, LeftSide, RightSide) = (height, bottomBase, topBase, leftSide, rightSide);
        public Trapezoid()
            : this(1, 1, 1, 1, 1)
        { }
        public double GetSquare()
            => ((BottomBase + TopBase) / 2) * Height;
        public double GetPerimeter()
            => TopBase + BottomBase + LeftSide + RightSide;
        public override string ToString()
            => $"Type: {typeof(Trapezoid)} | LeftSide: {LeftSide} | RightSide: {RightSide} | TopBase: {TopBase} " +
               $"| BottomBase: {BottomBase} | Height: {Height} | Square: {GetSquare()} | Perimeter: {GetPerimeter()}";
    }
}