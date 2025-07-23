using Forms.Models;
using Forms.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class YeniBasvuruForm : Form
    {
        public static YeniBasvuruForm instance;
        public TextBox tbAd;
        public TextBox tbId;
        public TextBox tbKod;


        public YeniBasvuruForm(int musteriID)
        {

            InitializeComponent();
            instance = this;
            tbAd = txtUrunAd;
            tbId = txtUrunNo;
            tbKod = txtUrunKod;

            txtGelir.Enabled = false;
            txtGelir2.Enabled = false;
            btnAsgari.Enabled = false;

            txtUrunAd.Enabled = false;
            txtUrunNo.Enabled = false;
            txtUrunKod.Enabled = false;

            var repo = new MusteriRepository();
            var musteri = repo.GetClient(musteriID);
            /*var basvuruRepo = new BasvuruRepository();
            var basvuru = basvuruRepo.*/

            Random rnd = new Random();
            int rastgele = rnd.Next(1, 999999999);

            txtMusteriID.Text = musteriID.ToString();
            txtReferansNo.Text = rastgele.ToString();
            txtBasvuruTarihi.Text = DateTime.Now.ToString("dd.MM.yyyy");

        }

        private void btnUrunSec_Click(object sender, EventArgs e)
        {
            UrunSecForm urunSec = new UrunSecForm();
            urunSec.ShowDialog();
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            try
            {
                var repo = new BasvuruRepository();
                Basvuru basvuru = new Basvuru();

                if (!int.TryParse(txtMusteriID.Text, out int musteriId))
                {
                    MessageBox.Show("Geçerli bir Müşteri ID giriniz!");
                    return;
                }
                if (!int.TryParse(txtUrunNo.Text, out int urunId))
                {
                    MessageBox.Show("Geçerli bir Ürün ID giriniz!");
                    return;
                }
                if (!decimal.TryParse(txtTutar.Text, out decimal tutar))
                {
                    MessageBox.Show("Geçerli bir tutar giriniz!");
                    return;
                }
                if (!int.TryParse(comboVade.Text, out int vade))
                {
                    MessageBox.Show("Geçerli bir vade seçiniz!");
                    return;
                }

                var repoUrun = new UrunRepository();
                var urun = repoUrun.GetUrunById(urunId);

                if (urun == null || string.IsNullOrEmpty(urun.tip))
                {
                    MessageBox.Show("Seçili ürün bulunamadı veya tipi tanımsız!");
                    return;
                }

                string tip = urun.tip.ToLower();

                if (tip == "ihtiyaç kredileri")
                {
                    if (tutar < 500 || tutar > 500000)
                    {
                        MessageBox.Show("İhtiyaç kredisi için tutar 500 - 500.000 TL arasında olmalıdır!");
                        return;
                    }
                }
                else if (tip == "konut kredileri")
                {
                    if (tutar < 1000 || tutar > 10000000)
                    {
                        MessageBox.Show("Konut kredisi için tutar 1.000 - 10.000.000 TL arasında olmalıdır!");
                        return;
                    }
                }
                else if (tip == "taşıt kredileri")
                {
                    if (tutar < 1000 || tutar > 280000)
                    {
                        MessageBox.Show("Taşıt kredisi için tutar 1.000 - 280.000 TL arasında olmalıdır!");
                        return;
                    }
                }
                else
                {
                    if (tutar < 500 || tutar > 10000000)
                    {
                        MessageBox.Show("Diğer krediler için tutar 1.000 - 10.000.000 TL arasında olmalıdır!");
                        return;
                    }
                }

                bool gelir1Var = decimal.TryParse(txtGelir.Text, out decimal gelir1) && gelir1 >= 1000 && !string.IsNullOrWhiteSpace(comboGelirTip.Text);
                bool gelir2Var = decimal.TryParse(txtGelir2.Text, out decimal gelir2) && gelir2 >= 1000 && !string.IsNullOrWhiteSpace(comboGelirTip2.Text);

                if (decimal.TryParse(txtGelir.Text, out gelir1) && gelir1 > 0 && gelir1 < 1000)
                {
                    MessageBox.Show("Birinci gelir değeri en az 1000 TL olmalıdır!");
                    return;
                }

                if (decimal.TryParse(txtGelir2.Text, out gelir2) && gelir2 > 0 && gelir2 < 1000)
                {
                    MessageBox.Show("İkinci gelir değeri en az 1000 TL olmalıdır!");
                    return;
                }


                if (!gelir1Var && !gelir2Var)
                {
                    MessageBox.Show("En az bir gelir değeri girmelisiniz ve bu değer en az 1000 TL olmalıdır!");
                    return;
                }

                var repoGelir = new GelirRepository();

                basvuru.musteriID = musteriId;
                basvuru.urunID = urunId;
                basvuru.referansNo = txtReferansNo.Text?.Trim();
                basvuru.tutar = tutar;
                basvuru.vade = vade;
                basvuru.basvuruTarihi = DateTime.Now;
                basvuru.onayDurumu = 1;

                int basvuruId = repo.CreateBasvuru(basvuru);

                if (gelir1Var)
                {
                    repoGelir.AddGelirTipi(basvuruId, comboGelirTip.Text?.Trim(), gelir1);
                }
                if (gelir2Var)
                {
                    repoGelir.AddGelirTipi(basvuruId, comboGelirTip2.Text?.Trim(), gelir2);
                }

                MessageBox.Show("Ön başvuru eklendi!");
                this.Close();

                DetayliBasvuruForm detayliBasvuru = new DetayliBasvuruForm(basvuru.referansNo);
                detayliBasvuru.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }




        private void btnAsgari_Click(object sender, EventArgs e)
        {
            txtGelir.Text = "22.104";
        }

        private void comboGelirTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboGelirTip.SelectedIndex >= 0 && comboGelirTip.SelectedIndex != 0)
            {
                txtGelir.Enabled = true;

                string selected = comboGelirTip.SelectedItem.ToString();

                if (selected == "Ücretli")
                {
                    btnAsgari.Enabled = true;
                }
                else
                {
                    btnAsgari.Enabled = false;
                }
            }
            else
            {
                txtGelir.Enabled = false;
                btnAsgari.Enabled = false;
            }
        }

        private void comboGelirTip2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboGelirTip2.SelectedIndex >= 0 && comboGelirTip2.SelectedIndex != 0)
            {
                txtGelir2.Enabled = true;

                string selected = comboGelirTip2.SelectedItem.ToString();

                
            }
            else
            {
                txtGelir2.Enabled = false;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtUrunAd.Text = "";
            txtUrunNo.Text = "";
            txtUrunKod.Text = "";
            txtTutar.Text = "";
            txtGelir.Text = "";

            comboVade.SelectedIndex = -1;
            comboGelirTip.SelectedIndex = -1;

            txtGelir.Enabled = false;
            btnAsgari.Enabled = false;

            tbAd.Text = "";
            tbId.Text = "";
            tbKod.Text = "";
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
