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
string ejercicio2(int edad)
{
    string fiesta;

    if (edad >= 18) { fiesta = "¡Bienvenido a la fiesta!"; }
    else { fiesta = "Lo siento, eres muy joven"; }
    return fiesta;
}
string ejercicio3(string contraseña)
{
    string confirmacion;
    if (contraseña == "python123") { confirmacion = "¡Contraseña correcta! Acceso concedido."; }
    else { confirmacion = "¡Contraseña incorrecta, Autodestrucción en 5 minutos"; }
    return confirmacion;
}
string ejercicio4(int NUM)
{
    string verificacion;
    if (NUM % 2 == 0) { verificacion = "El número es par"; }
    else { verificacion = "El número es impar"; }
    return verificacion;
}
string ejercicio5(int numero, string compro)
{
    string validacion;
    if (numero > 65 && compro == "si") { validacion = "¡Felicidades! Tienes entrada gratuita al cine."; }
    else { validacion = "Comprá la entrada o raja de acá"; }
    return validacion;
}

bool menu = true;
while (menu == true)
{
    Console.WriteLine("1 = ejercicio 1, 2 = ejercicio 2, 3 = ejercicio 3, 4 = ejercicio 4, 5 = ejercicio 5, 0 = cerrar programa");
    int x = Convert.ToInt16(Console.ReadLine());
    switch (x)
    {
        case 1:
            Console.WriteLine("ingrese un número y le digo si es positivo o negativo");
            int ej1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ejercicio1(ej1));
            break;
        case 2:
            Console.WriteLine("Decime tu edad y te digo si entrás o no a la fiesta");
            int ej2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ejercicio2(ej2));
            break;
        case 3:
            Console.WriteLine("ingresá una contraseña");
            string contra = Console.ReadLine();
            Console.WriteLine(ejercicio3(contra));
            break;
        case 4:
            Console.WriteLine("ingresá un número entero y te digo si es par o impar");
            int ej4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ejercicio4(ej4));
            break;
        case 5:
            Console.WriteLine("decime tu edad y si compraste pochoclos.");
            int edad = Convert.ToInt32(Console.ReadLine());
            string compros = Console.ReadLine();
            Console.WriteLine(ejercicio5(edad, compros));
            break;
        case 0:
            menu = false;
            break;
        default:
            Console.WriteLine("Ese no es un número disponible");
            break;
    }
}
