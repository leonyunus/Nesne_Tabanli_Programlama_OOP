using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Kapsülleme_
{
    public class Base
    {
        public int ID { get; set; }

        public string UserFirstName { get; set; }

        public string UserLastName { get; set; }

        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 18)
                {
                    _age = value;
                }

                else
                {
                   System.Windows.Forms.MessageBox.Show("Reşit değilsiniz üye olamazsınız..!");
                }

            }

        }

    }
}
