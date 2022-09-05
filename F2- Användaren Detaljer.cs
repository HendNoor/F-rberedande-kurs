// See https://aka.ms/new-console-template for more information
{
    string förnamn;
    string efternamn;
    int ålder;
    Console.WriteLine("Förnamn: ");
    förnamn = Console.ReadLine();
    Console.WriteLine("Efternamn: ");
    efternamn = Console.ReadLine();
    Console.WriteLine("ålder: ");
    ålder = int.Parse(Console.ReadLine());
    Console.WriteLine($"{förnamn} {efternamn} {ålder}");
}

