using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPOO.Core
{
    public interface IDataSource
    {
        List<Articulo> GetItems();

    }
}
