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

        public int getPrecioProducto(int id)
        {
            return mapper.getPrecioProducto(id);
        }
        public int getIdProducto(string nombre)
        {
            return mapper.getIdProducto(nombre);
        }
        public int getStock(Producto producto)
        {
            return mapper.getStock(producto);
        }

        public string getNombreProducto(int id)
        {
            return mapper.getNombreProducto(id);
        }
        public bool validarCantidadProductos(Producto p, int cantidad)
        {
            if (getStock(p) < cantidad)
                return false;
            else return true;
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
        public bool generarXML()
        {
            return mapper.generarXMLProducto();
        }
    }
}
