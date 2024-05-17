//conversao implicita
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);


int myInt = 3;
Console.WriteLine($"int: {myInt}");
decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");


decimal myDecimal2 = 3.14m;
Console.WriteLine($"decimal: {myDecimal2}");
int myInt2 = (int)myDecimal2;
Console.WriteLine($"int: {myInt2}");


decimal myDecimal3 = 1.23456789m;
float myFloat = (float)myDecimal;
Console.WriteLine($"Decimal: {myDecimal3}");
Console.WriteLine($"Float  : {myFloat}");

//toString
int first2 = 5;
int second2 = 7;
string message = first2.ToString() + second2.ToString();
Console.WriteLine(message);

//Parse
string first3 = "5";
string second3 = "7";
int sum = int.Parse(first3) + int.Parse(second3);
Console.WriteLine(sum);

//Convert
string value1 = "5";
string value2 = "7";
int result2 = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result2);


int value3 = (int)1.5m; // casting truncates
Console.WriteLine(value3);
int value4 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value4);

//tryParse
//string value5 = "102";
string value5 = "bad";
int result3 = 0;
if (int.TryParse(value5, out result3))
{
    Console.WriteLine($"Measurement: {result3}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result3}");