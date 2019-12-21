
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnterface_Arayüz_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Defans d = new Defans()
        {
            AdSoyad = "Sabri Sarıoğlu",
            Agresiflik = 98,
            FormaNumarası = 89,
            MilliMi = true,
            Refleks = 55,
            SutGucu = 85,
        };

        Kaleci k = new Kaleci()
        {
            AdSoyad = "Volkan Babacan",
            Agresiflik = 100,
            FormaNumarası = 1,
            MilliMi = true,
            Refleks = 70,
            SutGucu = 65,
            
        };

        Forvet f = new Forvet()
        {
            AdSoyad = "Radamel Falcao",
            Agresiflik = 99,
            FormaNumarası = 9,
            MilliMi = false,
            Refleks = 99,
            SutGucu = 99,
        };



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            IFutbolcu secilenFutbolcu = (IFutbolcu)listBox1.SelectedItem;

            foreach (var item in secilenFutbolcu.GetType().GetProperties())
            {
                Label lbl = new Label();
                lbl.AutoSize = false;
                lbl.Width = flowLayoutPanel1.Width;
                lbl.Text = item.Name + " - " + item.GetValue(secilenFutbolcu);
                flowLayoutPanel1.Controls.Add(lbl);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(d);
            listBox1.Items.Add(k);
            listBox1.Items.Add(f);
        }
    }
}
