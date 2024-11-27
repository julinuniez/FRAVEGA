namespace GUI
{
    partial class Login
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
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.lblTxtContraseña = new GUI.lblTxtBox();
            this.lbltxtDNI = new GUI.lblTxtBox();
            this.SuspendLayout();
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(218, 176);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(84, 46);
            this.btnRegistrarse.TabIndex = 68;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 25);
            this.label5.TabIndex = 65;
            this.label5.Text = "INICIAR SESION";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(104, 176);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(84, 46);
            this.btnIniciarSesion.TabIndex = 71;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.FileName = "C:\\Windows\\notepad.exe";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // serviceController1
            // 
            this.serviceController1.ServiceName = "MSSQLSERVER";
            // 
            // lblTxtContraseña
            // 
            this.lblTxtContraseña.CaracterContraseña = "\0";
            this.lblTxtContraseña.Etiqueta = "Contraseña";
            this.lblTxtContraseña.Location = new System.Drawing.Point(135, 107);
            this.lblTxtContraseña.Name = "lblTxtContraseña";
            this.lblTxtContraseña.RegexPattern = null;
            this.lblTxtContraseña.Size = new System.Drawing.Size(150, 46);
            this.lblTxtContraseña.TabIndex = 74;
            this.lblTxtContraseña.Texto = "";
            // 
            // lbltxtDNI
            // 
            this.lbltxtDNI.CaracterContraseña = "\0";
            this.lbltxtDNI.Etiqueta = "DNI";
            this.lbltxtDNI.Location = new System.Drawing.Point(135, 55);
            this.lbltxtDNI.Name = "lbltxtDNI";
            this.lbltxtDNI.RegexPattern = null;
            this.lbltxtDNI.Size = new System.Drawing.Size(150, 46);
            this.lbltxtDNI.TabIndex = 73;
            this.lbltxtDNI.Texto = "";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 268);
            this.Controls.Add(this.lblTxtContraseña);
            this.Controls.Add(this.lbltxtDNI);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Diagnostics.Process process1;
        private System.ServiceProcess.ServiceController serviceController1;
        private lblTxtBox lbltxtDNI;
        private lblTxtBox lblTxtContraseña;
    }
}