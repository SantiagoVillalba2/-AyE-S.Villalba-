namespace ejercicio3
{
    internal class Program
    {
        struct producto
        {
            public string Nombre { get; set; }
            public int Codigo { get; set; }
            public int Precio { get; set; }

            public producto(string nombre, int codigo, int precio)
            {
                Nombre = nombre;
                Codigo = codigo;
                Precio = precio;

            }
        }

        static void Main(string[] args)
        {
            producto[] inventario = new producto[3];

            inventario[0] = new producto("Consola", 101, 350);
            inventario[1] = new producto("Computadora", 102, 780);
            inventario[2] = new producto("Celular", 103, 120);

            foreach(producto p in inventario)
            {
                Console.WriteLine($"Producto: {p.Nombre} | Codigo: {p.Codigo} | Precio: ${p.Precio}");
            }
        }
    }
}
