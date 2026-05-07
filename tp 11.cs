// ejercicio 1

int contar(int contador)
{
    contador = 1;
    if(contador > 10)
    {
        Console.WriteLine(contador);
        return contador;
    }
    else
    {
        contar(contador + 1);
        Console.WriteLine(contador);
        return contador;
    }
}