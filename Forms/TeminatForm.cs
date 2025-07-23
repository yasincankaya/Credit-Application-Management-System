using Forms.Repositories;
using Forms.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Forms
{
    public partial class TeminatForm : Form
    {
        private BasvuruKefil kefil1;
        private BasvuruKefil kefil2;
        private string referansNo2;
        public TeminatTip staticTeminatTip;
        private List<TeminatGoruntuModel> teminatGoruntuListesi = new List<TeminatGoruntuModel>();

        public TeminatForm(string referansNo, BasvuruKefil kefil1, BasvuruKefil kefil2)
        {
            InitializeComponent();

            btnCinsSec.Enabled = false;
            SetAllInputs(false);

            this.kefil1 = kefil1;
            this.kefil2 = kefil2;

            this.referansNo2 = referansNo;

            var repoBasvuru = new BasvuruRepository();
            var basvuru = repoBasvuru.GetBasvuruByReferansNo(referansNo);

            
            if (basvuru == null)
            {
                MessageBox.Show("Başvuru bulunamadı!");
                return;
            }

            var repoMusteri = new MusteriRepository();

            if (kefil1 != null && kefil1.musteriId > 0)
            {
                var musteri1 = repoMusteri.GetClient(kefil1.musteriId);
                if (musteri1 != null)
                {
                    txtKefil1Ad.Text = musteri1.ad;
                    txtKefil1Soyad.Text = musteri1.soyad;
                    txtKefil1MusNo.Text = musteri1.musteriID.ToString();
                }
            }

            if (kefil2 != null && kefil2.musteriId > 0)
            {
                var musteri2 = repoMusteri.GetClient(kefil2.musteriId);
                if (musteri2 != null)
                {
                    txtKefil2Ad.Text = musteri2.ad;
                    txtKefil2Soyad.Text = musteri2.soyad;
                    txtKefil2MusNo.Text = musteri2.musteriID.ToString();
                }
            }

            var repoUrun = new UrunRepository();
            var urun = repoUrun.GetUrunById(basvuru.urunID);

            txtUrunAd.Text = urun.urunAd;

            TabloyaYaz();



        }

        private void btnTipSec_Click(object sender, EventArgs e)
        {
            TeminatTipForm form = new TeminatTipForm(referansNo2);
            if (form.ShowDialog() == DialogResult.OK)
            {
                var secilenTip = form.SecilenTeminatTip;
                txtTeminatTipId.Text = secilenTip.tipId.ToString();
                txtTeminatTipAd.Text = secilenTip.teminatTipAd;
                staticTeminatTip = secilenTip;

                if (secilenTip != null)
                {
                    btnCinsSec.Enabled = true;
                    txtTeminatCinsId.Text = "";
                    txtTeminatCinsAd.Text = "";
                }
                txtTeminatTipId_TextChanged(null, null);
                
            }
        }

        private void TabloyaYaz()
        {

            var repoBasvuru = new BasvuruRepository();
            var basvuru = repoBasvuru.GetBasvuruByReferansNo(referansNo2);

            var teminatRepo = new TeminatRepository();
            var teminatlar = teminatRepo.GetTeminatlarByBasvuruId(basvuru.basvuruId);

            var repoTeminatTip = new TeminatTipRepository();
            var repoTeminatCins = new TeminatCinsRepository();

            var repoUrun = new UrunRepository();
            var urun = repoUrun.GetUrunById(basvuru.urunID);


            foreach (var teminat in teminatlar)
            {
                var teminatCins = repoTeminatCins.GetById(teminat.cinsId);
                var teminatTip = repoTeminatTip.GetTeminatTipByCinsId(teminat.cinsId);

                teminatGoruntuListesi.Add(new TeminatGoruntuModel
                {
                    dovizCinsi = teminat.dovizCinsi,
                    teminatTutari = teminat.teminatTutar,
                    urunTipKod = urun.tipKod,
                    urunId = basvuru.urunID.ToString(),
                    teminatTipAd = teminatTip.teminatTipAd,
                    teminatCinsAd = teminatCins?.cinsAd ?? ""
                });
            }

            // Tabloya bind et
            teminatTablosu.AutoGenerateColumns = false;
            teminatTablosu.DataSource = null;
            teminatTablosu.DataSource = teminatGoruntuListesi;
        }

        private void btnCinsSec_Click(object sender, EventArgs e)
        {
            TeminatCinsForm form = new TeminatCinsForm(referansNo2, staticTeminatTip);
            if (form.ShowDialog() == DialogResult.OK)
            {
                var secilenCins = form.SecilenTeminatCins;
                txtTeminatCinsId.Text = secilenCins.cinsId.ToString();
                txtTeminatCinsAd.Text = secilenCins.cinsAd;

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var basvuruRepo = new BasvuruRepository();
            var basvuru = basvuruRepo.GetBasvuruByReferansNo(referansNo2);

            var teminatRepo = new TeminatRepository();
            var teminat = new Teminat();

            if (!int.TryParse(txtTeminatTipId.Text, out int tipId))
            {
                MessageBox.Show("Teminat Tip ID geçersiz.");
                return;
            }

            // Ortak alan: Teminat Cins
            if (!int.TryParse(txtTeminatCinsId.Text, out int cinsId))
            {
                MessageBox.Show("Geçerli bir Cins ID giriniz.");
                return;
            }
            teminat.cinsId = cinsId;

            // Tip bazlı kontroller
            switch (tipId)
            {
                case 1: // KEFALET
                case 3: // MEVDUAT REHNİ
                    if (!decimal.TryParse(txtTeminatTutar.Text, out decimal tutar))
                    {
                        MessageBox.Show("Geçerli bir teminat tutarı giriniz.");
                        return;
                    }
                    teminat.teminatTutar = tutar;

                    if (string.IsNullOrWhiteSpace(comboDovizCinsi.Text))
                    {
                        MessageBox.Show("Döviz cinsi seçiniz.");
                        return;
                    }
                    teminat.dovizCinsi = comboDovizCinsi.Text.Trim();
                    break;

                case 2: // İPOTEK
                    if (string.IsNullOrWhiteSpace(comboKonutTipi.Text))
                    {
                        MessageBox.Show("Konut tipini seçiniz.");
                        return;
                    }
                    teminat.konutTipi = comboKonutTipi.Text.Trim();

                    if (!int.TryParse(txtIpotekDerecesi.Text, out int derece))
                    {
                        MessageBox.Show("Geçerli bir ipotek derecesi giriniz.");
                        return;
                    }
                    teminat.ipotekDerecesi = derece;

                    if (!decimal.TryParse(txtSatisTutari.Text, out decimal satisTutar))
                    {
                        MessageBox.Show("Geçerli bir satış tutarı giriniz.");
                        return;
                    }
                    teminat.aracSatisTutar = satisTutar;
                    if (!DateTime.TryParse(dateSatisTarihi.Text, out DateTime satisTarihi))
                    {
                        MessageBox.Show("Geçerli bir satış tarihi giriniz.");
                        return;
                    }
                    teminat.satisTarihi = satisTarihi;
                    break;

                case 4: // ARAÇ REHNİ
                    if (!decimal.TryParse(txtKaskoDegeri.Text, out decimal kasko))
                    {
                        MessageBox.Show("Geçerli bir kasko değeri giriniz.");
                        return;
                    }
                    teminat.kaskoDegeri = kasko;

                    if (string.IsNullOrWhiteSpace(txtAracModel.Text))
                    {
                        MessageBox.Show("Araç modeli boş olamaz.");
                        return;
                    }
                    teminat.aracModel = txtAracModel.Text.Trim();

                    if (!int.TryParse(txtAracModelYili.Text, out int modelYili))
                    {
                        MessageBox.Show("Geçerli bir araç model yılı giriniz.");
                        return;
                    }
                    teminat.aracModelYili = modelYili;

                    if (string.IsNullOrWhiteSpace(txtAracSasiNo.Text))
                    {
                        MessageBox.Show("Araç şasi no giriniz.");
                        return;
                    }
                    teminat.aracSasiNo = txtAracSasiNo.Text.Trim();
                    break;

                default:
                    MessageBox.Show("Bilinmeyen teminat tipi.");
                    return;
            }

            // Ortak alanlar
            teminat.basvuruId = basvuru.basvuruId;
            teminat.satisTarihi = dateSatisTarihi.Checked ? dateSatisTarihi.Value : null;
            teminat.ekspertizSekli = comboEkspertizSekli.Text.Trim();
            teminat.enerjiKimlik = comboEnerjiKimlikSinifi.Text.Trim();

            // Kayıt işlemi
            teminatRepo.Create(teminat);

            // Görsel listeye ekleme
            /*teminatGoruntuListesi.Add(new TeminatGoruntuModel
            {
                dovizCinsi = teminat.dovizCinsi,
                teminatTutari = teminat.teminatTutar,
                urunTipKod = txtUrunAd.Text,
                urunId = basvuru.urunID.ToString(),
                teminatTipAd = txtTeminatTipAd.Text,
                teminatCinsAd = txtTeminatCinsAd.Text,
            });

            // Tabloyu yenile
            teminatTablosu.AutoGenerateColumns = false;
            teminatTablosu.DataSource = null;
            teminatTablosu.DataSource = teminatGoruntuListesi;*/
            TabloyaYaz();
            TemizleTumKontroller(groupBox3);
        }


        private void TemizleTumKontroller(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (textBox.Name != "txtUrunAd")
                    {
                        textBox.Clear();
                    }
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (control.HasChildren)
                {
                    // İç içe groupbox/panel varsa onları da temizle
                    TemizleTumKontroller(control);
                }
            }
        }


        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (teminatTablosu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek bir teminat seçin.");
                return;
            }

            var seciliIndex = teminatTablosu.SelectedRows[0].Index;
            var seciliGoruntu = teminatGoruntuListesi[seciliIndex];

            var teminatRepo = new TeminatRepository();
            var teminatlar = teminatRepo.GetAll();

            var guncellenecekTeminat = teminatlar.FirstOrDefault(t =>
                t.dovizCinsi == seciliGoruntu.dovizCinsi &&
                t.teminatTutar == seciliGoruntu.teminatTutari);

            if (guncellenecekTeminat == null)
            {
                MessageBox.Show("Seçilen teminat veritabanında bulunamadı.");
                return;
            }

            int tipId = staticTeminatTip?.tipId ?? 0;

            switch (tipId)
            {
                case 1: // KEFALET
                case 3: // MEVDUAT REHNİ
                    if (!decimal.TryParse(txtTeminatTutar.Text, out decimal yeniTutar))
                    {
                        MessageBox.Show("Geçerli bir teminat tutarı giriniz.");
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(comboDovizCinsi.Text))
                    {
                        MessageBox.Show("Döviz cinsi seçiniz.");
                        return;
                    }
                    if (!int.TryParse(txtTeminatCinsId.Text, out int cinsId1))
                    {
                        MessageBox.Show("Geçerli bir teminat cinsi seçiniz.");
                        return;
                    }
                    guncellenecekTeminat.cinsId = cinsId1;
                    guncellenecekTeminat.teminatTutar = yeniTutar;
                    guncellenecekTeminat.dovizCinsi = comboDovizCinsi.Text.Trim();
                    
                    break;

                case 2: // İPOTEK
                    if (!decimal.TryParse(txtTeminatTutar.Text, out decimal yeniTutar2))
                    {
                        MessageBox.Show("Geçerli bir teminat tutarı giriniz.");
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(comboDovizCinsi.Text))
                    {
                        MessageBox.Show("Döviz cinsi seçiniz.");
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(comboKonutTipi.Text))
                    {
                        MessageBox.Show("Konut tipi seçiniz.");
                        return;
                    }

                    if (!int.TryParse(txtIpotekDerecesi.Text, out int ipotekDerecesi))
                    {
                        MessageBox.Show("Geçerli bir ipotek derecesi giriniz.");
                        return;
                    }

                    if (!decimal.TryParse(txtSatisTutari.Text, out decimal satisTutar))
                    {
                        MessageBox.Show("Geçerli bir satış tutarı giriniz.");
                        return;
                    }

                    if (!dateSatisTarihi.Checked || !DateTime.TryParse(dateSatisTarihi.Text, out DateTime satisTarihi))
                    {
                        MessageBox.Show("Geçerli bir satış tarihi giriniz.");
                        return;
                    }
                    if (!int.TryParse(txtTeminatCinsId.Text, out int cinsId2))
                    {
                        MessageBox.Show("Geçerli bir teminat cinsi seçiniz.");
                        return;
                    }

                    guncellenecekTeminat.konutTipi = comboKonutTipi.Text.Trim();
                    guncellenecekTeminat.ipotekDerecesi = ipotekDerecesi;
                    guncellenecekTeminat.aracSatisTutar = satisTutar;
                    guncellenecekTeminat.satisTarihi = satisTarihi;
                    guncellenecekTeminat.ekspertizSekli = comboEkspertizSekli.Text.Trim();
                    guncellenecekTeminat.enerjiKimlik = comboEnerjiKimlikSinifi.Text.Trim();
                    guncellenecekTeminat.teminatTutar = yeniTutar2;
                    guncellenecekTeminat.dovizCinsi = comboDovizCinsi.Text.Trim();
                    guncellenecekTeminat.cinsId = cinsId2;
                    break;

                case 4: // ARAÇ REHNİ
                    if (!decimal.TryParse(txtTeminatTutar.Text, out decimal yeniTutar3))
                    {
                        MessageBox.Show("Geçerli bir teminat tutarı giriniz.");
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(comboDovizCinsi.Text))
                    {
                        MessageBox.Show("Döviz cinsi seçiniz.");
                        return;
                    }
                    if (!decimal.TryParse(txtKaskoDegeri.Text, out var kasko))
                    {
                        MessageBox.Show("Geçerli bir kasko değeri giriniz.");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(txtAracModel.Text))
                    {
                        MessageBox.Show("Araç modeli giriniz.");
                        return;
                    }

                    if (!int.TryParse(txtAracModelYili.Text, out int modelYili))
                    {
                        MessageBox.Show("Geçerli bir araç model yılı giriniz.");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(txtAracSasiNo.Text))
                    {
                        MessageBox.Show("Şasi numarası boş olamaz.");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(comboEkspertizSekli.Text))
                    {
                        MessageBox.Show("Ekspertiz şeklini seçiniz.");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(comboEnerjiKimlikSinifi.Text))
                    {
                        MessageBox.Show("Enerji kimlik sınıfı seçiniz.");
                        return;
                    }
                    if (!int.TryParse(txtTeminatCinsId.Text, out int cinsId3))
                    {
                        MessageBox.Show("Geçerli bir teminat cinsi seçiniz.");
                        return;
                    }
                    guncellenecekTeminat.cinsId = cinsId3;

                    guncellenecekTeminat.kaskoDegeri = kasko;
                    guncellenecekTeminat.aracModel = txtAracModel.Text.Trim();
                    guncellenecekTeminat.aracModelYili = modelYili;
                    guncellenecekTeminat.aracSasiNo = txtAracSasiNo.Text.Trim();
                    guncellenecekTeminat.ekspertizSekli = comboEkspertizSekli.Text.Trim();
                    guncellenecekTeminat.enerjiKimlik = comboEnerjiKimlikSinifi.Text.Trim();
                    guncellenecekTeminat.teminatTutar = yeniTutar3;
                    guncellenecekTeminat.dovizCinsi = comboDovizCinsi.Text.Trim();
                    break;

                default:
                    MessageBox.Show("Bilinmeyen teminat tipi.");
                    return;
            }

            teminatRepo.Update(guncellenecekTeminat);
            MessageBox.Show("Teminat başarıyla güncellendi.");

            // Görsel listeyi güncelle
            /*if (tipId == 1 || tipId == 3)
            {
                teminatGoruntuListesi[seciliIndex].teminatTutari = guncellenecekTeminat.teminatTutar;
                teminatGoruntuListesi[seciliIndex].dovizCinsi = guncellenecekTeminat.dovizCinsi;
            }

            teminatTablosu.DataSource = null;
            teminatTablosu.DataSource = teminatGoruntuListesi;*/
            teminatGoruntuListesi.Clear();
            TabloyaYaz();


            TemizleTumKontroller(groupBox3);
        }


        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TemizleTumKontroller(groupBox3);
            dateSatisTarihi.Value = DateTime.Now;
            dateSatisTarihi.Checked = false;
        }


        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (teminatTablosu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek bir teminat seçin.");
                return;
            }

            var seciliIndex = teminatTablosu.SelectedRows[0].Index;
            var seciliGoruntu = teminatGoruntuListesi[seciliIndex];

            var teminatRepo = new TeminatRepository();
            var teminatlar = teminatRepo.GetAll();

            var silinecekTeminat = teminatlar.FirstOrDefault(t =>
                t.dovizCinsi == seciliGoruntu.dovizCinsi &&
                t.teminatTutar == seciliGoruntu.teminatTutari);

            if (silinecekTeminat != null)
            {
                teminatRepo.Delete(silinecekTeminat.teminatId);
                teminatGoruntuListesi.RemoveAt(seciliIndex);

                teminatTablosu.DataSource = null;
                teminatTablosu.DataSource = teminatGoruntuListesi;

                MessageBox.Show("Teminat başarıyla silindi.");
            }
            else
            {
                MessageBox.Show("Veritabanında bu teminat bulunamadı.");
            }

            TemizleTumKontroller(groupBox3);
        }

        private void txtTeminatTipId_TextChanged(object sender, EventArgs e)
        {

            SetAllInputs(false);

            if (!int.TryParse(txtTeminatTipId.Text, out int tipId))
                return;

            switch (tipId)
            {
                case 1: // KEFALET
                    txtTeminatTutar.Enabled = true;
                    comboDovizCinsi.Enabled = true;
                    break;

                case 2: // İPOTEK
                    txtTeminatTutar.Enabled = true;
                    comboDovizCinsi.Enabled = true;
                    comboKonutTipi.Enabled = true;
                    txtIpotekDerecesi.Enabled = true;
                    txtSatisTutari.Enabled = true;
                    dateSatisTarihi.Enabled = true;
                    break;

                case 3: // MEVDUAT REHNİ
                    txtTeminatTutar.Enabled = true;
                    comboDovizCinsi.Enabled = true;
                    break;

                case 4: // ARAÇ REHNİ
                    txtTeminatTutar.Enabled = true;
                    comboDovizCinsi.Enabled = true;
                    txtKaskoDegeri.Enabled = true;
                    txtAracModel.Enabled = true;
                    txtAracModelYili.Enabled = true;
                    txtAracSasiNo.Enabled = true;
                    comboEkspertizSekli.Enabled = true;
                    comboEnerjiKimlikSinifi.Enabled = true;
                    break;

                default:
                    break;
            }
        }

        private void SetAllInputs(bool enabled)
        {
            txtTeminatTutar.Enabled = enabled;
            comboDovizCinsi.Enabled = enabled;
            txtKaskoDegeri.Enabled = enabled;
            txtAracModel.Enabled = enabled;
            txtAracModelYili.Enabled = enabled;
            txtAracSasiNo.Enabled = enabled;
            txtSatisTutari.Enabled = enabled;
            txtIpotekDerecesi.Enabled = enabled;
            comboKonutTipi.Enabled = enabled;
            comboEkspertizSekli.Enabled = enabled;
            comboEnerjiKimlikSinifi.Enabled = enabled;
            dateSatisTarihi.Enabled = enabled;
        }


        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
