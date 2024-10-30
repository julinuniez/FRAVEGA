using BE;
using BLL;
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

namespace GUI
{
    public partial class frmProductos : Form
    {
        ProductoBLL gestorProducto = new ProductoBLL();
        BLLCategoria gestorCategoria = new BLLCategoria();
        public frmProductos()
        {
            InitializeComponent();
            ActualizarDGVProductos();
            ActualizarCmbCategoria();
        }
        private void ActualizarDGVProductos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = gestorProducto.ListarProductos();
        }

        private void ActualizarCmbCategoria()
        {
            cmbCategoria.DataSource = gestorCategoria.ListarCategoria();
            cmbCategoria.DisplayMember = "NombreCategoria";
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.NombreProducto = txtNombreProducto.Text;
            producto.Descripcion = txtDescripcion.Text;
            producto.idCategoria = gestorCategoria.getIdCategoria(cmbCategoria.Text);
            producto.Stock = Convert.ToInt32(txtStock.Text);
            producto.Precio = Convert.ToDecimal(txtPrecio.Text);
            gestorProducto.AgregarProducto(producto);
            ActualizarDGVProductos();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreProducto.Text = dgvProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDescripcion.Text = dgvProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbCategoria.Text = gestorCategoria.getNombreCategoria(Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells[3].Value.ToString()));
            txtStock.Text = dgvProductos.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPrecio.Text = dgvProductos.Rows[e.RowIndex].Cells[5].Value.ToString();

            
        }
    }
}
