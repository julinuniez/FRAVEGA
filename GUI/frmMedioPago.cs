using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            // Validar datos
            if (!ValidarNumeroTarjeta(txtNumero.Text))
            {
                MessageBox.Show("Por favor, ingrese un número de tarjeta válido (16 dígitos).");
                return;
            }

            if (!ValidarFechaCaducidad(txtFechaCaducidad.Text))
            {
                MessageBox.Show("Por favor, ingrese una fecha de caducidad válida (formato MM/AA o MM/YYYY, y debe ser futura).");
                return;
            }

            if (!ValidarCVV(txtCVV.Text))
            {
                MessageBox.Show("Por favor, ingrese un CVV válido (3 o 4 dígitos).");
                return;
            }

            // Procesar la adición del medio de pago
            try
            {
                MedioDePago medioPago = new MedioDePago
                {
                    nroTarjeta = Convert.ToString(txtNumero.Text), // Usar `long` para tarjetas largas
                    FechaCaducidad = Convert.ToDateTime($"01/{txtFechaCaducidad.Text}"), // Agregar día ficticio
                    cvv = Convert.ToInt32(txtCVV.Text)
                };

                gestorMedioPago.AgregarMedioDePago(medioPago);
                ActualizarListaMedioPago();
                MessageBox.Show("Medio de pago agregado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al agregar el medio de pago: {ex.Message}");
            }
        }

        private bool ValidarNumeroTarjeta(string numero)
        {
            string pattern = @"^\d{16}$"; // Solo números, exactamente 16 dígitos
            return Regex.IsMatch(numero, pattern);
        }

        private bool ValidarFechaCaducidad(string fechaCaducidad)
        {
            string pattern = @"^(0[1-9]|1[0-2])/(?:\d{2}|\d{4})$"; // Formato MM/AA o MM/YYYY
            if (!Regex.IsMatch(fechaCaducidad, pattern)) return false;

            // Verificar si la fecha es futura
            try
            {
                string[] partes = fechaCaducidad.Split('/');
                int mes = Convert.ToInt32(partes[0]);
                int anio = partes[1].Length == 2 ? 2000 + Convert.ToInt32(partes[1]) : Convert.ToInt32(partes[1]);
                DateTime fecha = new DateTime(anio, mes, 1);
                return fecha > DateTime.Now;
            }
            catch
            {
                return false;
            }
        }

        private bool ValidarCVV(string cvv)
        {
            string pattern = @"^\d{3,4}$"; // Solo números, 3 o 4 dígitos
            return Regex.IsMatch(cvv, pattern);
        }

        private void btnEliminarMedioPago_Click(object sender, EventArgs e)
        {
            // Validar número de tarjeta
            if (!ValidarNumeroTarjeta(txtNumero.Text))
            {
                MessageBox.Show("Por favor, ingrese un número de tarjeta válido (16 dígitos).");
                return;
            }

            // Procesar la eliminación
            try
            {
                MedioDePago medioPago = new MedioDePago
                {
                    nroTarjeta = Convert.ToString(txtNumero.Text)
                };

                gestorMedioPago.EliminarMedioDePago(medioPago.nroTarjeta);
                MessageBox.Show("Medio de pago eliminado correctamente");
                ActualizarListaMedioPago();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al eliminar el medio de pago: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gestorMedioPago.generarXML();
        }
    }
}
