using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterface_Arayüz_
{
    public class Forvet : IFutbolcu
    {
        public string AdSoyad { get; set; }
        public byte Agresiflik { get; set; }
        public byte Refleks { get; set; }
        public int FormaNumarası { get; set; }
        public bool MilliMi { get; set; }
        public byte SutGucu { get; set; }

        public void PasAt()
        {
            throw new NotImplementedException();
        }

        public void SutCek()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return AdSoyad;
        }
    }
}
