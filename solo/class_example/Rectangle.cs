using System;
namespace Shapes
{
    public class Rectangle
    {
        protected int _length = 0;
        private int _width = 0;
        public Rectangle(int length, int width)
        {
            _length = length;
            _width = width;
        }
        public int Area()
        {
            return _length * _width;
        }
        public int Perimeter()
        {
            return 2 * _length + 2 * _width;
        }
    }
}