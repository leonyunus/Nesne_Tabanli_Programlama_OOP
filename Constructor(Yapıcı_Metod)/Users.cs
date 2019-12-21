using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Yapıcı_Metod_
{
    public class Users
    {
        //ctor+tab+tab

        public Users()
        {
            //Yapıcı metotlar sadece hızlı değer atanması için değil, aynı zamanda türetildiği anda yapılmasını istediğimiz işlemleride yerine getirmede kullanılır.

            System.Windows.Forms.MessageBox.Show("Yapıcı metot çalıştı");
        }

        //Constructor metotlar parametreleri, içinde bulunduğu sınıfın hangi property'lerine değer atamak istiyorsak o şekilde yazılırlar ve varsayılan olarak sınıfımdaki tüm property'lere yapıcı metodumuz üzerinnde değerler verebilririz.

        //Bir class çağrıldığında ilk constructor method tetiklenir.

        public string UserName { get; set; }

        public string UserSurname { get; set; }

        public int Age { get; set; }

        public Users(string username, string usersurname, int age)
        {
            this.UserName = username;
            this.UserSurname = username;
            this.Age = age;


        }
    }
}
