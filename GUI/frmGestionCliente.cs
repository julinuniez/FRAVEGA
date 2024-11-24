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
            ActualizarListaUsuario();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                usuario.DNI = Convert.ToInt32(txtDNI.Text);
                gestorUsuario.EliminarUsuario(usuario.DNI);
                MessageBox.Show("Cliente eliminado correctamente");
                ActualizarListaUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ActualizarListaUsuario()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = gestorUsuario.ListarUsuario();
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
                ActualizarListaUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];
                txtApellido.Text = row.Cells["Apellido"].Value.ToString();
                txtDNI.Text = row.Cells["DNI"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();

            }
        }
    }
}
