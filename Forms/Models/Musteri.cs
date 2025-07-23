using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
    public class Musteri
    {
        public int musteriID { get; set; }
        public string tcKimlikNo { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string adres { get; set; }
        public DateTime dogumTarihi { get; set; }
        public string dogumYeri { get; set; }
        public string babaAdi { get; set; }
        public string anneAdi { get; set; }
        public string cinsiyet { get; set; }         
        public string medeniHal { get; set; }

    }
}
