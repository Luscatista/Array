//Criar vetor de idades com 4 posicoes, use um for para preencher e tambem um for para listar as idades

int[] idades = new int[4];

for(int i = 0; i < 4; i++)
{
    Console.WriteLine("Digite a idade.");
    idades[i] = int.Parse(Console.ReadLine()); 
}
Console.WriteLine();
for(int i = 0;i < 4; i++)
{
    Console.WriteLine($"Idade numero {i+1}: { idades[i]}");
}