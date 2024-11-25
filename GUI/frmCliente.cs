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
    public partial class frmCliente : Form
    {
        Usuario loginUser;
        public frmCliente(Usuario user)
        {
            InitializeComponent();
            loginUser = user;
            crearDG();
            cargarCmb();
        }

        BLLProducto gestorProducto = new BLLProducto();
        BLLMedioDePago gestorMedioPago = new BLLMedioDePago();

        private void crearDG()
        {
            DGdetalleView.AutoGenerateColumns = false;
            DGdetalleView.Columns.Add("NombreProducto", "Nombre Producto");
            DGdetalleView.Columns.Add("Cantidad", "Cantidad");
            DGdetalleView.Columns.Add("Sub total", "Sub total");
            DGdetalleView.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood;
        }

        private void cargarCmb()
        {
            cmbProducto.DataSource = null;
            cmbProducto.DataSource = gestorProducto.ListarProducto();
            cmbProducto.DisplayMember = "NombreProducto";
            cmbProducto.ValueMember = "idProducto";

            cmbTarjeta.DataSource = null;
            cmbTarjeta.DataSource = gestorMedioPago.ListarMedioDePago(loginUser.DNI);
            cmbTarjeta.DisplayMember = "NroTarjeta";
        }

        private void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.idProducto = Convert.ToInt32(cmbProducto.Text);
            p.NombreProducto = cmbProducto.Text;
            int precioProducto = gestorProducto.getPrecioProducto(p);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int subtotal = precioProducto * cantidad;
            DGdetalleView.Rows.Add(p.NombreProducto, cantidad,subtotal);
        }

        private void DGdetalleView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
