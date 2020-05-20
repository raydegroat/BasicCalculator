using System;

namespace BasicCalculatorAlligator
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2;
            char operation;

            Console.WriteLine("Enter an integer between -2 billion and +2 billion");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another integer between -2 billion and +2 billion");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter one of the following 4 operators + - * /");
            operation = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();

            switch (operation)
            {
                case '+':
                    Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine(num1 + " x " + num2 + " = " + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine(num1 + " ÷ " + num2 + " = " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }   
    }
}
