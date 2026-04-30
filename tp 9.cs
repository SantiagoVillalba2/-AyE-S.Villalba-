Console.WriteLine("Ingrese un número entero");
try
{
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
}
catch(OverflowException)
{
    Console.WriteLine("número demasiado grande");
}
catch (FormatException)
{
    Console.WriteLine("Entrada no válida");
}

// ejercicio 2
Console.WriteLine("Cuál es tu edad?");
try
{
    string ejercicio2(int edad)
    {
        string fiesta;

        if (edad >= 18) { fiesta = "¡Bienvenido a la fiesta!"; }
        else { fiesta = "Lo siento, eres muy joven"; }
        return fiesta;
    }
    Console.WriteLine(ejercicio2(Convert.ToInt32(Console.ReadLine())));
}
catch (OverflowException)
{
    Console.WriteLine("número demasiado grande");
}
catch (FormatException)
{
    Console.WriteLine("Entrada no válida");
}

// ejercicio 3
Console.WriteLine("Ingrese una contraseña");
try
{
    string ejercicio3(string contraseña)
    {
        string confirmacion;
        if (contraseña == "python123") { confirmacion = "¡Contraseña correcta! Acceso concedido."; }
        else { confirmacion = "¡Contraseña incorrecta, Autodestrucción en 5 minutos"; }
        return confirmacion;
    }
    Console.WriteLine(ejercicio3(Console.ReadLine()));
}
catch
{

}