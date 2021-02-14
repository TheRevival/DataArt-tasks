using System.Collections.Generic;
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
    }
}