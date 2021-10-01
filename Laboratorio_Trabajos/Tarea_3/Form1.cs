using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Lara Nosti 5º 10º
        }

        private void Boton1_Click(object sender, EventArgs e)
        {
            CajaLista1.Items.Add(CajaTexto1.Text);
            CajaTexto1.Clear();
        }

        private void Boton2_Click(object sender, EventArgs e)
        {
            CajaLista2.Items.Add(CajaTexto2.Text);
            CajaTexto2.Clear();
        }

        private void CajaTexto1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Boton1_Click(this, e);
            }
        }

        private void CajaTexto2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Boton2_Click(this, e);
            }
        }

        //Primer y Segundo punto
        private void Izq2_Click(object sender, EventArgs e)//Modo Seleccion
        {
            if (CajaLista2.SelectionMode != SelectionMode.MultiExtended)
            {
                MessageBox.Show("Ahora puede seleccionar varios Items de la derecha", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CajaLista2.SelectionMode = SelectionMode.MultiExtended;
            }
            else
            {
                MessageBox.Show("Ahora puede seleccionar un Item de la derecha", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CajaLista2.SelectionMode = SelectionMode.One;
            }
        }

        private void Izq1_Click(object sender, EventArgs e)
        {
            if (CajaLista2.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un Item de la derecha primero", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                for (int i = CajaLista2.SelectedItems.Count - 1; i >= 0; i--)
                {
                    CajaLista1.Items.Add(CajaLista2.SelectedItems[i]);
                    CajaLista2.Items.Remove(CajaLista2.SelectedItems[i]);

                    CajaLista2.Refresh();
                    CajaLista1.Refresh();
                }
            }
        }

        private void Izq3_Click(object sender, EventArgs e)
        {
            CajaLista1.Items.AddRange(CajaLista2.Items);
            CajaLista2.Items.Clear();
        }

        private void Der3_Click(object sender, EventArgs e)
        {
            CajaLista2.Items.AddRange(CajaLista1.Items);
            CajaLista1.Items.Clear();
        }

        private void Der1_Click(object sender, EventArgs e)
        {
            if (CajaLista1.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un Item de la izquierda primero", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                for (int i = CajaLista1.SelectedItems.Count - 1; i >= 0; i--)
                {
                    CajaLista2.Items.Add(CajaLista1.SelectedItems[i]);
                    CajaLista1.Items.Remove(CajaLista1.SelectedItems[i]);

                    CajaLista1.Refresh();
                    CajaLista2.Refresh();
                }
            }

        }

        private void Der2_Click(object sender, EventArgs e)//Modo Seleccion
        {
            if(CajaLista1.SelectionMode != SelectionMode.MultiExtended){
                MessageBox.Show("Ahora puede seleccionar varios Items de la izquierda", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CajaLista1.SelectionMode = SelectionMode.MultiExtended;
            }
            else
            {
                MessageBox.Show("Ahora puede seleccionar un Item de la izquierda", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CajaLista1.SelectionMode = SelectionMode.One;
            }
            
        }

        //Tercer punto
        private void CajaLista1_DoubleClick(object sender, EventArgs e)
        {
            for (int i = CajaLista1.SelectedItems.Count - 1; i >= 0; i--)
            {
                CajaLista1.Items.Remove(CajaLista1.SelectedItems[i]);
                CajaLista1.Refresh();
            }
        }

        private void CajaLista2_DoubleClick(object sender, EventArgs e)
        {
            for (int i = CajaLista2.SelectedItems.Count - 1; i >= 0; i--)
            {
                CajaLista2.Items.Remove(CajaLista2.SelectedItems[i]);
                CajaLista2.Refresh();
            }
        }

        //Cuarto punto
        private void CajaLista1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                if (this.CajaLista1.Items != null &&
                    this.CajaLista1.SelectedItem != null &&
                    this.CajaLista1.Items.Count == this.CajaLista2.Items.Count)
                {
                    object tmp = this.CajaLista1.SelectedItem;
                    int index = this.CajaLista1.SelectedIndex;
                    this.CajaLista1.Items[index] = this.CajaLista2.Items[index];
                    this.CajaLista2.Items[index] = tmp;
                }
            }
        }

        private void CajaLista2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                if (this.CajaLista2.Items != null &&
                    this.CajaLista2.SelectedItem != null &&
                    this.CajaLista2.Items.Count == this.CajaLista1.Items.Count)
                {
                    object tmp = this.CajaLista2.SelectedItem;
                    int index = this.CajaLista2.SelectedIndex;
                    this.CajaLista2.Items[index] = this.CajaLista1.Items[index];
                    this.CajaLista1.Items[index] = tmp;
                }
            }
        }
    }
}
