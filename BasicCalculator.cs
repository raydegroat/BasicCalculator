using System;

namespace BasicCalculatorAlligator
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1;
            int num2;

            Console.WriteLine("Enter an integer between -2 billion and +2 billion");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another integer between -2 billion and +2 billion");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
        }   
    }
}
