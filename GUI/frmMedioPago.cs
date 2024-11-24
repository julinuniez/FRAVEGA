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
            crearDG();
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
        private void crearDG()
        {
            dgvMediosDePago.AutoGenerateColumns = false;
            dgvMediosDePago.Columns.Add("nroTarjeta", "Numero de tarjeta");
            dgvMediosDePago.Columns.Add("idTipoTarjeta", "Tipo de tarjeta");
            dgvMediosDePago.Columns.Add("DNI", "DNI");
            dgvMediosDePago.Columns.Add("fechacaducida", "Fecha de caducidad");
            dgvMediosDePago.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood;
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


     
    }
}
