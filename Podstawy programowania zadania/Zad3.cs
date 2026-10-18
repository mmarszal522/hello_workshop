Console.WriteLine("Racje żywności:");
string insRations = Console.ReadLine()!;
int foodRations = int.Parse(insRations);
Console.WriteLine("Członkowie drużyny");
string insMembers = Console.ReadLine()!;
int partyMembers = int.Parse(insMembers);
Console.WriteLine("Dni podróży");
string insDays = Console.ReadLine()!;
int days = int.Parse(insDays);

int rationsPerParty = foodRations / partyMembers;
int foodLeft = foodRations % partyMembers;
double rationsPerDay = foodRations / days;
double rationsOnAverage = rationsPerDay / partyMembers;

Console.WriteLine("Pełne racje dla członka drużyny: " + rationsPerParty);
Console.WriteLine("Reszta racji: " + foodLeft);
Console.WriteLine("Ilość racji na dzień: " + rationsPerDay);
Console.WriteLine("Średnia ilość racji dla członka drużyny: " + rationsOnAverage);
