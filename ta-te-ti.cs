

char[,] tablero =
{
    {' ', ' ', ' ' },
    {' ', ' ', ' ' },
    {' ', ' ', ' ' }
};

char jugador = 'X';
char jugador2 = 'O';
int contadorX = 0;
int contadorO = 0;
char turno = jugador;
bool jugada = true;
for (int turnos = 0; turnos < 9; turnos++)
{
    mostrartablero();
    hacerjugada();

    if (verificar())
    {
        mostrartablero();
        Console.WriteLine($"ganó el jugador {turno}");
        return;
    }
    if (turno == jugador)
    {
        turno = jugador2;
    }
    else
    {
        turno = jugador;
    }
}
mostrartablero();
Console.WriteLine("Empate");
void mostrartablero()
{
    for(int i = 0; i < 3; i++)
    {
        for(int o = 0; o < 3; o++)
        {
            Console.Write(tablero[i, o] + "\t");
        }
    }
}
void hacerjugada()
{
    while (jugada)
    {
        Console.WriteLine($"Turno del jugador {turno}. Ingrese la posición de fila del 0 al 2");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la posición de columna del 0 al 2");
        int b = int.Parse(Console.ReadLine());

        if(a >=0 && a < 3 && b >= 0 && b < 3 && tablero[a,b] == ' ')
        {
            tablero[a, b] = turno;
            break;
        }
    }
}

bool verificar()
{
    for (int i = 0; i<3; i++)
    {
        contadorX = 0;
        contadorO = 0;
        for (int o = 0; o < 3; o++)
        {
            if (tablero[i,o] == jugador)
            {
                contadorX++;
            }
            if (tablero[i,o] == jugador2)
            {
                contadorO++;
            }
            if(contadorX == 3 || contadorO == 3)
            {
                return true;
            }
        }
    }
    for (int i = 0; i < 3; i++)
    {
        contadorX = 0;
        contadorO = 0;
        for (int o = 0; o < 3; o++)
        {
            if (tablero[o, i] == jugador)
            {
                contadorX++;
            }
            if (tablero[o, i] == jugador2)
            {
                contadorO++;
            }
            if (contadorX == 3 || contadorO == 3)
            {
                return true;
            }
        }
    }
    contadorX = 0;
    contadorO = 0;
    for (int i = 0; i < 3; i++)
    {
        if (tablero[i, i] == jugador)
        {
            if (tablero[i, i] == jugador)
            {
                contadorX++;
            }
            if (tablero[i, i] == jugador)
            {
                contadorO++;
            }
        }
    }

    contadorX = 0;
    contadorO = 0;
    for (int i = 0; i < 3; i++)
    {
        if (tablero[i, 2 - i] == jugador)
        {
            contadorX++;
        }
        if (tablero[i, 2 - i] == jugador2)
        {
            contadorO++;
        }
    }
    return contadorX == 3 || contadorO == 3;
}