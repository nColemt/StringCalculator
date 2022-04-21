using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            Console.Write(".:: String Calculator ::.\n");
            Console.WriteLine("[Example:(3 + 4 * 3)] \n");

            while (true)
            {
                Console.Write("Enter your Math Expression: ");
                string input = Console.ReadLine();

                if (input == "clear")
                {
                    Console.Clear();
                }

                while (input.Contains(' '))
                {
                    input = StringCalculation(input);
                }

                if (input != "clear")
                {
                    Console.Write("Result = " + input + "\n\n");
                }

                if (input.Equals("exit", StringComparison.InvariantCultureIgnoreCase))
                {
                    Environment.Exit(0);
                }
            }


        }

        // Calculate ["number" + "operator" + "number"]
        static string StringCalculation(string input)
        {
            string output = input;
            string Reader = "";

            if (!input.Contains('('))
            {
                input = putIntoBrackets(input);
            }

            if (input.Contains('('))
            {

                string formula;
                string testFormula;

                int iniBracket = -1;
                int closingBracket = -1;


                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i].Equals('('))
                    {
                        iniBracket = i;
                    }
                }



                for (int i = 0; i < input.Length - iniBracket; i++)
                {
                    if (input[iniBracket + i].Equals(')'))
                    {
                        closingBracket = iniBracket + i;
                        break;
                    }
                }


                testFormula = input.Remove(0, iniBracket + 1);
                testFormula = testFormula.Remove(closingBracket - (iniBracket + 1));

                if (testFormula.Split(' ').Length > 3)
                {
                    Reader = "";
                    input = putIntoBrackets(input);
                    Reader += "-   INPUT = " + input;

                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i].Equals('('))
                        {
                            iniBracket = i;
                        }
                    }


                    for (int i = 0; i < input.Length - iniBracket; i++)
                    {
                        if (input[iniBracket + i].Equals(')'))
                        {
                            closingBracket = iniBracket + i;
                            break;
                        }
                    }

                }


                output = input.Remove(iniBracket, 1);
                output = output.Remove(closingBracket - 1, 1);


                formula = input.Remove(0, iniBracket + 1);
                formula = formula.Remove(closingBracket - (iniBracket + 1));


                output = output.Replace(formula, Calculate(formula));

                Console.WriteLine(Reader);

                return output;
            }

            return output;
        }

        static string Calculate(string input)
        {
            string output = input;
            switch (input)
            {
            }
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
            if (input.Contains('^'))
            {
                output = Exponentiation(input);
            }

            return output;
        }

        //Division
        static string Division(string input)
        {
            double[] nums = GetNumbers(input);

            return Math.Round(nums[0] / nums[1], 2).ToString();
        }

        //Multiplication
        static string Multiplication(string input)
        {
            double[] nums = GetNumbers(input);

            return Math.Round(nums[0] * nums[1], 2).ToString();
        }


        //Exponentiation
        static string Exponentiation(string input)
        {
            double[] nums = GetNumbers(input);

            return Math.Round(Math.Pow(nums[0], nums[1]), 2).ToString();
        }

        //Addition
        static string Addition(string input)
        {
            double[] nums = GetNumbers(input);
            return (nums[0] + nums[1]).ToString();
        }

        //Subtraction
        static string Substraction(string input)
        {
            double[] nums = GetNumbers(input);
            return (nums[0] - nums[1]).ToString();
        }

        static double[] GetNumbers(string input)
        {
            List<string> numbers = input.Split(' ').ToList();

            double[] output = { Convert.ToDouble(numbers[0]), Convert.ToDouble(numbers[2]) };

            return output;
        }

        static string putIntoBrackets(string input)
        {
            List<string> input2 = input.Split(' ').ToList();

            bool doBreak = false;

            if (input.Contains('^'))
            {
                for (int i = 0; i < input2.Count; i++)
                {
                    if (doBreak)
                    {
                        break;
                    }
                    if (input2[i].Contains('^'))
                    {
                        input2[i - 1] = "(" + input2[i - 1];
                        input2[i + 1] = input2[i + 1] + ")";
                        doBreak = true;
                    }
                }
            }

            if (input.Contains('/') || input.Contains('*'))
            {
                for (int i = 0; i < input2.Count; i++)
                {
                    if (doBreak)
                    {
                        break;
                    }
                    if (input2[i].Contains('/') || input2[i].Contains('*'))
                    {
                        input2[i - 1] = "(" + input2[i - 1];
                        input2[i + 1] = input2[i + 1] + ")";
                        doBreak = true;
                    }
                }
            }

            if (input.Contains('+') || input.Contains('-'))
            {
                for (int i = 0; i < input2.Count; i++)
                {
                    if (doBreak)
                    {
                        break;
                    }
                    if (input2[i].Contains('+') || input2[i].Contains('-'))
                    {
                        input2[i - 1] = "(" + input2[i - 1];
                        input2[i + 1] = input2[i + 1] + ")";


                        doBreak = true;
                    }
                }
            }


            input = "";

            for (int i = 0; i < input2.Count; i++)
            {
                if (i == 0)
                {
                    input += input2[i];
                }
                else
                {
                    input += " " + input2[i];
                }
            }
            return input;
        }
    }
}