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
        {/*
            if(serviceController1.Status == ServiceControllerStatus.Stopped)
            {
                serviceController1.Start();
            }*/
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.DNI = Convert.ToInt32(txtDNI.Text);
            usuario.contraseña= txtContraseña.Text;
            gestorUsuario.Login(usuario.DNI,usuario.contraseña);

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
    }
}
