using System.Numerics;

namespace Geom
{
    public abstract class Geometry
    {
        public float Square;
    }

    public class Circle: Geometry
    {
        public Circle(float Radius) 
        {
            if (Radius <= 0)
                throw new ArgumentException();
            radius = Radius; 
        }
        float radius;
        public float Square { 
            get 
            {
                return (float)(Math.PI * Math.Pow(radius, 2));
            }  
        }
    }

    public class Triangle : Geometry
    {
        public Triangle(float A, float B, float C) 
        {
            if (A <= 0 || B <= 0 || C <= 0)
                throw new ArgumentException();
            a = A;
            b = B;
            c = C;
        }
        float a;
        float b;
        float c;
        public float Square
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
