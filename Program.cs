using Prueba_Base_de_Datos;

namespace prueba_base_de_datos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var Base = new AppDbContext();

            //Agregar
            var Pj = new Pjs(23, "Pedro", "Hombre", "Reduro", "Super", "Treemendo");
            Base.personajes.Add(Pj);
            Base.SaveChanges();

            //Actualizar
            int IDPj = 4;
            var personajeactualizado = Base.personajes.Find(4);

            if(personajeactualizado != null)
            {
                personajeactualizado.nombre = "Gatubelo";
            }

            //Eliminar
            int IDPj2 = 7;
            var personajeeliminar = Base.personajes.Find(7);

            if (personajeactualizado != null)
            {
                Base.personajes.Remove(personajeeliminar);
                Base.SaveChanges();
            }

            //Consultar
            var todalabase = Base.personajes.ToList();
            Console.WriteLine("TODOS LOS DATOS");
            foreach(var i in todalabase)
            {
                Console.WriteLine($"{i.ID} {i.nombre} {i.genero} {i.titulo_1} {i.titulo_2} {i.titulo_3}");
            }

            //insertar en el arbol
            Arbol arbolpersonaje = new Arbol();
            var personajesinsertar = Base.personajes.ToList();
            foreach(var i in personajesinsertar)
            {
                arbolpersonaje.insertar(i);
            }

            //Buscar en el arbol
            int idbuscado = 8;
            arbolpersonaje.Buscar(idbuscado);

            //Lista con todos los personajes (Mostrando solo los nombres de forma desordenada)
            Pjs[] listapersonajes = Base.personajes.ToArray();
            foreach(Pjs i in listapersonajes)
            {
                Console.WriteLine(i.nombre);
            }



        }
    }
}
