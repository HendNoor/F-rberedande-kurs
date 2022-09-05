// See https://aka.ms/new-console-template for more information

{
    int[] array = new int[11];
    var random = new Random();
    int temp = 0;
    for (int i = 0; i < array.Length; ++i)
    {
        int number = random.Next(1, 100);
        array[i] = number;
    }
    Console.WriteLine(" Slumpmässiga Tal");
    foreach (var i in array)
    {
        Console.Write($" {i} ");
    }

    for (int i = 0; i <= array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    Console.WriteLine("\n Talen från den första i stigande ordning");
    foreach (var i in array)
    {
        Console.WriteLine(i);
        
    }
}