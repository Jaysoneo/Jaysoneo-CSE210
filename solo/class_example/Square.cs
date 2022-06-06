using System;

namespace Shapes
{
    public class Square : Rectangle
    {
        public Square(int length) :  base(length,length){}

        public int SurfaceArea(){
            return 6*base.Area();
        }
        public int Volume()
        {
            return base.Area()*base.length();
        }
    }
}