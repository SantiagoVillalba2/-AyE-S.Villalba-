// ejercicio 1
string contraseña = "secreto123";
string intento = "";
while(intento != contraseña)
{
    Console.WriteLine("ingrese la contraseña");
    intento = Console.ReadLine();
    if (intento != contraseña)
    {
        Console.WriteLine("intentelo de nuevo");
    }
    else { break; }
}
Console.WriteLine("entrando...");

//ejercicio 2
int CuentaRegresiva = 5;
while(CuentaRegresiva >= 1)
{
    Console.WriteLine(CuentaRegresiva);
    CuentaRegresiva--;
}
Console.WriteLine("¡LISTO PARA EL DESPEGUE!");
Console.WriteLine("¡Despegue!");

// ejercicio 3
int secreto = 7;
int intentos = 0;
while (intentos != 7)
{
    Console.WriteLine("¡Adiviná el número!");
    intentos = Convert.ToInt32(Console.ReadLine());
    if(intentos != 7) { Console.WriteLine("¡Número incorrecto! Intentalo de nuevo"); } else
    {
        break;
    }
}
Console.WriteLine("¡Adivinaste mi número!");

// ejercicio 4
int numero = 1;
int acum = 0;
while(numero != 0)
{
    Console.WriteLine("Ingrese un número");
    numero = Convert.ToInt32(Console.ReadLine());
    acum +=numero;
}
Console.Write("La suma total es de: ");
Console.Write(acum);