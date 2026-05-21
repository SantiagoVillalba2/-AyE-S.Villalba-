Console.WriteLine("Ejercicio 1");
Console.WriteLine("Nombres: Luis, Thiago, Bruno, Santiago, Juan, Leo, Ana, Pepe, Willy, Matias");

string[] nombres = { "Luis", "Thiago", "Bruno", "Santiago", "Juan", "Leo", "Ana", "Pepe", "Willy", "Matias" };

string maslargo = "";

for(int i = 0; i < nombres.Length; i++)
{
    if (nombres[i].Length > maslargo.Length)
    {
        maslargo = nombres[i];
    }
}

Console.WriteLine($"el nombre más largo es: {maslargo}");

Console.WriteLine("Ejercicio 2");
Console.WriteLine("Palabras: Mesa, Playstation, Celular, Computadora, Resident, Evil, Teclado, Gato, Hola, Bien");
string[] palabras = { "Mesa", "Playstation", "Celular", "Computadora", "Resident", "Evil", "Teclado", "Gato", "Hola", "Bien" };
string vocales = "aeiouAEIOU";
int contador = 0;


for (int i = 0; i < palabras.Length; i++)
{
    foreach (char x in palabras[i])
    {
        foreach(char l in vocales)
        {
            if(x == l)
            {
                contador++;
            }
        }
    }
}
Console.WriteLine($"vocales totales: {contador}");

Console.WriteLine("Ejercicio 3");
int[] numeros = { 3, 6, 8, 9 };
int factor = 4;

int[] numerosmultiplicados;
numerosmultiplicados = new int[numeros.Length];

for(int i = 0; i < numeros.Length; i++)
{
    numerosmultiplicados[i] = numeros[i] * factor;


}

Console.WriteLine("valores originales");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("Valores multiplicados");
for (int i = 0; i < numerosmultiplicados.Length; i++)
{
    Console.WriteLine(numerosmultiplicados[i]);
}
