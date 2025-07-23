using Forms.Models;
using Forms.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class UrunSecForm : Form
    {
        public UrunSecForm()
        {
            InitializeComponent();
            ReadUrunler();
        }
        public Urun SecilenUrun { get; private set; }
        private void ReadUrunler()
        {

            var repo = new UrunRepository();
            var urunler = repo.GetUrunler();

            this.urunTablosu.AutoGenerateColumns = false;
            this.urunTablosu.DataSource = urunler;

        }

        private void CategorizeUrunler()
        {
            string arananUrunAd = txtUrunAd.Text.Trim().ToLower();
            var repo = new UrunRepository();

            List<Urun> urunler = new List<Urun>();

            if (ihtiyac.Checked)
                urunler.AddRange(repo.GetUrunler("İhtiyaç Kredileri"));
            if (tasit.Checked)
                urunler.AddRange(repo.GetUrunler("Taşıt Kredileri"));
            if (konut.Checked)
                urunler.AddRange(repo.GetUrunler("Konut Kredileri"));
            if (turev.Checked)
                urunler.AddRange(repo.GetUrunler("Türev İşlemler Kredisi"));
            if (cekTaahhut.Checked)
                urunler.AddRange(repo.GetUrunler("Çek Taahhüt Kredisi"));
            if (ipotekli.Checked)
                urunler.AddRange(repo.GetUrunler("İpotekli Destek Kredisi"));
            if (paraf.Checked)
                urunler.AddRange(repo.GetUrunler("Paraf"));
            if (parafly.Checked)
                urunler.AddRange(repo.GetUrunler("Parafly"));
            if (parafGenc.Checked)
                urunler.AddRange(repo.GetUrunler("Paraf Genç"));
            if (parafDual.Checked)
                urunler.AddRange(repo.GetUrunler("Paraf Dual"));
            if (paraflyDual.Checked)
                urunler.AddRange(repo.GetUrunler("Parafly Dual"));
            if (parafGencDual.Checked)
                urunler.AddRange(repo.GetUrunler("Paraf Genç Dual"));
            if (parafTroy.Checked)
                urunler.AddRange(repo.GetUrunler("Paraf Troy"));
            if (paraflyTroy.Checked)
                urunler.AddRange(repo.GetUrunler("Parafly Troy"));
            if (parafGencTroy.Checked)
                urunler.AddRange(repo.GetUrunler("Paraf Genç Troy"));


            if (urunler.Count == 0)
                urunler = repo.GetUrunler();


            urunler = urunler.DistinctBy(u => u.urunId).ToList();


            if (!string.IsNullOrWhiteSpace(arananUrunAd))
            {
                urunler = urunler
                    .Where(u => u.urunAd != null && u.urunAd.ToLower().Contains(arananUrunAd))
                    .ToList();
            }

            this.urunTablosu.AutoGenerateColumns = false;
            this.urunTablosu.DataSource = urunler;

        }

        private void ihtiyac_CheckedChanged(object sender, EventArgs e)
        {
            CategorizeUrunler();
        }

        private void tasit_CheckedChanged(object sender, EventArgs e)
        {
            CategorizeUrunler();
        }

        private void konut_CheckedChanged(object sender, EventArgs e)
        {
            CategorizeUrunler();
        }

        private void turev_CheckedChanged(object sender, EventArgs e)
        {
            CategorizeUrunler();
        }

        private void cekTaahhut_CheckedChanged(object sender, EventArgs e)
        {
            CategorizeUrunler();
        }

        private void ipotekli_CheckedChanged(object sender, EventArgs e)
        {
            CategorizeUrunler();
        }

        private void paraf_CheckedChanged(object sender, EventArgs e)
        {
            CategorizeUrunler();
        }

        private void parafly_CheckedChanged(object sender, EventArgs e)
        {
            CategorizeUrunler();
        }

        private void parafGenc_CheckedChanged(object sender, EventArgs e)
        {
            CategorizeUrunler();
        }

        private void parafDual_CheckedChanged(object sender, EventArgs e)
        {
            CategorizeUrunler();
        }

        private void paraflyDual_CheckedChanged(object sender, EventArgs e)
        {
            CategorizeUrunler();
        }

        private void parafGencDual_CheckedChanged(object sender, EventArgs e)
        {
            CategorizeUrunler();
        }

        private void parafTroy_CheckedChanged(object sender, EventArgs e)
        {
            CategorizeUrunler();
        }

        private void paraflyTroy_CheckedChanged(object sender, EventArgs e)
        {
            CategorizeUrunler();
        }

        private void parafGencTroy_CheckedChanged(object sender, EventArgs e)
        {
            CategorizeUrunler();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string arananUrunAd = txtUrunAd.Text.Trim().ToLower();
            var repo = new UrunRepository();

            List<Urun> urunler = new List<Urun>();

            if (ihtiyac.Checked)
                urunler.AddRange(repo.GetUrunler("İhtiyaç Kredileri"));
            if (tasit.Checked)
                urunler.AddRange(repo.GetUrunler("Taşıt Kredileri"));
            if (konut.Checked)
                urunler.AddRange(repo.GetUrunler("Konut Kredileri"));
            if (turev.Checked)
                urunler.AddRange(repo.GetUrunler("Türev İşlemler Kredisi"));
            if (cekTaahhut.Checked)
                urunler.AddRange(repo.GetUrunler("Çek Taahhüt Kredisi"));
            if (ipotekli.Checked)
                urunler.AddRange(repo.GetUrunler("İpotekli Destek Kredisi"));
            if (paraf.Checked)
                urunler.AddRange(repo.GetUrunler("Paraf"));
            if (parafly.Checked)
                urunler.AddRange(repo.GetUrunler("Parafly"));
            if (parafGenc.Checked)
                urunler.AddRange(repo.GetUrunler("Paraf Genç"));
            if (parafDual.Checked)
                urunler.AddRange(repo.GetUrunler("Paraf Dual"));
            if (paraflyDual.Checked)
                urunler.AddRange(repo.GetUrunler("Parafly Dual"));
            if (parafGencDual.Checked)
                urunler.AddRange(repo.GetUrunler("Paraf Genç Dual"));
            if (parafTroy.Checked)
                urunler.AddRange(repo.GetUrunler("Paraf Troy"));
            if (paraflyTroy.Checked)
                urunler.AddRange(repo.GetUrunler("Parafly Troy"));
            if (parafGencTroy.Checked)
                urunler.AddRange(repo.GetUrunler("Paraf Genç Troy"));

            if (urunler.Count == 0)
                urunler = repo.GetUrunler();

            urunler = urunler.DistinctBy(u => u.urunId).ToList();

            if (!string.IsNullOrWhiteSpace(arananUrunAd))
            {
                urunler = urunler
                    .Where(u => u.urunAd != null && u.urunAd.ToLower().Contains(arananUrunAd))
                    .ToList();
            }

            this.urunTablosu.AutoGenerateColumns = false;
            this.urunTablosu.DataSource = urunler;
        }


        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtUrunAd.Text = "";

            var repo = new UrunRepository();
            var urunler = repo.GetUrunler();
            CategorizeUrunler();
            this.urunTablosu.AutoGenerateColumns = false;
            this.urunTablosu.DataSource = urunler;
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (urunTablosu.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = urunTablosu.SelectedRows[0];
                int urunId = Convert.ToInt32(selectedRow.Cells["Column2"].Value);

                var repo = new UrunRepository();
                var urun = repo.GetUrunById(urunId);

                if (urun != null)
                {
                    this.SecilenUrun = urun;
                    this.DialogResult = DialogResult.OK;
                    YeniBasvuruForm.instance.tbAd.Text = urun.urunAd;
                    YeniBasvuruForm.instance.tbKod.Text = urun.tipKod;
                    YeniBasvuruForm.instance.tbId.Text = urun.urunId.ToString();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ürün veritabanında bulunamadı!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçiniz!");
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void urunTablosu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSec.PerformClick();
        }
    }
}
