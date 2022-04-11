using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("String Calculator");

            Console.WriteLine("=================================="  );

            int action = Convert.ToInt32(Console.ReadLine());

            
            Console.Write("Ensert the expression: ");
            string input1 = Console.ReadLine();
            Convert.ToInt32(input1);

            int result = Int32.Parse(input1);
            
            Console.WriteLine(result);
            

            Console.Write($"The result is: {result} ");

        }

        //Add
        //public static void Addition(int inpu1)
        //{
            
        //}
        

        //Divide
        //public static void Divisions()
        //{
        //    try
        //    {
        //         Console.WriteLine();
        //    }
        //    catch (DivideByZeroException)
        //    {
        //        Console.WriteLine("CannotDivideByZero");
        //    }
        //}

        //Calculate
        public static void calculate(int input1)
        {
            if (input1 == 0)
            {

            }

            else if ()

            else
        }

    }

}
