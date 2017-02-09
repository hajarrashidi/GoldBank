using System;

namespace app
{
    public class Circle
    {

        //Calculates the circles diameter.
        public static double Diameter(double radius)
        {
            return radius * 2;
        }

        //Calculates the circles area.
        public static double Area(double radius)
        {   
            return Math.PI * Math.Pow(radius, 2);
        }

        //Calculates the circles circumference.
        public static double Circumference(double radius)
        {
            return (Math.PI * 2) * radius;
        }
    }
}
