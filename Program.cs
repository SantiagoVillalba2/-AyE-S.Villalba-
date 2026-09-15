namespace tp_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arbol arbolito = new Arbol();
            arbolito.insertar(45);
            arbolito.insertar(90);
            arbolito.insertar(30);

            Console.WriteLine($"Valor mínimo: {arbolito.ObtenerMinimo()}");
            Console.WriteLine($"Valor máximo: {arbolito.ObtenerMaximo()}");
            Console.WriteLine($"Cantidad de nodos totales: {arbolito.ObtenerCantidadNodos()}");
            Console.WriteLine($"La altura del arbol es: {arbolito.ObtenerAltura()}");
            Console.WriteLine($"Nodos sin hijos: {arbolito.ContarHojas()}");


        }
    }
}
