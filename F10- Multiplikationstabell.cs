// See https://aka.ms/new-console-template for more information

{
    Console.WriteLine("Multiplikationstabell");
    int n = int.Parse(Console.ReadLine());
    for (int i = 1; i <= 10; ++i)
        Console.Write(n + " * " + i + " = " + n * i + "\n");
    Console.ReadLine();
}