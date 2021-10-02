using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Servcicio_Post_DarkSky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string latitud = "-34.6119666";
        string longitud = "-58.4030375";
        bool ubi = true;

        public static DateTime TomarDia(double unixTimeStamp)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }

        private void Coordenadas_Click(object sender, EventArgs e)
        {
            latitud = textBox1.Text;
            longitud = textBox2.Text;
            ubi = false;
            Form1_Load(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                JObject json;

                string sURL = "https://api.darksky.net/forecast/b4497c8a6b18bf75776b7fd997f2b90a/" + latitud + "," + longitud + "?lang=es&units=ca";
                WebRequest wrGETURL = WebRequest.Create(sURL);
                Stream objStream = wrGETURL.GetResponse().GetResponseStream();
                StreamReader objReader = new StreamReader(objStream);

                string sLine = "";
                string sLinePrev = "";
                int i = 0;

                while (sLine != null)
                {
                    i++;
                    sLinePrev = sLine;
                    sLine = objReader.ReadLine();
                }
                json = JObject.Parse(sLinePrev);

                climaHoy.Image = Image.FromFile("climas/" + json["currently"]["icon"].ToString() + ".png");
                clima1.Image = Image.FromFile("climas/" + json["daily"]["data"][1]["icon"].ToString() + ".png");
                clima2.Image = Image.FromFile("climas/" + json["daily"]["data"][2]["icon"].ToString() + ".png");
                clima3.Image = Image.FromFile("climas/" + json["daily"]["data"][3]["icon"].ToString() + ".png");
                clima4.Image = Image.FromFile("climas/" + json["daily"]["data"][4]["icon"].ToString() + ".png");
                clima5.Image = Image.FromFile("climas/" + json["daily"]["data"][5]["icon"].ToString() + ".png");
                clima6.Image = Image.FromFile("climas/" + json["daily"]["data"][6]["icon"].ToString() + ".png");

                string[] lugar = json["timezone"].ToString().Split('/');
                string[] ciudad = lugar[2].Split('_');
                if (lugar.Length == 3)
                {
                    if (lugar[2].Split('_').Length == 1)
                    {
                        zona1.Text = lugar[0] + " - " + lugar[1];
                        zona2.Text = lugar[2];
                    }
                    else if (lugar[2].Split('_').Length == 2)
                    {
                        zona1.Text = lugar[0] + " - " + lugar[1];
                        zona2.Text = ciudad[0] + " " + ciudad[1];
                    }
                    else
                    {
                        zona1.Text = lugar[0] + " - " + lugar[1];
                        zona2.Text = ciudad[0] + " " + ciudad[1] + " " + ciudad[2];
                    }
                }

                double tiempo = Convert.ToDouble(json["currently"]["time"]);
                DateTime fecha = TomarDia(tiempo);
                string dia = fecha.ToLongDateString();
                string[] d = dia.Split(',');
                diaHoy1.Text = d[0];
                diaHoy2.Text = d[1];

                tiempo = Convert.ToDouble(json["daily"]["data"][1]["time"]);
                fecha = TomarDia(tiempo);
                dia = fecha.ToLongDateString();
                d = dia.Split(',');
                dia1.Text = d[0];

                tiempo = Convert.ToDouble(json["daily"]["data"][2]["time"]);
                fecha = TomarDia(tiempo);
                dia = fecha.ToLongDateString();
                d = dia.Split(',');
                dia2.Text = d[0];

                tiempo = Convert.ToDouble(json["daily"]["data"][3]["time"]);
                fecha = TomarDia(tiempo);
                dia = fecha.ToLongDateString();
                d = dia.Split(',');
                dia3.Text = d[0];

                tiempo = Convert.ToDouble(json["daily"]["data"][4]["time"]);
                fecha = TomarDia(tiempo);
                dia = fecha.ToLongDateString();
                d = dia.Split(',');
                dia4.Text = d[0];

                tiempo = Convert.ToDouble(json["daily"]["data"][5]["time"]);
                fecha = TomarDia(tiempo);
                dia = fecha.ToLongDateString();
                d = dia.Split(',');
                dia5.Text = d[0];

                tiempo = Convert.ToDouble(json["daily"]["data"][6]["time"]);
                fecha = TomarDia(tiempo);
                dia = fecha.ToLongDateString();
                d = dia.Split(',');
                dia6.Text = d[0];

                gradosHoy.Text = json["currently"]["temperature"].ToString();
                gradosHoy1.Text = json["daily"]["data"][0]["temperatureHigh"].ToString();
                gradosHoy2.Text = json["daily"]["data"][0]["temperatureLow"].ToString();

                grados1a.Text = json["daily"]["data"][1]["temperatureHigh"].ToString();
                grados2a.Text = json["daily"]["data"][2]["temperatureHigh"].ToString();
                grados3a.Text = json["daily"]["data"][3]["temperatureHigh"].ToString();
                grados4a.Text = json["daily"]["data"][4]["temperatureHigh"].ToString();
                grados5a.Text = json["daily"]["data"][5]["temperatureHigh"].ToString();
                grados6a.Text = json["daily"]["data"][6]["temperatureHigh"].ToString();

                grados1b.Text = json["daily"]["data"][1]["temperatureLow"].ToString();
                grados2b.Text = json["daily"]["data"][2]["temperatureLow"].ToString();
                grados3b.Text = json["daily"]["data"][3]["temperatureLow"].ToString();
                grados4b.Text = json["daily"]["data"][4]["temperatureLow"].ToString();
                grados5b.Text = json["daily"]["data"][5]["temperatureLow"].ToString();
                grados6b.Text = json["daily"]["data"][6]["temperatureLow"].ToString();
            }
            catch
            {
                if (ubi == false)
                {
                    MessageBox.Show("No existe esa ubicacion", "Donde?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    latitud = "-34.6119666";
                    longitud = "-58.4030375";
                }
                else
                {
                    MessageBox.Show("Disculpe, no tiene internet, revise su conexion", "Sin internet, sin informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }
    }
}