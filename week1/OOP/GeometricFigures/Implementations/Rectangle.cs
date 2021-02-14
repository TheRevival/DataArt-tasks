using System;
using GeometricFigures.Interfaces;

namespace GeometricFigures.Implementations
{
    public class Rectangle : IShape
    {
        private double _width;
        private double _height;

        public double Width
        {
            get => _width;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be less or equal to zero! " + 
                                                         "Probably, you forget to set width explicitly.", nameof(Width));
                }

                _width = value;
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

        public Rectangle(double width, double height)
            => (Width, Height) = (width, height);
        
        public Rectangle()
            : this(1, 1)
        { }
        public double GetSquare()
            => Width * Height;

        public double GetPerimeter()
            => Width * 2 + Height * 2;
        
        public override string ToString()
            => $"Type: {typeof(Rectangle)} | Width: {Width} | Height: {Height} | Square: {GetSquare()} | Perimeter: {GetPerimeter()}";
    }
}