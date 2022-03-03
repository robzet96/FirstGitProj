int correctPin = 1111;

Console.WriteLine("Ppin");
Console.WriteLine("Po pin");
Console.WriteLine("Podin");
Console.WriteLine("Poin");
Console.WriteLine("Popin");
Console.WriteLine("Po pin");
Console.WriteLine("Ppin");
Console.WriteLine("Pj pin");
Console.WriteLine("Ppin");
Console.WriteLine("Po pin");

for (int i = 2; i >= 0; i--)
{
    Console.WriteLine("Podaj pin");
    int pin = Convert.ToInt32(Console.ReadLine());

    if(pin == correctPin)
    {
        Console.WriteLine("Zalogowano");
        break;
    }
    else if(i == 0)
    {
        Console.WriteLine("Zly pin, zablokowano dostep do konta");
    }
    else
    {
        Console.WriteLine("Zly pin, pozostalo " + i + " prob");
    }
}