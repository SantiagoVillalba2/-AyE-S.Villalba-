void ejercicio1()
{
    int[,] matriz1 = new int[4, 4];
    int[,] matriz = {
        {5,9,1,3},
        {7,2,3,2},
        {0,2,4,5},
        {9,3,1,2}
};

    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int o = 0; o < matriz.GetLength(1); o++)
        {
            Console.Write(matriz[i, o] + "\t");
        }
        Console.WriteLine();
    }
    int suma = matriz[0, 0] + matriz[0, 3] + matriz[3, 0] + matriz[3, 3];
    Console.WriteLine($"Suma de esquinas: {suma}");
}
void ejercicio2()
{
    int suma1;
    int suma2;
    int[,] matriz1 = new int[3, 3];
    int[,] matriz = {
    {1,2,5},
    {4,6,7},
    {8,4,2}
};
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int o = 0; o < matriz.GetLength(1); o++)
        {
            Console.Write(matriz[i, o] + "\t");
        }
        Console.WriteLine();
    }
    suma1 = matriz[0, 0] + matriz[1, 1] + matriz[2, 2];
    suma2 = matriz[0, 2] + matriz[1, 1] + matriz[2, 0];
    Console.WriteLine($"Suma diagonal principal: {suma1}");
    Console.WriteLine($"Suma diagonal secundaria: {suma2}");
}
void ejercicio3()
{
    Console.WriteLine("Ingrese el tamaño de la matriz cuadrada");
    int num = Convert.ToInt32(Console.ReadLine());
    int[,] matriz = new int[num, num];

    for (int i = 0; i < num; i++)
    {
        for (int o = 0; o < num; o++)
        {
            if (i == o)
            {
                matriz[i, o] = 1;
            }
            else
            {
                matriz[i, o] = 0;
            }
        }
    }
    Console.WriteLine("Matriz identidad");
    for (int i = 0; i < num; i++)
    {
        for (int o = 0; o < num; o++)
        {
            Console.Write(matriz[i, o] + "\t");
        }
        Console.WriteLine();
    }
}

bool menu = true;
while (menu)
{
    Console.WriteLine("1 = ejercicio 1 | 2 = ejercicio 2 | 3 = ejercicio 3 | 4 = terminar programa");
    int opcion = Convert.ToInt16(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            ejercicio1();
            break;
        case 2:
            ejercicio2();
            break;
        case 3:
            ejercicio3();
            break;
        case 4:
            menu = false;
            break;
        default:
            Console.WriteLine("No es una opción disponible");
            break;
    }

}
