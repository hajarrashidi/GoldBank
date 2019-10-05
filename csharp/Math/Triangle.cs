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
        public static double Circumference(double side1, double side2, double side3)
        {
            return side1 + side2 + side3;
        }
        
    }
}


