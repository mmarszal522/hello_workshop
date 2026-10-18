Console.WriteLine("Wybierz kierunek: północ, południe, wschód, zachód\n(n/s/e/w)");
string kierunek = Console.ReadLine()!;

switch (kierunek)
{
    case "n":
        Console.WriteLine("Wyruszasz w stronę gór");
        break;
    case "s":
        Console.WriteLine("Wyruszasz w stronę pustyni");
        break;
    case "e":
        Console.WriteLine("Wyruszasz w stronę lasu");
        break;
    case "w":
        Console.WriteLine("Wyruszasz w stronę morza");
        break;
    default:
        Console.WriteLine("Nieznany kierunek");
        break;
}