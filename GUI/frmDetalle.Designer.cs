namespace GUI
{
    partial class frmDetalle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMostrarDetalleVenta = new System.Windows.Forms.Button();
            this.cmbNumeroVenta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblMonto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDetalleVentas = new System.Windows.Forms.DataGridView();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.btnXML = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMostrarDetalleVenta);
            this.panel1.Controls.Add(this.cmbNumeroVenta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(638, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 97);
            this.panel1.TabIndex = 27;
            // 
            // btnMostrarDetalleVenta
            // 
            this.btnMostrarDetalleVenta.Location = new System.Drawing.Point(3, 51);
            this.btnMostrarDetalleVenta.Name = "btnMostrarDetalleVenta";
            this.btnMostrarDetalleVenta.Size = new System.Drawing.Size(102, 43);
            this.btnMostrarDetalleVenta.TabIndex = 39;
            this.btnMostrarDetalleVenta.Text = "Mostrar";
            this.btnMostrarDetalleVenta.UseVisualStyleBackColor = true;
            this.btnMostrarDetalleVenta.Click += new System.EventHandler(this.btnMostrarDetalleVenta_Click);
            // 
            // cmbNumeroVenta
            // 
            this.cmbNumeroVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumeroVenta.FormattingEnabled = true;
            this.cmbNumeroVenta.Location = new System.Drawing.Point(3, 25);
            this.cmbNumeroVenta.Name = "cmbNumeroVenta";
            this.cmbNumeroVenta.Size = new System.Drawing.Size(121, 21);
            this.cmbNumeroVenta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de Venta";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Crimson;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalir.Location = new System.Drawing.Point(885, 23);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Volver";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(62, 213);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(0, 20);
            this.lblMonto.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "DETALLES DE VENTA";
            // 
            // dgvDetalleVentas
            // 
            this.dgvDetalleVentas.AllowUserToAddRows = false;
            this.dgvDetalleVentas.AllowUserToDeleteRows = false;
            this.dgvDetalleVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVentas.Location = new System.Drawing.Point(12, 271);
            this.dgvDetalleVentas.Name = "dgvDetalleVentas";
            this.dgvDetalleVentas.ReadOnly = true;
            this.dgvDetalleVentas.Size = new System.Drawing.Size(604, 307);
            this.dgvDetalleVentas.TabIndex = 37;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(12, 72);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.Size = new System.Drawing.Size(604, 176);
            this.dgvVentas.TabIndex = 38;
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(654, 271);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(89, 46);
            this.btnXML.TabIndex = 39;
            this.btnXML.Text = "Generar XML";
            this.btnXML.UseVisualStyleBackColor = true;
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 590);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.dgvDetalleVentas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.label2);
            this.Name = "frmDetalle";
            this.Text = "frmDetalle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbNumeroVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDetalleVentas;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnMostrarDetalleVenta;
        private System.Windows.Forms.Button btnXML;
    }
}