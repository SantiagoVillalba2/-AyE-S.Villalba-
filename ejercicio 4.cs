using System.Transactions;

namespace ejercicio_4
{
    internal class Program
    {
        public struct estudiante
        {
            public string Nombre { get; set; }
            public double[] Notas { get; set; }

            public estudiante(string nombre, double[] notas)
            {
                Nombre = nombre;
                Notas = notas;
            }

            public double CalcularPromedio()
            {
                double suma = 0;

                foreach(double n in Notas)
                {
                    suma += n;
                }

                return suma / Notas.Length;
            }
        }
        static void Main(string[] args)
        {
            double[] notasestudiante = new double[] { 8.5, 3.0, 5.5 };

            estudiante alumno = new estudiante("Pepe", notasestudiante);
            double promediofinal = alumno.CalcularPromedio();

            Console.WriteLine("Calificaciones");
            Console.WriteLine($"Estudiante: {alumno.Nombre}");
            Console.WriteLine($"Promedio final: {promediofinal}");
        }
    }
}