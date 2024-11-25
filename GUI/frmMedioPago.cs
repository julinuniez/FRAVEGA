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
        Usuario loginUser;
        public frmMedioPago(Usuario user)
        {
            InitializeComponent();
            loginUser = user;
            ActualizarListaMedioPago();
            CargarCBMTipoTarjeta();
            
        }
        BLLMedioDePago gestorMedioPago = new BLLMedioDePago();
        BLLTipoTarjeta gestorTipoTarjeta = new BLLTipoTarjeta();

        private void CargarCBMTipoTarjeta()
        {
            cmbTipoTarjeta.DataSource = null;
            cmbTipoTarjeta.DataSource = gestorTipoTarjeta.ListarTipoTarjeta();
            cmbTipoTarjeta.DisplayMember = "Nombre";
        }
        public void ActualizarListaMedioPago()
        {
            dgvMediosDePago.DataSource = null;
            dgvMediosDePago.DataSource = gestorMedioPago.ListarMedioDePago(loginUser.DNI);
        }
        private void btnAgregarMedioPago_Click(object sender, EventArgs e)
        {
            try
            {
                MedioDePago medioPago = new MedioDePago();
                medioPago.nroTarjeta = txtNumero.Text;
                medioPago.DNI = loginUser.DNI;
                medioPago.FechaCaducidad = Convert.ToDateTime(txtFechaCaducidad.Text);
                medioPago.cvv = Convert.ToInt32(txtCVV.Text);
                gestorMedioPago.AgregarMedioDePago(medioPago);
                ActualizarListaMedioPago();
                MessageBox.Show("Medio de pago agregado correctamente");
                
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
                medioPago.nroTarjeta = txtNumero.Text.ToString();
                gestorMedioPago.EliminarMedioDePago(medioPago.nroTarjeta);
                MessageBox.Show("Medio de pago eliminado correctamente");
                ActualizarListaMedioPago();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }


     
    }
}
