using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {

        static string StringCalculation(string input)
        {
            while (true)
            {
                Console.WriteLine("Enter your Math Expression. Example: (3 + 4 * 3) ");
                string input = Console.ReadLine();
            }
        }



        static string Calculate(string input)
        {
            string output = input;

            if (input.Contains('+'))
            {
                output = Addition(input);
            }
            if (input.Contains('-'))
            {
                output = Substraction(input);
            }
            if (input.Contains('/'))
            {
                output = Division(input);
            }
            if (input.Contains('*'))
            {
                output = Multiplication(input);
            }


            return output;
        }

        static string Division(string input)
        {
            double[] nums = GetNumbers(input);

            return
        }

        static string Multiplication(string input)
        {
            double[] nums = GetNumbers(input);

            return
        }

        static string Addition(string input)
        {
            double[] nums = GetNumbers(input);
            return
        }

        static string Substraction(string input)
        {
            double[] nums = GetNumbers(input);
            return
        }

        static double[] GetNumbers(string input)
        {
            List<string> numbers = input.Split(' ').ToList();

            int[] output = { Convert.ToInt32(numbers[]), Convert.ToInt32(numbers[]) };

            return output;
        }




    }
}