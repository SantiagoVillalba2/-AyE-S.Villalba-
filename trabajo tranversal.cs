//bloque 1
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

//ejercicio E
Console.WriteLine("Ingresa 10 números");
int num_max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("1/10");
for(int i = 2; i <= 10; i++)
{
    Console.WriteLine($"{i}/10");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num > num_max)
    {
        num_max = num;
    }
}
Console.WriteLine($"el número más alto fue {num_max}");

// ejercicio F
Console.WriteLine("Ingresá tu nombre");
string nombre = Console.ReadLine();
string resultado = "";
for (int i = 0; i < nombre.Length; i++)
{
    if (i == 0)
    {
        resultado += char.ToUpper(nombre[i]);
    }
    else
    {
        resultado += char.ToLower(nombre[i]);
    }
}
Console.WriteLine($"hola, {resultado}");

// ejercicio G
for (int I = 1; I <= 10; I++)
{
    Console.WriteLine(7 * I);

}

// ejercicio H
int CuentaRegresiva = 10;
while (CuentaRegresiva >= 1)
{
    Console.WriteLine(CuentaRegresiva);
    CuentaRegresiva--;
}
Console.WriteLine("oa");

// ejercicio I
Console.WriteLine("Ingrese un número entero");
string ejercicio4(int NUM)
{
    string verificacion;
    if (NUM % 2 == 0) { verificacion = "El número es par"; }
    else { verificacion = "El número es impar"; }
    return verificacion;
}
Console.WriteLine(ejercicio4(Convert.ToInt32(Console.ReadLine())));

// ejercicio J
Console.WriteLine("ingrese una frase");
string frase = Console.ReadLine();
string vocales = "aeiouAEIOU";
int contador = 0;
foreach (char letra in frase)
{
    foreach (char vocal in vocales)
    {
        if (letra == vocal)
        {
            contador++;
            break;
        }
    }
}
Console.WriteLine($"La cantidad de vocales que hay es de {contador}");

// ejercicio K
Console.WriteLine("Ingrese un número");
int numero = Convert.ToInt32(Console.ReadLine());
for (int I = 1; I <= 12; I++)
{
    Console.WriteLine(numero * I);

}
// ejercicio L
int acumulador = 0;
while (acumulador <= 100)
{
    Console.WriteLine($"llevás acumulado: {acumulador}");
    Console.WriteLine("Ingresá un número");
    int numeroo = Convert.ToInt32(Console.ReadLine());
    acumulador += numeroo;
}
Console.WriteLine($"llegaste al límite, tu acumulado es de {acumulador}");

// ejercicio M
Console.WriteLine("ingrese una palabra o frase");
string palabra = Console.ReadLine();
for (int i = 0; i < palabra.Length; i++)
{
    char fila = palabra[i];
    Console.WriteLine(fila);
}

// ejercicio N
Console.WriteLine("Escribí tu edad");
int edad = Convert.ToInt32(Console.ReadLine());
if (edad == 16)
{
    Console.WriteLine("tenés la edad para votar pero no podés manejar");
}
else if (edad > 18)
{
    Console.WriteLine("tenés la edad para votar y para manejar");
}
else
{
    Console.WriteLine("no podés ni manejar, ni votar");
}

// ejercicio O
Console.WriteLine("números del 50 al 0 de 5 en 5");
for (int i = 50; i > 0; i -= 5)
{
    Console.WriteLine(i);
}

// ejercicio P
Console.WriteLine("Ingrese una contraseña");
string contraseña1 = Console.ReadLine();
Console.WriteLine("Ingrese la contraseña nuevamente");
string contraseña2 = Console.ReadLine();
while (contraseña1 != contraseña2)
{
    Console.WriteLine("Las contraseñas no coinciden, ingresá la contraseña nuevamente");
    contraseña2 = Console.ReadLine();
}
Console.WriteLine("contraseña correcta");

// ejercicio Q
bool seguimos = true;
while (seguimos == true)
{
    Console.WriteLine("Ingresá un nombre, no debe contener 10 caracteres");
    string nombree = Console.ReadLine();
    if (nombree.Length == 10)
    {
        Console.WriteLine("El nombre tiene 10 caracteres");
        break;
    }
}

// ejericio R
Console.WriteLine("Escribí una oración");
string oracion = Console.ReadLine();
string letraa = "aA";
int contadorr = 0;
foreach(char letra in oracion)
{
    foreach(char a in letraa)
    {
        if (letra == a)
        {
            contador++;
            break;
        }
    }
}
Console.WriteLine($"Contador de A: {contador}");
