using System;

namespace app
{
    public class Circle
    {
        //Calculates the circles area.
        public static double area(double radius)
        {   
            return Math.PI * Math.Pow(radius, 2);
        }

        //Calculates the circles circumference.
        public static double circumference(double radius)
        {
            return (2 * Math.PI) * radius;
        }
    }
}
