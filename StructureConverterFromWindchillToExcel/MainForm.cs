using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StructureConverterFromWindchillToExcel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void конверторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConverterForm form = new ConverterForm();
            form.ShowDialog();
        }
    }
}
