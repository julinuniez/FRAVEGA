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

        public void ActualizarListaDetallesDeVenta(int nroVenta)
        {
            dgvVentas.DataSource = null;
            dgvVentas.DataSource = gestorDetalleVenta.ListarDetalleVenta(nroVenta);
        }

        public void ActualizarListaVentas()
        {
            dgvVentas.DataSource = null;
            dgvVentas.DataSource = gestorVenta.ListarVentas();
        }

        private void btnMostrarDetalleVenta_Click(object sender, EventArgs e)
        {
            try
            {
                ActualizarListaDetallesDeVenta(Convert.ToInt32(cmbNumeroVenta.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
