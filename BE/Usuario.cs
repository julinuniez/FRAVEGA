using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario : Cliente
    {
		private int _id;

		public int idUsuario
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _contraseña;

		public string contraseña
		{
			get { return _contraseña; }
			set { _contraseña = value; }
		}

		private int _idCliente;

		public int IdCliente 
		{
			get { return _idCliente; }
			set { _idCliente = value; }
		}

		private bool _admin;

		public bool admin
		{
			get { return _admin; }
			set { _admin = value; }
		}

	}
}
