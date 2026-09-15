using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_21
{
    internal class Arbol
    {
        public Nodo raiz { get; set; }

        public Arbol()
        {
            this.raiz = null;
        }

        public void insertar(int valor)
        {
            raiz = insertarRecursivo(raiz, valor);
        }

        public Nodo insertarRecursivo(Nodo nodoActual, int valor)
        {
            if (nodoActual == null)
            {
                return new Nodo(valor);
            }
            if (valor < nodoActual.valor)
            {
                nodoActual.izquierdo = insertarRecursivo(nodoActual.izquierdo, valor);
            }
            else if (valor > nodoActual.valor)
            {
                nodoActual.derecho = insertarRecursivo(nodoActual.derecho, valor);
            }

            return nodoActual;

        }
        public int ObtenerMinimo()
        {
            if (raiz == null)
            {
                throw new InvalidOperationException("El arbol está vacío");
            }

            Nodo actual = raiz;
            while (actual.izquierdo != null)
            {
                actual = actual.izquierdo;
            }
            return actual.valor;
        }

        public int ObtenerMaximo()
        {
            if (raiz == null)
            {
                throw new InvalidOperationException("El arbol está vacío");
            }

            Nodo actual = raiz;
            while(actual.derecho != null)
            {
                actual = actual.derecho;
            }

            return actual.valor;

        }

        public int ObtenerCantidadNodos()
        {
            return ContarNodos(raiz);
        }

        public int ContarNodos(Nodo NodoActual)
        {
            if(NodoActual == null)
            {
                return 0;
            }

            return 1 + ContarNodos(NodoActual.izquierdo) + ContarNodos(NodoActual.derecho);
        }

        public int ObtenerAltura()
        {
            return CalcularAltura(raiz);
        }

        public int CalcularAltura(Nodo NodoActual)
        {
            if(NodoActual == null)
            {
                return 0;
            }

            int alturaIzquierda = CalcularAltura(NodoActual.izquierdo);
            int alturaDerecho = CalcularAltura(NodoActual.derecho);

            if(alturaIzquierda > alturaDerecho)
            {
                return 1 + alturaIzquierda;
            }
            else
            {
                return 1 + alturaDerecho;
            }
            
        }

        public int ContarHojas()
        {
            return HojasContadas(raiz);
        }

        public int HojasContadas(Nodo NodoActual)
        {
            if (NodoActual == null)
            {
                return 0;
            }

            if (NodoActual.izquierdo == null && NodoActual.derecho == null)
            {
                return 1;
            }

            return HojasContadas(NodoActual.izquierdo) + HojasContadas(NodoActual.derecho);
        }


    }
}
