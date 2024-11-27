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

namespace GUI
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        BLLUsuario gestorUsuario = new BLLUsuario();
        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                bool valido = true;
                Usuario usuario = new Usuario();

                // Validaciones con REGEX
                if (!lblTxtBoxDNI.Validar())
                {
                    MessageBox.Show("DNI inválido. Debe contener 7 u 8 dígitos.");
                    valido = false;
                }
                if (!lblTxtBoxNombre.Validar())
                {
                    MessageBox.Show("Nombre inválido. Solo se permiten letras y espacios.");
                    valido = false;
                }
                if (!lblTxtBoxApellido.Validar())
                {
                    MessageBox.Show("Apellido inválido. Solo se permiten letras y espacios.");
                    valido = false;
                }
                if (!lblTxtBoxTelefono.Validar())
                {
                    MessageBox.Show("Teléfono inválido. Solo se permiten números (8 a 15 dígitos).");
                    valido = false;
                }

                if (lblTxtBoxContraseña.Texto != lblTxtBoxRepetirContraseña.Texto)
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                    valido = false;
                }
                else if (!lblTxtBoxContraseña.Validar())
                {
                    MessageBox.Show("Contraseña inválida. Debe contener al menos 8 caracteres, incluyendo una letra y un número.");
                    valido = false;
                }

                // Si todo es válido, registrar usuario
                if (valido)
                {
                    usuario.DNI = Convert.ToInt32(lblTxtBoxDNI.Texto);
                    usuario.Nombre = lblTxtBoxNombre.Texto;
                    usuario.Apellido = lblTxtBoxApellido.Texto;
                    usuario.Telefono = Convert.ToInt32(lblTxtBoxTelefono.Texto);

                    gestorUsuario.RegistrarUsuario(usuario, lblTxtBoxContraseña.Texto);
                    MessageBox.Show("Usuario registrado con éxito.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Register_Load(object sender, EventArgs e)
        {
            lblTxtBoxDNI.RegexPattern = @"^\d{7,8}$"; // Solo números, 7 u 8 dígitos
            lblTxtBoxNombre.RegexPattern = @"^[a-zA-Z\s]+$"; // Solo letras y espacios
            lblTxtBoxApellido.RegexPattern = @"^[a-zA-Z\s]+$"; // Solo letras y espacios
            lblTxtBoxTelefono.RegexPattern = @"^\d{8,15}$"; // Solo números, entre 8 y 15 dígitos
            lblTxtBoxContraseña.RegexPattern = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d@$!%*?&]{8,}$"; // Mínimo 8 caracteres, al menos una letra y un número
            lblTxtBoxRepetirContraseña.RegexPattern = lblTxtBoxContraseña.RegexPattern; // Misma validación que contraseña
        }
    }
}
