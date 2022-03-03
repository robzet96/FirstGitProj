int correctPin = 1111;

Console.WriteLine("Podaj pin");
Console.WriteLine("Podaj pin");
Console.WriteLine("Podaj pin");
Console.WriteLine("Podaj pin");
Console.WriteLine("Podaj pin");
Console.WriteLine("Podaj pin");
Console.WriteLine("Podaj pin");
Console.WriteLine("Podaj pin");
Console.WriteLine("Podaj pin");
Console.WriteLine("Podaj pin");

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