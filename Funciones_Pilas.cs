namespace prueba
{
    internal class Program
    {

        static void Main(string[] args)
        {
            

            Stack<Personaje> historialDelPersonaje = new Stack<Personaje>();

            Personaje pj3 = new Personaje(100, 100, "Correr");
            Personaje pj2 = new Personaje(100, 100, "Ejercitarse");
            Personaje pj1 = new Personaje(100, 100, "Trabajar");

            historialDelPersonaje.Push(pj3);
            historialDelPersonaje.Push(pj2);
            historialDelPersonaje.Push(pj1);

            foreach (Personaje n in historialDelPersonaje)
            {
                Console.WriteLine($"Vida Total: {n.VidaTotal} Vida Actual: {n.VidaActual} Ultima acción realizada: {n.UltimaAccion} ");
            }
            
            Console.WriteLine("");
            volverEnElTiempo(historialDelPersonaje);
            Console.WriteLine("");
            Golpear(historialDelPersonaje);

            Personaje volverEnElTiempo(Stack<Personaje> retroceder)
            {
                var volver = retroceder.Pop();
                Console.WriteLine($"Accion que fue eliminada del personaje 1: {volver.UltimaAccion}");
                Console.WriteLine("");
                Console.WriteLine("Historial actualizado de ultimas acciones");

                foreach (Personaje n in retroceder)
                {
                    Console.WriteLine($"Realizadas: {n.UltimaAccion}");
                }

                return volver;
            }
            Personaje Golpear(Stack<Personaje> golpeado)
            {
                Personaje golpear1 = new Personaje(100, 100 - 20, "Golpe recibido");
                golpeado.Push(golpear1);

                Console.WriteLine("Accion actualizada, el personaje 1 recibió un golpe. Le restaron 20 a su vida actual");
                foreach (Personaje n in golpeado)
                {
                    Console.WriteLine($"Vida total: {n.VidaTotal} Vida actual: {n.VidaActual} Ultima accion: {n.UltimaAccion}");
                }

                return golpear1;
            }
        }
    }
}