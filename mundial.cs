namespace mundial
{
    internal class Program
    {
        public struct jugador
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Posicion { get; set; }
            public string Equipo { get; set; }
            public int CantGoles { get; set; }
            public int CantDisparos { get; set; }
            public int NumeroCamiseta { get; set; }

            public jugador(string nombre, string apellido, string posicion, string equipo, int cantgoles, int cantdisparos, int numerocamiseta)
            {
                nombre = Nombre;
                apellido = Apellido;
                posicion = Posicion;
                equipo = Equipo;
                cantgoles = CantGoles;
                cantdisparos = CantDisparos;
                numerocamiseta = NumeroCamiseta;
            }


            public double indiceAtaque()
            {
                double indice;
                indice = (CantGoles / CantDisparos) * 100;
                return indice;
            }

        }
        static void Main(string[] args)
        {
            jugador[] jugadores = new jugador[]
            {
                new jugador ("Lionel", "Messi", "Delantero", "Inter Miami", 12, 40, 10),
                new jugador ("Erling", "Haaland", "Delantero", "Manchester City", 18, 45, 9),
                new jugador ("Lautaro", "Martinez", "Delantero", "Inter",  10, 25, 22)
            };

            jugador mejor = jugadores;
            for (int i = 1; i < jugadores.Length; i++)
            {
                if (jugadores[i].indiceAtaque > mejor.indiceAtaque)
                {

                }
            }
        }
    }
}