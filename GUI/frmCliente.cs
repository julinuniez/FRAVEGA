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
            DGdetalleView.EditMode = DataGridViewEditMode.EditOnEnter;
            
            DGdetalleView.Columns.Add("NombreProducto", "Nombre Producto");
            DGdetalleView.Columns.Add("Cantidad", "Cantidad");
            DGdetalleView.Columns.Add("Sub total", "Sub total");
            if (DGdetalleView.DataSource != null)
            {
                DataGridViewButtonColumn BtnEliminarColumna = new DataGridViewButtonColumn();
                BtnEliminarColumna.HeaderText = "Eliminar";
                BtnEliminarColumna.Name = "Eliminar";
                BtnEliminarColumna.Text = "Eliminar";
                BtnEliminarColumna.UseColumnTextForButtonValue = true;

                if (DGdetalleView.Columns["Eliminar"] == null)
                {
                    DGdetalleView.Columns.Insert(0, BtnEliminarColumna);
                }
            }
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
            string nombre = cmbProducto.Text;
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            decimal subtotal = gestorProducto.ListarProducto().Find(x => x.NombreProducto == nombre).Precio * cantidad;
            DGdetalleView.Rows.Add(nombre, cantidad, subtotal);
        }

        private void btnSeleccionarProducto_Click_1(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.idProducto = gestorProducto.getIdProducto(cmbProducto.Text);
            p.NombreProducto = cmbProducto.Text;
            decimal precioProducto = Convert.ToDecimal(gestorProducto.getPrecioProducto(p.idProducto));
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            decimal subtotal = precioProducto * cantidad;
            DGdetalleView.Rows.Add(p.NombreProducto, cantidad, subtotal);
        }
    }
}
