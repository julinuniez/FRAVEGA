﻿using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class MP_Producto
    {
        Acceso acceso = new Acceso();
        public int AgregarProducto(Producto producto)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("nombre", producto.NombreProducto),
                new SqlParameter("descripcion", producto.Descripcion),
                new SqlParameter("idCategoria", producto.idCategoria),
                new SqlParameter("stock",producto.Stock),
                new SqlParameter("precio", producto.Precio),
            };
            return acceso.escribir("AgregarProducto", parametros);
        }

        public int ActualizarProducto(Producto producto)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("idProducto",producto.idProducto),
                new SqlParameter("Nombre", producto.NombreProducto),
                new SqlParameter("Descripcion", producto.Descripcion),
                new SqlParameter("Stock", producto.Stock),
                new SqlParameter("idCategoria", producto.idCategoria),
                new SqlParameter("precio", producto.Precio),
            };
            return acceso.escribir("actualizarProducto", parametros);
        }

        public int EliminarProducto(Producto producto)
        {
            SqlParameter[] parametros = new SqlParameter[1]
            {
                new SqlParameter("idProducto",producto.idProducto)
            };
            return acceso.escribir("EliminarProducto", parametros);
        }

        public List<Producto> ListarProducto()
        {
            List<Producto> list = new List<Producto>();
            DataTable dt = new DataTable();
            dt = acceso.leer("selectProductos", null);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(SqlMapper.MapeoProducto(dr));
            }
            return list;
        }
        public int getStock(Producto producto)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@idProducto",producto.idProducto)
            };
            return acceso.obtenerInt("getStock", parametros);
        }
        public int getPrecioProducto(int id)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("idProducto",id)
            };
            return acceso.obtenerInt("getPrecioProducto", parametros);

        }
        public int getIdProducto(string nombre)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("Nombre",nombre)
            };
            return acceso.obtenerInt("getIdProducto", parametros);
        }

        public string getNombreProducto(int id)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@id",id)
            };
            DataTable dt = acceso.leer("getNombreProducto", parametros);
            return dt.Rows[0]["nombre"].ToString();
        }

        public bool generarXMLProducto()
        {
            return acceso.EscribirXML("sp_GenerarXMLProducto", "Productos");
        }
    }
}
