using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Simple_calculator_with_user_s_operator
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("enter number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter operator");
            string op  = Console.ReadLine();
            Console.WriteLine("enter second number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num2 + num1);

            } else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Not an operator");
            }
            Console.ReadLine();
        }
    }
}
