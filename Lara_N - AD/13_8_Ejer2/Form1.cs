using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_8_Ejer2
{
    public partial class Form1 : Form
    {
        bool Jugador1 = true;

        int[,] matriz = new int[,]
        {
            {0,0,0},
            {0,0,0},
            {0,0,0}
        };

        //pipe teclado |

        /*
        private void victoria()
        {
            MessageBox.Show("Ganaste jugador 1 la partida, bien hecho", "¡¡Victoria!!");
            //button1_Click();
            //victoria();
        }

        private void formasDeGanar()
        {
            //Formas en las que se puede ganar, debe haber un if por cada forma en la que se puede ganar
        }
        */

        private void formasDeGanar1()
        {
            if (
                pictureBox1.Image == pictureBox11.Image && pictureBox2.Image == pictureBox11.Image && pictureBox3.Image == pictureBox11.Image ||
                pictureBox4.Image == pictureBox11.Image && pictureBox5.Image == pictureBox11.Image && pictureBox6.Image == pictureBox11.Image ||
                pictureBox7.Image == pictureBox11.Image && pictureBox8.Image == pictureBox11.Image && pictureBox9.Image == pictureBox11.Image ||
                pictureBox1.Image == pictureBox11.Image && pictureBox4.Image == pictureBox11.Image && pictureBox7.Image == pictureBox11.Image ||
                pictureBox2.Image == pictureBox11.Image && pictureBox5.Image == pictureBox11.Image && pictureBox8.Image == pictureBox11.Image ||
                pictureBox3.Image == pictureBox11.Image && pictureBox6.Image == pictureBox11.Image && pictureBox9.Image == pictureBox11.Image ||
                pictureBox1.Image == pictureBox11.Image && pictureBox5.Image == pictureBox11.Image && pictureBox9.Image == pictureBox11.Image ||
                pictureBox3.Image == pictureBox11.Image && pictureBox5.Image == pictureBox11.Image && pictureBox7.Image == pictureBox11.Image
                )
            {
                MessageBox.Show("Ganaste jugador 1 la partida, bien hecho", "¡¡Victoria!!");
                pictureBox1.Image = pictureBox2.Image = pictureBox3.Image = pictureBox4.Image = pictureBox5.Image = pictureBox6.Image = pictureBox7.Image = pictureBox8.Image = pictureBox9.Image = pictureBox12.Image;
            }
        }

        private void formasDeGanar2()
        {
            if (
                pictureBox1.Image == pictureBox10.Image && pictureBox2.Image == pictureBox10.Image && pictureBox3.Image == pictureBox10.Image ||
                pictureBox4.Image == pictureBox10.Image && pictureBox5.Image == pictureBox10.Image && pictureBox6.Image == pictureBox10.Image ||
                pictureBox7.Image == pictureBox10.Image && pictureBox8.Image == pictureBox10.Image && pictureBox9.Image == pictureBox10.Image ||
                pictureBox1.Image == pictureBox10.Image && pictureBox4.Image == pictureBox10.Image && pictureBox7.Image == pictureBox10.Image ||
                pictureBox2.Image == pictureBox10.Image && pictureBox5.Image == pictureBox10.Image && pictureBox8.Image == pictureBox10.Image ||
                pictureBox3.Image == pictureBox10.Image && pictureBox6.Image == pictureBox10.Image && pictureBox9.Image == pictureBox10.Image ||
                pictureBox1.Image == pictureBox10.Image && pictureBox5.Image == pictureBox10.Image && pictureBox9.Image == pictureBox10.Image ||
                pictureBox3.Image == pictureBox10.Image && pictureBox5.Image == pictureBox10.Image && pictureBox7.Image == pictureBox10.Image
                )
                /*
                matriz[0, 0] == 1 && matriz[0, 1] == 1 && matriz[0, 2] == 1 ||
                matriz[1, 0] == 1 && matriz[1, 1] == 1 && matriz[1, 2] == 1 ||
                matriz[2, 0] == 1 && matriz[2, 1] == 1 && matriz[2, 2] == 1 ||
                matriz[0, 0] == 1 && matriz[1, 1] == 1 && matriz[2, 2] == 1 ||
                matriz[0, 2] == 1 && matriz[1, 1] == 1 && matriz[2, 0] == 1 ||
                matriz[0, 0] == 1 && matriz[1, 0] == 1 && matriz[2, 0] == 1 ||
                matriz[0, 1] == 1 && matriz[1, 1] == 1 && matriz[2, 1] == 1 ||
                matriz[0, 2] == 1 && matriz[1, 2] == 1 && matriz[2, 2] == 1
                */
            {
                MessageBox.Show("Ganaste jugador 2 la partida, bien hecho", "¡¡Victoria!!");
                pictureBox1.Image = pictureBox2.Image = pictureBox3.Image = pictureBox4.Image = pictureBox5.Image = pictureBox6.Image = pictureBox7.Image = pictureBox8.Image = pictureBox9.Image = pictureBox12.Image;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image != pictureBox11.Image && pictureBox1.Image != pictureBox10.Image)
            {
                pictureBox1.Image = (Jugador1 == true) ? pictureBox11.Image : pictureBox10.Image;
                matriz[0, 0] = (Jugador1 == true) ? 1 : 2;
                Jugador1 = !Jugador1;
            }
            formasDeGanar1();
            formasDeGanar2();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != pictureBox11.Image && pictureBox2.Image != pictureBox10.Image)
            {
                pictureBox2.Image = (Jugador1 == true) ? pictureBox11.Image : pictureBox10.Image;
                matriz[0, 1] = (Jugador1 == true) ? 1 : 2;
                Jugador1 = !Jugador1;
            }
            formasDeGanar1();
            formasDeGanar2();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image != pictureBox11.Image && pictureBox3.Image != pictureBox10.Image)
            {
                pictureBox3.Image = (Jugador1 == true) ? pictureBox11.Image : pictureBox10.Image;
                matriz[0, 2] = (Jugador1 == true) ? 1 : 2;
                Jugador1 = !Jugador1;
            }
            formasDeGanar1();
            formasDeGanar2();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Image != pictureBox11.Image && pictureBox4.Image != pictureBox10.Image)
            {
                pictureBox4.Image = (Jugador1 == true) ? pictureBox11.Image : pictureBox10.Image;
                matriz[1, 0] = (Jugador1 == true) ? 1 : 2;
                Jugador1 = !Jugador1;
            }
            formasDeGanar1();
            formasDeGanar2();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Image != pictureBox11.Image && pictureBox5.Image != pictureBox10.Image)
            {
                pictureBox5.Image = (Jugador1 == true) ? pictureBox11.Image : pictureBox10.Image;
                matriz[1, 1] = (Jugador1 == true) ? 1 : 2;
                Jugador1 = !Jugador1;
            }
            formasDeGanar1();
            formasDeGanar2();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Image != pictureBox11.Image && pictureBox6.Image != pictureBox10.Image)
            {
                pictureBox6.Image = (Jugador1 == true) ? pictureBox11.Image : pictureBox10.Image;
                matriz[1, 2] = (Jugador1 == true) ? 1 : 2;
                Jugador1 = !Jugador1;
            }
            formasDeGanar1();
            formasDeGanar2();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox7.Image != pictureBox11.Image && pictureBox7.Image != pictureBox10.Image)
            {
                pictureBox7.Image = (Jugador1 == true) ? pictureBox11.Image : pictureBox10.Image;
                matriz[2, 0] = (Jugador1 == true) ? 1 : 2;
                Jugador1 = !Jugador1;
            }
            formasDeGanar1();
            formasDeGanar2();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox8.Image != pictureBox11.Image && pictureBox8.Image != pictureBox10.Image)
            {
                pictureBox8.Image = (Jugador1 == true) ? pictureBox11.Image : pictureBox10.Image;
                matriz[2, 1] = (Jugador1 == true) ? 1 : 2;
                Jugador1 = !Jugador1;
            }
            formasDeGanar1();
            formasDeGanar2();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox9.Image != pictureBox11.Image && pictureBox9.Image != pictureBox10.Image)
            {
                pictureBox9.Image = (Jugador1 == true) ? pictureBox11.Image : pictureBox10.Image;
                matriz[2, 2] = (Jugador1 == true) ? 1 : 2;
                Jugador1 = !Jugador1;
            }
            formasDeGanar1();
            formasDeGanar2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox2.Image = pictureBox3.Image = pictureBox4.Image = pictureBox5.Image = pictureBox6.Image = pictureBox7.Image = pictureBox8.Image = pictureBox9.Image = pictureBox12.Image;
            Jugador1 = true;
            /*for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", matriz[i, j]);
                }
                Console.WriteLine();
            }*
        }
    }
}