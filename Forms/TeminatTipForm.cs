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
    public partial class TeminatTipForm : Form
    {
        public TeminatTip SecilenTeminatTip { get; private set; }

        public TeminatTipForm(string referansNo)
        {
            InitializeComponent();

            var repoBasvuru = new BasvuruRepository();
            var basvuru = repoBasvuru.GetBasvuruByReferansNo(referansNo);

            var repoUrun = new UrunRepository();
            var urun = repoUrun.GetUrunById(basvuru.urunID);

            var repoTeminatTip = new TeminatTipRepository();
            var teminatTip = repoTeminatTip.GetAllTeminatTipleri();

            txtUrunKod.Text = urun.tipKod;
            txtUrunAd.Text = urun.urunAd;
            txtSiraNo.Text = urun.urunId.ToString();

            teminatTipTablosu.DataSource = teminatTip;
            teminatTipTablosu.AutoGenerateColumns = false;
        }

        private void btnSec_Click(object sender, EventArgs e)
        {

            var secilenSatir = teminatTipTablosu.CurrentRow;
            if (secilenSatir != null)
            {
                SecilenTeminatTip = new TeminatTip
                {
                    tipId = Convert.ToInt32(secilenSatir.Cells["tipId"].Value),
                    teminatTipAd = secilenSatir.Cells["teminatTipAd"].Value.ToString(),
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void teminatTipTablosu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSec.PerformClick();
        }
    }
}
