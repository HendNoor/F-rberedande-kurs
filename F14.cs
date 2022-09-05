// See https://aka.ms/new-console-template for more information
using System;

class Q14

{

    public static void Main()

    {

        Console.WriteLine(" Enter Numbers Seprated by comma");

        string line = Console.ReadLine();

        string[] values = line.Split(',');

        int[] arr1 = Array.ConvertAll(values, s => int.Parse(s));

        int len = arr1.Length;



        int[] arr2 = new int[len];

        int[] arr3 = new int[len];

        int i, j = 0, k = 0, n;

        n = len;

        Console.Write("\n\nSeparate odd and even integers in separate arrays:\n");

        Console.Write("------------------------------------------------------\n");



        for (i = 0; i < n; i++)

        {

            if (arr1[i] % 2 == 0)

            {

                arr2[j] = arr1[i];

                j++;

            }

            else

            {

                arr3[k] = arr1[i];

                k++;

            }

        }



        Console.Write("\nThe Even elements are : \n");

        for (i = 0; i < j; i++)

        {

            Console.Write("{0} ", arr2[i]);

        }



        Console.Write("\nThe Odd elements are :\n");

        for (i = 0; i < k; i++)

        {

            Console.Write("{0} ", arr3[i]);

        }

        Console.Write("\n\n");

    }

}