using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            string r;
            openFileDialog1.ShowDialog();
            System.IO.StreamReader arch = new System.IO.StreamReader(openFileDialog1.FileName);
            r = arch.ReadLine();
            richTextBox1.Text = r.ToString();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "texto.rtf";
            var guar = saveFileDialog1.ShowDialog();
            if (guar == DialogResult.OK)
            {
                using (var guardar_archivo = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    guardar_archivo.WriteLine(richTextBox1.Text);
                }
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Deshacer_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void Repetir_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void Copiar_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void Cortar_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void Pegar_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void Seleccionar_todo_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void Borrar_todo_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void Tipografia_Click(object sender, EventArgs e)
        {
            var tipo = fontDialog1.ShowDialog();
            if (tipo == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void Color_Click(object sender, EventArgs e)
        {
            var colo = colorDialog1.ShowDialog();
            if (colo == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void cambiar_tamaño(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.SystemFontName, float.Parse(TSComboBox1.SelectedItem.ToString()), richTextBox1.Font.Style);
            }
        }

        //https://www.youtube.com/watch?v=eNhBnLJcv78&ab_channel=nicosiored
        //Mirar
    }
}
