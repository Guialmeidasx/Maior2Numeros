//Digite o primeiro número..: 7
//Digite o segundo número...: 15
//O maior número é 15

int Primeiro, Segundo;

Console.Write("Digite o primeiro número..:");
Primeiro = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número..:");
Segundo = Convert.ToInt32(Console.ReadLine());

if (Primeiro>Segundo){
        Console.Write($"O maior número é..: {Primeiro}");
}

else {
        Console.Write($"O maior número é..: {Segundo}");
}

