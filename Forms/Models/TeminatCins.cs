using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
    public class TeminatCins
    {
        public int cinsId { get; set; }
        public int tipId { get; set; }            // Yabancı anahtar
        public string cinsAd { get; set; }
    }
}
