
string nombre = Console.ReadLine();
double promedio = Convert.ToDouble(Console.ReadLine());
int distancia = Convert.ToInt32(Console.ReadLine());

bool DeterminarBeca(double promedio, int distancia)
{
    if (promedio >= 8.5 || distancia > 50) { return true;} 
    else { return false; }
}
bool resultado = DeterminarBeca(double promedio, int distancia)