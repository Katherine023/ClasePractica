using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Interfaces
{
    public interface IProductosModel:IProductos<Producto>
    {
        Producto FindById(int id);
        int GetLastProductoId();

    }
}
