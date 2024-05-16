Random decisao = new();

int dado1 = decisao.Next(1, 7);
int dado2 = decisao.Next(1, 7);
int dado3 = decisao.Next(1, 7);

int pontuacao = dado1 + dado2 + dado3;
Console.WriteLine($"Pontos: {dado1} + {dado2} + {dado3}");
int bonus = 0;

if (dado1 == dado2 && dado2 == dado3)
{
    Console.WriteLine("Você lançous três dados com valores iguais! +6 pontos!");
    bonus += 6;
} else if (dado1 == dado2 || dado2 == dado3 || dado1 == dado3)
{
    Console.WriteLine("Você lançous dois dados com valores iguais! +2 pontos!");
    bonus += 2;
}

pontuacao += bonus;

if (pontuacao >= 15)
{
    Console.WriteLine($"Ganhou, sua pontuação foi {pontuacao}");
}
else
{
    Console.WriteLine($"Perdeu, sua pontuação foi {pontuacao}");
}




