using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class MedioDePago
    {
		private string _nroTarjeta;

		public string nroTarjeta
		{
			get { return _nroTarjeta; }
			set { _nroTarjeta = value; }
		}

		private int _idTipoTarjeta;

		public int idTipoTarjeta
		{
			get { return _idTipoTarjeta; }
			set { _idTipoTarjeta = value; }
		}

		private int _dni;

		public int DNI
		{
			get { return _dni; }
			set { _dni = value; }
		}

		private DateTime _fecha;

		public DateTime FechaCaducidad
		{
			get { return _fecha; }
			set { _fecha = value; }
		}

		private int _cvv;

		public int cvv
		{
			get { return _cvv; }
			set { _cvv = value; }
		}

	}
}
