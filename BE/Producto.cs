using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Producto
    {
		private int _id;

		public int idProducto
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _nom;

		public string NombreProducto
		{
			get { return _nom; }
			set { _nom = value; }
		}

		private string _desc;

		public string Descripcion
		{
			get { return _desc; }
			set { _desc = value; }
		}

		private int _idCategoria;

		public int idCategoria
		{
			get { return _idCategoria; }
			set { _idCategoria = value; }
		}

		private int _stock;

		public int Stock
		{
			get { return _stock; }
			set { _stock = value; }
		}
		private decimal _precio;

		public decimal Precio
		{
			get { return _precio; }
			set { _precio = value; }
		}






	}
}
