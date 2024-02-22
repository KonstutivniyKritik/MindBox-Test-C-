using System.Numerics;

namespace MindBox_Test_C_
{
    public abstract class Geometry
    {
        float Square;
    }

    public class Circle: Geometry
    {
        public Circle() { }
        float Radius;
        float Square { 
            get 
            {
                return (float)(Math.PI * Math.Pow(Radius, 2));
            }  
        }
    }

    public class Triangle : Geometry
    {
        public Triangle() { }
        float a;
        float b;
        float c;
        float Square
        {
            get
            {
                float p = (a + b + c) / 2;
                return (float)Math.Sqrt(p *(p-a)*(p-b)*(p-c));
            }
            
        }
        bool isRight()
        {
            float[] sides = (new float[3] { a, b, c });
            Array.Sort(sides);
            Array.Reverse(sides);


            return (Math.Pow(sides[0], 2)) == (Math.Pow(sides[1], 2)) + (Math.Pow(sides[2], 2));
        }

    }
}
