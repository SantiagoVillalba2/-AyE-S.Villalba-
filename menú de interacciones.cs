bool menu = true;
while (menu == true)
{
    Console.WriteLine("1 = ejercicio 1, 2 = ejercicio 2, 3 = ejercicio 3, 4 = ejercicio 4, 5 = ejercicio 5, 0 = cerrar programa");
    int x = Convert.ToInt16(Console.ReadLine());
    switch (x)
    {
        case 1:
            Console.WriteLine("ingrese un número y le digo si es positivo o negativo");
            string ejercicio1(int N);
            Console.WriteLine(ejercicio1(Convert.ToInt32(Console.ReadLine())));
            break;
        case 2:
            Console.WriteLine("Decime tu edad y te digo si entrás o no a la fiesta");
            string ejercicio2(int edad)
            {
                string fiesta;

                if (edad >= 18) { fiesta = "¡Bienvenido a la fiesta!"; }
                else { fiesta = "Lo siento, eres muy joven"; }
                return fiesta;
            }
            Console.WriteLine(ejercicio2(Convert.ToInt32(Console.ReadLine())));
            break;
        case 3:
            Console.WriteLine("ingresá una contraseña");
            string ejercicio3(string contraseña)
            {
                string confirmacion;
                if (contraseña == "python123") { confirmacion = "¡Contraseña correcta! Acceso concedido."; }
                else { confirmacion = "¡Contraseña incorrecta, Autodestrucción en 5 minutos"; }
                return confirmacion;
            }
            Console.WriteLine(ejercicio3(Console.ReadLine()));
            break;
        case 4:
            Console.WriteLine("ingresá un número entero y te digo si es par o impar");
            string ejercicio4(int NUM)
            {
                string verificacion;
                if (NUM % 2 == 0) { verificacion = "El número es par"; }
                else { verificacion = "El número es impar"; }
                return verificacion;
            }
            Console.WriteLine(ejercicio4(Convert.ToInt32(Console.ReadLine())));
            break;
        case 5:
            Console.WriteLine("decime tu edad y si compraste pochoclos.");
            string ejercicio5(int numero, string compro)
            {
                string validacion;
                if (numero > 65 && compro == "si") { validacion = "¡Felicidades! Tienes entrada gratuita al cine."; }
                else { validacion = "Comprá la entrada o raja de acá"; }
                return validacion;
            }
            Console.WriteLine(ejercicio5(Convert.ToInt32(Console.ReadLine()), Console.ReadLine()));
            break;
        case 0:
            menu = false;
            break;
        default:
            Console.WriteLine("Ese no es un número disponible");
            break;
    }
}






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