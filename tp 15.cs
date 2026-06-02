int[,] matriz = {
    {1,2,5},
    {4,6,7},
    {8,4,2}

};

for (int i = 0; i < 3; i++)
{
    for (int o = 0; o < 3; o++)
    {
        Console.Write(matriz[i, o] + "\t");
    }
    Console.WriteLine("");
}

Console.WriteLine("Ejercicio 2");
void ejercicio2(int resultado)
{
    int[,] matriz = {
    {10,20,30},
    {40,50,60},
    {70,80,90}
};
    resultado = 0;
    for (int i = 0; i < 3; i++)
    {
        for (int p = 0; p < 3; p++)
        {
            Console.Write(matriz[i, p] + "\t");
            resultado += matriz[i, p];
        }
        Console.WriteLine("");
    }
}
ejercicio2();