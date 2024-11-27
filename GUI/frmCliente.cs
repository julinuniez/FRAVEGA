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
    public partial class frmCliente : Form
    {
        int total = 0;
        Usuario loginUser;
        public frmCliente(Usuario user)
        {
            InitializeComponent();
            loginUser = user;
            crearDG();
            cargarCmb();
        }

        BLLProducto gestorProducto = new BLLProducto();
        BLLMedioDePago gestorMedioPago = new BLLMedioDePago();
        BLLDetalleVenta gestorDetalleVenta = new BLLDetalleVenta();
        BLLVenta gestorVenta = new BLLVenta();

        private void crearDG()
        {
            DGdetalleView.AutoGenerateColumns = false;
            DGdetalleView.EditMode = DataGridViewEditMode.EditOnEnter;
            
            DGdetalleView.Columns.Add("NombreProducto", "Nombre Producto");
            DGdetalleView.Columns.Add("Cantidad", "Cantidad");
            DGdetalleView.Columns.Add("Sub total", "Sub total");

            DGdetalleView.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood;
            
        }
        private DataGridViewButtonColumn CrearBotonElimninarDGV()
        {
            DataGridViewButtonColumn BtnEliminarColumna = new DataGridViewButtonColumn();
            BtnEliminarColumna.HeaderText = "Eliminar";
            BtnEliminarColumna.Name = "Eliminar";
            BtnEliminarColumna.Text = "Eliminar";
            BtnEliminarColumna.UseColumnTextForButtonValue = true;

            if (DGdetalleView.Columns["Eliminar"] == null)
            {
                DGdetalleView.Columns.Insert(0, BtnEliminarColumna);
            }
            return BtnEliminarColumna;
        }

        private void cargarCmb()
        {
            cmbProducto.DataSource = null;
            cmbProducto.DataSource = gestorProducto.ListarProducto();
            cmbProducto.DisplayMember = "NombreProducto";
            cmbProducto.ValueMember = "idProducto";

            cmbTarjeta.DataSource = null;
            cmbTarjeta.DataSource = gestorMedioPago.ListarMedioDePago(loginUser.DNI);
            cmbTarjeta.DisplayMember = "NroTarjeta";
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            lblNroVenta.Text = (gestorVenta.getNroVenta()).ToString();
        }

        private void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {
            // Validar la cantidad ingresada
            if (!ValidarCantidad(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida (número entero positivo).");
                return;
            }

            // Validar que se haya seleccionado un producto
            if (string.IsNullOrWhiteSpace(cmbProducto.Text))
            {
                MessageBox.Show("Por favor, seleccione un producto válido.");
                return;
            }

            // Procesar los datos después de validar
            try
            {
                string nombre = cmbProducto.Text;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                Producto producto = gestorProducto.ListarProducto().Find(x => x.NombreProducto == nombre);

                if (producto == null)
                {
                    MessageBox.Show("Producto no encontrado en la base de datos.");
                    return;
                }

                decimal subtotal = producto.Precio * cantidad;

                // Agregar al DataGridView
                DGdetalleView.Rows.Add(nombre, cantidad, subtotal);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al agregar el producto: {ex.Message}");
            }
        }
        private bool ValidarCantidad(string cantidad)
        {
            string pattern = @"^\d+$"; // Solo números enteros positivos
            return Regex.IsMatch(cantidad, pattern);
        }


        private void btnSeleccionarProducto_Click_1(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.idProducto = gestorProducto.getIdProducto(cmbProducto.Text);
            p.NombreProducto = cmbProducto.Text;
            int precioProducto = Convert.ToInt32(gestorProducto.getPrecioProducto(p.idProducto));
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int subtotal = precioProducto * cantidad;
            if (gestorProducto.validarCantidadProductos(p, cantidad))
            {
                DGdetalleView.Rows.Add(CrearBotonElimninarDGV(), p.NombreProducto, cantidad, subtotal);
                total += subtotal;
                lblMonto.Text = total.ToString();
            }
            else
                MessageBox.Show("no hay suficiente stock");
        }

        private void DGdetalleView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGdetalleView.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                // Confirmación opcional
                var confirmar = MessageBox.Show("¿Estás seguro de que deseas eliminar esta fila?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes)
                {

                    DGdetalleView.Rows.RemoveAt(e.RowIndex);
                    //total -= Convert.ToInt32(DGdetalleView.Rows[e.RowIndex].Cells[3].Value);
                    ActualizarMontoAcumulado();
                }
            }
        }

        private void ActualizarMontoAcumulado()
        {
            int total = 0;
            foreach (DataGridViewRow row in DGdetalleView.Rows)
            {
                total += Convert.ToInt32(row.Cells[3].Value);
            }
            lblMonto.Text = total.ToString();
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {

            try
            {
                int totalVenta = 0;
                if (gestorMedioPago.ValidarMedioDePago(cmbTarjeta.Text, Convert.ToInt32(txtCvv.Text)))
                {

                    foreach (DataGridViewRow row in DGdetalleView.Rows)
                    {
                        DetalleVenta Detalle = new DetalleVenta();
                        Detalle.nroVenta = Convert.ToInt32(lblNroVenta.Text);
                        Detalle.idProducto = gestorProducto.getIdProducto(row.Cells[1].Value.ToString());
                        Detalle.Cantidad = Convert.ToInt32(row.Cells[2].Value);
                        Detalle.Subtotal = Convert.ToInt32(row.Cells[3].Value);
                        totalVenta += Convert.ToInt32(Detalle.Subtotal);
                        gestorDetalleVenta.AgregarDetalleVenta(Detalle);
                    }
                    Venta venta = new Venta();
                    venta.DNI = loginUser.DNI;
                    venta.total = totalVenta;
                    venta.fecha = DateTime.Now;
                    venta.nroTarjeta = Convert.ToString(cmbTarjeta.Text);
                    gestorVenta.AgregarVenta(venta);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
