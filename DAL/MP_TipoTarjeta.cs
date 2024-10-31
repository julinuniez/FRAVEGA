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
    public class MP_TipoTarjeta
    {
        Acceso acceso = new Acceso();
        public int AgregarTipoTarjeta(TipoTarjeta tipo)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Nombre", tipo.Nombre),
            };
            return acceso.escribir("AgregarTipoTarjeta", parametros);
        }
        public int EliminarTipoTarjeta(int id)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@idTipoTarjeta", id),
            };
            return acceso.escribir("EliminarTipoTarjeta", parametros);
        }

        public List<TipoTarjeta> ListarTipoTarjeta()
        {
            List<TipoTarjeta> lista = new List<TipoTarjeta>();
            DataTable dt = acceso.leer("ListarTipoTarjeta",null);

            foreach(DataRow dr in dt.Rows)
            {
                TipoTarjeta tt = new TipoTarjeta();
                tt.idTipoTarjeta = Convert.ToInt32(dr["idTipoTarjeta"]);
                tt.Nombre = dr["Nombre"].ToString();
                lista.Add(tt);
            }
            return lista;
        }

    }
}
