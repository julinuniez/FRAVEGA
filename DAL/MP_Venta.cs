﻿using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_Venta
    {
        Acceso acceso = new Acceso();

        public int AgregarVenta(Venta venta)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@DNI", venta.DNI),
            new SqlParameter("@Total", venta.total),
            new SqlParameter("@Fecha", venta.fecha),
            new SqlParameter("@NroTarjeta", venta.nroTarjeta)
            };
            return acceso.escribir("AgregarVenta", parametros);
        }

        public List<Venta> ListarVentas()
        {
            List<Venta> lista = new List<Venta>();
            DataTable dt = acceso.leer("ListarVentas", null);
            foreach (DataRow dr in dt.Rows)
            {
                Venta venta = new Venta();
                venta.nroVenta = Convert.ToInt32(dr["nroVenta"]);
                venta.DNI = Convert.ToInt32(dr["dni"]);
                venta.total = Convert.ToInt32(dr["total"]);
                venta.fecha = Convert.ToDateTime(dr["fecha"]);
                venta.nroTarjeta = Convert.ToString(dr["nroTarjeta"]);
                lista.Add(venta);
            }
            return lista;
        }
        public int getNroVenta()
        {
            return acceso.obtenerIntQuery("SELECT COALESCE(MAX(nroVenta), 0) + 1 FROM Venta");
        }
        public bool generarXMLVenta()
        {
            return acceso.EscribirXML("sp_GenerarXMLVenta", "Ventas");
        }

        public List<Venta> ListarVentasPorDni(Usuario user)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@DNI", user.DNI)
            };

            List<Venta> lista = new List<Venta>();
            DataTable dt = acceso.leer("ListarVentasPorDni", parametros);
            foreach (DataRow dr in dt.Rows)
            {
                Venta venta = new Venta();
                venta.nroVenta = Convert.ToInt32(dr["nroVenta"]);
                venta.total = Convert.ToInt32(dr["total"]);
                venta.fecha = Convert.ToDateTime(dr["fecha"]);
                venta.nroTarjeta = Convert.ToString(dr["nroTarjeta"]);
                lista.Add(venta);
            }
            return lista;
        }

    }
}
