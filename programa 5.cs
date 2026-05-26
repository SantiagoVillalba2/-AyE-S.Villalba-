int maxcontactos = 100;
int contador = 0;
string[] listacontactos = new string[maxcontactos];
string[] listanumeros = new string[maxcontactos];


bool menu = true;

while (menu)
{
    Console.WriteLine("1 Para añadir contactos nuevos");
    Console.WriteLine("2 para mostrar todos los contactos");
    Console.WriteLine("3 para buscar el nombre de un contacto");
    Console.WriteLine("4 para salir del programa");
    int opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            if (contador >= maxcontactos)
            {
                Console.WriteLine("La agenda está llena");
            }
            else
            {
                Console.WriteLine("Introduce el nombre del contacto");
                listacontactos[contador] = Console.ReadLine();
                Console.WriteLine("Introduce el teléfono del contacto");
                listanumeros[contador] = Console.ReadLine();

                contador++;
                Console.WriteLine("Contacto guardado");
            }
            break;
        case 2: 
            if (contador == 0)
            {
                Console.WriteLine("La agenda está vacía");
            }
            else
            {
                for (int i = 0; i < contador; i++)
                {
                    Console.WriteLine($"contacto: {listacontactos[i]} | Numero de telefono: {listanumeros[i]}");
                }
            }
            break;
        case 3:
            if (contador == 0)
            {
                Console.WriteLine("La agenda está vacía");
            }
            else
            {
                Console.WriteLine("Introduce el nombre que quieres buscar");
                string nombrebuscado = Console.ReadLine();
                bool encontrado = false;

                for(int i = 0; i < contador; i++)
                {
                    if (listacontactos[i] == nombrebuscado)
                    {
                        Console.WriteLine($"El teléfono de {listacontactos[i]} es {listanumeros[i]}");
                        encontrado = true;
                        break;
                    }
                    if (!encontrado)
                    {
                        Console.WriteLine("Contacto no encontrado");
                    }
                }
            }
            break;
        case 4:
            Console.WriteLine("Saliste del programa");
            menu = false;
            break;
        default:
            Console.WriteLine("Opción no valida, ingresá el número indicado");
            break;
    }


}
