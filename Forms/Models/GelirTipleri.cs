using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
    public class GelirTipleri
    {
        public int gelirTipId { get; set; }
        public int basvuruId { get; set; }
        public string gelirTip { get; set; }
        public decimal gelirMiktari { get; set; }
    }
}
