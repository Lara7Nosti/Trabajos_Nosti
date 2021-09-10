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

        private void Abrir_Click(object sender, EventArgs e) //Modificar
        {
            try
            {
                string r;
                openFileDialog1.ShowDialog();
                System.IO.StreamReader arch = new System.IO.StreamReader(openFileDialog1.FileName);
                r = arch.ReadLine();
                richTextBox1.Text = r.ToString();
            }
            catch (Exception ex) { }
        }

        private void Guardar_Click(object sender, EventArgs e) //Modificar
        {
            saveFileDialog1.DefaultExt = "rtf";
            saveFileDialog1.FileName = "fileName";
            saveFileDialog1.Filter = "RTF files (*.rtf)|*.rtf|TXT files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                //Form1. = saveFileDialog1.FileName;
                //string codigo = richTextBox1.SelectedRtf;
                //MessageBox.Show(codigo);
            }
        }
        
        private void Guardar_como_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "rtf";
            saveFileDialog1.FileName = "fileName";
            saveFileDialog1.Filter = "RTF files (*.rtf)|*.rtf|TXT files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void Cerrar_Click(object sender, EventArgs e) //Completar
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
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void Color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void Fondo_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void cambiar_tamaño(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.SystemFontName, float.Parse(TSComboBox1.SelectedItem.ToString()), richTextBox1.Font.Style);
            }
        }

        private void Imagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Imagen |*.jpg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Clipboard.SetImage(Image.FromFile(openFileDialog1.FileName));
                richTextBox1.Paste();
            }
        }
    }
}
