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
    public partial class BasvuruGoruntuleForm : Form
    {
        private List<TeminatGoruntuModel> teminatGoruntuListesi = new List<TeminatGoruntuModel>();
        public BasvuruGoruntuleForm(string referansNo)
        {
            InitializeComponent();

            var repoBasvuru = new BasvuruRepository();
            var repoMusteri = new MusteriRepository();
            var repoTeminat = new TeminatRepository();
            var repoTeminatTip = new TeminatTipRepository();
            var repoTeminatCins = new TeminatCinsRepository();
            var repoUrun = new UrunRepository();
            var repoKefil = new BasvuruKefilRepository();

            var basvuru = repoBasvuru.GetBasvuruByReferansNo(referansNo);
            var musteri = repoMusteri.GetClient(basvuru.musteriID);
            var urun = repoUrun.GetUrunById(basvuru.urunID);
            var kefiller = repoKefil.GetByBasvuruId(basvuru.basvuruId);

            var teminatlar = repoTeminat.GetTeminatlarByBasvuruId(basvuru.basvuruId);

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


            teminatTablosu.AutoGenerateColumns = false;
            teminatTablosu.DataSource = null;
            teminatTablosu.DataSource = teminatGoruntuListesi;


            if (basvuru.onayDurumu == 1)
            {
                onayDurumu.Text = "Ön Başvuruda";
            }
            else if (basvuru.onayDurumu == 2)
            {
                onayDurumu.Text = "Onaylandı";
            }
            else if (basvuru.onayDurumu == 3)
            {
                onayDurumu.Text = "İptal Edildi";
            }

            refer.Text = referansNo;
            tc.Text = musteri.tcKimlikNo;
            ad.Text = musteri.ad;
            soyad.Text = musteri.soyad;
            dogumTarihi.Text = musteri.dogumTarihi.ToString();
            dogumYeri.Text = musteri.dogumYeri;
            baba.Text = musteri.babaAdi;
            vade.Text = basvuru.vade.ToString();
            basvuruTarihi.Text = basvuru.basvuruTarihi.ToString();

            urunTip.Text = urun.tipKod;
            urunAd.Text = urun.urunAd;
            urunSira.Text = urun.urunId.ToString();
            txtKrediTutari.Text = basvuru.tutar.ToString();

            if (basvuru.ikametSuresi != null)
            {
                ikametSuresi.Text = basvuru.ikametSuresi.ToString();
            }
            if (basvuru.odemeGunu != null)
            {
                odemeGunu.Text = basvuru.odemeGunu.ToString();
            }
            if (basvuru.maasDurumu != null)
            {
                maasDurumu.Text = basvuru.maasDurumu.ToString();
            }
            if (basvuru.maasGunu != null)
            {
                maasGunu.Text = basvuru.maasGunu.ToString();
            }


            if (kefiller.Count > 0)
            {
                var kefil1 = kefiller[0];
                var kefilmusteri1 = repoMusteri.GetClient(kefil1.musteriId);
                kefilAdSoyad1.Text = $"{kefilmusteri1.ad} {kefilmusteri1.soyad}";
            }

            if (kefiller.Count > 1)
            {
                var kefil2 = kefiller[1];
                var kefilmusteri2 = repoMusteri.GetClient(kefil2.musteriId);
                kefilAdSoyad2.Text = $"{kefilmusteri2.ad} {kefilmusteri2.soyad}";
            }



        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
