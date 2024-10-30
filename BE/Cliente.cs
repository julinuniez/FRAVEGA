using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente
    {
		private int _dni;

		public int DNI
		{
			get { return _dni; }
			set { _dni = value; }
		}

		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private string _apellido;

		public string Apellido
		{
			get { return _apellido; }
			set { _apellido = value; }
		}

		private string _email;

		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}

		private int myVar;

		public int MyProperty
		{
			get { return myVar; }
			set { myVar = value; }
		}

		private int _telefono;

		public int Telefono
		{
			get { return _telefono; }
			set { _telefono = value; }
		}




	}
}
