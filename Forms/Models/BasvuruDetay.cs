using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
    public class BasvuruDetay
    {
        public int basvuruId { get; set; }
        public int musteriID { get; set; }
        public int urunID { get; set; }
        public string referansNo { get; set; }
        public decimal tutar { get; set; }
        public int vade { get; set; }
        public string gelirTip { get; set; }
        public DateTime basvuruTarihi { get; set; }
        public decimal gelir { get; set; }
        public string urunAd { get; set; }
        public string tip { get; set; }
        public string tipKod { get; set; }
        public string onayDurumu {  get; set; }
    }
}
