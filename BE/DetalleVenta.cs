using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DetalleVenta
    {
		private int _id;

		public int idDetalleVenta
		{
			get { return _id; }
			set { _id = value; }
		}

		private int _nroVenta;

		public int nroVenta
		{
			get { return _nroVenta; }
			set { _nroVenta = value; }
		}

		private int _idProducto;

		public int idProducto
		{
			get { return _idProducto; }
			set { _idProducto = value; }
		}

		private int _cant;

		public int Cantidad
		{
			get { return _cant; }
			set { _cant = value; }
		}

		private int _subtotal;

		public int Subtotal
		{
			get { return _subtotal; }
			set { _subtotal = value; }
		}

	}
}
