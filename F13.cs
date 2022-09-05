// See https://aka.ms/new-console-template for more information
using System;

class Q13

{



    static public void Main()

    {



        Console.WriteLine(" Enter no1: ");



        string no1 = Console.ReadLine();



        Console.WriteLine(" Enter no2: ");

        string no2 = Console.ReadLine();



        var n1 = Int16.Parse(no1);

        var n2 = Int16.Parse(no2);



        Console.WriteLine(" THE BETWEEN NUMBERS ARE : \n");

        if (n1 < n2)

        {

            for (int i = n1 + 1; i < n2; i++)

                Console.WriteLine(i + ".");





        }

        else

        {

            for (int i = n1 - 1; i > n2; i--)

                Console.WriteLine(i + ".");

        }

    }

}