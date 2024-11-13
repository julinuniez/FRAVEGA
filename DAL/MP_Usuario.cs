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
            
            DataTable dt= acceso.leer("Login", parametros);
            if (dt.Rows.Count == 0) return null;

                Usuario usuario = new Usuario();
                usuario.idUsuario = Convert.ToInt32(dt.Rows[0]["idUsuario"]);
                usuario.DNI = Convert.ToInt32(dt.Rows[0]["Dni"]);
                usuario.admin = Convert.ToBoolean(dt.Rows[0]["admin"]);
                usuario.Nombre = dt.Rows[0]["Nombre"].ToString();
                usuario.Apellido = dt.Rows[0]["Apellido"].ToString();

            return usuario;
            
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



    }
}
