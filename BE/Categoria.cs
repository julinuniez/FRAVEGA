using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Categoria
    {
		private int _id;

		public int idCategoria
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _nombre;

		public string NombreCategoria
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private string _desc;

		public string Descripcion
		{
			get { return _desc; }
			set { _desc = value; }
		}

		
}
