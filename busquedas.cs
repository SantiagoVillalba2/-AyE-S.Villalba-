using System.Security.Cryptography.X509Certificates;

namespace tp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 };
            Console.WriteLine("Escribí el número que querés buscar");
            int buscar = Convert.ToInt32(Console.ReadLine());
            busqueda_secuencial_simple(num, buscar);
            int buscar2 = Convert.ToInt32(Console.ReadLine());
            busqueda_secuencial_optimizada(num, buscar2);
            bool busqueda_secuencial_simple(int[] lista, int buscar)
            {
                bool encontrado = false;
                for (int i = 0; i < lista.Length; i++)
                {
                    if (lista[i] == buscar)
                    {
                        Console.WriteLine("El elemento fue encontrado");
                        encontrado = true;
                        return true;
                        break;
                    }
                }
                Console.WriteLine("No se encontró");
                return false;
            }

            bool busqueda_secuencial_optimizada(int[] lista, int buscar)
            {
                bool encontrado = false;
                for(int i = 0; i < lista.Length; i++)
                {
                    if (lista[i] == buscar)
                    {
                        Console.WriteLine("El número fue encontrado");
                        encontrado = true;
                        return true;
                    }

                    if(lista[i] > buscar)
                    {
                        break;
                    }
                }
                return false;
            }


        }
    }
}
