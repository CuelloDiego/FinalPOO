using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPOO.Core
{
    public class Lista
    {
        /*
        * Diseñar una librería de clases en C# que permita gestionar una lista de artículos (nombre, descripcion, stock, precio), 
        * en donde puedas obtener todos los productos, un producto solo y el stock total (la suma de todos los stock)
        */
        private List<Articulo> ListaArticulos { get; set; }



        public Lista(IDataSource dataSource)
        {
            ListaArticulos = dataSource.GetItems();
        }

        public List<Articulo> GetItems()
        {
            return ListaArticulos;

        }

        public Articulo GetItemByName(string name)
        {

            var found = ListaArticulos.Where(x=>x.Nombre==name).FirstOrDefault();

           
            return found;

        }

        public int SumStock()
        {
            int sum = 0;
            foreach (var item in ListaArticulos)
            {
                sum += item.Stock;
            }
            return sum;

        }




    }
}
