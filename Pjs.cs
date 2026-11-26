using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_base_de_datos
{
    internal class Pjs
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string genero { get; set; }
        public string titulo_1 { get; set; }
        public string titulo_2 { get; set; }
        public string titulo_3 { get; set; }

        public Pjs(int ID, string nombre, string genero, string titulo_1, string titulo_2, string titulo_3)
        {
            this.ID = ID;
            this.nombre = nombre;
            this.titulo_1 = titulo_1;
            this.titulo_2 = titulo_2;
            this.titulo_3 = titulo_3;
        }

    }
}
