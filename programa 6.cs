int[,] mapa = new int[10, 10];
Random aleatorio = new Random();
int tesoros = 0;

while(tesoros < 3)
{
    int filaazar = aleatorio.Next(0, 10);
    int colazar = aleatorio.Next(0, 10);

    if (mapa[filaazar, colazar] == 0)
    {
        mapa[filaazar, colazar] = 1;
        tesoros++;
    }
}