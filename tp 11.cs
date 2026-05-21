Console.WriteLine("Ejercicio 1");
void for1(int num = 1)
{
    if(num > 10 )
    {
        return;
    }
    else
    {
        Console.WriteLine(num);
        for1(num + 1);
    }
}
for1();
Console.WriteLine("Ejercicio 2");
void for2(int n = 1, string hola = "¡Hola, mundo!")
{
    if(n > 5)
    {
        return;
    }
    else
    {
        Console.WriteLine(hola);
        for2(n + 1);
    }
}
for2();
Console.WriteLine("Ejercicio 3");
void for3(int numm = 2)
{
    if(numm > 20)
    {
        return;
    }
    else
    {
        Console.WriteLine(numm);
        for3(numm + 2);
    }
}
for3();
Console.WriteLine("Ejercicio 4");
void for4(int multiplicador = 1)
{
    if(multiplicador > 10)
    {
        return;
    }
    else
    {
        int resultado = 7 * multiplicador;
        Console.WriteLine(resultado);
        for4(multiplicador + 1);
    }
}
for4();
Console.WriteLine("Ejercicio 5");
int for5(int suma = 1)
{
    if(suma > 5)
    {
        return 0;
    }
    else
    {
        return suma + for5(suma + 1);
    }
}
int resultadoo = for5();
Console.WriteLine($"La suma total: {resultadoo}");
Console.WriteLine("");
Console.WriteLine("Ejercicio 6");
void while1()
{
    Console.WriteLine("Ingrese una contraseña");
    string intento = Console.ReadLine();
    if(intento == "playstation")
    {
        Console.WriteLine("Entrando...");
        return;
    }
    else
    {
        Console.WriteLine("Intentelo de nuevo");
        while1();
    }
}
while1();

Console.WriteLine("");
Console.WriteLine("Ejercicio 7");
void while2(int contador = 5)
{
    if (contador == 0)
    {
        Console.WriteLine("¡Listo para despegar!");
        Console.WriteLine("¡Despegue!");
        return;
    }
    else
    {
        Console.WriteLine(contador);
        while2(contador - 1);
    }
}
while2();

Console.WriteLine("");
Console.WriteLine("Ejercicio 8");
void while3(int numerosec = 7)
{
    Console.WriteLine("Adiviná el número");
    int intento = Convert.ToInt32(Console.ReadLine());
    if(intento == 7)
    {
        Console.WriteLine("¡Felicidades! Adivinaste el número!");
        return;
    }
    else
    {
        Console.WriteLine("¡Fallaste! Adivinalo de vuelta.");
        while3();
    }
}
while3();
