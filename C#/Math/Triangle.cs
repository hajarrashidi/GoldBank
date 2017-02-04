using System;

namespace app
{
    public class Triangle
    {
        //Calculates the area of a triangle.
        public static double area(double height, double width) {

            return (height * width * 0.5);
   
        }

        //Calculates the circumference of a triangle.
        public static double circumference(double a, double b, double c)
        {
            return a + b + c;

        }
        
    }
}


