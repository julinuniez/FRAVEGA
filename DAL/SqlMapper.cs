using BE;
using System;
using System.Data;

namespace DAL
{
    internal static class SqlMapper
    {
        public static Producto MapeoProducto(DataRow registro) => new Producto()
        {
            idProducto = Convert.ToInt32(registro["idProducto"]),
            NombreProducto = registro["Nombre"].ToString(),
            Descripcion = registro["Descripcion"].ToString(),
            idCategoria = Convert.ToInt32(registro["idCategoria"]),
            Stock = Convert.ToInt32(registro["stock"]),
            Precio = Convert.ToDecimal(registro["precio"])
        };

        public static Cliente MapeoCliente(DataRow registro) => new Cliente
        {
            DNI = Convert.ToInt32(registro["DNI"]),
            Nombre = registro["nombre"].ToString(),
            Apellido = registro["apellido"].ToString(),
            Telefono = Convert.ToInt32(registro["Telefono"])
        };

        public static Categoria MapeoCategoria(DataRow dr) => new Categoria()
        {
            idCategoria = Convert.ToInt32(dr["idCategoria"]),
            NombreCategoria = dr["Nombre"].ToString(),
            Descripcion = dr["Descripcion"].ToString()
        };


    }
}
