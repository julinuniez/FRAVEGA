using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace GUI
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        BLLUsuario gestorUsuario = new BLLUsuario();

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            bool valido = false;
            Usuario usuario = new Usuario();
            if(lblTxtBoxDNI.Validar() && lblTxtBoxNombre.Validar() && lblTxtBoxApellido.Validar() && lblTxtBoxTelefono.Validar())
            {
                valido = true;
                usuario.DNI = Convert.ToInt32(lblTxtBoxDNI.Texto);
                usuario.Nombre = lblTxtBoxNombre.Texto;
                usuario.Apellido = lblTxtBoxApellido.Texto;
                usuario.Telefono = Convert.ToInt32(lblTxtBoxTelefono.Texto);
            }
                

            if (lblTxtBoxContraseña.Texto == lblTxtBoxRepetirContraseña.Texto && valido)
            {
                gestorUsuario.RegistrarUsuario(usuario, lblTxtBoxContraseña.Texto);
                MessageBox.Show("Usuario registrado con exito");
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
    }
}
