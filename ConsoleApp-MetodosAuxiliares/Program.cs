//metodo Sort
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

//metodo Reverse
Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

//metodo Clear e Resize
string[] pallets2 = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets2, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets2.Length}");
foreach (var pallet in pallets2)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets2, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets2.Length}");

pallets2[4] = "C01";
pallets2[5] = "C02";

foreach (var pallet in pallets2)
{
    Console.WriteLine($"-- {pallet}");
}

//redimensionar array usando o Resize
Console.WriteLine("");
Array.Resize(ref pallets2, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets2.Length}");

foreach (var pallet in pallets2)
{
    Console.WriteLine($"-- {pallet}");
}

//toChar + Reverse
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);

//Join e Split
string value2 = "abc123";
char[] valueArray2 = value2.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result2 = String.Join(",", valueArray2);
Console.WriteLine(result2);

string[] items = result2.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}


