using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class lblTxtBox : UserControl
    {
        public lblTxtBox()
        {
            InitializeComponent();
        }
        public string Etiqueta
        {
            get { return lblEtiqueta.Text; }
            set { lblEtiqueta.Text = value; }
        }
        public string Texto
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        protected void SetearColor(Color unColor)
        {
            lblEtiqueta.ForeColor = unColor;
        }

        public virtual bool Validar()
        {
            bool ok = true;
            if (string.IsNullOrWhiteSpace(this.textBox1.Text))
            {
                ok = false;
                SetearColor(Color.Red);
            }
            else
            {
                SetearColor(Color.Black);
            }
            return ok;
        }
    }
}
