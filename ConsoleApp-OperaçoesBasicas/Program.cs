
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");


//erro
/*int decimalQuotient2 = 7 / 5.0m;
int decimalQuotient3 = 7.0m / 5;
int decimalQuotient4 = 7.0m / 5.0m;
decimal decimalQuotient6 = 7 / 5;
*/

//downcast|upcast
int first = 7;
int second = 5;
decimal quotient7 = (decimal)first / (decimal)second;
Console.WriteLine(quotient7);

//restante da divisao
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

//ordem das operações conforme a regra da matematica
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

/* *Utilize operadores como +, -, * e / para realizar operações matemáticas básicas.
   *A divisão de dois valores int resultará na truncagem de todos os valores à direita da vírgula. Para reter valores após o ponto decimal, você precisa lançar o divisor ou dividendo (ou ambos) em um número de ponto flutuante como decimal primeiro, então o quociente deve ser do mesmo tipo de ponto flutuante também, a fim de int evitar truncamento.
   *Realize uma operação de conversão para tratar temporariamente um valor como se fosse de um tipo de dados diferente.
   *Utilize o operador % para obter o resto depois da divisão.
   *A ordem das operações seguirá as regras do acrónimo PEMDAS.
*/

//incremento e decremento
int value3 = 0;     // value is now 0.
value3 = value3 + 5; // value is now 5.
value3 += 5;        // value is now 10.

int value4 = 0;     // value is now 0.
value4 = value4 + 1; // value is now 1.
value4++;

int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);        // value is now 2.


int value5 = 1;
value5++;
Console.WriteLine("First: " + value5);
Console.WriteLine($"Second: {value5++}");
Console.WriteLine("Third: " + value5);
Console.WriteLine("Fourth: " + (++value5));