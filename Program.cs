// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;
class Test
{
    static void Main(string[] args)
    {
        for (; true;)
        {



            Console.Write("Enter a number: ");
            int num1, num2;
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            num2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Select the mathmatical operation: \n1. Addition \n2.Subtraction \n3. Multiplication \n4. Division");

            int ch;
            ch = int.Parse(Console.ReadLine());


            switch (ch)
            {
                case 1:
                    Console.WriteLine(num1 + num2);
                    break;

                case 2:
                    Console.WriteLine(num1 - num2);
                    break;

                case 3:
                    Console.WriteLine(num1 * num2);
                    break;

                case 4:
                    Console.WriteLine(num1 / num2);
                    break;

                default:
                    Console.WriteLine("Please enter a correct choice: ");
                    break;

                    Console.ReadLine();
            }

            Console.WriteLine("Do you want to continue 1\0");
            int choise;
            choise = int.Parse(Console.ReadLine());

            if (choise == 1)
                Console.Clear();
            else
                break;
        }



    }
}