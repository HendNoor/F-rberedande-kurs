// See https://aka.ms/new-console-template for more information
{
    var random = new Random();
    int number = random.Next(1, 100);
    int attempts = 0;
    while (true)
    {
        Console.WriteLine("Gissa ett nummer");
        int input = int.Parse(Console.ReadLine());
        attempts++;
        if (input == number)
        {
            Console.WriteLine($"Antalet försök var { attempts}");
            break;
        }
        else if (input > number)
        {
            Console.WriteLine($"Numret är för stor");
        }
        else
        {
            Console.WriteLine($"Numret är för lite");
        }
    }
}
