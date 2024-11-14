using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;

namespace GUI
{
    public partial class frmCategoria : Form
    {

        public frmCategoria()
        {
            InitializeComponent();
            ActualizarListaCategorias();
        }

        BLLCategoria gestorCategoria = new BLLCategoria();

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria categoria = new Categoria();
                categoria.NombreCategoria = txtNombreCategoria.Text;
                categoria.Descripcion = txtDescripcion.Text;
                gestorCategoria.AgregarCategoria(categoria);
                ActualizarListaCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        /*
        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            try
            {

                Categoria categoria = new Categoria();
                categoria.idCategoria = Convert.ToInt32(txtIdCategoria.Text);
                categoria.NombreCategoria = txtNombreCategoria.Text;
                categoria.Descripcion = txtDescripcion.Text;
                gestorCategoria.ModificarCategoria();
                ActualizarListaCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

                private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria categoria = new Categoria();
                categoria.idCategoria = Convert.ToInt32(txtIdCategoria.Text);
                gestorCategoria.EliminarCategoria(categoria);
                ActualizarListaCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }   
        */

        public void ActualizarListaCategorias()
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = gestorCategoria.ListarCategoria();
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria categoria = new Categoria();
                categoria.idCategoria = Convert.ToInt32(txtIdCategoria.Text);
                categoria.NombreCategoria = txtNombreCategoria.Text;
                categoria.Descripcion = txtDescripcion.Text;
                gestorCategoria.ActualizarCategoria(categoria);
                ActualizarListaCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
