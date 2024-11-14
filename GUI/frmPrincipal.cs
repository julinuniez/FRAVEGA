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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void LimpiarPanel()
        {
            panelPrincipal.Controls.Clear();
        }   

        private void gESTIONARTARJETAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            frmProducto frm = new frmProducto();
            this.Width = frm.Width;
            this.Height = frm.Height+40;
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(frm);
            frm.Show();
        }

        private void gestionarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            frmCategoria frm = new frmCategoria();
            this.Width = frm.Width;
            this.Height = frm.Height+40;
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(frm);
            frm.Show();
        }

        private void verInformesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            frmDetalle frm = new frmDetalle();
            this.Width = frm.Width;
            this.Height = frm.Height + 40;
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(frm);
            frm.Show();
        }

        private void gestionarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            frmGestionCliente frm = new frmGestionCliente();
            this.Width = frm.Width;
            this.Height = frm.Height + 40;
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(frm);
            frm.Show();
        }
    }
}
