// See https://aka.ms/new-console-template for more information
using System;
class Q3
{
    static public void Main()
    {

        var currentForeground = Console.ForegroundColor.ToString();
        if (currentForeground == "-1")
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}