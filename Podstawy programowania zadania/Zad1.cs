string name = "Grzegorz";
char playerIcon = '&';
int expLevel = 5;
double gold = 12.0;
double backpackWeight = 3.4;
bool hasMap = false;

Console.WriteLine("\n~~ Status bohatera ~~");
Console.WriteLine("Imię (string): " + name);
Console.WriteLine("Ikona (char): " + playerIcon);
Console.WriteLine("Poziom (int): " + expLevel);
Console.WriteLine("Złoto (double): " + gold);
Console.WriteLine("Plecak (double): " + backpackWeight + " kg");
Console.WriteLine("Ma mapę (bool): " + hasMap + "\n");

gold = 5.5;
backpackWeight = 3.5;
hasMap = true;

Console.WriteLine("\n~~ Status bohatera ~~");
Console.WriteLine("Imię (string): " + name);
Console.WriteLine("Ikona (char): " + playerIcon);
Console.WriteLine("Poziom (int): " + expLevel);
Console.WriteLine("Złoto (double): " + gold);
Console.WriteLine("Plecak (double): " + backpackWeight + " kg");
Console.WriteLine("Ma mapę (bool): " + hasMap + "\n");