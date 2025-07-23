using Forms.Repositories;
using Forms.Models;
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
    public partial class TeminatCinsForm : Form
    {
        public TeminatCins SecilenTeminatCins { get; private set; }
        public TeminatCinsForm(string referansNo, TeminatTip teminatTip)
        {
            InitializeComponent();

            var repoBasvuru = new BasvuruRepository();
            var basvuru = repoBasvuru.GetBasvuruByReferansNo(referansNo);

            var repoUrun = new UrunRepository();
            var urun = repoUrun.GetUrunById(basvuru.urunID);

            var repoTeminatCins = new TeminatCinsRepository();
            var teminatCinsler = repoTeminatCins.GetCinslerByTipId(teminatTip.tipId);

            txtUrunTipKod.Text = urun.tipKod;
            txtUrunSiraNo.Text = urun.urunId.ToString();
            txtUrunAd.Text = urun.urunAd;


            teminatCinsTablosu.AutoGenerateColumns = false;
            teminatCinsTablosu.DataSource = teminatCinsler;
            
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            var secilenSatir = teminatCinsTablosu.CurrentRow;
            if (secilenSatir != null)
            {
                SecilenTeminatCins = new TeminatCins
                {
                    cinsId = Convert.ToInt32(secilenSatir.Cells["cinsId"].Value),
                    cinsAd = secilenSatir.Cells["cinsAd"].Value.ToString(),
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

        private void teminatCinsTablosu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSec.PerformClick();
        }
    }
}
