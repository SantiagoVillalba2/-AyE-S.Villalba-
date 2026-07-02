namespace ejercicio2
{
    internal class program
    {
        public struct Dimensiones
        {
            public int ancho { get; set; }
            public int alto { get; set; }

            public Dimensiones(int Ancho, int Alto)
            {
                Ancho = ancho;
                Alto = alto;
            }
        }

        static void Main(string[] args)
        {
            Dimensiones dimension1 = new Dimensiones(10, 20);
            Dimensiones dimension2 = dimension1;
            dimension2.ancho = 99;

            Console.WriteLine("Ancho y alto de dimension 1");
            Console.WriteLine($"Ancho: {dimension1.ancho}, alto: {dimension1.alto}");
            Console.WriteLine("Ancho y alto de dimension 2");
            Console.WriteLine($"Ancho: {dimension2.ancho}, alto: {dimension2.alto}");
        }
    }
}