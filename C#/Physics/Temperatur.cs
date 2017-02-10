using System;
using System.Collections.Generic;
using System.Text;

namespace app
{
    public class Temperatur
    {
        /*
            Supported Units
            ---------------
            Celsius: 0
            Fahrenheit: 1
            Kelvin: 2

        */

        public static byte Celsius = 0;
        public static byte Fahrenheit = 1;
        public static byte Kelvin = 2;


        //Converts temperatur to celsius
        public static double ConvertToCelsius(double temperatur, byte unit)
        {
            switch (unit)
            {
                //Celsius
                case 0:
                    return temperatur;
                    break;

                //Fahrenheit
                case 1:
                    return 1.8 * temperatur + 32;
                    break;

                //Kelvin
                case 2:
                    return temperatur + 273.15;
                    break;

                //Default
                default:
                    return 0;
                    break;
            }
        }


        //Converts temperatur to Fahrenheit
        public static double ConvertToFahrenheit(double temperatur, byte unit)
        {
            switch (unit)
            {
                //Celsius
                case 0:
                    return temperatur * 9/5 + 32 ;
                    break;

                //Fahrenheit
                case 1:
                    return temperatur;
                    break;

                //Kelvin
                case 2:
                    return (temperatur - 32) * (5.0 / 9);
                    break;

                //Default
                default:
                    return 0;
                    break;
            }

        }


    }
}
