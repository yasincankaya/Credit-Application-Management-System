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
    public partial class BasvuruIptalForm : Form
    {
        private readonly string referansNo;
        public BasvuruIptalForm(string referansNo)
        {
            InitializeComponent();
            this.referansNo = referansNo;
        }

        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            var repo = new BasvuruRepository();
            var basvuru = repo.GetBasvuruByReferansNo(referansNo);

            if (basvuru != null)
            {
                basvuru.onayDurumu = 3; // 3 = İptal Edildi
                repo.UpdateBasvuru(basvuru); // Güncelleme metodu olması gerekir

                MessageBox.Show("Başvuru başarıyla iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Başvuru bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
