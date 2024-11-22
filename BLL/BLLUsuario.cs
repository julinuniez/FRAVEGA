using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class BLLUsuario
    {
        MP_Usuario mapper = new MP_Usuario();

        public Usuario Login(int Dni, string contraseña)
        {
            return mapper.Login(Dni, contraseña);
        }
        public List<Usuario> ListarUsuario()
        {
            return mapper.ListarUsuarios();
        }

        public int RegistrarUsuario(Usuario usuario, string contraseña)
        {
            return mapper.RegistrarUsuario(usuario, contraseña);
        }

        public int ActualizarUsuario(Usuario usuario)
        {
            return mapper.ActualizarUsuario(usuario);
        }

        public int EliminarUsuario(int id)
        {
            return mapper.EliminarUsuario(id);
        }
    }
}
