using System;
using System.Collections.Generic;

namespace FractionProject
{
    public abstract class MenuFunction
    {
        private const int EXIT = 0;
        public MenuFunction()
        {

        }
        protected int GetChoice(string message)
        {
            return InputInteger(message);
        }
        public void Run(string message)
        {
            bool running = true;
            
            while(running)
            {
                PrintMenu();
                int choice = GetChoice(message);
                DoTask(choice);
                running = choice != EXIT;
            }
        }
        protected void Exit(string message)
        {
            Console.WriteLine(message);
        }
        public int InputInteger(string message)
        {
            int input = 0;
            bool invalid = true;
            while (invalid)
            {
                try
                {
                    Console.Write(message);
                    input = Convert.ToInt32(Console.ReadLine());
                    invalid = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format");
                }
            }
            return input;
        }
        public double InputDouble(string message)
        {
            double input = 0;
            bool invalid = true;
            while (invalid)
            {
                try
                {
                    Console.Write(message);
                    input = Convert.ToInt32(Console.ReadLine());
                    invalid = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format");
                }
            }
            return input;
        }
        public string InputString(string message)
        {
            string input = "";
            bool invalid = true;
            while (invalid)
            {
                try
                {
                    Console.Write(message);
                    input = Console.ReadLine();
                    invalid = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format");
                }
            }
            return input;
        }
        public int CheckValidInteger(string message, int min, int max)
        {
            bool check = true;
            int choice = 0;
            while (check)
            {
                choice = InputInteger(message);
                check = choice < min || choice > max;
                if (check) Console.WriteLine("Invalid, min is {0}, max is {1}", min, max);
            }
            return choice;
        }
        public double CheckValidDouble(string message, double min, double max)
        {
            bool check = true;
            double choice = 0;
            while (check)
            {
                choice = InputDouble(message);
                check = choice < min || choice > max;
                if (check) Console.WriteLine("Invalid, min is {0}, max is {1}", min, max);
            }
            return choice;
        }
        public string CheckValidString(string message, int min, int max)
        {
            bool check = true;
            string choice = "";
            while (check)
            {
                choice = InputString(message);
                check = choice.Length < min || choice.Length > max;
                if (check) Console.WriteLine("Invalid, min length is {0}, max length is {1}", min, max);
            }
            return choice;
        }
        protected abstract void PrintMenu();
        protected abstract void DoTask(int choice);
    }
}