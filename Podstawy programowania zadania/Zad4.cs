Console.WriteLine("Punkty życia bohatera:");
string insLife = Console.ReadLine()!;
int lifePoints = int.Parse(insLife);
Console.WriteLine("Mikstury bohatera:");
string insPotions = Console.ReadLine()!;
int potions = int.Parse(insPotions);
Console.WriteLine("Czy bohater ma klucz?: (true/false)");
bool hasKey = bool.Parse(Console.ReadLine()!);
Console.WriteLine("Czy bohater ma mapę?: (true/false)");
bool hasMap = bool.Parse(Console.ReadLine()!);

bool isAlive = lifePoints > 0;
bool fullHealth = lifePoints >= 100;
bool needsHealing = !fullHealth;
bool hasPotions = potions > 0;
bool hasEquipment = hasKey || hasMap;
bool readyToHeadOut = isAlive && hasPotions && hasEquipment;

Console.WriteLine("Bohater żyje: " + isAlive);
Console.WriteLine("Bohater ma pełne zdrowie: " + fullHealth);
Console.WriteLine("Bohater wymaga leczenia: " + needsHealing);
Console.WriteLine("Bohater posiada zaopatrzenie: " + hasPotions);
Console.WriteLine("Bohater posiada klucz lub mapę: " + hasEquipment);
Console.WriteLine("Bohater jest gotowy na wyprawę: " + readyToHeadOut);