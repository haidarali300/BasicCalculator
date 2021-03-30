using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter The First Num: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter The Operatore: ");
            string op = Console.ReadLine();
            if (op == "+")
            {
                Console.WriteLine("Enter the Second Num: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(a + b);
            }
            else if (op == "-")
            {
                Console.WriteLine("Enter the Second Num: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(a - b);
            }
            else if (op == "*")
            {
                Console.WriteLine("Enter the Second Num : ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(a * b);
            }
            else if (op == "/")
            {
                Console.WriteLine("Enter the Second Num : ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(a / b);
            }
            else
            {
                Console.WriteLine("Enter a Valid Operatore! Which are +, -, * or /");
            }

        }
    }

}
