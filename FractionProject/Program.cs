using System;

namespace FractionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f = Utility.InputFraction();
            Fraction other = Utility.InputFraction();
            Console.WriteLine(f.Add(other));
            Console.WriteLine(f);
            Console.WriteLine(other);
        }
    }
}