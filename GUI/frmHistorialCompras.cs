using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class frmHistorialCompras : Form
    {
        Usuario loginUser;
        public frmHistorialCompras(Usuario user)
        {
            InitializeComponent();
            loginUser = user;
            crearDG();
            crearDGDetalle();
        }
        BLLDetalleVenta gestorDetalleVenta = new BLLDetalleVenta();
        BLLVenta gestorVenta = new BLLVenta();
        BLLProducto gestorProducto = new BLLProducto();
        private void crearDG()
        {
            dataGridViewHistorial.AutoGenerateColumns = false;
            dataGridViewHistorial.EditMode = DataGridViewEditMode.EditOnEnter;

            dataGridViewHistorial.Columns.Add("NroVenta", "Numero de venta");
            dataGridViewHistorial.Columns.Add("total", "Total");
            dataGridViewHistorial.Columns.Add("fecha", "Fecha");
            dataGridViewHistorial.Columns.Add("nroTarjeta", "Numero de tarjeta");
            dataGridViewHistorial.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood;

            //dataGridViewHistorial.DataSource = null;
            //dataGridViewHistorial.DataSource = gestorVenta.ListarVentasPorDNI(loginUser);
            foreach (Venta v in gestorVenta.ListarVentasPorDNI(loginUser))
            {
                dataGridViewHistorial.Rows.Add(v.nroVenta, v.total, v.fecha, v.nroTarjeta);
            }

        }

        private void crearDGDetalle()
        {
            dataGridViewDetalles.AutoGenerateColumns = false;
            dataGridViewDetalles.EditMode = DataGridViewEditMode.EditOnEnter;

            dataGridViewDetalles.Columns.Add("Producto", "Producto");
            dataGridViewDetalles.Columns.Add("cantidad", "Cantidad");
            dataGridViewDetalles.Columns.Add("subtotal", "Subtotal");
            dataGridViewDetalles.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood;
        }

        private void dataGridViewHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dataGridViewHistorial.Rows[e.RowIndex];
                    dataGridViewDetalles.DataSource = null;
                    foreach (DetalleVenta dv in gestorDetalleVenta.ListarDetalleVenta(Convert.ToInt32(row.Cells["nroVenta"].Value)))
                    {
                        string nombreProducto = gestorProducto.getNombreProducto(dv.idProducto);
                        dataGridViewDetalles.Rows.Add(nombreProducto, dv.Cantidad, dv.Subtotal);
                    }
                    dataGridViewDetalles.DataSource = gestorDetalleVenta.ListarDetalleVenta(Convert.ToInt32(row.Cells["nroVenta"].Value));

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridViewDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
