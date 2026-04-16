int n = Convert.ToInt32(Console.ReadLine());

bool esPrimo(int n)
{
    if(n <= 1)
    {
        return false;
    }
    if(n % 2 == 0)
    {
        return false;
    } 
    if(n == 2)
    {
        return true;
    }
    for(int x = 3; x < n; x = +2)
    {
        if(n % x == 0)
        {
            return false;
        }
    }
    return true;
}
bool resultado = esPrimo(n);
if(resultado == true)
{
    Console.WriteLine("Es primo");
}
else
{
    Console.WriteLine("No es primo");
}
// ejercicio 2
Console.WriteLine("ingrese un número entero NO negativo");
int numero = Convert.ToInt32(Console.ReadLine());
int resultadoo = 1;
if (n < 0)
{
    Console.WriteLine("Ingrese un número positivo");
}
else
{
    for (int xx = 1; xx <= numero; xx++)
    {
        resultadoo *= xx;
    }
    Console.Write("El factorial de ");
    Console.Write(numero);
    Console.Write(" es ");
    Console.Write(resultadoo);
}
