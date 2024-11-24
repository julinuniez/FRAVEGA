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
            try
            {
                Producto producto = new Producto();
                producto.NombreProducto = txtNombreProducto.Text;
                producto.Descripcion = txtDescripcion.Text;
                producto.Precio = Convert.ToDecimal(txtPrecio.Text);
                producto.Stock = Convert.ToInt32(txtStock.Text);
                producto.idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
                BLLProducto gestorProducto = new BLLProducto();
                gestorProducto.AgregarProducto(producto);
                MessageBox.Show("Producto agregado correctamente");
                ActualizarListaProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {

            try
            {
                Producto producto = new Producto();
                producto.idProducto = Convert.ToInt32(txtIdProducto.Text);
                BLLProducto gestorProducto = new BLLProducto();
                gestorProducto.EliminarProducto(producto);
                MessageBox.Show("Producto eliminado correctamente");
                ActualizarListaProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {

            try
            {
                Producto producto = new Producto();
                producto.idProducto = Convert.ToInt32(txtIdProducto.Text);
                producto.Descripcion = txtDescripcion.Text;
                producto.NombreProducto = txtNombreProducto.Text;
                producto.Precio = Convert.ToDecimal(txtPrecio.Text);
                producto.Stock = Convert.ToInt32(txtStock.Text);
                producto.idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
                BLLProducto gestorProducto = new BLLProducto();
                gestorProducto.ActualizarProducto(producto);
                MessageBox.Show("Producto modificado correctamente");
                ActualizarListaProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void btnGestionarCategorias_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimirProductosXML_Click(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                txtIdProducto.Text = row.Cells["idProducto"].Value.ToString();
                txtNombreProducto.Text = row.Cells["NombreProducto"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio"].Value.ToString();
                txtStock.Text = row.Cells["Stock"].Value.ToString();
                cmbCategoria.SelectedValue = row.Cells["idCategoria"].Value;

            }
        }
    }
}
