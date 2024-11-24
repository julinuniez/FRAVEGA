using BE;
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
    public partial class frmPrincipalCliente : Form
    {
        Usuario loginUser;
        public frmPrincipalCliente(Usuario user)
        {
            InitializeComponent();
            loginUser = user;
        }
        private void LimpiarPanel()
        {
            panel.Controls.Clear();
        }
        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            frmCliente frm = new frmCliente(loginUser);
            this.Width = frm.Width;
            this.Height = frm.Height + 40;
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
            frm.Show();
        }

        private void mediosDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            frmMedioPago frm = new frmMedioPago(loginUser);
            this.Width = frm.Width;
            this.Height = frm.Height + 40;
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
            frm.Show();
        }
    }
}
