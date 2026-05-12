// ejercicio 1
using System.ComponentModel.Design;
Console.WriteLine("Ingrese la cantidad de horas trabajadas");
int semanal(int horas)
{
    int salario = 16;
    int salarioextra = 20;
    int contadorr = 0;
    try
    {
        horas = Convert.ToInt32(Console.ReadLine());
        if (horas <= 40)
        {
            for (int i = 1; i <= horas; i++)
            {
                contadorr += salario;
            }
            Console.WriteLine($"salario: {contadorr}");
        }
        else if (horas > 40)
        {
            for (int i = 1; i <= horas; i++)
            {
                if (i <= 40)
                {
                    contadorr += salario;
                }
                else if (i > 40)
                {
                    contadorr += salarioextra;
                }
            }
            Console.WriteLine($"Salario: {contadorr}");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Ese no es un formato válido");
    }
    return horas;
}
Console.WriteLine(semanal(Convert.ToInt32(Console.ReadLine())));
// ejercicio 2
Console.WriteLine("Ingrese números. Si ingresás 0 el programa termina y muestra la suma de tus números");
void contador()
{
    bool seguimos = true;
    int contador = 0;
    while (seguimos)
    {
        try
        {
            int num = Convert.ToInt32(Console.ReadLine());
            contador += num;
            if (num == 0)
            {
                Console.WriteLine($"resultado total: {contador}");
                seguimos = false;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ese no es un formato válido");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Número demasiado grande");
        }
    }
}
contador();


// ejercicio 3
Console.WriteLine("Ingrese una palabra");
void vocales()
{
    try
    {
        string palabra = Console.ReadLine();
        string vocales = "aeiou";
        int contadorr = 0;
        foreach (char l in palabra)
        {
            foreach (char v in vocales)
            {
                if (l == v)
                {
                    contadorr++;
                }
            }
        }
        Console.WriteLine($"cantidad de vocales: {contadorr}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Ese no es un formato válido");
    }
}
vocales();

// ejercicio 4
string palabrita = Console.ReadLine();
string invertido = "";
bool palindromo = true;
while (palindromo)
{
    Console.WriteLine("No es palíndromo, intentalo de vuelta");
    palabrita = Console.ReadLine();
    for (int i = 0; i < palabrita.Length; i++)
    {
        for (int o = palabrita.Length; i > 0; i--)
        {
            invertido += o;
            if (invertido == palabrita)
            {
                Console.WriteLine("Es palíndromo");
                palindromo = false;
            }
        }
    }
}

