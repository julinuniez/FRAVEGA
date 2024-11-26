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
    public class MP_MedioDePago
    {
        Acceso acceso = new Acceso();

        public List<MedioDePago> ListarMedioDePago(int Dni)
        {
            List<MedioDePago> lista = new List<MedioDePago>();
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Dni",Dni)
            };
            DataTable dt = acceso.leer("ListarMedioDePago", parametros);
            foreach(DataRow dr in dt.Rows)
            {
                MedioDePago mdp = new MedioDePago();
                mdp.nroTarjeta = Convert.ToString(dr["nroTarjeta"]);
                mdp.idTipoTarjeta = Convert.ToInt32(dr["idTipoTarjeta"]);
                mdp.DNI = Convert.ToInt32(dr["dni"]);
                mdp.FechaCaducidad = Convert.ToDateTime(dr["FechaCaducidad"]);
                lista.Add(mdp);
            }
            return lista;
        }


        public int AgregarMedioDePago(MedioDePago mdp)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@nroTarjeta", mdp.nroTarjeta),
                new SqlParameter("@idTipoTarjeta", mdp.idTipoTarjeta),
                new SqlParameter("@dni", mdp.DNI),
                new SqlParameter("@FechaCaducidad", mdp.FechaCaducidad),
                new SqlParameter("@cvv", mdp.cvv)
            };
            return acceso.escribir("AgregarMedioDePago", parametros);
        }

        public int EliminarMedioDePago(string nroTarjeta)
        {
            SqlParameter[] parametro = new SqlParameter[]
            {
                new SqlParameter("@nroTarjeta", nroTarjeta)
            };
            return acceso.escribir("EliminarMedioDePago",parametro);
        }

        public bool ValidarMedioDePago(string nroTarjeta, int cvv)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@nroTarjeta",nroTarjeta),
                new SqlParameter("@cvv",cvv)
            };
            if (acceso.obtenerInt("ValidarMedioDePago", parametros) > 0)
                return true;
            else
                return false;
        }
        public bool generarXMLMedioDePago()
        {
            return acceso.EscribirXML("sp_GenerarXMLMedioDePago", "MediosDePago");
        }

    }
}
