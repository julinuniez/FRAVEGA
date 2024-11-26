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
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
            ActualizarListaProductos();
            LlenarComboCategorias();
        }

        BLLProducto gestorProducto = new BLLProducto();
        BLLCategoria gestorCategoria = new BLLCategoria();

        public void ActualizarListaProductos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = gestorProducto.ListarProducto();
        }

        public void LlenarComboCategorias()
        {
            cmbCategoria.DataSource = gestorCategoria.ListarCategoria();
            cmbCategoria.DisplayMember = "NombreCategoria";
            cmbCategoria.ValueMember = "idCategoria";
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            // Validar los datos antes de procesar
            if (!ValidarCamposProducto())
                return;

            try
            {
                Producto producto = new Producto
                {
                    NombreProducto = txtNombreProducto.Text,
                    Descripcion = txtDescripcion.Text,
                    Precio = Convert.ToDecimal(txtPrecio.Text),
                    Stock = Convert.ToInt32(txtStock.Text),
                    idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue)
                };

                gestorProducto.AgregarProducto(producto);
                MessageBox.Show("Producto agregado correctamente");
                ActualizarListaProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el producto: {ex.Message}");
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdProducto.Text))
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.");
                return;
            }

            try
            {
                int idProducto = Convert.ToInt32(txtIdProducto.Text);
                gestorProducto.EliminarProducto(new Producto { idProducto = idProducto });
                MessageBox.Show("Producto eliminado correctamente");
                ActualizarListaProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el producto: {ex.Message}");
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            // Validar los datos antes de procesar
            if (!ValidarCamposProducto())
                return;

            try
            {
                Producto producto = new Producto
                {
                    idProducto = Convert.ToInt32(txtIdProducto.Text),
                    NombreProducto = txtNombreProducto.Text,
                    Descripcion = txtDescripcion.Text,
                    Precio = Convert.ToDecimal(txtPrecio.Text),
                    Stock = Convert.ToInt32(txtStock.Text),
                    idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue)
                };

                gestorProducto.ActualizarProducto(producto);
                MessageBox.Show("Producto modificado correctamente");
                ActualizarListaProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el producto: {ex.Message}");
            }
        }

        private void btnGestionarCategorias_Click(object sender, EventArgs e)
        {
            frmCategoria frm = new frmCategoria(); // Redirige a otro formulario para gestionar categorías
            frm.ShowDialog();
            LlenarComboCategorias(); // Actualiza la lista de categorías en caso de cambios
        }

        private void btnImprimirProductosXML_Click(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvProductos.Rows[e.RowIndex];
                    txtDescripcion.Text = row.Cells["Descripcion"].Value?.ToString() ?? string.Empty;
                    txtIdProducto.Text = row.Cells["idProducto"].Value?.ToString() ?? string.Empty;
                    txtNombreProducto.Text = row.Cells["NombreProducto"].Value?.ToString() ?? string.Empty;
                    txtPrecio.Text = row.Cells["Precio"].Value?.ToString() ?? string.Empty;
                    txtStock.Text = row.Cells["Stock"].Value?.ToString() ?? string.Empty;
                    cmbCategoria.SelectedValue = row.Cells["idCategoria"].Value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los datos del producto: {ex.Message}");
                }
            }
        }

        private bool ValidarCamposProducto()
        {
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("La descripción del producto es obligatoria.");
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido (mayor a 0).");
                return false;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Ingrese un stock válido (0 o mayor).");
                return false;
            }

            if (cmbCategoria.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una categoría.");
                return false;
            }

            return true;
        }
    }
}
