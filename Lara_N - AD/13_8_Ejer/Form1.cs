using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_8_Ejer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                pictureBox1.Visible = true;
            else
                pictureBox1.Visible = false;
            if (checkBox1.Checked == true && checkBox2.Checked == true)
                checkBox3.Checked = true;
            else
                checkBox3.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                pictureBox2.Visible = true;
            else
                pictureBox2.Visible = false;
            if (checkBox1.Checked == true && checkBox2.Checked == true)
                checkBox3.Checked = true;
            else
                checkBox3.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
                checkBox1.Checked = checkBox2.Checked = true;
            else
                checkBox1.Checked = checkBox2.Checked = false;
        }
    }
}