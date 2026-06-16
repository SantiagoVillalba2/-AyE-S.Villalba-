Random nombres1 = new Random();
Random posiciones1 = new Random();
Random valor = new Random();
int[,] plantilla1 = new int[23, 3];
int[,] plantilla2 = new int[23, 3];
int valoraciones = valor.Next(50, 100);
string[] nombres = { "Juan", "Pepe", "Lolo", "Marulete", "Ignacio", "Lautaro", "Rick", "Chris", "Manuel", "Joaquin", "Lisandro", "Pepe2", "Pepe3", "Pepe4", "Pepe5", "Pepe6", "Pepe7", "Pepe8", "Pepe9", "Pepe10", "Pepe11", "Pepe12", "Pepe13" };
string[] posiciones = { "Delantero", "Mediocampista", "Defensor", "Arquero" };

// ejercicio2
int aux = 1;
Console.WriteLine("Ingrese un número");
int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese su potencia");
int potencia = Convert.ToInt32(Console.ReadLine());

void for1(int num = 1)
{
    if (num > potencia)
    {
        return;
    }
    else
    {
        aux = aux * numero;
        for1(num + 1);
    }
}
for1();
Console.WriteLine(aux);

