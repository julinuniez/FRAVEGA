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
            ActualizarListaVentas();
        }
        BLLDetalleVenta gestorDetalleVenta = new BLLDetalleVenta();
        BLLVenta gestorVenta = new BLLVenta();


        public void ActualizarListaVentas()
        {
            dataGridViewHistorial.DataSource = null;
            dataGridViewHistorial.DataSource = gestorVenta.ListarVentasPorDNI(loginUser);
        }


        private void dataGridViewHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dataGridViewHistorial.Rows[e.RowIndex];
                    dataGridViewDetalles.DataSource = null;
                    dataGridViewDetalles.DataSource = gestorDetalleVenta.ListarDetalleVenta(Convert.ToInt32(row.Cells["nroVenta"].Value));

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
