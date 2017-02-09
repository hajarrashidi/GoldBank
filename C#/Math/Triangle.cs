using System;

namespace app
{
    public class Triangle
    {
        //Calculates the area of a triangle.
        public static double Area(double height, double width)
        {
            return (height * width * 0.5);
        }

        //Calculates the circumference of a triangle.
        public static double Circumference(double a, double b, double c)
        {
            return a + b + c;
        }
        
    }
}


