namespace GUI
{
    partial class frmCategoria
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "CATEGORIAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre";
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(28, 220);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(84, 46);
            this.btnAgregarCategoria.TabIndex = 38;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Location = new System.Drawing.Point(28, 116);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(84, 20);
            this.txtNombreCategoria.TabIndex = 37;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(316, 48);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.Size = new System.Drawing.Size(604, 431);
            this.dgvCategorias.TabIndex = 36;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(28, 178);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(84, 20);
            this.txtDescripcion.TabIndex = 39;
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Location = new System.Drawing.Point(28, 285);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(84, 46);
            this.btnModificarCategoria.TabIndex = 40;
            this.btnModificarCategoria.Text = "Modificar";
            this.btnModificarCategoria.UseVisualStyleBackColor = true;

            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Crimson;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(845, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 41;
            this.btnSalir.Text = "Volver";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Location = new System.Drawing.Point(156, 116);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(84, 20);
            this.txtIdCategoria.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "ID Categoria";
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 510);
            this.Controls.Add(this.txtIdCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.txtNombreCategoria);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCategoria";
            this.Text = "frmCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtIdCategoria;
        private System.Windows.Forms.Label label3;
    }
}