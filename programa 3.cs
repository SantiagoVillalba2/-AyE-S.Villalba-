string palabra = "playstation";
string guiones = "";
string nuevo = "";
char letra = ' ';
int intentos = 7;
bool adivina = true;
bool encontro = false;


for (int i = 0; i < palabra.Length; i++)
{
    guiones += "_";
}
for (int i = 0; i < palabra.Length; i++)
{
    while (letra != palabra[i] && !adivina)
    {
        Console.WriteLine($"palabra: {guiones}");
        Console.WriteLine($"intentos restantes: {intentos}");
        Console.WriteLine("Ingresá una letra");
        letra = Convert.ToChar(Console.ReadLine());

        if (letra == palabra[i])
        {
            nuevo += letra;
            encontro = true;
        }
        else
        {
            nuevo += guiones[i];
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