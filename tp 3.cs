// ejercicio 1
string ejercicio1(int N) {

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
string ejercicio2(int edad)
{
    string fiesta;

    if (edad >= 18) { fiesta = "¡Bienvenido a la fiesta!"; }
    else {fiesta = "Lo siento, eres muy joven"; }
    return fiesta;}
Console.WriteLine(ejercicio2(Convert.ToInt32(Console.ReadLine())));

// ejercicio 3
string ejercicio3(string contraseña)
{
    string confirmacion;
    if (contraseña == "python123") { confirmacion = "¡Contraseña correcta! Acceso concedido."; }
    else { confirmacion = "¡Contraseña incorrecta, Autodestrucción en 5 minutos"; }
    return confirmacion; 
}
Console.WriteLine(ejercicio3(Console.ReadLine()));

// ejercicio 4
