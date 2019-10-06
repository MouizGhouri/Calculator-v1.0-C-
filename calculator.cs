using System;

namespace LookTisM8
{
    class Program
    { 
        static void Main(string[] args)
        {

            Console.WriteLine("CREDITS: A VERY SIMPLE CALCULATOR MADE BY THE LEGEND NAMED MOUIZ GHOURI");
            Console.WriteLine("///////////////////////////////////////////////////////////////////////");
            Console.WriteLine("\n");

            Console.WriteLine("(ID: 1) Division");
            Console.WriteLine("(ID: 2) Subtraction");
            Console.WriteLine("(ID: 3) Addition");
            Console.WriteLine("(ID: 4) Multiplication");
            Console.WriteLine("_____________________________\n");
            Console.WriteLine("Enter the ID of an operation:  ");
            
            string input_value = Console.ReadLine();

            int input_value_int;
            
            bool parse_success = int.TryParse(input_value, out input_value_int);

            switch (input_value_int)
            {
                case 1:
                {
                    Console.WriteLine("Enter the operation according to syntax (n1 / n2 / n3 ...): ");

                    string input = Console.ReadLine();

                    string[] numbers_string = input.Split ('/');

                    int[] numbers = new int[numbers_string.Length];

                    float result = 1;

                    for (int i = 0; i < numbers_string.Length; i++)
                    {
                        numbers[i] = int.Parse (numbers_string[i]);

                        if (i == 0)
                        {
                            result = (result * numbers[i]);
                        }
                        else
                        {
                            result = (result / numbers[i]);
                        }
                    }

                    Console.WriteLine("Answer: " + result);

                    break;
                }
                case 2:
                {
                    Console.WriteLine("Enter the operation according to syntax (n1 - n2 - n3 ...): ");

                    string input = Console.ReadLine();

                    string[] numbers_string = input.Split('-');

                    int[] numbers = new int[numbers_string.Length];

                    float result = 0;

                    for (int i = 0; i < numbers_string.Length; i++)
                    {
                        numbers[i] = int.Parse(numbers_string[i]);

                        if (i == 0)
                        {
                            result = numbers[i];
                        }
                        else
                        {
                            result = (result - numbers[i]);
                        }
                    }

                    Console.WriteLine("Answer: " + result);

                    break;
                }
                case 3:
                {
                    Console.WriteLine("Enter the operation according to syntax (n1 + n2 + n3 ...): ");

                    string input = Console.ReadLine();

                    string[] numbers_string = input.Split('+');

                    int[] numbers = new int[numbers_string.Length];

                    float result = 0;

                    for (int i = 0; i < numbers_string.Length; i++)
                    {
                        numbers[i] = int.Parse(numbers_string[i]);

                        result += numbers[i];
                    }

                    Console.WriteLine("Answer: " + result);

                    break;
                }
                case 4:
                {
                    Console.WriteLine("Enter the operation according to syntax (n1 * n2 * n3 ...): ");

                    string input = Console.ReadLine();

                    string[] numbers_string = input.Split('*');

                    int[] numbers = new int[numbers_string.Length];

                    float result = 1;

                    for (int i = 0; i < numbers_string.Length; i++)
                    {
                        numbers[i] = int.Parse(numbers_string[i]);

                        result *= numbers[i];
                    }

                    Console.WriteLine("Answer: " + result);

                    break;
                }
                default:
                {
                    Console.WriteLine("\n- Wrong ID You Fool!");
                    break;
                }
            }

        }
    }
}
