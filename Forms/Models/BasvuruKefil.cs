using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
    public class BasvuruKefil
    {
        public int kefilId { get; set; }
        public int basvuruId { get; set; }
        public int musteriId { get; set; }
        public string kefilGelirTip { get; set; }
        public decimal kefilGelirMiktari { get; set; }
        public string yakinlikDurumu { get; set; }
        public decimal teminat { get; set; }

    }
}
