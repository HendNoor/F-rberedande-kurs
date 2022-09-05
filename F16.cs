// See https://aka.ms/new-console-template for more information
using System;

class Q16

{

    private double health = 60.5;

    private double strength = 80.4;

    private double luck = 90.3;

    private string name;

    public void display()

    {

        Console.WriteLine(" Health = " + health + "\n Strength = " + strength + "\n Luck = " + luck);



    }





    public void setName(string n)

    {

        name = n;

    }



    public string getName()

    {

        return name;

    }

}

class Test

{

    static void Main(string[] args)

    {



        string name1, name2;

        // Creating two objects 

        Q16 Obj1 = new Q16();

        Q16 Obj2 = new Q16();



        Console.WriteLine("Enter your name: ");

        name1 = Console.ReadLine();



        Console.WriteLine("Enter opponent name: ");

        name2 = Console.ReadLine();





        // using objects to call the member functions 

        Obj1.setName(name1);

        Obj2.setName(name2);



        Console.WriteLine(Obj1.getName() + " and " + Obj2.getName() + " Stored Randam Health, Strength and Luck values are:\n");

        Obj1.display();

    }

} 
