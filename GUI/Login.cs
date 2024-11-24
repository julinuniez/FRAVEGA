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
            if(lbltxtDNI.Validar() && lblTxtContraseña.Validar())
            {
                Usuario usuario = new Usuario();
                usuario.DNI = Convert.ToInt32(lbltxtDNI.Texto);
                usuario.contraseña = lblTxtContraseña.Texto;
                Usuario logeado = gestorUsuario.Login(usuario.DNI, usuario.contraseña);
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
