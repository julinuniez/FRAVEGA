using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_DetalleVenta
    {
        Acceso acceso = new Acceso();
        public int AgregarDetalleVenta(DetalleVenta detalleVenta)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@nroVenta", detalleVenta.nroVenta),
            new SqlParameter("@idProducto", detalleVenta.idProducto),
            new SqlParameter("@cantidad", detalleVenta.Cantidad),
            new SqlParameter("@precio", detalleVenta.Subtotal)
            };
            return acceso.escribir("AgregarDetalleVenta", parametros);
        }

        public List<DetalleVenta> ListarDetalleVenta(int nroVenta)
        {
            List<DetalleVenta> lista = new List<DetalleVenta>();
            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@nroVenta", nroVenta)
            };
            DataTable dt = acceso.leer("ListarDetalleVenta", parametros);
            foreach (DataRow dr in dt.Rows)
            {
                DetalleVenta detalleVenta = new DetalleVenta();
                detalleVenta.idDetalleVenta = Convert.ToInt32(dr["idDetalleVenta"]);
                detalleVenta.nroVenta = Convert.ToInt32(dr["nroVenta"]);
                detalleVenta.idProducto = Convert.ToInt32(dr["idProducto"]);
                detalleVenta.Cantidad = Convert.ToInt32(dr["cantidad"]);
                detalleVenta.Subtotal = Convert.ToDecimal(dr["precio"]);
                lista.Add(detalleVenta);
            }
            return lista;
        }

    }
}
