using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FractionProject
{
    public class Fraction
    {
        private int numerator;
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        private int denominator;
        public int Denominator
        {
            get { return denominator; }
            set 
            { 
                if (value == 0)
                {
                    throw new DivideByZeroException();
                }
                denominator = value; 
            }
        }

        public Fraction()
        {
            Numerator = 1;
            Denominator = 1;
        }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
            CheckFraction(Numerator, Denominator);
        }

        public override string ToString()
        {
            if (Numerator == 0) return String.Format("Result is 0");
            else if (Denominator == 1) return String.Format("Result is {0}", Numerator);
            return String.Format("Result is {0}/{1}", Numerator, Denominator);
        }

        public Fraction Add(Fraction other)
        {
            int sumNumerator = numerator * other.denominator + other.numerator * denominator;
            int sumDenominator = denominator * other.denominator;
            Fraction f = new Fraction(sumNumerator, sumDenominator);
            return f;
        }
        public Fraction Subtraction(Fraction other)
        {
            int subtractionNumerator = numerator * other.denominator - other.numerator * denominator;
            int subtractionDenominator = denominator * other.denominator;
            Fraction f = new Fraction(subtractionNumerator, subtractionDenominator);
            return f;
        }
        public Fraction Human(Fraction other)
        {
            int humanNumerator = numerator * other.numerator;
            int humanDenominator = denominator * other.denominator;
            Fraction f = new Fraction(humanNumerator, humanDenominator);
            return f;
        }
        public Fraction Division(Fraction other)
        {
            int divisionNumerator = numerator * other.denominator;
            int divisionDenominator = denominator * other.numerator;
            Fraction f = new Fraction(divisionNumerator, divisionDenominator);
            return f;
        }
        public void CheckFraction(int numerator, int denominator)
        {
            if (Math.Abs(numerator) >= Math.Abs(denominator)) CompactFraction(numerator, denominator);
            else CompactFraction(denominator, numerator);
            if (Numerator ==  Denominator || Numerator % Denominator == 0)
            {
                Numerator = Numerator / Denominator;
                Denominator = 1;
            }
        }
        public void CompactFraction(int max, int min)
        {
            for (int i = Math.Abs(min); i >=1; i--)
            {
                if (max % i == 0 && min % i == 0)
                {
                    numerator   /= i;
                    denominator /= i;
                    break;
                }
            }
        }
    }
}
