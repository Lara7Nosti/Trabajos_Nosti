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

namespace Clima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sURL;
            WebRequest wrGETURL;
            JObject json;
            Stream objStream;

            string latitud = "-34.6119666";
            string longitud = "-58.4030375";
            //sURL = "https://api.darksky.net/forecast/b4497c8a6b18bf75776b7fd997f2b90a/-34.6119666,-58.4030375?lang=es&units=ca";
            sURL = "https://api.darksky.net/forecast/b4497c8a6b18bf75776b7fd997f2b90a/" + latitud + "," + longitud + "?lang=es&units=ca";
            wrGETURL = WebRequest.Create(sURL);
            objStream = wrGETURL.GetResponse().GetResponseStream();
            StreamReader objReader = new StreamReader(objStream);

            string sLine = "";
            string sLinePrev = "";
            int i = 0;

            while (sLine != null)
            {
                i++;
                sLinePrev = sLine;
                sLine = objReader.ReadLine();
                //if (sLine != null)
                //    MessageBox.Show(sLine);                    

            }
            //MessageBox.Show(sLinePrev);

            json = JObject.Parse(sLinePrev);
            //MessageBox.Show(json["daily"]["data"][0]["icon"] + ".png");

            climaHoy.Image = Image.FromFile("climas/" + json["currently"]["icon"].ToString() + ".png");
            clima1.Image = Image.FromFile("climas/" + json["daily"]["data"][1]["icon"].ToString() + ".png");
            clima2.Image = Image.FromFile("climas/" + json["daily"]["data"][2]["icon"].ToString() + ".png");
            clima3.Image = Image.FromFile("climas/" + json["daily"]["data"][3]["icon"].ToString() + ".png");
            clima4.Image = Image.FromFile("climas/" + json["daily"]["data"][4]["icon"].ToString() + ".png");
            clima5.Image = Image.FromFile("climas/" + json["daily"]["data"][5]["icon"].ToString() + ".png");
            clima6.Image = Image.FromFile("climas/" + json["daily"]["data"][6]["icon"].ToString() + ".png");

            zona1.Text = json["timezone"].ToString();
            zona2.Text = json["timezone"].ToString();
            gradosHoy.Text = json["currently"]["temperature"].ToString();

            grados1a.Text = json["daily"]["data"][1]["temperatureHigh"].ToString();
            grados2a.Text = json["daily"]["data"][2]["temperatureHigh"].ToString();
            grados3a.Text = json["daily"]["data"][3]["temperatureHigh"].ToString();
            grados4a.Text = json["daily"]["data"][4]["temperatureHigh"].ToString();
            grados5a.Text = json["daily"]["data"][5]["temperatureHigh"].ToString();
            grados6a.Text = json["daily"]["data"][6]["temperatureHigh"].ToString();

            grados1b.Text = json["daily"]["data"][1]["temperatureLow"].ToString();
            grados2b.Text = json["daily"]["data"][1]["temperatureLow"].ToString();
            grados3b.Text = json["daily"]["data"][1]["temperatureLow"].ToString();
            grados4b.Text = json["daily"]["data"][1]["temperatureLow"].ToString();
            grados5b.Text = json["daily"]["data"][1]["temperatureLow"].ToString();
            grados6b.Text = json["daily"]["data"][1]["temperatureLow"].ToString();

            /*
            string[] lugar;
            lugar = json["timezone"].ToString().Split('/' , '_');
            MessageBox.Show(lugar[0] + " - " + lugar[1]);
            MessageBox.Show(lugar[2] + " - " + lugar[3]);
            */
            Console.ReadLine();
        }
    }
}
