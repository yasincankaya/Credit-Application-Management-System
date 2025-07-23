using Forms.Models;
using Forms.Repositories;
using System.Collections.Immutable;
using System.Data;

namespace Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ReadClients()
        {

            var repo = new MusteriRepository();
            var musteriler = repo.GetClients();
            MessageBox.Show("Toplam müşteri sayısı: " + musteriler.Count);

            this.basvuruTablosu.AutoGenerateColumns = false;
            this.basvuruTablosu.DataSource = musteriler;

        }

        private void btnAddBasvuru_Click(object sender, EventArgs e)
        {
            int musteriID = -1;
            if (Int32.TryParse(txtMusteriID.Text, out musteriID))
            {
                var repo = new MusteriRepository();
                var musteri = repo.GetClient(musteriID);

                if (musteri != null && musteri.ad == txtAd.Text)
                {
                    YeniBasvuruForm yeniBasvuru = new YeniBasvuruForm(musteriID);
                    yeniBasvuru.ShowDialog();
                }

                else
                {
                    MessageBox.Show("Geçerli bir müşteri giriniz.");
                }
            }

            else
            {
                MessageBox.Show("Geçerli bir müşteri numarası giriniz.");
            }



        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Musteri musteri = null;
            var repoMusteri = new MusteriRepository();

            if (int.TryParse(txtMusteriID.Text.Trim(), out int musteriID))
            {
                musteri = repoMusteri.GetClient(musteriID);
            }
            else if (!string.IsNullOrWhiteSpace(txtTCKN.Text.Trim()))
            {
                string tckn = txtTCKN.Text.Trim();
                musteri = repoMusteri.GetClientByTc(tckn);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir Müşteri ID veya TCKN giriniz!");
                return;
            }

            if (musteri != null)
            {
                txtAd.Text = musteri.ad;
                txtSoyad.Text = musteri.soyad;
                txtTCKN.Text = musteri.tcKimlikNo;
                txtMusteriID.Text = musteri.musteriID.ToString();

                var repoBasvuru = new BasvuruRepository();
                var basvurular = repoBasvuru.GetBasvurularByMusteriID(musteri.musteriID);

                var repoUrun = new UrunRepository();
                List<BasvuruDetay> detaylar = new List<BasvuruDetay>();

                foreach (var basvuru in basvurular)
                {
                    var urun = repoUrun.GetUrunById(basvuru.urunID);

                    BasvuruDetay detay = new BasvuruDetay
                    {
                        basvuruId = basvuru.basvuruId,
                        musteriID = basvuru.musteriID,
                        urunID = basvuru.urunID,
                        urunAd = urun?.urunAd,
                        tip = urun?.tip,
                        tipKod = urun?.tipKod,
                        referansNo = basvuru.referansNo,
                        tutar = basvuru.tutar,
                        vade = basvuru.vade,
                        basvuruTarihi = basvuru.basvuruTarihi
                    };
                    if (basvuru.onayDurumu == 1)
                    {
                        detay.onayDurumu = "Ön Başvuruda";
                    }
                    else if (basvuru.onayDurumu == 2)
                    {
                        detay.onayDurumu = "Onaylandı";
                    }
                    else if (basvuru.onayDurumu == 3)
                    {
                        detay.onayDurumu = "İptal Edildi";
                    }

                    detaylar.Add(detay);
                }

                this.basvuruTablosu.AutoGenerateColumns = false;
                basvuruTablosu.DataSource = detaylar;

                txtMusteriID.Enabled = false;
                txtTCKN.Enabled = false;
                txtAd.Enabled = false;
                txtSoyad.Enabled = false;
                btnSearch.Enabled = false;
            }
            else
            {
                MessageBox.Show("Girilen bilgiye ait bir müşteri bulunamadı!");
                txtAd.Text = "";
                txtSoyad.Text = "";
                txtMusteriID.Text = "";
                txtTCKN.Text = "";
            }
        }


        private void btnTemizle_Click(object sender, EventArgs e)
        {
            basvuruTablosu.DataSource = null;

            txtMusteriID.Text = "";
            txtTCKN.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtMusteriID.Enabled = true;
            txtTCKN.Enabled = true;
            btnSearch.Enabled = true;

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMusteriID.Text.Trim(), out int musteriID))
            {
                var repoBasvuru = new BasvuruRepository();
                var basvurular = repoBasvuru.GetBasvurularByMusteriID(musteriID);

                var repoUrun = new UrunRepository();

                List<BasvuruDetay> detaylar = new List<BasvuruDetay>();

                foreach (var basvuru in basvurular)
                {
                    var urun = repoUrun.GetUrunById(basvuru.urunID);

                    BasvuruDetay detay = new BasvuruDetay
                    {
                        basvuruId = basvuru.basvuruId,
                        musteriID = basvuru.musteriID,
                        urunID = basvuru.urunID,
                        urunAd = urun?.urunAd,
                        tip = urun?.tip,
                        tipKod = urun?.tipKod,
                        referansNo = basvuru.referansNo,
                        tutar = basvuru.tutar,
                        vade = basvuru.vade,
                        basvuruTarihi = basvuru.basvuruTarihi
                    };

                    if (basvuru.onayDurumu == 1)
                    {
                        detay.onayDurumu = "Ön Başvuruda";
                    }
                    else if (basvuru.onayDurumu == 2)
                    {
                        detay.onayDurumu = "Onaylandı";
                    }
                    else if (basvuru.onayDurumu == 3)
                    {
                        detay.onayDurumu = "İptal Edildi";
                    }
                    detaylar.Add(detay);
                }

                this.basvuruTablosu.AutoGenerateColumns = false;
                basvuruTablosu.DataSource = detaylar;
            }
            else
            {
                MessageBox.Show("Geçerli bir müşteri ID giriniz!");
            }
        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            var repo = new BasvuruRepository();

            if (basvuruTablosu.CurrentRow == null)
            {
                MessageBox.Show("Lütfen bir başvuru seçiniz.");
                return;
            }

            string referansNo = basvuruTablosu.CurrentRow.Cells["referansNo"].Value.ToString();

            var basvuru = repo.GetBasvuruByReferansNo(referansNo);
            if (basvuru == null)
            {
                MessageBox.Show("Başvuru bulunamadı.");
                return;
            }


            if (basvuru.onayDurumu == 1)
            {
                DetayliBasvuruForm detayliBasvuruForm = new DetayliBasvuruForm(referansNo);
                detayliBasvuruForm.ShowDialog();
            }
            else if (basvuru.onayDurumu == 2)
            {
                BasvuruGoruntuleForm detayForm = new BasvuruGoruntuleForm(referansNo);
                detayForm.ShowDialog();
            }
            else if (basvuru.onayDurumu == 3)
            {
                BasvuruGoruntuleForm detayForm = new BasvuruGoruntuleForm(referansNo);
                detayForm.ShowDialog();
            }



        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            var repo = new BasvuruRepository();

            if (basvuruTablosu.CurrentRow == null)
            {
                MessageBox.Show("Lütfen bir başvuru seçiniz.");
                return;
            }

            string referansNo = basvuruTablosu.CurrentRow.Cells["referansNo"].Value.ToString();

            var basvuru = repo.GetBasvuruByReferansNo(referansNo);
            if (basvuru == null)
            {
                MessageBox.Show("Başvuru bulunamadı.");
                return;
            }


            if (basvuru.onayDurumu == 1)
            {
                BasvuruIptalForm iptalForm = new BasvuruIptalForm(referansNo);
                iptalForm.ShowDialog();
                btnYenile_Click(null, null);
            }
            else if (basvuru.onayDurumu == 2)
            {
                BasvuruIptalForm iptalForm = new BasvuruIptalForm(referansNo);
                iptalForm.ShowDialog();
                btnYenile_Click(null, null);
            }
            else if (basvuru.onayDurumu == 3)
            {
                MessageBox.Show("Bu başvuru zaten iptal edilmiş");
            }
        }

        private void basvuruTablosu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDetay.PerformClick();
        }
    }
}
