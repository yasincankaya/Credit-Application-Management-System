using Forms.Models;
using Forms.Repositories;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Forms
{
    public partial class DetayliBasvuruForm : Form
    {
        BasvuruKefil kefil1 = new BasvuruKefil();
        BasvuruKefil kefil2 = new BasvuruKefil();
        public DetayliBasvuruForm(string referansNo)
        {
            InitializeComponent();

            var repoBasvuru = new BasvuruRepository();
            var basvuru = repoBasvuru.GetBasvuruByReferansNo(referansNo);

            var repoMusteri = new MusteriRepository();
            var musteri = repoMusteri.GetClient(basvuru.musteriID);

            var repoUrun = new UrunRepository();
            var urun = repoUrun.GetUrunById(basvuru.urunID);

            //Kişisel Ekran Load

            txtReferansNo.Text = referansNo;
            txtBasvuruTarihi.Text = basvuru.basvuruTarihi.ToString("dd.MM.yyyy");
            txtMusteriNo.Text = musteri.musteriID.ToString();
            txtTckn.Text = musteri.tcKimlikNo.ToString();
            txtAdi.Text = musteri.ad;
            txtSoyadi.Text = musteri.soyad;
            txtDogumTarihi.Text = musteri.dogumTarihi.ToString();

            var repoGelir = new GelirRepository();
            var gelirler = repoGelir.GetGelirTipleriByBasvuruId(basvuru.basvuruId);

            foreach (var gelir in gelirler) //Ücretli,Serbest,Menkul,Kira,Emekli,Part Time,Zirai
            {
                if (gelir.gelirTip == "Ücretli")
                {
                    txtUcretli.Text = gelir.gelirMiktari.ToString();
                }
                if (gelir.gelirTip == "Serbest")
                {
                    txtSerbest.Text = gelir.gelirMiktari.ToString();
                }
                if (gelir.gelirTip == "Menkul")
                {
                    txtMenkul.Text = gelir.gelirMiktari.ToString();
                }
                if (gelir.gelirTip == "Kira")
                {
                    txtKira.Text = gelir.gelirMiktari.ToString();
                }
                if (gelir.gelirTip == "Emekli")
                {
                    txtEmekli.Text = gelir.gelirMiktari.ToString();
                }
                if (gelir.gelirTip == "Part Time")
                {
                    txtPartTime.Text = gelir.gelirMiktari.ToString();
                }
                if (gelir.gelirTip == "Zirai")
                {
                    txtZirai.Text = gelir.gelirMiktari.ToString();
                }


            }

            //Kefil Ekran Load

            grpKefilBilgileri.Enabled = false;

            //Ürün Şube Ekran Load

            if (urun.tipKod == "BK")
            {
                txtBK.Text = urun.urunId.ToString();
                txtBKAd.Text = urun.urunAd;
            }
            if (urun.tipKod == "BG")
            {
                if (urun.tip == "Çek Taahhüt Kredisi")
                {
                    txtBG1.Text = urun.urunId.ToString();
                    txtBG1Ad.Text = urun.urunAd;
                }
                if (urun.tip == "Türev İşlemler Kredisi")
                {
                    txtBG2.Text = urun.urunId.ToString();
                    txtBG2Ad.Text = urun.urunAd;
                }
            }
            if (urun.tip == "KK")
            {
                txtKK.Text = urun.urunId.ToString();
                txtKKAd.Text = urun.urunAd;
            }

            txtVade.Text = basvuru.vade.ToString();



        }

        private void btnKefilAra_Click(object sender, EventArgs e)
        {
            var repoMusteri = new MusteriRepository();
            Musteri musteri = null;

            // Öncelikle müşteri numarası girilmiş mi kontrol et
            if (int.TryParse(txtKefilMusNo.Text, out int kefilMusteriId))
            {
                musteri = repoMusteri.GetClient(kefilMusteriId);
            }
            else if (!string.IsNullOrWhiteSpace(txtKefilTcNo.Text)) // Eğer müşteri numarası değilse, TC ile ara
            {
                musteri = repoMusteri.GetClientByTc(txtKefilTcNo.Text.Trim());
            }

            if (musteri != null)
            {
                txtKefilMusNo.Text = musteri.musteriID.ToString(); // ID'yi kutuya yaz
                txtKefilAd.Text = musteri.ad;
                txtKefilSoyad.Text = musteri.soyad;
                txtKefilTcNo.Text = musteri.tcKimlikNo;
                txtKefilDogumTarihi.Text = musteri.dogumTarihi.ToShortDateString();
                txtKefilDogumYeri.Text = musteri.dogumYeri;
                txtKefilBabaAdi.Text = musteri.babaAdi;
                txtKefilAnneAdi.Text = musteri.anneAdi;
                txtCinsiyet.Text = musteri.cinsiyet;
                txtMedeniHal.Text = musteri.medeniHal;
            }
            else
            {
                MessageBox.Show("Girilen müşteri numarası veya T.C. Kimlik numarasıyla eşleşen bir kefil bulunamadı.");
            }
        }


        private void btnKayit_Click(object sender, EventArgs e)
        {
            var repoBasvuru = new BasvuruRepository();
            var repoGelir = new GelirRepository();
            var repoKefil = new BasvuruKefilRepository();

            string referans = txtReferansNo.Text?.Trim();
            if (string.IsNullOrEmpty(referans))
            {
                MessageBox.Show("Referans numarası boş olamaz!");
                return;
            }

            var basvuru = repoBasvuru.GetBasvuruByReferansNo(referans);
            if (basvuru == null)
            {
                MessageBox.Show("Geçerli bir başvuru bulunamadı! Lütfen referans numarasını kontrol edin.");
                return;
            }

            // Oturulan ev
            if (string.IsNullOrWhiteSpace(comboOturulanEv.Text))
            {
                MessageBox.Show("Oturulan ev tipini seçiniz!");
                return;
            }
            basvuru.oturulanEv = comboOturulanEv.Text.Trim();

            // İkamet süresi
            if (!int.TryParse(txtIkametSüresi.Text, out int ikamet) || ikamet < 0)
            {
                MessageBox.Show("Geçerli ve pozitif bir ikamet süresi giriniz!");
                return;
            }
            basvuru.ikametSuresi = ikamet;

            // Konut / Taşıt var mı kontrolü
            if (rKonutEvet.Checked)
                basvuru.konutuVarMi = true;
            else if (rKonutHayir.Checked)
                basvuru.konutuVarMi = false;
            else
            {
                MessageBox.Show("Lütfen konut durumunu seçiniz!");
                return;
            }

            if (rTasitEvet.Checked)
                basvuru.tasitiVarMi = true;
            else if (rTasitHayir.Checked)
                basvuru.tasitiVarMi = false;
            else
            {
                MessageBox.Show("Lütfen taşıt durumunu seçiniz!");
                return;
            }

            // Gelir tiplerinden en az birinin girildiğini ve ≥1000 TL olduğunu kontrol et
            bool enAzBirGelirVar = false;

            if (!string.IsNullOrEmpty(txtUcretli.Text))
            {
                if (decimal.TryParse(txtUcretli.Text, out decimal miktar) && miktar >= 1000)
                {
                    repoGelir.AddOrUpdateGelirTipi(basvuru.basvuruId, "Ücretli", miktar);
                    enAzBirGelirVar = true;
                }
                else
                {
                    MessageBox.Show("Ücretli gelir miktarı en az 1000 TL olmalıdır!");
                    return;
                }
            }

            if (!string.IsNullOrEmpty(txtSerbest.Text))
            {
                if (decimal.TryParse(txtSerbest.Text, out decimal miktar) && miktar >= 1000)
                {
                    repoGelir.AddOrUpdateGelirTipi(basvuru.basvuruId, "Serbest", miktar);
                    enAzBirGelirVar = true;
                }
                else
                {
                    MessageBox.Show("Serbest gelir miktarı en az 1000 TL olmalıdır!");
                    return;
                }
            }

            if (!string.IsNullOrEmpty(txtMenkul.Text))
            {
                if (decimal.TryParse(txtMenkul.Text, out decimal miktar) && miktar >= 1000)
                {
                    repoGelir.AddOrUpdateGelirTipi(basvuru.basvuruId, "Menkul", miktar);
                    enAzBirGelirVar = true;
                }
                else
                {
                    MessageBox.Show("Menkul gelir miktarı en az 1000 TL olmalıdır!");
                    return;
                }
            }

            if (!string.IsNullOrEmpty(txtKira.Text))
            {
                if (decimal.TryParse(txtKira.Text, out decimal miktar) && miktar >= 1000)
                {
                    repoGelir.AddOrUpdateGelirTipi(basvuru.basvuruId, "Kira", miktar);
                    enAzBirGelirVar = true;
                }
                else
                {
                    MessageBox.Show("Kira gelir miktarı en az 1000 TL olmalıdır!");
                    return;
                }
            }

            if (!string.IsNullOrEmpty(txtEmekli.Text))
            {
                if (decimal.TryParse(txtEmekli.Text, out decimal miktar) && miktar >= 1000)
                {
                    repoGelir.AddOrUpdateGelirTipi(basvuru.basvuruId, "Emekli", miktar);
                    enAzBirGelirVar = true;
                }
                else
                {
                    MessageBox.Show("Emekli gelir miktarı en az 1000 TL olmalıdır!");
                    return;
                }
            }

            if (!string.IsNullOrEmpty(txtPartTime.Text))
            {
                if (decimal.TryParse(txtPartTime.Text, out decimal miktar) && miktar >= 1000)
                {
                    repoGelir.AddOrUpdateGelirTipi(basvuru.basvuruId, "Part Time", miktar);
                    enAzBirGelirVar = true;
                }
                else
                {
                    MessageBox.Show("Part Time gelir miktarı en az 1000 TL olmalıdır!");
                    return;
                }
            }

            if (!string.IsNullOrEmpty(txtZirai.Text))
            {
                if (decimal.TryParse(txtZirai.Text, out decimal miktar) && miktar >= 1000)
                {
                    repoGelir.AddOrUpdateGelirTipi(basvuru.basvuruId, "Zirai", miktar);
                    enAzBirGelirVar = true;
                }
                else
                {
                    MessageBox.Show("Zirai gelir miktarı en az 1000 TL olmalıdır!");
                    return;
                }
            }

            if (!enAzBirGelirVar)
            {
                MessageBox.Show("En az bir gelir türü girmelisiniz ve bu değer en az 1000 TL olmalıdır!");
                return;
            }

            // Kefiller checkbox işaretliyse ve doldurulduysa kaydet
            if (chkKefilVar.Checked)
            {
                repoKefil.Create(kefil1);
                repoKefil.Create(kefil2);
            }

            // Ürün/Şube Ekran Kayıt


            if (!int.TryParse(txtOdemeGunu.Text, out int odemeGunu))
            {
                MessageBox.Show("Lütfen geçerli bir ödeme günü giriniz!");
                return;
            }
            basvuru.odemeGunu = odemeGunu;

            // Geri Ödeme Tercihi Kontrolü
            if (string.IsNullOrWhiteSpace(comboGeriOdeme.Text))
            {
                MessageBox.Show("Lütfen bir geri ödeme tercihi seçiniz!");
                return;
            }
            basvuru.geriOdemeTercihi = comboGeriOdeme.Text;

            // Satış Kaynağı Kontrolü
            if (string.IsNullOrWhiteSpace(comboSatisKaynagi.Text))
            {
                MessageBox.Show("Lütfen bir satış kaynağı seçiniz!");
                return;
            }
            basvuru.satisKaynagi = comboSatisKaynagi.Text;

            // Maaş Durumu Kontrolü
            if (string.IsNullOrWhiteSpace(comboMaasDurumu.Text))
            {
                MessageBox.Show("Lütfen bir maaş durumu seçiniz!");
                return;
            }
            basvuru.maasDurumu = comboMaasDurumu.Text;

            // Maaş Günü Kontrolü
            if (!int.TryParse(txtMaasGunu.Text, out int maasGunu))
            {
                MessageBox.Show("Lütfen geçerli bir maaş günü giriniz!");
                return;
            }
            basvuru.maasGunu = maasGunu;

            // Kullanım Amacı (Radio Button) Kontrolü
            if (radioTasit.Checked)
                basvuru.kullanimAmaci = radioTasit.Text;
            else if (radioBorc.Checked)
                basvuru.kullanimAmaci = radioBorc.Text;
            else if (radioEv.Checked)
                basvuru.kullanimAmaci = radioEv.Text;
            else if (radioDiger.Checked)
                basvuru.kullanimAmaci = radioDiger.Text;
            else
            {
                MessageBox.Show("Lütfen bir kullanım amacı seçiniz!");
                return; // Seçim yoksa kaydetme
            }

            // Onay Durumu Sabit Veriliyor
            basvuru.onayDurumu = 2;

            // Güncelleme ve Bilgilendirme
            repoBasvuru.UpdateBasvuru(basvuru);
            MessageBox.Show("Başvuru başarıyla güncellendi!");
        }


        private void chkKefilVar_CheckedChanged(object sender, EventArgs e)
        {
            UpdateKefilBilgileriEnabled();
        }

        private void btnKefilEkle_Click(object sender, EventArgs e)
        {
            // Seçili olan kefil nesnesini bul
            BasvuruKefil aktifKefil = radioKefil1.Checked ? kefil1 : kefil2;

            var repoBasvuru = new BasvuruRepository();
            Basvuru basvuru = repoBasvuru.GetBasvuruByReferansNo(txtReferansNo.Text);
            aktifKefil.basvuruId = basvuru.basvuruId;

            if (int.TryParse(txtKefilMusNo.Text, out int kefilMusteriId))
                aktifKefil.musteriId = kefilMusteriId;
            else
            {
                MessageBox.Show("Geçerli bir kefil müşteri ID giriniz!");
                return;
            }

            aktifKefil.kefilGelirTip = comboKefilGelirTipi.Text;

            if (!decimal.TryParse(txtKefilGelirMik.Text, out decimal kefilGelirMiktari))
            {
                MessageBox.Show("Geçerli bir kefil gelir miktarı giriniz!");
                return;
            }
            aktifKefil.kefilGelirMiktari = kefilGelirMiktari;

            aktifKefil.yakinlikDurumu = comboYakinlik.Text;

            if (!decimal.TryParse(txtTeminat.Text, out decimal teminat))
            {
                MessageBox.Show("Geçerli bir teminat tutarı giriniz!");
                return;
            }
            aktifKefil.teminat = teminat;

            MessageBox.Show($"{(radioKefil1.Checked ? "1." : "2.")} kefil bilgileri geçici olarak kaydedildi.");
        }

        private void LoadKefilToForm(BasvuruKefil kefil)
        {
            txtKefilMusNo.Text = kefil.musteriId > 0 ? kefil.musteriId.ToString() : "";
            comboKefilGelirTipi.Text = kefil.kefilGelirTip ?? "";
            txtKefilGelirMik.Text = kefil.kefilGelirMiktari > 0 ? kefil.kefilGelirMiktari.ToString() : "";
            comboYakinlik.Text = kefil.yakinlikDurumu ?? "";
            txtTeminat.Text = kefil.teminat > 0 ? kefil.teminat.ToString() : "";

            // Musteriler tablosundan bilgileri al
            var repoMusteri = new MusteriRepository();
            var musteri = repoMusteri.GetClient(kefil.musteriId);

            if (musteri != null)
            {
                txtKefilTcNo.Text = musteri.tcKimlikNo ?? "";
                txtKefilAd.Text = musteri.ad ?? "";
                txtKefilSoyad.Text = musteri.soyad ?? "";
                txtKefilBabaAdi.Text = musteri.babaAdi ?? "";
                txtKefilAnneAdi.Text = musteri.anneAdi ?? "";
                txtKefilDogumYeri.Text = musteri.dogumYeri ?? "";
                txtKefilDogumTarihi.Text = musteri.dogumTarihi.ToString("yyyy-MM-dd");
                txtCinsiyet.Text = musteri.cinsiyet ?? "";
                txtMedeniHal.Text = musteri.medeniHal ?? "";
            }
            else
            {
                // Müşteri bulunamazsa kutuları boş bırak
                txtKefilTcNo.Text = "";
                txtKefilAd.Text = "";
                txtKefilSoyad.Text = "";
                txtKefilBabaAdi.Text = "";
                txtKefilAnneAdi.Text = "";
                txtKefilDogumYeri.Text = "";
                txtKefilDogumTarihi.Text = "";
                txtCinsiyet.Text = "";
                txtMedeniHal.Text = "";
            }
        }


        private void radioKefil1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateKefilBilgileriEnabled();
            if (radioKefil1.Checked)
                LoadKefilToForm(kefil1);
        }

        private void radioKefil2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateKefilBilgileriEnabled();
            if (radioKefil2.Checked)
                LoadKefilToForm(kefil2);
        }

        private void UpdateKefilBilgileriEnabled()
        {
            grpKefilBilgileri.Enabled = chkKefilVar.Checked && (radioKefil1.Checked || radioKefil2.Checked);
        }

        private void btnKisiselAsgari_Click(object sender, EventArgs e)
        {
            txtUcretli.Text = "22.104";
        }

        private void btnKefilAsgari_Click(object sender, EventArgs e)
        {
            txtKefilGelirMik.Text = "22.104";
        }

        private void btnKefilTemizle_Click(object sender, EventArgs e)
        {
            txtKefilMusNo.Text = "";
            txtKefilAd.Text = "";
            txtKefilSoyad.Text = "";
            txtKefilTcNo.Text = "";
            txtKefilDogumTarihi.Text = "";
            txtKefilDogumYeri.Text = "";
            txtKefilBabaAdi.Text = "";
            txtKefilAnneAdi.Text = "";
            txtCinsiyet.Text = "";
            txtMedeniHal.Text = "";
            txtKefilGelirMik.Text = "";
            txtTeminat.Text = "";
            comboKefilGelirTipi.SelectedIndex = -1;
            comboYakinlik.SelectedIndex = -1;
        }

        private void btnUrunSubeTemizle_Click(object sender, EventArgs e)
        {
            txtOdemeGunu.Text = "";
            comboGeriOdeme.SelectedIndex = -1;
            comboMaasDurumu.SelectedIndex = -1;
            comboSatisKaynagi.SelectedIndex = -1;
            txtOdemeGunu.Text = "";
            txtSiraNo.Text = "";
            radioTasit.Checked = false;
            radioBorc.Checked = false;
            radioEv.Checked = false;
            radioDiger.Checked = false;
        }

        private void btnTeminat_Click(object sender, EventArgs e)
        {
            TeminatForm teminatForm = new TeminatForm(txtReferansNo.Text, kefil1, kefil2);
            teminatForm.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
