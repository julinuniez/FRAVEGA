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
using System.Text.RegularExpressions;

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
            // Validar campos antes de procesar
            if (!ValidarNombreCategoria(txtNombreCategoria.Text))
            {
                MessageBox.Show("El nombre de la categoría debe contener al menos 3 caracteres alfabéticos.");
                return;
            }

            if (!ValidarDescripcion(txtDescripcion.Text))
            {
                MessageBox.Show("La descripción debe contener al menos 10 caracteres válidos (letras, números, espacios, comas, puntos).");
                return;
            }

            // Intentar agregar la categoría si las validaciones son exitosas
            try
            {
                Categoria categoria = new Categoria
                {
                    NombreCategoria = txtNombreCategoria.Text,
                    Descripcion = txtDescripcion.Text
                };
                gestorCategoria.AgregarCategoria(categoria);
                ActualizarListaCategorias();
                MessageBox.Show("Categoría agregada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al agregar la categoría: {ex.Message}");
            }
        }

        public void ActualizarListaCategorias()
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = gestorCategoria.ListarCategoria();
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            // Validar campos antes de procesar
            if (!ValidarNombreCategoria(txtNombreCategoria.Text))
            {
                MessageBox.Show("El nombre de la categoría debe contener al menos 3 caracteres alfabéticos.");
                return;
            }

            if (!ValidarDescripcion(txtDescripcion.Text))
            {
                MessageBox.Show("La descripción debe contener al menos 10 caracteres válidos (letras, números, espacios, comas, puntos).");
                return;
            }

            // Intentar modificar la categoría si las validaciones son exitosas
            try
            {
                Categoria categoria = new Categoria
                {
                    idCategoria = Convert.ToInt32(txtIdCategoria.Text),
                    NombreCategoria = txtNombreCategoria.Text,
                    Descripcion = txtDescripcion.Text
                };
                gestorCategoria.ActualizarCategoria(categoria);
                ActualizarListaCategorias();
                MessageBox.Show("Categoría modificada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al modificar la categoría: {ex.Message}");
            }
        }

        private bool ValidarNombreCategoria(string nombre)
        {
            string pattern = @"^[a-zA-Z\s]{3,}$"; // Letras y espacios, mínimo 3 caracteres
            return Regex.IsMatch(nombre, pattern);
        }

        private bool ValidarDescripcion(string descripcion)
        {
            string pattern = @"^[\w\s,.]{10,}$"; // Letras, números, espacios, comas, puntos, mínimo 10 caracteres
            return Regex.IsMatch(descripcion, pattern);
        }

        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria categoria = new Categoria();
                categoria.idCategoria = Convert.ToInt32(txtIdCategoria.Text);
                gestorCategoria.EliminarCategoria(categoria);
                ActualizarListaCategorias();
                MessageBox.Show("Categoria eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCategorias.Rows[e.RowIndex];
                txtIdCategoria.Text = row.Cells["idCategoria"].Value.ToString();
                txtNombreCategoria.Text = row.Cells["NombreCategoria"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                gestorCategoria.generarXML();
                MessageBox.Show("XML Categorias generado correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
