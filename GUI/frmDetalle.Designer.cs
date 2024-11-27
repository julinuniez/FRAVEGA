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
            this.lblMonto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDetalleVentas = new System.Windows.Forms.DataGridView();
            this.dataGridViewHistorial = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorial)).BeginInit();
            this.SuspendLayout();
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
            this.label2.Location = new System.Drawing.Point(106, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "HISTORIAL DE VENTAS";
            // 
            // dgvDetalleVentas
            // 
            this.dgvDetalleVentas.AllowUserToAddRows = false;
            this.dgvDetalleVentas.AllowUserToDeleteRows = false;
            this.dgvDetalleVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVentas.Location = new System.Drawing.Point(512, 72);
            this.dgvDetalleVentas.Name = "dgvDetalleVentas";
            this.dgvDetalleVentas.ReadOnly = true;
            this.dgvDetalleVentas.Size = new System.Drawing.Size(474, 425);
            this.dgvDetalleVentas.TabIndex = 37;
            // 
            // dataGridViewHistorial
            // 
            this.dataGridViewHistorial.AllowUserToAddRows = false;
            this.dataGridViewHistorial.AllowUserToDeleteRows = false;
            this.dataGridViewHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistorial.Location = new System.Drawing.Point(12, 72);
            this.dataGridViewHistorial.Name = "dataGridViewHistorial";
            this.dataGridViewHistorial.ReadOnly = true;
            this.dataGridViewHistorial.Size = new System.Drawing.Size(494, 425);
            this.dataGridViewHistorial.TabIndex = 38;
            this.dataGridViewHistorial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHistorial_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 46);
            this.button1.TabIndex = 39;
            this.button1.Text = "Generar XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(616, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "DETALLES DE VENTAS";
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(998, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewHistorial);
            this.Controls.Add(this.dgvDetalleVentas);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.label2);
            this.Name = "frmDetalle";
            this.Text = "frmDetalle";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDetalleVentas;
        private System.Windows.Forms.DataGridView dataGridViewHistorial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}