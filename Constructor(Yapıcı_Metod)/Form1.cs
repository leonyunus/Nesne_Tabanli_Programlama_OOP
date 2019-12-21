using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor_Yapıcı_Metod_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Users users = new Users()
            {
                UserName = "Yunus",
                UserSurname = "Arslan",
                Age = 23


            };

            MessageBox.Show($"{users.UserName} {users.UserSurname} {users.Age}");
        }
    }
}
