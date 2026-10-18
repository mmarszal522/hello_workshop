Console.WriteLine("Podaj wiek");
int age = int.Parse(Console.ReadLine()!)!;

if (age < 0)
{
    Console.WriteLine("Niepoprawny wiek");
}
else if (0 <= age && age <= 12)
{
    Console.WriteLine("Dziecko");
}
else if (12 <= age && age <= 17)
{
    Console.WriteLine("Nastolatek");
}
else if (18 <= age && age <= 64)
{
    Console.WriteLine("Osoba dorosła");
}
else
{
    Console.WriteLine("Senior");
}