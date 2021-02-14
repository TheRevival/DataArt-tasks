using System;
using System.Collections.Generic;
using System.Linq;
using GeometricFigures.Interfaces;

namespace GeometricFigures
{
    public class ShapeCollectionWrapper
    {
        private List<IShape> _shapes;

        public ShapeCollectionWrapper(List<IShape> shapes)
        {
            _shapes = shapes;
        }

        public ShapeCollectionWrapper() 
            : this(new List<IShape>()) { }
        public List<IShape> Shapes
        {
            get => _shapes;
            set
            {
                if (_shapes.Count > 0)
                {
                    _shapes.AddRange(value);
                    return;
                }
                
                _shapes = value;
            }
        }
        /// <summary>
        /// Returns sum of all shapes square.
        /// </summary>
        /// <returns></returns>
        public double TotalShapesSquare()
            => Shapes.Select(shape => shape.GetSquare())
                    .Sum();
        
        /// <summary>
        /// Return sum of all shapes perimeter.
        /// </summary>
        /// <returns></returns>
        public double TotalShapesPerimeter()
            => Shapes.Select(shape => shape.GetPerimeter())
                    .Sum();

        public void DisplayShapesInfo()
        {
            foreach (var shape in Shapes)
            {
                Console.WriteLine(shape);
            }
        }

        public void Add(IShape shape)
        {
            Shapes.Add(shape);
        }
        public void AddRange(IEnumerable<IShape> shapes)
        {
            Shapes.AddRange(shapes);
        }
    }
}