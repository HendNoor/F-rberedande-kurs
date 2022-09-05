// See https://aka.ms/new-console-template for more information
using System;

class Q15

{

    static public void Main()

    {

        Console.WriteLine(" Enter Numbers Seprated by comma");

        string line = Console.ReadLine();

        string[] values = line.Split(',');

        int[] ints = Array.ConvertAll(values, s => int.Parse(s));

        int sum = 0;

        for (int i = 0; i < ints.Length; i++)

            sum = sum + ints[i];

        Console.WriteLine(" the sum of all numbers =" + sum);

    }

}