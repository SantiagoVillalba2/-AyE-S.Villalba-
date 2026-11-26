using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_base_de_datos
{
    internal class Nodo
    {
        public Pjs valor { get; set; }
        public Nodo izquierdo { get; set; }
        public Nodo derecho { get; set; }

        public Nodo(Pjs valor, Nodo izquierdo, Nodo derecho)
        {
            this.valor = valor;
            izquierdo = null;
            derecho = null;
        }
    }
}
