// ejercicio a
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine(i);
    }
}

// ejercicio b
Console.WriteLine("ingresá tu edad");
int edad = Convert.ToInt16(Console.ReadLine());

if(edad < 18)
{
    Console.WriteLine("Sos menor de edad");
}else if (edad == 18)
{
    Console.WriteLine("tenés justo 18");
}
else
{
    Console.WriteLine("Sos mayor de 18");
}

// ejercicio c
Console.WriteLine("Ingresá una palabra");
string palabra = Console.ReadLine();

int letras = palabra.Length;
Console.WriteLine($"tu palabra tiene {letras} letras");

// ejercicio D 

for (int i = 5; i>-1; i--)
{
    Console.WriteLine("Ingrese una contraseña");
    string intentos = Console.ReadLine();
    string secreto = "trolaso";
    if (intentos == secreto)
    {
        Console.WriteLine("Felicidades, acertaste la contraseña");
        break;
    }
    else
    {
        Console.WriteLine($"Contraseña incorrecta, te quedan {i} intentos");
    }
}

// ejercicio E