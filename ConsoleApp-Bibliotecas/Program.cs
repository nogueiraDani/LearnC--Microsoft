//Random dice = new Random(); forma antiga de instanciar
Random dice = new(); // versao mais recente que o .NET Runtime permite

//int roll = dice.Next(1, 7);
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50,101);

//Console.WriteLine(roll);
Console.WriteLine($"Roll1 = {roll1}");
Console.WriteLine($"Roll2 = {roll2}");
Console.WriteLine($"Roll3 = {roll3}");

