using System;

namespace UserOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            double input1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            double input2 = double.Parse(Console.ReadLine());

        start:
            Console.WriteLine("Which operation do you want to perform? (+, -, *, /, %)");
            string userOperation = Console.ReadLine();

            switch (userOperation)
            {
                case "+":
                    double sum = input1 + input2;
                    Console.WriteLine($"{input1} + {input2} = {sum}");
                    break;
                case "-":
                    double subtraction = input1 - input2;
                    Console.WriteLine($"{input1} - {input2} = {subtraction}");
                    break;
                case "*":
                    double multiplication = input1 * input2;
                    Console.WriteLine($"{input1} * {input2} = {multiplication}");
                    break;
                case "/":
                    double division = input1 / input2;
                    Console.WriteLine($"{input1} / {input2} = {division}");
                    break;
                case "%":
                    double modulo = input1 % input2;
                    Console.WriteLine($"{input1} % {input2} = {modulo}");
                    break;

                default:
                    Console.WriteLine("Invalid operation. Please choose between +, -, *, /, %");
                    goto start;
            }
        }
    }
}