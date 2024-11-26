using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            if (!ValidarLogin(Dni, contraseña))
                throw new Exception("Completar campos");

            return mapper.Login(Dni, contraseña);
        }
        public List<Usuario> ListarUsuario()
        {
            return mapper.ListarUsuarios();
        }

        public int RegistrarUsuario(Usuario usuario, string contraseña)
        {
            if (!validarRegistro(usuario))
            throw new Exception("Debe completar los campos");

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

        public bool generarXML()
        {
            return mapper.generarXMLUsuario();
        }
        private bool ValidarLogin(int dni, string contraseña)
        {
            bool validar = false;
            if (string.IsNullOrEmpty(contraseña) || dni == 0)
            {
                validar = false;
            }
            else
            {
                validar = true;
            }
            return validar;
        }
        private bool validarRegistro(Usuario usuario)
        {
            bool validar = false;
            if (!string.IsNullOrEmpty(usuario.contraseña) && !string.IsNullOrEmpty(usuario.Nombre) && !string.IsNullOrEmpty(usuario.Apellido) && usuario.DNI >= 1000000)
                validar = false;
            else
                validar = true;
            return validar;
        }
    }
}

