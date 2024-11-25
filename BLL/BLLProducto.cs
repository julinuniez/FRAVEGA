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
            if(!ValidarProducto(producto))return 0;
            return mapper.AgregarProducto(producto);
        }

        public int ActualizarProducto(Producto producto)
        {
            if (!ValidarProducto(producto)) return 0;
            return mapper.ActualizarProducto(producto);
        }

        public int EliminarProducto(Producto producto)
        {
            return mapper.EliminarProducto(producto);
        }

        public int getPrecioProducto(Producto producto)
        {
            return mapper.getPrecioProducto(producto);
        }
        private bool ValidarProducto(Producto producto)
        {
            if (producto.NombreProducto == "")
            {
                throw new Exception("El nombre del producto no puede estar vacio");
            }
            if (producto.Precio == 0)
            {
                throw new Exception("El precio del producto no puede ser 0");
            }
            if (producto.Stock == 0)
            {
                throw new Exception("El stock del producto no puede ser 0");
            }
            return true;
        }
    }
}
