// See https://aka.ms/new-console-template for more information
using System;
class FileEx
{

    void F7(string path)
    {
        Console.WriteLine($"Save to file");
        var input = Console.ReadLine();
        File.WriteAllTextAsync(path + "WriteText.txt", input);
    }
    void F8(string path)
    {
        var text = File.ReadAllText(path + "WriteText.txt");
        Console.WriteLine(text);
        Console.ReadLine();
    }
    static public void Main()
    {
        FileEx obj = new FileEx();
        obj.F7("c:");
        obj.F8("c:");
    }
}

