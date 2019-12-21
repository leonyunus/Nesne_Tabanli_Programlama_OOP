using Abtract_Soyut_.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abtract_Soyut_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Keman keman = new Keman();
        Gitar gitar = new Gitar();

        private void Form1_Load(object sender, EventArgs e)
        {


           
            keman.Marka = "Hora";
            keman.Aciklama = "Hora";


            
            gitar.Marka = "Yamaha";
            gitar.Aciklama = "F310";

            MessageBox.Show($"Keman Markası: {keman.Marka}\nKeman Açıklaması: {keman.Aciklama}\n ---------- \n Gitar Markası : {gitar.Marka} \n Gitar Açıklaması: {gitar.Aciklama} ");

           
        }
    }
}
