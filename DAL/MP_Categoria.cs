using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_Categoria
    {
        Acceso acceso = new Acceso();

        public List<Categoria> ListarCategoria()
        {
            List<Categoria> list = new List<Categoria>();
            DataTable dt = acceso.leer("selectCategorias", null);
            foreach(DataRow dr in dt.Rows)
            {
                list.Add(SqlMapper.MapeoCategoria(dr));
            }
            return list;
        }

        public string selectNombreCategoriaSegunID(int id)
        {
            string nombre = null;
            SqlParameter[] parametro = new SqlParameter[]
            {
                new SqlParameter("idCategoria",id)
            };
            DataTable dt = acceso.leer("selectNombreCategoriaSegunID", parametro);
            foreach (DataRow dr in dt.Rows)
            {
                nombre = dr["Nombre"].ToString();
            }
            return nombre;
        }

        public int EliminarCategoria(Categoria cat)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("idCategoria",cat.idCategoria)
            };
            return acceso.escribir("EliminarCategoria", parametros);
        }

        public int AgregarCategoria(Categoria cat)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("Nombre",cat.NombreCategoria),
                new SqlParameter("Descripcion",cat.Descripcion)
            };
            return acceso.escribir("AgregarCategoria", parametros);
        }

        public int getIdCategoria(string nombre)
        {
            SqlParameter[] parametro = new SqlParameter[]
            {
                new SqlParameter("Nombre",nombre)
            };
            return acceso.obtenerInt("getIdCategoria",parametro);

        }

        public int ActualizarCategoria(Categoria cat)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("idCategoria",cat.idCategoria),
                new SqlParameter("Nombre",cat.NombreCategoria),
                new SqlParameter("Descripcion",cat.Descripcion)
            };
            return acceso.escribir("ActualizarCategoria", parametros);
        }

        public bool generarXMLCategorias()
        {
            return acceso.EscribirXML("sp_GenerarXMLCategorias", "Categorias");
        }
    }
}
