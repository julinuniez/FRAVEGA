using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;


namespace BLL
{
    public class BLLProducto
    {
        MP_Producto mapper = new MP_Producto();

        public List<Producto> ListarProducto()
        {
            return mapper.ListarProducto();
        }

        public int AgregarProducto(Producto producto)
        {
            return mapper.AgregarProducto(producto);
        }

        public int ActualizarProducto(Producto producto)
        {
            return mapper.ActualizarProducto(producto);
        }

        public int EliminarProducto(Producto producto)
        {
            return mapper.EliminarProducto(producto);
        }

    }
}
