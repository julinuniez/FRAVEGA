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
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModificarMedioPago = new System.Windows.Forms.Button();
            this.btnAgregarMedioPago = new System.Windows.Forms.Button();
            this.btnEliminarMedioPago = new System.Windows.Forms.Button();
            this.cmbTarjeta = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
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
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Crimson;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(745, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 49;
            this.btnSalir.Text = "Volver";
            this.btnSalir.UseVisualStyleBackColor = false;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(71, 288);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 63;
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
            // btnModificarMedioPago
            // 
            this.btnModificarMedioPago.Location = new System.Drawing.Point(252, 244);
            this.btnModificarMedioPago.Name = "btnModificarMedioPago";
            this.btnModificarMedioPago.Size = new System.Drawing.Size(84, 46);
            this.btnModificarMedioPago.TabIndex = 65;
            this.btnModificarMedioPago.Text = "Modificar";
            this.btnModificarMedioPago.UseVisualStyleBackColor = true;
            // 
            // btnAgregarMedioPago
            // 
            this.btnAgregarMedioPago.Location = new System.Drawing.Point(252, 132);
            this.btnAgregarMedioPago.Name = "btnAgregarMedioPago";
            this.btnAgregarMedioPago.Size = new System.Drawing.Size(84, 46);
            this.btnAgregarMedioPago.TabIndex = 64;
            this.btnAgregarMedioPago.Text = "Agregar";
            this.btnAgregarMedioPago.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMedioPago
            // 
            this.btnEliminarMedioPago.Location = new System.Drawing.Point(252, 189);
            this.btnEliminarMedioPago.Name = "btnEliminarMedioPago";
            this.btnEliminarMedioPago.Size = new System.Drawing.Size(84, 46);
            this.btnEliminarMedioPago.TabIndex = 66;
            this.btnEliminarMedioPago.Text = "Eliminar";
            this.btnEliminarMedioPago.UseVisualStyleBackColor = true;
            // 
            // cmbTarjeta
            // 
            this.cmbTarjeta.FormattingEnabled = true;
            this.cmbTarjeta.Location = new System.Drawing.Point(71, 181);
            this.cmbTarjeta.Name = "cmbTarjeta";
            this.cmbTarjeta.Size = new System.Drawing.Size(121, 21);
            this.cmbTarjeta.TabIndex = 67;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(71, 235);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBox1.TabIndex = 68;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // frmMedioPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 469);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.cmbTarjeta);
            this.Controls.Add(this.btnEliminarMedioPago);
            this.Controls.Add(this.btnModificarMedioPago);
            this.Controls.Add(this.btnAgregarMedioPago);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmMedioPago";
            this.Text = "frmMedioPago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModificarMedioPago;
        private System.Windows.Forms.Button btnAgregarMedioPago;
        private System.Windows.Forms.Button btnEliminarMedioPago;
        private System.Windows.Forms.ComboBox cmbTarjeta;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}