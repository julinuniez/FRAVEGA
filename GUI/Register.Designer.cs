namespace GUI
{
    partial class Register
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
            this.buttonRegistrarse = new System.Windows.Forms.Button();
            this.lblTxtBoxRepetirContraseña = new GUI.lblTxtBox();
            this.lblTxtBoxContraseña = new GUI.lblTxtBox();
            this.lblTxtBoxTelefono = new GUI.lblTxtBox();
            this.lblTxtBoxApellido = new GUI.lblTxtBox();
            this.lblTxtBoxNombre = new GUI.lblTxtBox();
            this.lblTxtBoxDNI = new GUI.lblTxtBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRegistrarse
            // 
            this.buttonRegistrarse.Location = new System.Drawing.Point(221, 305);
            this.buttonRegistrarse.Name = "buttonRegistrarse";
            this.buttonRegistrarse.Size = new System.Drawing.Size(114, 42);
            this.buttonRegistrarse.TabIndex = 6;
            this.buttonRegistrarse.Text = "Registrarse";
            this.buttonRegistrarse.UseVisualStyleBackColor = true;
            this.buttonRegistrarse.Click += new System.EventHandler(this.buttonRegistrarse_Click);
            // 
            // lblTxtBoxRepetirContraseña
            // 
            this.lblTxtBoxRepetirContraseña.CaracterContraseña = "\0";
            this.lblTxtBoxRepetirContraseña.Etiqueta = "Repetir Contraseña";
            this.lblTxtBoxRepetirContraseña.Location = new System.Drawing.Point(383, 237);
            this.lblTxtBoxRepetirContraseña.Name = "lblTxtBoxRepetirContraseña";
            this.lblTxtBoxRepetirContraseña.RegexPattern = null;
            this.lblTxtBoxRepetirContraseña.Size = new System.Drawing.Size(150, 46);
            this.lblTxtBoxRepetirContraseña.TabIndex = 5;
            this.lblTxtBoxRepetirContraseña.Texto = "";
            // 
            // lblTxtBoxContraseña
            // 
            this.lblTxtBoxContraseña.CaracterContraseña = "\0";
            this.lblTxtBoxContraseña.Etiqueta = "Contraseña";
            this.lblTxtBoxContraseña.Location = new System.Drawing.Point(383, 160);
            this.lblTxtBoxContraseña.Name = "lblTxtBoxContraseña";
            this.lblTxtBoxContraseña.RegexPattern = null;
            this.lblTxtBoxContraseña.Size = new System.Drawing.Size(150, 46);
            this.lblTxtBoxContraseña.TabIndex = 4;
            this.lblTxtBoxContraseña.Texto = "";
            // 
            // lblTxtBoxTelefono
            // 
            this.lblTxtBoxTelefono.CaracterContraseña = "\0";
            this.lblTxtBoxTelefono.Etiqueta = "Telefono";
            this.lblTxtBoxTelefono.Location = new System.Drawing.Point(383, 74);
            this.lblTxtBoxTelefono.Name = "lblTxtBoxTelefono";
            this.lblTxtBoxTelefono.RegexPattern = null;
            this.lblTxtBoxTelefono.Size = new System.Drawing.Size(150, 46);
            this.lblTxtBoxTelefono.TabIndex = 3;
            this.lblTxtBoxTelefono.Texto = "";
            // 
            // lblTxtBoxApellido
            // 
            this.lblTxtBoxApellido.CaracterContraseña = "\0";
            this.lblTxtBoxApellido.Etiqueta = "Apellido";
            this.lblTxtBoxApellido.Location = new System.Drawing.Point(107, 238);
            this.lblTxtBoxApellido.Name = "lblTxtBoxApellido";
            this.lblTxtBoxApellido.RegexPattern = null;
            this.lblTxtBoxApellido.Size = new System.Drawing.Size(150, 46);
            this.lblTxtBoxApellido.TabIndex = 2;
            this.lblTxtBoxApellido.Texto = "";
            // 
            // lblTxtBoxNombre
            // 
            this.lblTxtBoxNombre.CaracterContraseña = "\0";
            this.lblTxtBoxNombre.Etiqueta = "Nombre";
            this.lblTxtBoxNombre.Location = new System.Drawing.Point(107, 161);
            this.lblTxtBoxNombre.Name = "lblTxtBoxNombre";
            this.lblTxtBoxNombre.RegexPattern = null;
            this.lblTxtBoxNombre.Size = new System.Drawing.Size(150, 46);
            this.lblTxtBoxNombre.TabIndex = 1;
            this.lblTxtBoxNombre.Texto = "";
            // 
            // lblTxtBoxDNI
            // 
            this.lblTxtBoxDNI.CaracterContraseña = "\0";
            this.lblTxtBoxDNI.Etiqueta = "DNI";
            this.lblTxtBoxDNI.Location = new System.Drawing.Point(107, 75);
            this.lblTxtBoxDNI.Name = "lblTxtBoxDNI";
            this.lblTxtBoxDNI.RegexPattern = null;
            this.lblTxtBoxDNI.Size = new System.Drawing.Size(150, 46);
            this.lblTxtBoxDNI.TabIndex = 0;
            this.lblTxtBoxDNI.Texto = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(235, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 66;
            this.label5.Text = "Registro";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 430);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonRegistrarse);
            this.Controls.Add(this.lblTxtBoxRepetirContraseña);
            this.Controls.Add(this.lblTxtBoxContraseña);
            this.Controls.Add(this.lblTxtBoxTelefono);
            this.Controls.Add(this.lblTxtBoxApellido);
            this.Controls.Add(this.lblTxtBoxNombre);
            this.Controls.Add(this.lblTxtBoxDNI);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lblTxtBox lblTxtBoxDNI;
        private lblTxtBox lblTxtBoxNombre;
        private lblTxtBox lblTxtBoxApellido;
        private lblTxtBox lblTxtBoxTelefono;
        private lblTxtBox lblTxtBoxContraseña;
        private lblTxtBox lblTxtBoxRepetirContraseña;
        private System.Windows.Forms.Button buttonRegistrarse;
        private System.Windows.Forms.Label label5;
    }
}