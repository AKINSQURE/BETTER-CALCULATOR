using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BETTERCALCULATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter a number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Enter operator:");
            string op = Console.ReadLine();

            if (op == "sqrt")
            {
                Console.WriteLine(Math.Sqrt(num1));

            }
            else if (op == "log10") 
            {
                Console.WriteLine(Math.Log10(num1));
            }
                else if (op == "log")
            {
                Console.WriteLine(Math.Log(num1));
            }
            else if (op == "sin")
            {
                Console.WriteLine(Math.Sin(num1));
            }
            else if (op == "tan")
            {
                Console.WriteLine(Math.Tan(num1));
            }
            else if (op =="cos") 
            {
                Console.WriteLine(Math.Cos(num1));
            }
            else


                Console.Write(" Enter a number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
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
           else if (op == "pow")
            {

                Console.WriteLine(Math.Pow(num1, num2));
           }
            else
            {
                Console.Write("invalid operator: ");
            }

            Console.ReadLine();

        }



}
}
