// See https://aka.ms/new-console-template for more information
using System;

class Q9

{



    double decRoot(double n)

    {

        return Math.Sqrt(n);

    }

    double decPower2(double n)

    {

        double sum = 1;

        sum = n * n;

        return sum;



    }

    double decPower10(double n)

    {

        double sum = 1;

        for (int i = 0; i < 10; i++)

            sum = sum * n;

        return sum;

    }







    static public void Main()

    {



        double no;

        Q9 Obj = new Q9();





        Console.WriteLine("Enter a decimal number: ");

        no = Convert.ToDouble(Console.ReadLine());



        Console.WriteLine("\nthe root of " + no + " = " + Obj.decRoot(no));

        Console.WriteLine("\nthe 2 power  of " + no + " = " + Obj.decPower2(no));

        Console.WriteLine("\nthe 10 power of " + no + " = " + Obj.decPower10(no));

    }

}