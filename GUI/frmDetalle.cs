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
            ActualizarListaDetallesDeVenta();
            ActualizarListaVentas();
        }
        BLLDetalleVenta gestorDetalleVenta = new BLLDetalleVenta();
        BLLVenta gestorVenta = new BLLVenta();

        public void ActualizarListaDetallesDeVenta()
        {
            dataGridView1.DataSource = null;
            //llenar...
        }

        public void ActualizarListaVentas()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestorVenta.ListarVentas();
        }

        private void btnMostrarDetalleVenta_Click(object sender, EventArgs e)
        {
            try
            {
                List<DetalleVenta> listaDetalleVenta = gestorDetalleVenta.ListarDetalleVenta(Convert.ToInt32(cmbNumeroVenta.Text));
                dgvDetalleVentas.DataSource = listaDetalleVenta;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
