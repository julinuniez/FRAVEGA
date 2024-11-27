namespace GUI
{
    partial class frmHistorialCompras
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDetalles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewHistorial = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.label2.Location = new System.Drawing.Point(565, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Detalle de Compra";
            // 
            // dataGridViewDetalles
            // 
            this.dataGridViewDetalles.AllowUserToAddRows = false;
            this.dataGridViewDetalles.AllowUserToDeleteRows = false;
            this.dataGridViewDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalles.Location = new System.Drawing.Point(421, 54);
            this.dataGridViewDetalles.Name = "dataGridViewDetalles";
            this.dataGridViewDetalles.ReadOnly = true;
            this.dataGridViewDetalles.Size = new System.Drawing.Size(367, 371);
            this.dataGridViewDetalles.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.label1.Location = new System.Drawing.Point(107, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Historial de Compra";
            // 
            // dataGridViewHistorial
            // 
            this.dataGridViewHistorial.AllowUserToAddRows = false;
            this.dataGridViewHistorial.AllowUserToDeleteRows = false;
            this.dataGridViewHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistorial.Location = new System.Drawing.Point(12, 54);
            this.dataGridViewHistorial.Name = "dataGridViewHistorial";
            this.dataGridViewHistorial.ReadOnly = true;
            this.dataGridViewHistorial.Size = new System.Drawing.Size(361, 371);
            this.dataGridViewHistorial.TabIndex = 4;
            this.dataGridViewHistorial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHistorial_CellClick);
            // 
            // frmHistorialCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewDetalles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewHistorial);
            this.Name = "frmHistorialCompras";
            this.Text = "frmHistorialCompras";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDetalles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewHistorial;
    }
}