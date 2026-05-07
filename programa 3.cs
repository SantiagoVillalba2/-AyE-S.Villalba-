string palabra = "playstation";
string guiones = "";
string nuevo = "";
char letra = ' ';
int intentos = 7;
bool adivina = false;
bool encontro = false;


for (int i = 0; i < palabra.Length; i++)
{
    guiones += "_";
}

while (intentos > 0 && !adivina)
{
    Console.WriteLine($"palabra: {guiones}");
    Console.WriteLine($"intentos restantes: {intentos}");
    Console.WriteLine("Ingresá una letra");
    letra = Convert.ToChar(Console.ReadLine());
    for (int i = 0; i < palabra.Length; i++)
    {
        
        if (palabra[i] == letra)
        {
            nuevo += letra;
            encontro = true;
        }
        else
        {
            nuevo += guiones[i];
        }
    }
    guiones = nuevo;
    if (!encontro)
    {
        intentos--;
        Console.WriteLine("Letra incorrecta.");
    }
    else
    {
        Console.WriteLine("Letra encontrada.");
    }
    if (guiones == palabra)
    {
        adivina = true;
    }
}

Console.WriteLine("");
if (adivina)
{
    Console.WriteLine($"Ganaste, la palabra era: {palabra}");
}
else
{
    Console.WriteLine($"Perdiste, la palabra era: {palabra}");
}
