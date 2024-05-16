/*
A finalidade de alto nível deste código é inverter uma cadeia de carateres 
e contar o número de vezes que um carater específico é apresentado.
*/

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = originalMessage.ToCharArray();

Array.Reverse(charMessage);

int letterCount = 0;

foreach (char letter in charMessage)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string new_message = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {letterCount} times.");

