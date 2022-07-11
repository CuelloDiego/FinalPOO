using FinalPOO.Core;

namespace FinalPOO.DataSource
{
    public class DataSource : IDataSource
    {
        public List<Articulo> listado { get; set; }
        public DataSource()
        {
            listado = new List<Articulo>()
            {

                new Articulo(){Nombre="RTX 3070",Descripcion="GPU",Stock=3,Precio=1000},
                new Articulo(){Nombre="RTX 2060",Descripcion="GPU",Stock=34,Precio=500},
                new Articulo(){Nombre="AMD RYZEN 5",Descripcion="PROC",Stock=54,Precio=1500},
                new Articulo(){Nombre="INTEL I7",Descripcion="PROC",Stock=123,Precio=2300},
                new Articulo(){Nombre="ROYAL 16GB",Descripcion="RAM",Stock=2,Precio=5000}
            };
        }

        public List<Articulo> GetItems()
        {
            return listado;
            
        }
    }
        
}