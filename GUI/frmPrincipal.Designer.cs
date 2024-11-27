namespace GUI
{
    partial class frmPrincipal
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
            this.cOMPRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gESTIONARTARJETAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verInformesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOMPRARToolStripMenuItem,
            this.gESTIONARTARJETAToolStripMenuItem,
            this.vENTASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cOMPRARToolStripMenuItem
            // 
            this.cOMPRARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarClientesToolStripMenuItem});
            this.cOMPRARToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.cOMPRARToolStripMenuItem.Name = "cOMPRARToolStripMenuItem";
            this.cOMPRARToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
            this.cOMPRARToolStripMenuItem.Text = "CLIENTES";
            // 
            // gestionarClientesToolStripMenuItem
            // 
            this.gestionarClientesToolStripMenuItem.Name = "gestionarClientesToolStripMenuItem";
            this.gestionarClientesToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.gestionarClientesToolStripMenuItem.Text = "Gestionar Clientes";
            this.gestionarClientesToolStripMenuItem.Click += new System.EventHandler(this.gestionarClientesToolStripMenuItem_Click);
            // 
            // gESTIONARTARJETAToolStripMenuItem
            // 
            this.gESTIONARTARJETAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarProductosToolStripMenuItem,
            this.gestionarCategoriaToolStripMenuItem});
            this.gESTIONARTARJETAToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.gESTIONARTARJETAToolStripMenuItem.Name = "gESTIONARTARJETAToolStripMenuItem";
            this.gESTIONARTARJETAToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.gESTIONARTARJETAToolStripMenuItem.Text = "PRODUCTOS";
            this.gESTIONARTARJETAToolStripMenuItem.Click += new System.EventHandler(this.gESTIONARTARJETAToolStripMenuItem_Click);
            // 
            // gestionarProductosToolStripMenuItem
            // 
            this.gestionarProductosToolStripMenuItem.Name = "gestionarProductosToolStripMenuItem";
            this.gestionarProductosToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.gestionarProductosToolStripMenuItem.Text = "Gestionar Productos";
            this.gestionarProductosToolStripMenuItem.Click += new System.EventHandler(this.gestionarProductosToolStripMenuItem_Click);
            // 
            // gestionarCategoriaToolStripMenuItem
            // 
            this.gestionarCategoriaToolStripMenuItem.Name = "gestionarCategoriaToolStripMenuItem";
            this.gestionarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.gestionarCategoriaToolStripMenuItem.Text = "Gestionar Categoria";
            this.gestionarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.gestionarCategoriaToolStripMenuItem_Click);
            // 
            // vENTASToolStripMenuItem
            // 
            this.vENTASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verInformesToolStripMenuItem});
            this.vENTASToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.vENTASToolStripMenuItem.Name = "vENTASToolStripMenuItem";
            this.vENTASToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.vENTASToolStripMenuItem.Text = "VENTAS";
            // 
            // verInformesToolStripMenuItem
            // 
            this.verInformesToolStripMenuItem.Name = "verInformesToolStripMenuItem";
            this.verInformesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verInformesToolStripMenuItem.Text = "Ver informes";
            this.verInformesToolStripMenuItem.Click += new System.EventHandler(this.verInformesToolStripMenuItem_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 26);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(844, 424);
            this.panelPrincipal.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cOMPRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gESTIONARTARJETAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENTASToolStripMenuItem;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.ToolStripMenuItem gestionarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verInformesToolStripMenuItem;
    }
}