int[][] triangulo = new int[4][];
triangulo[0] = new int[1];
triangulo[1] = new int[2];
triangulo[2] = new int[3];
triangulo[3] = new int[4];

int numeroconsecutivo = 1;
for (int i = 0; i< triangulo.Length; i++)
{
    for(int x = 0; x < triangulo[i].Length; x++)
    {
        triangulo[i][x] = numeroconsecutivo;
        numeroconsecutivo++;
    }
}
Console.WriteLine("Triángulo");
for(int i = 0; i < triangulo.Length; i++)
{
    for(int x = 0; x < triangulo[i].Length; x++)
    {
        Console.Write(triangulo[i][x] + "");
    }
    Console.WriteLine();
}