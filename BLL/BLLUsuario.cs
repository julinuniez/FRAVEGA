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

        public Usuario Login(string Dni, string contraseña)
        {
            return mapper.Login(Dni, contraseña);
        }

        public int RegistrarUsuario(Cliente cliente, string contraseña)
        {
            return mapper.RegistrarUsuario(cliente, contraseña);
        }
    }
}
