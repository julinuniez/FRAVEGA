using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLDetalleVenta
    {
        MP_DetalleVenta mapper = new MP_DetalleVenta();

        public int AgregarDetalleVenta(DetalleVenta detalleVenta)
        {
            return mapper.AgregarDetalleVenta(detalleVenta);
        }

        public List<DetalleVenta> ListarDetalleVenta(int nroVenta)
        {
            return mapper.ListarDetalleVenta(nroVenta);
        }
        
    }
}
