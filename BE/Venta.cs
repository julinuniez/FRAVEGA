using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Venta
    {
		private int _nroVenta;

		public int nroVenta
		{
			get { return _nroVenta; }
			set { _nroVenta = value; }
		}

		private int _idCliente;

		public int idCliente
		{
			get { return _idCliente; }
			set { _idCliente = value; }
		}

		private decimal _total;

		public decimal total
		{
			get { return _total; }
			set { _total = value; }
		}

		private DateTime _fecha;

		public DateTime fecha
		{
			get { return _fecha; }
			set { _fecha = value; }
		}

		private string _nroTarjeta;

		public string nroTarjeta
		{
			get { return _nroTarjeta; }
			set { _nroTarjeta = value; }
		}

	}
}
