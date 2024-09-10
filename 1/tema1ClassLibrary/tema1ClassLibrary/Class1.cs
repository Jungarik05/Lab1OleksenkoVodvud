using System;

namespace tema1ClassLibrary
{
    public class Class1
    {
        public static double GradToRad(double a)
        {
            return a * Math.PI / 180;
        }
        public static double CalculateZ1(double a)
        {
            return (Math.Sin(a) + Math.Sin(5 * a) - Math.Sin(3 * a)) / (Math.Cos(a) - Math.Cos(3 * a) + Math.Cos(5 * a));
        }
        public static double CalculateZ2(double a)
        {
            return Math.Tan(3 * a);
        }
    }
}