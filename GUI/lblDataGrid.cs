using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class lblDataGrid : UserControl
    {
        public lblDataGrid()
        {
            InitializeComponent();
        }

        private string nombreLabel;

        public string NombreLabel
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        private DataGridView dataSource;

        public Object DataSource
        {
            get { return dataGridView1.DataSource; }
            set { dataGridView1.DataSource = value; }
        }

    }
}
