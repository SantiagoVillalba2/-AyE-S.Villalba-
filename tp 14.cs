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
ejercicio3();

void ejercicio4()
{
    int[] temperaturas = { 25, 35, 32, 45, 21 };
    int acum = 0;
    int acum2 = 99999999;
 
    for (int i = 0; i <= 4; i++)
    {
      
        
        if (temperaturas[i] > acum)
        {
            acum = temperaturas[i];
        }
    }
    for (int i = 0; i <= 4; i++)
    {
       
        if (temperaturas[i] < acum)
        {
            acum2 = temperaturas[i];
     
        }
    }
    Console.WriteLine("La temperatura mayor es de: " + acum);
    Console.WriteLine("La temperatura menor es de: " + acum2);




}
ejercicio4();
void ejercicio5()
{

   
    int[] numeros = { 5, 2, 9, 1, 7, 4 };

  
    for (int i = 0; i < numeros.Length - 1; i++)
    {
        for (int j = 0; j < numeros.Length - 1; j++)
        {
           
            if (numeros[j] > numeros[j + 1])
            {
               
                int temporal = numeros[j];
                numeros[j] = numeros[j + 1];
                numeros[j + 1] = temporal;
            }
        }
    }

    Console.WriteLine("Lista ordenada:");
    for (int k = 0; k < numeros.Length; k++)
    {
        Console.Write(numeros[k] + " ");
    }


}
ejercicio5();
void ejercicio6()
{
    int[] numeros = { 14, 3, 22, 9, 45, 12, 7, 34, 19, 50, 1, 28, 15, 8, 41 };
    int acum = 0;
    int acumimpares = 0;
    for (int i = 0; i < 15; i++)
    {
        if (numeros[i] % 2 == 0)
        {
            acum++;
        }
        else
        {
            acumimpares++;
        }

    }
    Console.WriteLine("La cantidad de pares es de: " + acum);
    Console.WriteLine("La cantidad de impares es de: " + acumimpares);



}
ejercicio6();

