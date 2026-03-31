// ejercicio 1
using System.ComponentModel;

Console.WriteLine("Ingrese un número entero");
string ejercicio1(int N)
{

    string resultado;
    if (N > 0) { resultado = "positivo"; }
    else if (N < 0) { resultado = "es negativo"; }
    else
    {
        resultado = "es 0";
    }
    return resultado;
}

Console.WriteLine(ejercicio1(Convert.ToInt32(Console.ReadLine())));

// ejercicio 2
Console.WriteLine("Cuál es tu edad?");
string ejercicio2(int edad)
{
    string fiesta;

    if (edad >= 18) { fiesta = "¡Bienvenido a la fiesta!"; }
    else { fiesta = "Lo siento, eres muy joven"; }
    return fiesta;
}
Console.WriteLine(ejercicio2(Convert.ToInt32(Console.ReadLine())));

// ejercicio 3
Console.WriteLine("Ingrese una contraseña");
string ejercicio3(string contraseña)
{
    string confirmacion;
    if (contraseña == "python123") { confirmacion = "¡Contraseña correcta! Acceso concedido."; }
    else { confirmacion = "¡Contraseña incorrecta, Autodestrucción en 5 minutos"; }
    return confirmacion;
}
Console.WriteLine(ejercicio3(Console.ReadLine()));

// ejercicio 4
Console.WriteLine("Ingrese un número entero");
string ejercicio4(int NUM)
{
    string verificacion;
    if (NUM % 2 == 0) { verificacion = "El número es par"; }
    else { verificacion = "El número es impar"; }
    return verificacion;
}
Console.WriteLine(ejercicio4(Convert.ToInt32(Console.ReadLine())));

//ejercicio 5
Console.WriteLine("Cuál es tu edad?");
Console.WriteLine("compro pochoclos?");
string ejercicio5(int numero, string compro)
{   
    string validacion;
    if (numero > 65 && compro == "si") { validacion = "¡Felicidades! Tienes entrada gratuita al cine."; }
    else { validacion = "Comprá la entrada o raja de acá"; }
    return validacion;
}
Console.WriteLine(ejercicio5(Convert.ToInt32(Console.ReadLine()),Console.ReadLine()));


