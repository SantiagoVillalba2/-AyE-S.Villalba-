namespace asd
{
    internal class Program
    {
        public struct Punto2D
        {
            public int x { get; set; }
            public int y { get; set; }

            public Punto2D(int PuntoX, int PuntoY)
            {
                x = PuntoX;
                y = PuntoY;
            }

            public void mostrar()
            {
                Console.Write($"{x}, {y}");
            }
        }

        static void Main(string[] args)
        {
            Punto2D mipunto = new Punto2D(5, 10);

            mipunto.mostrar();
        }
    }
}