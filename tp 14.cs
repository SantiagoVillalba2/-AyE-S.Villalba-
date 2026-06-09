// ejercicio 1
int[] numeros = new int[5];
int resultado = 0;
Console.WriteLine("Ingresa 5 números");
for(int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Ingresa el número");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
    
}

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"numeros: { numeros[i]}");
}

// ejercicio 2
string[] nombrefruta = {"manzana", "sandia", "banana", "mango"};
bool encontrado = false;

for (int i = 0; i < nombrefruta.Length; i++)
{
    Console.WriteLine("Introduce el nombre que quieres buscar");
    string nombrebuscado = Console.ReadLine().ToLower();
    if (nombrefruta[i] == nombrebuscado)
    {
        Console.WriteLine($"La fruta está en la posición {i + 1}");
        encontrado = true;
        break;
    }
    if (!encontrado)
    {
        Console.WriteLine("fruta no encontrada");
    }
}

void ejercicio3()
{
    int[] notas = { 8, 5, 7, 10, 9, 7, 3, 2, 10, 10 };
    for (int i = 0; i < notas.Length; i++)
    {
        Console.Write(notas[i] + "\t");
    }
    Console.WriteLine("");
    int sumatotal = 0;
    for (int i = 0; i < notas.Length; i++)
    {
        sumatotal += notas[i];
    }

    int promedio = sumatotal / notas.Length;
    Console.WriteLine($"Suma total de las notas: {sumatotal}");
    Console.WriteLine($"Promedio general: {promedio}");
}

