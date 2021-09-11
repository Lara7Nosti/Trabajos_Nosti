using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MiniEditor
{
    public partial class Form1 : Form
    {
        bool estado = false;
        bool guardo = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            var n = openFileDialog1.ShowDialog();
            if ((n == DialogResult.OK) && (guardo == true))
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                estado = true;
                guardo = true;
            }
            else if ((n == DialogResult.OK) && (guardo == false))
            {
                DialogResult = MessageBox.Show("¿Esta seguro de abrir otro archivo sin guardar?", "¡Un Momento!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    estado = true;
                    guardo = true;
                }
                if (DialogResult == DialogResult.No)
                {
                    Guardar_Click(null, null);
                    Abrir_Click(null, null);
                }
            }
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            if (guardo == true)
            {
                richTextBox1.Clear();
                estado = false;
                guardo = true;
            }
            else
            {
                DialogResult = MessageBox.Show("¿Esta seguro de crear un nuevo archivo sin guardar?", "¡Un Momento!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    richTextBox1.Clear();
                    estado = false;
                    guardo = true;
                }
                else if (DialogResult == DialogResult.No)
                {
                    Guardar_Click(null, null);
                }
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (estado == false)
            {
                Guardar_como_Click(null, null);
            }
            else
            {
                richTextBox1.SaveFile(openFileDialog1.FileName);
                guardo = true;
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
                estado = true;
                guardo = true;
            }
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

        private void Imagen_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Imagen |*.jpg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Clipboard.SetImage(Image.FromFile(openFileDialog1.FileName));
                richTextBox1.Paste();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (guardo == false)
            {
                DialogResult = MessageBox.Show("No guardaste el archivo ¿Esta seguro de cerrar?", "¡Espera!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else if (DialogResult == DialogResult.No)
                {
                    Guardar_Click(null, null);
                    e.Cancel = true;
                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            guardo = false;
        }
    }
}
