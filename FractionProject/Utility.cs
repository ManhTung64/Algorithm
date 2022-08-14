using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FractionProject
{
    public class Utility
    {
        public static int InputInteger(string message)
        {
            int n = 0;
            bool invalid = true;
            while (invalid)
            {
                try 
                {
                    Console.Write(message);
                    n = Convert.ToInt32(Console.ReadLine());
                    invalid = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid integer format");
                }
            }
            return n;
        }
        public static Fraction InputFraction()
        {
            Fraction f = new Fraction();
            f.Numerator = InputInteger("Enter numerator: ");

            bool invalid = true;
            while (invalid)
            {
                try
                {
                    f.Denominator = InputInteger("Enter denominator: ");
                    invalid = false;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Invalid fraction denominator");
                }
            }
            f.CheckFraction(f.Numerator, f.Denominator);
            return f;
        }
    }
}