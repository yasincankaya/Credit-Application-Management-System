using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
    public class Basvuru
    {
        public int basvuruId { get; set; }
        public int musteriID { get; set; }
        public int urunID { get; set; }
        public string referansNo { get; set; }
        public decimal tutar { get; set; }
        public int vade { get; set; }
        public DateTime basvuruTarihi { get; set; }
        public int? ikametSuresi { get; set; } // null olabilsin diye int?
        public bool? konutuVarMi { get; set; } // null olabilsin diye bool?
        public bool? tasitiVarMi { get; set; } 
        public string telefonNo { get; set; }
        public string oturulanEv { get; set; }
        public int? odemeGunu { get; set; }
        public string geriOdemeTercihi { get; set; }
        public string satisKaynagi { get; set; }
        public string maasDurumu { get; set; }
        public string kullanimAmaci {  get; set; }
        public int? maasGunu { get; set; }
        public int? teminatId { get; set; }
        public int? onayDurumu { get; set; }


    }
}
