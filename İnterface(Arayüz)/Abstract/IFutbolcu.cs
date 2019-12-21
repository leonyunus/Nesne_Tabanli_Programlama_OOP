using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterface_Arayüz_
{
   public interface IFutbolcu
    {
        string AdSoyad { get; set; }
        byte Agresiflik { get; set; }
        byte Refleks { get; set; }
        int FormaNumarası { get; set; }
        bool MilliMi { get; set; }
        byte SutGucu { get; set; }

        void PasAt();
        void SutCek();
        
    }
}
