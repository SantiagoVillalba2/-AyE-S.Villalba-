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

// ejercicio 3
string[] palabras = { "hola", "bien", "locura", "pino" };

