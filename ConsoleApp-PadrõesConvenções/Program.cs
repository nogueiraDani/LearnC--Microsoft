/*
Há algumas regras de nomenclatura de variáveis que são impostas pelo compilador do C#.

Os nomes de variáveis podem conter carateres alfanuméricos e o caráter de sublinhado. Não são permitidos carateres especiais como o sinal de libra #, o traço - e o cifrão $.
Os nomes de variáveis têm de começar com uma letra alfabética ou um caráter de sublinhado, não com um número. Os programadores utilizam o caráter de sublinhado para uma finalidade especial, por isso, tente não o utilizar por enquanto.
Os nomes de variáveis NÃO devem ser uma palavra-chave C#. Por exemplo, estas declarações de nome de variável não serão permitidas: float float; ou string string;.
Os nomes das variáveis são sensíveis a maiúsculas e minúsculas, o que significa que string MyValue; e string myValue; são duas variáveis diferentes.

Os nomes das variáveis devem utilizar o CamelCase, que é um estilo de escrita que utiliza uma letra minúscula no início da primeira palavra e uma letra maiúscula no início de cada palavra subsequente. Por exemplo: string thisIsCamelCase;.
Os nomes de variáveis devem ser descritivos e ter significado na sua aplicação. Você deve escolher um nome para sua variável que represente o tipo de dados que ela manterá (não o tipo de dados). Por exemplo: bool orderComplete;, NÃO bool isComplete;.
Os nomes das variáveis devem ser uma ou mais palavras inteiras anexadas umas às outras. Não utilize contrações porque o nome da variável pode não ser claro para as outras pessoas que estão a ler o código. Por exemplo: decimal orderAmount;, NÃO decimal odrAmt;.
Os nomes de variáveis não devem incluir o tipo de dados da variável. Podem aconselhá-lo a utilizar um estilo como string strMyValue;. Era um estilo popular há alguns anos. No entanto, a maioria dos desenvolvedores não segue mais este conselho e há boas razões para não usá-lo.

*/

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

// 

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

