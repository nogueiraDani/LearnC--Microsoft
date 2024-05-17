
string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

//Preço

/*
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
*/

//Moedas
//decimal measurement = 123456.78912m;
//Console.WriteLine($"Measurement: {measurement:N} units");

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");

//Porcentagem
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice) / price):P2}!"; //inserted
Console.WriteLine(yourDiscount);

//Interpolação
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");

//preenchimento e alinhamento

/*
Veja a seguir uma breve lista de categorias destes métodos incorporados para que possa ter uma ideia do que é possível.

Métodos que adicionam espaços em branco para fins de formatação (PadLeft(), PadRight())
Métodos que comparam duas cadeias de caracteres ou facilitam a comparação (Trim(), TrimStart(), TrimEnd(), GetHashcode(), a Length propriedade)
Métodos que ajudam a determinar o que existe dentro de uma cadeia ou até mesmo recuperam apenas uma parte da cadeia (Contains(), StartsWith(), EndsWith()Substring())
Métodos que alteram o conteúdo da cadeia ao substituir, inserir ou remover partes (Replace(), Insert(), Remove())
Métodos que transformam uma cadeia numa matriz de cadeias ou de carateres (Split(), ToCharArray())
*/

string input = "Pad this";
Console.WriteLine(input.PadLeft(12));
Console.WriteLine(input.PadRight(12));
//metodo sobrecarregado
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

//preechendo conforme necessidade dos espaços
string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);