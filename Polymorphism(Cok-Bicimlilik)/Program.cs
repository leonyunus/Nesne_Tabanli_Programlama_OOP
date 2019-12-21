using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Cok_Bicimlilik_
{
    class Program
    {
        static void Main(string[] args)
        {
            string sec;
            Console.WriteLine("1- Anadolu");
            Console.WriteLine("2- MTAL");
            Console.WriteLine("3- Fen");
            Console.Write("Seçiminiz: ");
            sec = Console.ReadLine();

            switch (sec)
            {
                case "1":
                    Anadolu A = new Anadolu();
                    Console.WriteLine(A.okul);
                    Console.ReadKey();
                    break;
                case "2":
                    MTAL M = new MTAL();
                    Console.WriteLine(M.okul);
                    Console.ReadKey();
                    break;
                case "3":
                    Fen F = new Fen();
                    Console.WriteLine(F.okul);
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Yanlış seçim yaptınız.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
