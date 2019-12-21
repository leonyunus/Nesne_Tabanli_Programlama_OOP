using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesne_Tabanli_Programlama_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Insan insan = new Insan();
        Hayvan hayvan = new Hayvan();

        private void Form1_Load(object sender, EventArgs e)
        {
            

            insan.el = 2;
            insan.ayak = 2;
            hayvan.ayak = 4;
            insan.Konus();
            hayvan.Kopek();

            MessageBox.Show($"İnsan \n İnsan eli: {insan.el} İnsan Ayağı:{insan.ayak}\n Köpek \n Köpek eli:{hayvan.el} Köpek Ayağı: {hayvan.ayak} ");

         
        }
    }
}
