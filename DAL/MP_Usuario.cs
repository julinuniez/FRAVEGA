using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class MP_Usuario
    {
        Acceso acceso = new Acceso();

        public Usuario Login(int Dni, string contraseña)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Dni", Dni),
                new SqlParameter("@Contraseña", contraseña)
            };
            
            DataTable dt= acceso.leer("sp_Login", parametros);
            if (dt.Rows.Count == 0) return null;

                Usuario usuario = new Usuario();
                usuario.idUsuario = Convert.ToInt32(dt.Rows[0]["idUsuario"]);
                usuario.DNI = Convert.ToInt32(dt.Rows[0]["Dni"]);
                usuario.admin = Convert.ToBoolean(dt.Rows[0]["admin"]);
                usuario.Nombre = dt.Rows[0]["Nombre"].ToString();
                usuario.Apellido = dt.Rows[0]["Apellido"].ToString();

            return usuario;
            
        }



        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            DataTable dt = acceso.leer("ListarUsuarios", null);
            foreach (DataRow dr in dt.Rows)
            {
                Usuario usuario = new Usuario();
                usuario.idUsuario = Convert.ToInt32(dr["idUsuario"]);
                usuario.contraseña = Convert.ToString(dr["contraseña"]);
                usuario.idUsuario = Convert.ToInt32(dr["idUsuario"]);
                usuario.admin = Convert.ToBoolean(dr["admin"]);
                usuario.DNI = Convert.ToInt32(dr["Dni"]);
                usuario.Nombre = dr["Nombre"].ToString();
                usuario.Apellido = dr["Apellido"].ToString();
                usuario.Telefono = Convert.ToInt32(dr["Telefono"].ToString());
                lista.Add(usuario);
            }
            return lista;
        }

        public int RegistrarUsuario(Usuario usuario, string contraseña)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Dni", usuario.DNI),
                new SqlParameter("@Nombre", usuario.Nombre),
                new SqlParameter("@Apellido",usuario.Apellido),
                new SqlParameter("@telefono",usuario.Telefono),
                new SqlParameter("@Contraseña", contraseña)
            };
            return acceso.escribir("RegistrarUsuario", parametros);
        }

        public int ActualizarUsuario(Usuario usuario)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Dni", usuario.DNI),
                new SqlParameter("@Nombre", usuario.Nombre),
                new SqlParameter("@Apellido",usuario.Apellido),
                new SqlParameter("@telefono",usuario.Telefono)
            };
            return acceso.escribir("ActualizarUsuario", parametros);
        }

        public int EliminarUsuario(int id)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@DNI", id) 
            };
            return acceso.escribir("EliminarUsuario", parametros);
        }

        public bool generarXMLUsuario()
        {
            return acceso.EscribirXML("sp_GenerarXMLUsuario", "Usuarios");
        }
    }
}
