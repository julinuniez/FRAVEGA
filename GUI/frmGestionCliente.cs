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
    public partial class frmGestionCliente : Form
    {

        BLLUsuario gestorUsuario = new BLLUsuario();

        public frmGestionCliente()
        {
            InitializeComponent();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                usuario.DNI = Convert.ToInt32(txtDNI.Text);
                gestorUsuario.EliminarUsuario(usuario.DNI);
                MessageBox.Show("Cliente eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                usuario.DNI = Convert.ToInt32(txtDNI.Text);
                usuario.Nombre = txtNombre.Text;
                usuario.Apellido = txtApellido.Text;
                usuario.Telefono = Convert.ToInt32(txtTelefono.Text);

                gestorUsuario.ActualizarUsuario(usuario);
                MessageBox.Show("Cliente modificado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
