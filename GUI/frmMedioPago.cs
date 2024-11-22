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
    public partial class frmMedioPago : Form
    {
        public frmMedioPago()
        {
            InitializeComponent();
            ActualizarListaMedioPago();
        }
        BLLMedioDePago gestorMedioPago = new BLLMedioDePago();
        private void btnAgregarMedioPago_Click(object sender, EventArgs e)
        {
            try
            {
                MedioDePago medioPago = new MedioDePago();
                medioPago.nroTarjeta = Convert.ToInt32(txtNumero.Text);
                medioPago.FechaCaducidad = Convert.ToDateTime(txtFechaCaducidad.Text);
                medioPago.cvv = Convert.ToInt32(txtCVV.Text);
                gestorMedioPago.AgregarMedioDePago(medioPago);
                MessageBox.Show("Medio de pago agregado correctamente");
                ActualizarListaMedioPago();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarMedioPago_Click(object sender, EventArgs e)
        {
            try
            {
                MedioDePago medioPago = new MedioDePago();
                medioPago.nroTarjeta = Convert.ToInt32(txtNumero.Text);
                gestorMedioPago.EliminarMedioDePago(medioPago.nroTarjeta);
                MessageBox.Show("Medio de pago eliminado correctamente");
                ActualizarListaMedioPago();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }


        public void ActualizarListaMedioPago()
        {
            int Dni = 0;
            dgvMediosDePago.DataSource = null;
            dgvMediosDePago.DataSource = gestorMedioPago.ListarMedioDePago(Dni);
        }
    }
}
