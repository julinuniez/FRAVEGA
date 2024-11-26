namespace GUI
{
    partial class Registro
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
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTxtBoxApellido = new GUI.lblTxtBox();
            this.lblTxtBoxNombre = new GUI.lblTxtBox();
            this.lblTxtBoxTelefono = new GUI.lblTxtBox();
            this.lblTxtBoxDNI = new GUI.lblTxtBox();
            this.lblTxtBoxContraseña = new GUI.lblTxtBox();
            this.lblTxtBoxRepetirContraseña = new GUI.lblTxtBox();
            this.SuspendLayout();
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(281, 275);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(96, 46);
            this.btnRegistrarse.TabIndex = 75;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 25);
            this.label5.TabIndex = 72;
            this.label5.Text = "REGISTRARSE";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Crimson;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(602, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 79;
            this.btnSalir.Text = "Volver";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTxtBoxApellido
            // 
            this.lblTxtBoxApellido.CaracterContraseña = "\0";
            this.lblTxtBoxApellido.Etiqueta = "APELLIDO";
            this.lblTxtBoxApellido.Location = new System.Drawing.Point(137, 148);
            this.lblTxtBoxApellido.Name = "lblTxtBoxApellido";
            this.lblTxtBoxApellido.Size = new System.Drawing.Size(150, 46);
            this.lblTxtBoxApellido.TabIndex = 89;
            this.lblTxtBoxApellido.Texto = "";
            // 
            // lblTxtBoxNombre
            // 
            this.lblTxtBoxNombre.CaracterContraseña = "\0";
            this.lblTxtBoxNombre.Etiqueta = "NOMBRE";
            this.lblTxtBoxNombre.Location = new System.Drawing.Point(134, 96);
            this.lblTxtBoxNombre.Name = "lblTxtBoxNombre";
            this.lblTxtBoxNombre.Size = new System.Drawing.Size(150, 46);
            this.lblTxtBoxNombre.TabIndex = 88;
            this.lblTxtBoxNombre.Texto = "";
            // 
            // lblTxtBoxTelefono
            // 
            this.lblTxtBoxTelefono.CaracterContraseña = "\0";
            this.lblTxtBoxTelefono.Etiqueta = "TELEFONO";
            this.lblTxtBoxTelefono.Location = new System.Drawing.Point(137, 200);
            this.lblTxtBoxTelefono.Name = "lblTxtBoxTelefono";
            this.lblTxtBoxTelefono.Size = new System.Drawing.Size(150, 46);
            this.lblTxtBoxTelefono.TabIndex = 90;
            this.lblTxtBoxTelefono.Texto = "";
            // 
            // lblTxtBoxDNI
            // 
            this.lblTxtBoxDNI.CaracterContraseña = "\0";
            this.lblTxtBoxDNI.Etiqueta = "DNI";
            this.lblTxtBoxDNI.Location = new System.Drawing.Point(411, 102);
            this.lblTxtBoxDNI.Name = "lblTxtBoxDNI";
            this.lblTxtBoxDNI.Size = new System.Drawing.Size(150, 46);
            this.lblTxtBoxDNI.TabIndex = 91;
            this.lblTxtBoxDNI.Texto = "";
            // 
            // lblTxtBoxContraseña
            // 
            this.lblTxtBoxContraseña.CaracterContraseña = "\0";
            this.lblTxtBoxContraseña.Etiqueta = "CONTRASEÑA";
            this.lblTxtBoxContraseña.Location = new System.Drawing.Point(414, 154);
            this.lblTxtBoxContraseña.Name = "lblTxtBoxContraseña";
            this.lblTxtBoxContraseña.Size = new System.Drawing.Size(150, 46);
            this.lblTxtBoxContraseña.TabIndex = 92;
            this.lblTxtBoxContraseña.Texto = "";
            // 
            // lblTxtBoxRepetirContraseña
            // 
            this.lblTxtBoxRepetirContraseña.CaracterContraseña = "\0";
            this.lblTxtBoxRepetirContraseña.Etiqueta = "REPETIR CONTRASEÑA";
            this.lblTxtBoxRepetirContraseña.Location = new System.Drawing.Point(414, 200);
            this.lblTxtBoxRepetirContraseña.Name = "lblTxtBoxRepetirContraseña";
            this.lblTxtBoxRepetirContraseña.Size = new System.Drawing.Size(164, 46);
            this.lblTxtBoxRepetirContraseña.TabIndex = 93;
            this.lblTxtBoxRepetirContraseña.Texto = "";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 343);
            this.Controls.Add(this.lblTxtBoxRepetirContraseña);
            this.Controls.Add(this.lblTxtBoxContraseña);
            this.Controls.Add(this.lblTxtBoxDNI);
            this.Controls.Add(this.lblTxtBoxTelefono);
            this.Controls.Add(this.lblTxtBoxApellido);
            this.Controls.Add(this.lblTxtBoxNombre);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.label5);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalir;
        private lblTxtBox lblTxtBoxApellido;
        private lblTxtBox lblTxtBoxNombre;
        private lblTxtBox lblTxtBoxTelefono;
        private lblTxtBox lblTxtBoxDNI;
        private lblTxtBox lblTxtBoxContraseña;
        private lblTxtBox lblTxtBoxRepetirContraseña;
    }
}