int[] numeros = new int[10];

for (int i = 0; i < 10; i++)
{
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Pares");
for (int i = 0; i < 10; i++)
{
    if (numeros[i] % 2 == 0)
    {
        Console.Write(numeros[i] + " ");
    }
}

Console.WriteLine();

Console.WriteLine("Ímpares");
for (int i = 0; i < 10; i++)
{
    if (numeros[i] % 2 != 0)
    {
        Console.Write(numeros[i] + " ");
    }
}
Console.WriteLine();
Console.WriteLine("Primeira posição: " + numeros[0]);
Console.WriteLine("Última posição: " + numeros[9]);
