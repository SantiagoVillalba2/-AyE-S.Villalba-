using System;

class Program
{
    static void Main()
    {
        string texto = funcion1();

        string resultado = funcion2(texto);

        Console.WriteLine();
        Console.WriteLine("Resultado:");
        Console.WriteLine(resultado);
    }

    static string funcion1()
    {
        string texto;
        string permitidos = "abcdefghijklmnñopqrstuvwxyz";

        while (true)
        {
            Console.WriteLine("Ingrese el mensaje");
            texto = Console.ReadLine() ?? "";

            texto = texto.ToLower();

            bool valido = true;

            for (int i = 0; i < texto.Length; i++)
            {
                bool encontrado = false;

                for (int x = 0; x < permitidos.Length; x++)
                {
                    if (texto[i] == permitidos[x])
                    {
                        encontrado = true;
                        break;
                    }
                }

                if (encontrado == false)
                {
                    valido = false;
                    break;
                }
            }

            if (valido == true)
            {
                return texto;
            }
            else
            {
                Console.WriteLine("El texto tiene caracteres no permitidos. Intentá de nuevo.");
            }
        }
    }

    static string funcion2(string texto)
    {
        string abc = "abcdefghijklmnñopqrstuvwxyz";

        Console.WriteLine("Elegí que acción queres hacer:");
        Console.WriteLine("1) Cifrar el texto");
        Console.WriteLine("2) Descifrar el texto");

        int accion = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingresá la clave del cifrado Cesar");
        int clave = Convert.ToInt32(Console.ReadLine());

        if (accion == 2)
        {
            clave = -clave;
        }

        string resultado = "";

        for (int i = 0; i < texto.Length; i++)
        {
            for (int x = 0; x < abc.Length; x++)
            {
                if (texto[i] == abc[x])
                {
                    int nuevaPosicion =
                        (x + clave + abc.Length) % abc.Length;

                    resultado += abc[nuevaPosicion];

                    break;
                }
            }
        }

        return resultado;
    }
}