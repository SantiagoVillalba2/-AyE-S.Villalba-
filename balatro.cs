int num_descartar;
int cantidad;
int opcion = 0;
string palo;
string numero;
Random aleatorio = new Random();
string[] palos = { "picas", "corazones", "treboles", "diamantes" };
string[] numeross = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

string[] carta1 = new string[2];
string[] carta2 = new string[2];
string[] carta3 = new string[2];
string[] carta4 = new string[2];
string[] carta5 = new string[2];
string[] carta6 = new string[2];
string[] carta7 = new string[2];
string[] carta8 = new string[2];

void darcartas()
{
    palo = palos[aleatorio.Next(0, 4)];
    numero = numeross[aleatorio.Next(0, 13)];
    carta1 = [palo, numero];
}

void descartar()
{
    Console.WriteLine("Ingrese la cantidad de cartas que quiere descartar");
    cantidad = Convert.ToInt32(Console.ReadLine());
    for(int i = 1; i<= cantidad; i++)
    {
        Console.WriteLine("Ingrese el número de carta que quiere descartar");
        num_descartar = Convert.ToInt32(Console.ReadLine());
        palo = palos[aleatorio.Next(0, 4)];
        numero = numeross[aleatorio.Next(0, 13)];
        switch (num_descartar)
        {
            case 1:
                carta1 = [palo, numero];
                break;
            case 2:
                carta2 = [palo, numero];
                break;
            case 3:
                carta3 = [palo, numero];
                break;
            case 4:
                carta4 = [palo, numero];
                break;
            case 5:
                carta5 = [palo, numero];
                break;
            case 6:
                carta6 = [palo, numero];
                break;
            case 7:
                carta7 = [palo, numero];
                break;
            case 8:
                carta8 = [palo, numero];
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }
}