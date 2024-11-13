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
            Usuario usuario = new Usuario();
            usuario.DNI = Convert.ToInt32(txtDNI.Text);
            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            usuario.Telefono = Convert.ToInt32(txtTelefono.Text);

            if (txtContraseña.Text == txtRepetirContraseña.Text)
            {
                gestorUsuario.RegistrarUsuario(usuario, txtContraseña.Text);
                MessageBox.Show("Usuario registrado con exito");
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }
    }
}
