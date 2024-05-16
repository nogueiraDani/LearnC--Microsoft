// string[] idsFraudulentos = new string[3];

/*idsFraudulentos[0] = "A123";
idsFraudulentos[1] = "B456";
idsFraudulentos[2] = "C789";

idsFraudulentos[0] = "F000";

System.Console.WriteLine($"Reassign first: {idsFraudulentos[0]}");
*/

class Program
{
    private static void Main(string[] args)
    {
        string[] idsFraudulentos = ["A123", "B456", "C789"];

        Console.WriteLine($"First: {idsFraudulentos[0]}");
        Console.WriteLine($"Second: {idsFraudulentos[1]}");
        Console.WriteLine($"Third: {idsFraudulentos[2]}");

        Console.WriteLine($"There are {idsFraudulentos.Length} fraudulent orders to process.");
    }
}