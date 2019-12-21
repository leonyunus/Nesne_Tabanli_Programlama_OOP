using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation_Kapsülleme_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Users user = new Users();

          

          try
            {

                user.UserFirstName = txtFirstName.Text;
                user.UserLastName = txtLastName.Text;
                user.Age = (DateTime.Now.Year - Convert.ToDateTime(mskAge.Text).Year);
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen değerleri boş geçmeyiniz..!");
            }


            if (user.Age > 18)
            {
                MessageBox.Show($"Kullanıcı Adı:{user.UserFirstName}\n Kullanıcı Soyadı:{user.UserLastName}\n Yas:{user.Age}");
            }
        }
    }
}
