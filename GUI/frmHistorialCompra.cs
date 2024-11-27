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
    public partial class frmHistorialCompra : Form
    {
        Usuario loginUser;
        public frmHistorialCompra(Usuario user)
        {
            InitializeComponent();
            loginUser = user;
            ActualizarDGV();
        }
        BLLVenta gestorVenta = new BLLVenta();
        private void ActualizarDGV()
        {
            dataGridViewHistorial.DataSource = null;
            dataGridViewHistorial.DataSource = gestorVenta.ListarVentasPorDNI(loginUser);
        }

        private void lblDataGrid1_Load(object sender, EventArgs e)
        {
            ActualizarDGV();
        }
    }
}
