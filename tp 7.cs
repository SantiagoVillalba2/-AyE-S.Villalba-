// ejercicio 1
Console.WriteLine("Ingrese un número entero");
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

// ejercicio 3
Console.WriteLine("Ingrese un número");
int n = Convert.ToInt32(Console.ReadLine());
int PT = 0;
int ST = 1;
int aux;
for (int i = 0; i < n; i++)
{
    aux = PT + ST;
    PT = ST;
    ST = aux;
    if (ST > n)
    {
        break;
    }
    Console.WriteLine(ST);
}

// ejercicio 4
bool menu = true;
while (menu == true)
{
    Console.WriteLine("Ingrese uno de estos 3 números para elegir una opción");
    Console.WriteLine("1 = Saludar, 2 = Despedirse, 3 = terminar programa");
    int x = Convert.ToInt32(Console.ReadLine());
    switch(x)
    {
        case 1:
            Console.WriteLine("Hola");
            break;
        case 2:
            Console.WriteLine("chau");
            break;
        case 3:
            menu = false;
            break;
        default:
            Console.WriteLine("Ese número no está en las opciones");
            break;
        }
    }
