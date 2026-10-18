Console.WriteLine("Podaj liczbę:");
int number = int.Parse(Console.ReadLine()!);

bool evenNumber = number % 2 == 0;

if (evenNumber == true)
{
    Console.WriteLine("Liczba jest parzysta");
}
else
{
    Console.WriteLine("Liczba jest nieparzysta");
}