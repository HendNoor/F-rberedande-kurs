// See https://aka.ms/new-console-template for more information

{
    Console.WriteLine("FörstaVärde: ");
    var FörstaVärde = int.Parse(Console.ReadLine());
    Console.WriteLine("AndraVärde: ");
    var AndraVärde = int.Parse(Console.ReadLine());
    int resultat;
    if (FörstaVärde> AndraVärde)
    {
        resultat = FörstaVärde;
    }
    else if (FörstaVärde < AndraVärde)
    {
        resultat = AndraVärde;
    }
    else
    {
        resultat = FörstaVärde; // båda är lika
    }
    Console.WriteLine(resultat);
    Console.ReadLine();
}