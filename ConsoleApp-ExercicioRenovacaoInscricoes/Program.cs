Random random = new();

int diasUteisParaExpirar = random.Next(12);
int porcentagemDesconto = 0;

if (diasUteisParaExpirar <= 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (diasUteisParaExpirar == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    porcentagemDesconto = 20;
}
else if (diasUteisParaExpirar <= 5)
{
    Console.WriteLine($"Your subscription expires in {diasUteisParaExpirar} days.");
    porcentagemDesconto = 10;
}
else if (diasUteisParaExpirar <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

Console.WriteLine($"Dias até expirar: {diasUteisParaExpirar}");

if(porcentagemDesconto > 0) {
    Console.WriteLine($"Renew now and save {porcentagemDesconto}%!");
}

