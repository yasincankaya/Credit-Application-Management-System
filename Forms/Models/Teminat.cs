namespace Forms.Models
{
    public class Teminat
    {
        public int teminatId { get; set; }
        public int cinsId { get; set; }                    
        public decimal? teminatTutar { get; set; }         
        public string dovizCinsi { get; set; }             
        public decimal? kaskoDegeri { get; set; }
        public int? aracModelYili { get; set; }
        public string aracSasiNo { get; set; }             
        public string aracModel { get; set; }
        public string ekspertizSekli { get; set; }         
        public string enerjiKimlik { get; set; }           
        public DateTime? satisTarihi { get; set; }
        public decimal? aracSatisTutar { get; set; }
        public string konutTipi { get; set; }              
        public int? ipotekDerecesi { get; set; }
        public int? basvuruId { get; set; } 
    }
}
