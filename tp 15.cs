void ejercicio1()
{
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
}

void ejercicio2()
{
    int[,] matriz = {
    {10,20,30},
    {40,50,60},
    {70,80,90}
};
    int resultado = 0;
    for (int i = 0; i < 3; i++)
    {
        for (int p = 0; p < 3; p++)
        {
            Console.Write(matriz[i, p] + "\t");
            resultado += matriz[i, p];
        }
        Console.WriteLine("");
    }
    Console.WriteLine($"La suma de todos los números es: {resultado}");
}

void ejercicio3()
{
    int[,] matriz = {
        {5,9,1,3},
        {7,2,3,2},
        {0,2,4,5},
        {9,3,1,2}
    };
    for (int i = 0; i < 4; i++)
    {
        for (int o = 0; o < 4; o++)
        {
            Console.Write(matriz[i, o] + "\t");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
    Console.WriteLine("Ingresa la coordenada de la fila");
    int fila = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ahora ingresá la coordenada de la columna");
    int columna = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"El elemento en esas coordenadas es: {matriz[fila, columna]}");
}

void ejercicio4()
{
    int mayor = 0;
    int[,] matriz = {
        {10,45,5,7},
        {4,6,14,65},
        {9,4,1,78},
        {37,23,17,32}
    };

    for (int i = 0; i < 4; i++)
    {
        for (int o = 0; o < 4; o++)
        {
            Console.Write(matriz[i, o] + "\t");
            if (matriz[i, o] > mayor)
                mayor = matriz[i, o];
        }
        Console.WriteLine("");
    }
    Console.WriteLine($"el elemento más grande es: {mayor}");
}

void ejercicio5()
{
    int[,] matriz = {
        {98,67,102,34},
        {21,22,121,65},
        {87,84,101,102},
        {18,47,234,901}
    };

    int[] sumasFilas = new int[4];
    int[] sumasColumnas = new int[4];

    for (int i = 0; i < 4; i++)
    {
        for (int o = 0; o < 4; o++)
        {
            Console.Write(matriz[i, o] + "\t");
            sumasFilas[i] += matriz[i, o];
            sumasColumnas[o] += matriz[i, o];
        }
        Console.WriteLine("");

    }
    for (int i = 0; i < sumasFilas.Length; i++)
    {
        Console.WriteLine($"Suma de fila: {sumasFilas[i]}");
    }
    for (int i = 0; i < sumasColumnas.Length; i++)
    {
        Console.WriteLine($"Suma de columna: {sumasColumnas[i]}");
    }
}

void ejercicio6()
{
    int[,] traspuesta = new int[4, 4];
    int[,] matriz = {
        {10,45,5,7},
        {4,6,14,65},
        {9,4,1,78},
        {37,23,17,32}
    };
    Console.WriteLine("Matriz original");
    for(int i = 0; i < 4; i++)
    {
        for(int o = 0; o<4; o++)
        {
            Console.Write(matriz[i, o] + "\t");
        }
        Console.WriteLine();
    }

    Console.WriteLine("Matriz traspuesta");
    for (int i = 0; i < 4; i++)
    {
        for (int o = 0; o < 4; o++)
        {
            traspuesta[o, i] = matriz[i, o];
            Console.Write(matriz[o, i] + "\t");
        }
        Console.WriteLine("");
    }
}

void ejercicio7()
{
    int contador = 0;
    int[,] matriz = {
    { 1, 5, 3, 5},
   { 8, 5, 9, 2},
   { 4, 5, 6, 7}
        };
    for (int i = 0; i < 3; i++)
    {
        for (int o = 0; o < 4; o++)
        {
            Console.Write(matriz[i, o] + "\t");
        }

        Console.WriteLine();
    }
    Console.WriteLine("Ingrese un número y te digo cuantas veces aparece en la matriz");
    int num = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < 3; i++)
    {
        for (int o = 0; o < 4; o++)
        {
            if (matriz[i, o] == num)
            {
                contador++;
            }
        }

    }
    Console.WriteLine($"Ese número aparece {contador} veces");
}
void ejercicio8()
{
    double suma = 0;
    double[,] matriztras = new double[4, 4];
    int[,] matriz = {
        {34,12,9,16},
        {4,56,15,85},
        {9,4,1,78},
        {37,23,17,32}
    };
    for (int i = 0; i < 4; i++)
    {
        for (int o = 0; o < 4; o++)
        {
            suma += matriz[i, o];
        }
    }
    double promedio = suma / 16;
    Console.WriteLine("Matriz");
    for (int i = 0; i < 4; i++)
    {
        for (int o = 0; o < 4; o++)
        {
            Console.Write(matriz[o, i] + "\t");
        }
        Console.WriteLine("");
    }

    for (int i = 0; i < 4; i++)
    {
        for(int o = 0; o < 4; o++)
        {
            if (matriz[i,o] < promedio)
            {
                matriztras[i, o] = promedio;
            }
            else
            {
                matriztras[i, o] = matriz[i, o];
            }
        }
    }
    Console.WriteLine("Matriz nueva");
    for (int i = 0; i < 4; i++)
    {
        for (int o = 0; o < 4; o++)
        {
            Console.Write(matriztras[o, i] + "\t");
        }
        Console.WriteLine("");
    }

}
