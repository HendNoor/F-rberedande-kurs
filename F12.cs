// See https://aka.ms/new-console-template for more information

{
    int n, r, sum = 0, temp;
    Console.Write("Ange ett nummer: ");
    n = int.Parse(Console.ReadLine());
    temp = n;
    while (n > 0)
    {
        r = n % 10;
        sum = (sum * 10) + r;
        n = n / 10;
    }
    if (temp == sum)
        Console.Write("Numret är palindrome.");
    else
        Console.Write("Numret är inte palindrome.");
    Console.ReadLine();
}