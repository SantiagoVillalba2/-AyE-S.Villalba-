using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_base_de_datos
{
    internal class Arbol
    {
        public Nodo raiz { get; set; }
        public Arbol()
        {
            raiz = null;
        }

        public void insertar(Pjs personajeinsertado)
        {
            raiz = InsertarRecursiva(personajeinsertado, raiz);
        }
        public Nodo InsertarRecursiva(Pjs personaje, Nodo nodoactual)
        {
            if(nodoactual == null)
            {
                Nodo Nuevonodo = new Nodo(personaje, null, null);
                return Nuevonodo;
            }

            if(personaje.ID < nodoactual.valor.ID)
            {
                nodoactual.izquierdo = InsertarRecursiva(personaje, nodoactual.izquierdo);
            }

            if (personaje.ID > nodoactual.valor.ID)
            {
                nodoactual.derecho = InsertarRecursiva(personaje, nodoactual.derecho);
            }

            return nodoactual;
        }

        public void Buscar(int numerobuscado)
        {
            Nodo nodoactual = raiz;
            BuscarRecursiva(numerobuscado, nodoactual);
        }
        public void BuscarRecursiva(int numerobuscado, Nodo nodoactual)
        {
            if(nodoactual == null)
            {
                Console.WriteLine("No se encontró el id");
                return;
            }

            if(nodoactual.valor.ID == numerobuscado)
            {
                Console.WriteLine($"Encontrado: {nodoactual.valor.ID} {nodoactual.valor.nombre} {nodoactual.valor.titulo_1} {nodoactual.valor.titulo_2} {nodoactual.valor.titulo_3} ");
                return;
            }

            if(nodoactual.valor.ID < numerobuscado)
            {
                BuscarRecursiva(numerobuscado, nodoactual.derecho);
            }

            if (nodoactual.valor.ID > numerobuscado)
            {
                BuscarRecursiva(numerobuscado, nodoactual.izquierdo);
            }
        }
    }
}
