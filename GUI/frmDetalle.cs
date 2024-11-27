using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;

namespace GUI
{
    public partial class frmDetalle : Form
    {
        public frmDetalle()
        {
            InitializeComponent();
            ActualizarListaVentas();
        }
        BLLDetalleVenta gestorDetalleVenta = new BLLDetalleVenta();
        BLLVenta gestorVenta = new BLLVenta();


        public void ActualizarListaVentas()
        {
            dataGridViewHistorial.DataSource = null;
            dataGridViewHistorial.DataSource = gestorVenta.ListarVentas();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            gestorVenta.generarXMLVenta();
        }

        private void dataGridViewHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dataGridViewHistorial.Rows[e.RowIndex];
                    gestorDetalleVenta.ListarDetalleVenta(Convert.ToInt32(row.Cells["nroVenta"].Value));

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
