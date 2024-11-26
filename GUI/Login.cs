using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.ServiceProcess;
using BE;
using BLL;
namespace GUI
{
    public partial class Login : Form
    {
        BLLUsuario gestorUsuario = new BLLUsuario();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Patrones de validación
            lbltxtDNI.RegexPattern = @"^\d{7,8}$"; // Solo números, 7-8 dígitos
            lblTxtContraseña.RegexPattern = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d@$!%*?&]{8,}$"; // Mínimo 8 caracteres, al menos una letra y un número
        }


        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Validar campos
            if (!lbltxtDNI.Validar())
            {
                MessageBox.Show("DNI inválido. Debe contener 7 u 8 dígitos numéricos.");
                return;
            }

            if (!lblTxtContraseña.Validar())
            {
                MessageBox.Show("Contraseña inválida. Debe contener al menos 8 caracteres, incluyendo una letra y un número.");
                return;
            }

            // Intentar iniciar sesión si los datos son válidos
            try
            {
                Usuario usuario = new Usuario
                {
                    DNI = Convert.ToInt32(lbltxtDNI.Texto),
                    contraseña = lblTxtContraseña.Texto
                };

                Usuario logeado = gestorUsuario.Login(usuario.DNI, usuario.contraseña);

                if (logeado == null)
                {
                    MessageBox.Show("Credenciales incorrectas. Por favor, intente de nuevo.");
                    return;
                }

                // Redirigir según el tipo de usuario
                if (!logeado.admin)
                {
                    frmPrincipalCliente frmCliente = new frmPrincipalCliente(logeado);
                    this.Hide();
                    frmCliente.ShowDialog();
                    this.Close();
                }
                else
                {
                    frmPrincipal frm = new frmPrincipal();
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al iniciar sesión: {ex.Message}");
            }
        }


        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
           Registro frmRegistro = new Registro();
            this.Hide();
            frmRegistro.ShowDialog();
            this.Show();
        }

        private void btnAbrirNotepad_Click(object sender, EventArgs e)
        {
            process1.Start();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
