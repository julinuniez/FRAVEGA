namespace GUI
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCvv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTarjeta = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSeleccionarProducto = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNroVenta = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFinalizarVenta = new System.Windows.Forms.Button();
            this.DGdetalleView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGdetalleView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtCvv);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cmbTarjeta);
            this.panel3.Location = new System.Drawing.Point(35, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 101);
            this.panel3.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.label3.Location = new System.Drawing.Point(5, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 67;
            this.label3.Text = "Cvv";
            // 
            // txtCvv
            // 
            this.txtCvv.Location = new System.Drawing.Point(4, 78);
            this.txtCvv.Name = "txtCvv";
            this.txtCvv.Size = new System.Drawing.Size(153, 20);
            this.txtCvv.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.label9.Location = new System.Drawing.Point(2, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "Elegir Nro Tarjeta";
            // 
            // cmbTarjeta
            // 
            this.cmbTarjeta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTarjeta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarjeta.FormattingEnabled = true;
            this.cmbTarjeta.Location = new System.Drawing.Point(3, 26);
            this.cmbTarjeta.Name = "cmbTarjeta";
            this.cmbTarjeta.Size = new System.Drawing.Size(150, 21);
            this.cmbTarjeta.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.txtCantidad);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnSeleccionarProducto);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmbProducto);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(34, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 168);
            this.panel2.TabIndex = 61;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(9, 105);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(153, 20);
            this.txtCantidad.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.label2.Location = new System.Drawing.Point(17, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 65;
            this.label2.Text = "Cantidad";
            // 
            // btnSeleccionarProducto
            // 
            this.btnSeleccionarProducto.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnSeleccionarProducto.Location = new System.Drawing.Point(9, 131);
            this.btnSeleccionarProducto.Name = "btnSeleccionarProducto";
            this.btnSeleccionarProducto.Size = new System.Drawing.Size(118, 34);
            this.btnSeleccionarProducto.TabIndex = 64;
            this.btnSeleccionarProducto.Text = "Seleccionar";
            this.btnSeleccionarProducto.UseVisualStyleBackColor = true;
            this.btnSeleccionarProducto.Click += new System.EventHandler(this.btnSeleccionarProducto_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Producto";
            // 
            // cmbProducto
            // 
            this.cmbProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(9, 55);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(153, 21);
            this.cmbProducto.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "SELECCION DE PRODUCTOS";
            // 
            // lblNroVenta
            // 
            this.lblNroVenta.AutoSize = true;
            this.lblNroVenta.Location = new System.Drawing.Point(172, 383);
            this.lblNroVenta.Name = "lblNroVenta";
            this.lblNroVenta.Size = new System.Drawing.Size(52, 13);
            this.lblNroVenta.TabIndex = 60;
            this.lblNroVenta.Text = "---------------";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(172, 406);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(52, 13);
            this.lblMonto.TabIndex = 59;
            this.lblMonto.Text = "---------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.label4.Location = new System.Drawing.Point(35, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 18);
            this.label4.TabIndex = 58;
            this.label4.Text = "Monto Acumulado: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.label1.Location = new System.Drawing.Point(35, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 63;
            this.label1.Text = "Numero Venta: ";
            // 
            // btnFinalizarVenta
            // 
            this.btnFinalizarVenta.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnFinalizarVenta.Location = new System.Drawing.Point(35, 424);
            this.btnFinalizarVenta.Name = "btnFinalizarVenta";
            this.btnFinalizarVenta.Size = new System.Drawing.Size(127, 60);
            this.btnFinalizarVenta.TabIndex = 66;
            this.btnFinalizarVenta.Text = "Finalizar Venta";
            this.btnFinalizarVenta.UseVisualStyleBackColor = true;
            this.btnFinalizarVenta.Click += new System.EventHandler(this.btnFinalizarVenta_Click);
            // 
            // DGdetalleView
            // 
            this.DGdetalleView.AllowUserToAddRows = false;
            this.DGdetalleView.AllowUserToDeleteRows = false;
            this.DGdetalleView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGdetalleView.Location = new System.Drawing.Point(322, 63);
            this.DGdetalleView.Name = "DGdetalleView";
            this.DGdetalleView.ReadOnly = true;
            this.DGdetalleView.Size = new System.Drawing.Size(415, 406);
            this.DGdetalleView.TabIndex = 67;
            this.DGdetalleView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGdetalleView_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(318, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 24);
            this.label5.TabIndex = 68;
            this.label5.Text = "Realizar Compra";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(761, 492);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DGdetalleView);
            this.Controls.Add(this.btnFinalizarVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblNroVenta);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.label4);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGdetalleView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNroVenta;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSeleccionarProducto;
        private System.Windows.Forms.Button btnFinalizarVenta;
        private System.Windows.Forms.DataGridView DGdetalleView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTarjeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCvv;
    }
}