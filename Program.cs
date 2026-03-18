using System;
Console.WriteLine("Hello, World!");
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