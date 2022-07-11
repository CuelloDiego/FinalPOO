namespace FinalPOO.Core
{
    public class Articulo
    {
        /*
         * Diseñar una librería de clases en C# que permita gestionar una lista de artículos (nombre, descripcion, stock, precio), 
         * en donde puedas obtener todos los productos, un producto solo y el stock total (la suma de todos los stock)
         */

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }

        public double Precio { get; set; }

    }
}