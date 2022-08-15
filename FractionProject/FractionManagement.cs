using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FractionProject
{
    public class FractionManagement : MenuFunction
    {
        private Fraction fractionA;
        private Fraction fractionB;
        private const int ADD         = 1;
        private const int SUM         = 2;
        private const int SUBTRACTION = 3;
        private const int HUMAN       = 4;
        private const int DIVISION    = 5;
        private const int EXIT        = 0;
        public FractionManagement()
        {

        }
        protected override void PrintMenu()
        {
            Console.WriteLine("1. Enter 2 fraction");
            Console.WriteLine("2. Sum of 2 fraction");
            Console.WriteLine("3. Subtraction of 2 fraction");
            Console.WriteLine("4. Human of 2 fraction");
            Console.WriteLine("5. Division of 2 fraction");
            Console.WriteLine("0. Exit");
        }
        protected override void DoTask(int choice)
        {
            switch (choice)
            {
                case ADD:          AddFraction();                       break;
                case SUM:          SumFraction();                       break;
                case SUBTRACTION:  SubtractionFraction();               break;
                case HUMAN:        HumanFraction();                     break;
                case DIVISION:     DivisionFraction();                  break;
                case EXIT:         Exit("Bye byeeee !!!!");             break;
                default:           Console.WriteLine("Invalid choice"); break;
            }
        }
        private void AddFraction()
        {
            Console.WriteLine("Enter first fraction: ");
            fractionA = Utility.InputFraction();
            Console.WriteLine("Enter second fraction: ");
            fractionB = Utility.InputFraction();
        }
        private void SumFraction()
        {
            Console.WriteLine(fractionA.Add(fractionB));
        }
        private void SubtractionFraction()
        {
            Console.WriteLine(fractionA.Subtraction(fractionB));
        }
        private void HumanFraction()
        {
            Console.WriteLine(fractionA.Human(fractionB));
        }
        private void DivisionFraction()
        {
            Console.WriteLine(fractionA.Division(fractionB));
        }
    }
}