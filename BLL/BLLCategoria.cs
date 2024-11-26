using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class BLLCategoria
    {
        MP_Categoria mapper = new MP_Categoria();

        public List<Categoria> ListarCategoria()
        {
            return mapper.ListarCategoria();
        }
        
        public int AgregarCategoria(Categoria cat)
        {
            return mapper.AgregarCategoria(cat);
        }

        public int getIdCategoria(string nombre)
        {
            return mapper.getIdCategoria(nombre);
        }

        public string getNombreCategoria(int id)
        {
            return mapper.selectNombreCategoriaSegunID(id);
        }

        public int ActualizarCategoria(Categoria cat)
        {
            return mapper.ActualizarCategoria(cat);
        }
        
        public int EliminarCategoria(Categoria cat)
        {
            return mapper.EliminarCategoria(cat);
        }

        public bool generarXML()
        {
            return mapper.generarXMLCategorias();
        }
    }
}
