namespace GUI
{
    partial class frmPrincipalCliente
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comprarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediosDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hISTORIALDEPAGOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprarToolStripMenuItem,
            this.mediosDePagoToolStripMenuItem,
            this.hISTORIALDEPAGOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comprarToolStripMenuItem
            // 
            this.comprarToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.comprarToolStripMenuItem.Name = "comprarToolStripMenuItem";
            this.comprarToolStripMenuItem.Size = new System.Drawing.Size(76, 22);
            this.comprarToolStripMenuItem.Text = "COMPRAR";
            this.comprarToolStripMenuItem.Click += new System.EventHandler(this.comprarToolStripMenuItem_Click);
            // 
            // mediosDePagoToolStripMenuItem
            // 
            this.mediosDePagoToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.mediosDePagoToolStripMenuItem.Name = "mediosDePagoToolStripMenuItem";
            this.mediosDePagoToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.mediosDePagoToolStripMenuItem.Text = "MEDIOS DE PAGO";
            this.mediosDePagoToolStripMenuItem.Click += new System.EventHandler(this.mediosDePagoToolStripMenuItem_Click);
            // 
            // hISTORIALDEPAGOToolStripMenuItem
            // 
            this.hISTORIALDEPAGOToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.hISTORIALDEPAGOToolStripMenuItem.Name = "hISTORIALDEPAGOToolStripMenuItem";
            this.hISTORIALDEPAGOToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.hISTORIALDEPAGOToolStripMenuItem.Text = "HISTORIAL DE PAGO";
            this.hISTORIALDEPAGOToolStripMenuItem.Click += new System.EventHandler(this.hISTORIALDEPAGOToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 26);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(800, 424);
            this.panel.TabIndex = 2;
            // 
            // frmPrincipalCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipalCliente";
            this.Text = "frmPrincipalCliente";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comprarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediosDePagoToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripMenuItem hISTORIALDEPAGOToolStripMenuItem;
    }
}