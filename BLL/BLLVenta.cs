using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class BLLVenta
    {
        MP_Venta mapper = new MP_Venta();

        public int AgregarVenta(Venta venta)
        {
            return mapper.AgregarVenta(venta);
        }

        public List<Venta> ListarVentas()
        {
            return mapper.ListarVentas();
        }
        public int getNroVenta()
        {
            return mapper.getNroVenta();
        }

        public bool generarXMLVenta()
        {
            return mapper.generarXMLVenta();
        }
    }
}
