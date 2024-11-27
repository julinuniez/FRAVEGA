namespace GUI
{
    partial class frmMedioPago
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarMedioPago = new System.Windows.Forms.Button();
            this.btnEliminarMedioPago = new System.Windows.Forms.Button();
            this.cmbTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.txtFechaCaducidad = new System.Windows.Forms.MaskedTextBox();
            this.dgvMediosDePago = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMediosDePago)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "MEDIOS DE PAGO";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(71, 132);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(121, 20);
            this.txtNumero.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Numero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Tarjeta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Fecha Caducidad";
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(71, 288);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(121, 20);
            this.txtCVV.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "CVV (Codigo de seguridad)";
            // 
            // btnAgregarMedioPago
            // 
            this.btnAgregarMedioPago.Location = new System.Drawing.Point(252, 132);
            this.btnAgregarMedioPago.Name = "btnAgregarMedioPago";
            this.btnAgregarMedioPago.Size = new System.Drawing.Size(84, 46);
            this.btnAgregarMedioPago.TabIndex = 64;
            this.btnAgregarMedioPago.Text = "Agregar";
            this.btnAgregarMedioPago.UseVisualStyleBackColor = true;
            this.btnAgregarMedioPago.Click += new System.EventHandler(this.btnAgregarMedioPago_Click);
            // 
            // btnEliminarMedioPago
            // 
            this.btnEliminarMedioPago.Location = new System.Drawing.Point(252, 189);
            this.btnEliminarMedioPago.Name = "btnEliminarMedioPago";
            this.btnEliminarMedioPago.Size = new System.Drawing.Size(84, 46);
            this.btnEliminarMedioPago.TabIndex = 66;
            this.btnEliminarMedioPago.Text = "Eliminar";
            this.btnEliminarMedioPago.UseVisualStyleBackColor = true;
            this.btnEliminarMedioPago.Click += new System.EventHandler(this.btnEliminarMedioPago_Click);
            // 
            // cmbTipoTarjeta
            // 
            this.cmbTipoTarjeta.FormattingEnabled = true;
            this.cmbTipoTarjeta.Location = new System.Drawing.Point(71, 181);
            this.cmbTipoTarjeta.Name = "cmbTipoTarjeta";
            this.cmbTipoTarjeta.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoTarjeta.TabIndex = 67;
            // 
            // txtFechaCaducidad
            // 
            this.txtFechaCaducidad.Location = new System.Drawing.Point(71, 235);
            this.txtFechaCaducidad.Mask = "00/00/0000";
            this.txtFechaCaducidad.Name = "txtFechaCaducidad";
            this.txtFechaCaducidad.Size = new System.Drawing.Size(121, 20);
            this.txtFechaCaducidad.TabIndex = 68;
            this.txtFechaCaducidad.ValidatingType = typeof(System.DateTime);
            // 
            // dgvMediosDePago
            // 
            this.dgvMediosDePago.AllowUserToAddRows = false;
            this.dgvMediosDePago.AllowUserToDeleteRows = false;
            this.dgvMediosDePago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMediosDePago.Location = new System.Drawing.Point(353, 116);
            this.dgvMediosDePago.Name = "dgvMediosDePago";
            this.dgvMediosDePago.ReadOnly = true;
            this.dgvMediosDePago.Size = new System.Drawing.Size(446, 266);
            this.dgvMediosDePago.TabIndex = 69;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 45);
            this.button1.TabIndex = 70;
            this.button1.Text = "GenerarXML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMedioPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvMediosDePago);
            this.Controls.Add(this.txtFechaCaducidad);
            this.Controls.Add(this.cmbTipoTarjeta);
            this.Controls.Add(this.btnEliminarMedioPago);
            this.Controls.Add(this.btnAgregarMedioPago);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Name = "frmMedioPago";
            this.Text = "frmMedioPago";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMediosDePago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarMedioPago;
        private System.Windows.Forms.Button btnEliminarMedioPago;
        private System.Windows.Forms.ComboBox cmbTipoTarjeta;
        private System.Windows.Forms.MaskedTextBox txtFechaCaducidad;
        private System.Windows.Forms.DataGridView dgvMediosDePago;
        private System.Windows.Forms.Button button1;
    }
}