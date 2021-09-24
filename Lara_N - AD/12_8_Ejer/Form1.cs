using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_8_Ejer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirSinGuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "apps windows|*.exe|zip|*.zip";
            openFileDialog1.ShowDialog();
        }
    }
}
