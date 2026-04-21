Console.WriteLine("ingrese una frase");
string frase = Console.ReadLine();
string vocales = "aeiouAEIOU";
int contador = 0;
foreach(char letra in frase)
{
    foreach(char vocal in vocales)
    {
        if(letra == vocal)
        {
            contador++;
            break;
        }
    }

}
Console.WriteLine($"La cantidad de vocales que hay es de {contador}");

// ejercicio 2
Console.WriteLine("ingrese una palabra o frase");
string palabra = Console.ReadLine();
for(int i = palabra.Length - 1; i > -1; i--)
{
    char invertido = palabra[i];
    Console.WriteLine(invertido);
}

// ejercicio 3
Console.WriteLine("ingrese un número");
string numero = Console.ReadLine();
int aux = 0;
int aux2;
foreach(char N in numero)
{
    aux2 = Convert.ToInt32("" + N);
    aux += aux2;
}
Console.WriteLine(aux);

//ejercicio 4
string reemplazo;
Console.WriteLine("ingresa una palabra prohibída");
string palabra1 = Console.ReadLine();
Console.WriteLine("ingresa una palabra de reemplazo");
string palabra2 = Console.ReadLine();
reemplazo = palabra1.Replace(palabra1, palabra2);
Console.WriteLine(reemplazo);

//ejercicio 5
Console.WriteLine("ingrese su nombre");
string nombre = Console.ReadLine();
Console.WriteLine("ingrese su apellido");
string apellido = Console.ReadLine();

foreach (char letra1 in nombre)
{

}
