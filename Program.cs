using System;

Console.WriteLine("Hello from main");
Console.WriteLine("Hello Conflicts!!!");
Console.Write("Podaj cyfre: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int number))
{
    Console.WriteLine("Oto twoja cyfra: " + number);
}
else
{
    Console.WriteLine("Błąd: Wprowadzona wartość nie jest cyfrą!");
}