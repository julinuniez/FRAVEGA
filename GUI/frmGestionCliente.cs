using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            // Validar DNI
            if (!ValidarDNI(txtDNI.Text))
            {
                MessageBox.Show("Por favor, ingrese un DNI válido (solo números).");
                return;
            }

            // Procesar eliminación
            try
            {
                Usuario usuario = new Usuario
                {
                    DNI = Convert.ToInt32(txtDNI.Text)
                };

                gestorUsuario.EliminarUsuario(usuario.DNI);
                MessageBox.Show("Cliente eliminado correctamente");
                ActualizarListaUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al eliminar el cliente: {ex.Message}");
            }
        }

        private bool ValidarDNI(string dni)
        {
            string pattern = @"^\d+$"; // Solo números enteros
            return Regex.IsMatch(dni, pattern) && dni.Length >= 7 && dni.Length <= 10;
        }

        private bool ValidarTelefono(string telefono)
        {
            string pattern = @"^\d+$"; // Solo números enteros
            return Regex.IsMatch(telefono, pattern) && telefono.Length >= 7 && telefono.Length <= 15;
        }

        private bool ValidarNombreOApellido(string texto)
        {
            string pattern = @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"; // Solo letras y espacios
            return Regex.IsMatch(texto, pattern) && texto.Length > 0;
        }

        public void ActualizarListaUsuario()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = gestorUsuario.ListarUsuario();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            // Validar datos
            if (!ValidarDNI(txtDNI.Text))
            {
                MessageBox.Show("Por favor, ingrese un DNI válido (solo números).");
                return;
            }

            if (!ValidarNombreOApellido(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre válido (solo letras y espacios).");
                return;
            }

            if (!ValidarNombreOApellido(txtApellido.Text))
            {
                MessageBox.Show("Por favor, ingrese un apellido válido (solo letras y espacios).");
                return;
            }

            if (!ValidarTelefono(txtTelefono.Text))
            {
                MessageBox.Show("Por favor, ingrese un teléfono válido (solo números).");
                return;
            }

            // Procesar actualización
            try
            {
                Usuario usuario = new Usuario
                {
                    DNI = Convert.ToInt32(txtDNI.Text),
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Telefono = Convert.ToInt32(txtTelefono.Text)
                };

                gestorUsuario.ActualizarUsuario(usuario);
                MessageBox.Show("Cliente modificado correctamente");
                ActualizarListaUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al modificar el cliente: {ex.Message}");
            }
        }


        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvClientes.Rows[e.RowIndex];
                    txtApellido.Text = row.Cells["Apellido"].Value?.ToString() ?? string.Empty;
                    txtDNI.Text = row.Cells["DNI"].Value?.ToString() ?? string.Empty;
                    txtNombre.Text = row.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                    txtTelefono.Text = row.Cells["Telefono"].Value?.ToString() ?? string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los datos del cliente: {ex.Message}");
                }
            }
        }

    }
}
