using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class TipoTarjeta
    {
		private int _idTipo;

		public int idTipoTarjeta
		{
			get { return _idTipo; }
			set { _idTipo = value; }
		}

		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

	}
}
