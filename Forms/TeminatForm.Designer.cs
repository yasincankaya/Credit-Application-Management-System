namespace Forms
{
    partial class TeminatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtKefil1Soyad = new TextBox();
            txtKefil1Ad = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtKefil1MusNo = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtKefil2Soyad = new TextBox();
            txtKefil2Ad = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtKefil2MusNo = new TextBox();
            label8 = new Label();
            groupBox3 = new GroupBox();
            dateSatisTarihi = new DateTimePicker();
            comboEnerjiKimlikSinifi = new ComboBox();
            comboEkspertizSekli = new ComboBox();
            label23 = new Label();
            txtIpotekDerecesi = new TextBox();
            comboKonutTipi = new ComboBox();
            label22 = new Label();
            label21 = new Label();
            txtSatisTutari = new TextBox();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            txtKaskoDegeri = new TextBox();
            txtAracSasiNo = new TextBox();
            txtAracModel = new TextBox();
            txtAracModelYili = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label10 = new Label();
            groupBox4 = new GroupBox();
            btnCikar = new Button();
            btnTemizle = new Button();
            btnDuzenle = new Button();
            btnEkle = new Button();
            btnCinsSil = new Button();
            btnCinsSec = new Button();
            btnTipSil = new Button();
            btnTipSec = new Button();
            comboDovizCinsi = new ComboBox();
            txtTeminatTipAd = new TextBox();
            txtTeminatCinsAd = new TextBox();
            txtTeminatTutar = new TextBox();
            txtTeminatCinsId = new TextBox();
            txtTeminatTipId = new TextBox();
            txtUrunAd = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            btnCikis = new Button();
            teminatTablosu = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teminatTablosu).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtKefil1Soyad);
            groupBox1.Controls.Add(txtKefil1Ad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtKefil1MusNo);
            groupBox1.Controls.Add(label1);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(475, 145);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "1. Kefil Kefalet Durumu";
            // 
            // txtKefil1Soyad
            // 
            txtKefil1Soyad.Location = new Point(94, 104);
            txtKefil1Soyad.Name = "txtKefil1Soyad";
            txtKefil1Soyad.ReadOnly = true;
            txtKefil1Soyad.Size = new Size(125, 27);
            txtKefil1Soyad.TabIndex = 5;
            // 
            // txtKefil1Ad
            // 
            txtKefil1Ad.Location = new Point(94, 69);
            txtKefil1Ad.Name = "txtKefil1Ad";
            txtKefil1Ad.ReadOnly = true;
            txtKefil1Ad.Size = new Size(125, 27);
            txtKefil1Ad.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 107);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 73);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 2;
            label2.Text = "Ad";
            // 
            // txtKefil1MusNo
            // 
            txtKefil1MusNo.Location = new Point(94, 37);
            txtKefil1MusNo.Name = "txtKefil1MusNo";
            txtKefil1MusNo.ReadOnly = true;
            txtKefil1MusNo.Size = new Size(125, 27);
            txtKefil1MusNo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 40);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Müşteri No";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtKefil2Soyad);
            groupBox2.Controls.Add(txtKefil2Ad);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtKefil2MusNo);
            groupBox2.Controls.Add(label8);
            groupBox2.Enabled = false;
            groupBox2.Location = new Point(523, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(475, 145);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "2. Kefil Kefalet Durumu";
            // 
            // txtKefil2Soyad
            // 
            txtKefil2Soyad.Location = new Point(101, 104);
            txtKefil2Soyad.Name = "txtKefil2Soyad";
            txtKefil2Soyad.ReadOnly = true;
            txtKefil2Soyad.Size = new Size(125, 27);
            txtKefil2Soyad.TabIndex = 13;
            // 
            // txtKefil2Ad
            // 
            txtKefil2Ad.Location = new Point(101, 69);
            txtKefil2Ad.Name = "txtKefil2Ad";
            txtKefil2Ad.ReadOnly = true;
            txtKefil2Ad.Size = new Size(125, 27);
            txtKefil2Ad.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 107);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 11;
            label6.Text = "Soyad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 73);
            label7.Name = "label7";
            label7.Size = new Size(28, 20);
            label7.TabIndex = 10;
            label7.Text = "Ad";
            // 
            // txtKefil2MusNo
            // 
            txtKefil2MusNo.Location = new Point(101, 37);
            txtKefil2MusNo.Name = "txtKefil2MusNo";
            txtKefil2MusNo.ReadOnly = true;
            txtKefil2MusNo.Size = new Size(125, 27);
            txtKefil2MusNo.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 40);
            label8.Name = "label8";
            label8.Size = new Size(82, 20);
            label8.TabIndex = 8;
            label8.Text = "Müşteri No";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dateSatisTarihi);
            groupBox3.Controls.Add(comboEnerjiKimlikSinifi);
            groupBox3.Controls.Add(comboEkspertizSekli);
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(txtIpotekDerecesi);
            groupBox3.Controls.Add(comboKonutTipi);
            groupBox3.Controls.Add(label22);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(txtSatisTutari);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(txtKaskoDegeri);
            groupBox3.Controls.Add(txtAracSasiNo);
            groupBox3.Controls.Add(txtAracModel);
            groupBox3.Controls.Add(txtAracModelYili);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(btnCinsSil);
            groupBox3.Controls.Add(btnCinsSec);
            groupBox3.Controls.Add(btnTipSil);
            groupBox3.Controls.Add(btnTipSec);
            groupBox3.Controls.Add(comboDovizCinsi);
            groupBox3.Controls.Add(txtTeminatTipAd);
            groupBox3.Controls.Add(txtTeminatCinsAd);
            groupBox3.Controls.Add(txtTeminatTutar);
            groupBox3.Controls.Add(txtTeminatCinsId);
            groupBox3.Controls.Add(txtTeminatTipId);
            groupBox3.Controls.Add(txtUrunAd);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(11, 347);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(987, 412);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Teminat Bilgileri";
            // 
            // dateSatisTarihi
            // 
            dateSatisTarihi.Location = new Point(496, 247);
            dateSatisTarihi.Margin = new Padding(3, 4, 3, 4);
            dateSatisTarihi.Name = "dateSatisTarihi";
            dateSatisTarihi.Size = new Size(121, 27);
            dateSatisTarihi.TabIndex = 49;
            // 
            // comboEnerjiKimlikSinifi
            // 
            comboEnerjiKimlikSinifi.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEnerjiKimlikSinifi.FormattingEnabled = true;
            comboEnerjiKimlikSinifi.Items.AddRange(new object[] { "", "A++", "A+", "A", "B", "C", "D", "E", "F" });
            comboEnerjiKimlikSinifi.Location = new Point(496, 213);
            comboEnerjiKimlikSinifi.Name = "comboEnerjiKimlikSinifi";
            comboEnerjiKimlikSinifi.Size = new Size(121, 28);
            comboEnerjiKimlikSinifi.TabIndex = 48;
            // 
            // comboEkspertizSekli
            // 
            comboEkspertizSekli.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEkspertizSekli.FormattingEnabled = true;
            comboEkspertizSekli.Items.AddRange(new object[] { "", "Yeni Ekspertiz Yapılacak", "2B vd - Eks.Süreci Olmayacak", "Toplu Ekspertiz", "Satış Vaadi Sözleşmesi", "BGS Ekspertiz Süreci" });
            comboEkspertizSekli.Location = new Point(496, 183);
            comboEkspertizSekli.Name = "comboEkspertizSekli";
            comboEkspertizSekli.Size = new Size(121, 28);
            comboEkspertizSekli.TabIndex = 47;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(862, 219);
            label23.Name = "label23";
            label23.Size = new Size(41, 20);
            label23.TabIndex = 46;
            label23.Text = "(1..9)";
            // 
            // txtIpotekDerecesi
            // 
            txtIpotekDerecesi.Location = new Point(792, 215);
            txtIpotekDerecesi.Name = "txtIpotekDerecesi";
            txtIpotekDerecesi.Size = new Size(63, 27);
            txtIpotekDerecesi.TabIndex = 45;
            // 
            // comboKonutTipi
            // 
            comboKonutTipi.DropDownStyle = ComboBoxStyle.DropDownList;
            comboKonutTipi.FormattingEnabled = true;
            comboKonutTipi.Items.AddRange(new object[] { "", "Satın Alınacak Gayrimenkul", "Müşteriye Ait İlave Gayrimenkul", "3.kişiye Ait Gayrimenkul", "Müşteriye Ait İşyeri" });
            comboKonutTipi.Location = new Point(792, 184);
            comboKonutTipi.Name = "comboKonutTipi";
            comboKonutTipi.Size = new Size(121, 28);
            comboKonutTipi.TabIndex = 44;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(667, 187);
            label22.Name = "label22";
            label22.Size = new Size(77, 20);
            label22.TabIndex = 43;
            label22.Text = "Konut Tipi";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(667, 219);
            label21.Name = "label21";
            label21.Size = new Size(112, 20);
            label21.TabIndex = 42;
            label21.Text = "İpotek Derecesi";
            // 
            // txtSatisTutari
            // 
            txtSatisTutari.Location = new Point(496, 280);
            txtSatisTutari.Name = "txtSatisTutari";
            txtSatisTutari.Size = new Size(121, 27);
            txtSatisTutari.TabIndex = 41;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(362, 283);
            label20.Name = "label20";
            label20.Size = new Size(82, 20);
            label20.TabIndex = 37;
            label20.Text = "Satış Tutarı";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(362, 251);
            label19.Name = "label19";
            label19.Size = new Size(79, 20);
            label19.TabIndex = 36;
            label19.Text = "Satış Tarihi";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(362, 219);
            label18.Name = "label18";
            label18.Size = new Size(128, 20);
            label18.TabIndex = 35;
            label18.Text = "Enerji Kimlik Sınıfı";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(362, 187);
            label17.Name = "label17";
            label17.Size = new Size(103, 20);
            label17.TabIndex = 34;
            label17.Text = "Ekspertiz Şekli";
            // 
            // txtKaskoDegeri
            // 
            txtKaskoDegeri.Location = new Point(122, 184);
            txtKaskoDegeri.Name = "txtKaskoDegeri";
            txtKaskoDegeri.Size = new Size(121, 27);
            txtKaskoDegeri.TabIndex = 33;
            // 
            // txtAracSasiNo
            // 
            txtAracSasiNo.Location = new Point(122, 247);
            txtAracSasiNo.Name = "txtAracSasiNo";
            txtAracSasiNo.Size = new Size(121, 27);
            txtAracSasiNo.TabIndex = 32;
            // 
            // txtAracModel
            // 
            txtAracModel.Location = new Point(122, 280);
            txtAracModel.Name = "txtAracModel";
            txtAracModel.Size = new Size(121, 27);
            txtAracModel.TabIndex = 31;
            // 
            // txtAracModelYili
            // 
            txtAracModelYili.Location = new Point(122, 215);
            txtAracModelYili.Name = "txtAracModelYili";
            txtAracModelYili.Size = new Size(121, 27);
            txtAracModelYili.TabIndex = 30;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 187);
            label16.Name = "label16";
            label16.Size = new Size(97, 20);
            label16.TabIndex = 29;
            label16.Text = "Kasko Değeri";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 219);
            label15.Name = "label15";
            label15.Size = new Size(110, 20);
            label15.TabIndex = 28;
            label15.Text = "Araç Model Yılı";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 251);
            label14.Name = "label14";
            label14.Size = new Size(93, 20);
            label14.TabIndex = 27;
            label14.Text = "Araç Şasi No";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 283);
            label10.Name = "label10";
            label10.Size = new Size(86, 20);
            label10.TabIndex = 26;
            label10.Text = "Araç Model";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnCikar);
            groupBox4.Controls.Add(btnTemizle);
            groupBox4.Controls.Add(btnDuzenle);
            groupBox4.Controls.Add(btnEkle);
            groupBox4.Location = new Point(745, 20);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(235, 157);
            groupBox4.TabIndex = 25;
            groupBox4.TabStop = false;
            groupBox4.Text = "İşlem";
            // 
            // btnCikar
            // 
            btnCikar.Location = new Point(130, 101);
            btnCikar.Name = "btnCikar";
            btnCikar.Size = new Size(101, 51);
            btnCikar.TabIndex = 3;
            btnCikar.Text = "Çıkar";
            btnCikar.UseVisualStyleBackColor = true;
            btnCikar.Click += btnCikar_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(6, 101);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(101, 51);
            btnTemizle.TabIndex = 2;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(130, 27);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(101, 51);
            btnDuzenle.TabIndex = 1;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(6, 27);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(101, 51);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnCinsSil
            // 
            btnCinsSil.Location = new Point(683, 91);
            btnCinsSil.Name = "btnCinsSil";
            btnCinsSil.Size = new Size(55, 29);
            btnCinsSil.TabIndex = 24;
            btnCinsSil.Text = "Sil";
            btnCinsSil.UseVisualStyleBackColor = true;
            // 
            // btnCinsSec
            // 
            btnCinsSec.Location = new Point(622, 91);
            btnCinsSec.Name = "btnCinsSec";
            btnCinsSec.Size = new Size(55, 29);
            btnCinsSec.TabIndex = 23;
            btnCinsSec.Text = "Seç";
            btnCinsSec.UseVisualStyleBackColor = true;
            btnCinsSec.Click += btnCinsSec_Click;
            // 
            // btnTipSil
            // 
            btnTipSil.Location = new Point(683, 60);
            btnTipSil.Name = "btnTipSil";
            btnTipSil.Size = new Size(55, 29);
            btnTipSil.TabIndex = 22;
            btnTipSil.Text = "Sil";
            btnTipSil.UseVisualStyleBackColor = true;
            // 
            // btnTipSec
            // 
            btnTipSec.Location = new Point(622, 60);
            btnTipSec.Name = "btnTipSec";
            btnTipSec.Size = new Size(55, 29);
            btnTipSec.TabIndex = 19;
            btnTipSec.Text = "Seç";
            btnTipSec.UseVisualStyleBackColor = true;
            btnTipSec.Click += btnTipSec_Click;
            // 
            // comboDovizCinsi
            // 
            comboDovizCinsi.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDovizCinsi.FormattingEnabled = true;
            comboDovizCinsi.Items.AddRange(new object[] { "", "TL", "USD", "EUR", "ALT", "GBP" });
            comboDovizCinsi.Location = new Point(242, 123);
            comboDovizCinsi.Name = "comboDovizCinsi";
            comboDovizCinsi.Size = new Size(121, 28);
            comboDovizCinsi.TabIndex = 18;
            // 
            // txtTeminatTipAd
            // 
            txtTeminatTipAd.Enabled = false;
            txtTeminatTipAd.Location = new Point(186, 61);
            txtTeminatTipAd.Name = "txtTeminatTipAd";
            txtTeminatTipAd.ReadOnly = true;
            txtTeminatTipAd.Size = new Size(430, 27);
            txtTeminatTipAd.TabIndex = 17;
            // 
            // txtTeminatCinsAd
            // 
            txtTeminatCinsAd.Enabled = false;
            txtTeminatCinsAd.Location = new Point(186, 91);
            txtTeminatCinsAd.Name = "txtTeminatCinsAd";
            txtTeminatCinsAd.ReadOnly = true;
            txtTeminatCinsAd.Size = new Size(430, 27);
            txtTeminatCinsAd.TabIndex = 16;
            // 
            // txtTeminatTutar
            // 
            txtTeminatTutar.Location = new Point(117, 123);
            txtTeminatTutar.Name = "txtTeminatTutar";
            txtTeminatTutar.Size = new Size(121, 27);
            txtTeminatTutar.TabIndex = 15;
            // 
            // txtTeminatCinsId
            // 
            txtTeminatCinsId.Enabled = false;
            txtTeminatCinsId.Location = new Point(117, 91);
            txtTeminatCinsId.Name = "txtTeminatCinsId";
            txtTeminatCinsId.ReadOnly = true;
            txtTeminatCinsId.Size = new Size(63, 27);
            txtTeminatCinsId.TabIndex = 14;
            // 
            // txtTeminatTipId
            // 
            txtTeminatTipId.Enabled = false;
            txtTeminatTipId.Location = new Point(117, 61);
            txtTeminatTipId.Name = "txtTeminatTipId";
            txtTeminatTipId.ReadOnly = true;
            txtTeminatTipId.Size = new Size(63, 27);
            txtTeminatTipId.TabIndex = 13;
            txtTeminatTipId.TextChanged += txtTeminatTipId_TextChanged;
            // 
            // txtUrunAd
            // 
            txtUrunAd.Enabled = false;
            txtUrunAd.Location = new Point(117, 29);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.ReadOnly = true;
            txtUrunAd.Size = new Size(623, 27);
            txtUrunAd.TabIndex = 12;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 64);
            label13.Name = "label13";
            label13.Size = new Size(91, 20);
            label13.TabIndex = 11;
            label13.Text = "Teminat Tipi";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 93);
            label12.Name = "label12";
            label12.Size = new Size(97, 20);
            label12.TabIndex = 10;
            label12.Text = "Teminat Cinsi";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 125);
            label11.Name = "label11";
            label11.Size = new Size(104, 20);
            label11.TabIndex = 9;
            label11.Text = "Teminat Tutarı";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 33);
            label9.Name = "label9";
            label9.Size = new Size(95, 20);
            label9.TabIndex = 7;
            label9.Text = "Ürün Bilgileri";
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(874, 781);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(123, 32);
            btnCikis.TabIndex = 47;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // teminatTablosu
            // 
            teminatTablosu.AllowUserToAddRows = false;
            teminatTablosu.AllowUserToDeleteRows = false;
            teminatTablosu.AllowUserToResizeColumns = false;
            teminatTablosu.AllowUserToResizeRows = false;
            teminatTablosu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            teminatTablosu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teminatTablosu.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            teminatTablosu.Location = new Point(18, 163);
            teminatTablosu.MultiSelect = false;
            teminatTablosu.Name = "teminatTablosu";
            teminatTablosu.ReadOnly = true;
            teminatTablosu.RowHeadersVisible = false;
            teminatTablosu.RowHeadersWidth = 51;
            teminatTablosu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            teminatTablosu.Size = new Size(987, 177);
            teminatTablosu.TabIndex = 48;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.DataPropertyName = "urunTipKod";
            Column1.FillWeight = 160.427811F;
            Column1.HeaderText = "Ürün Tip";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 75;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column2.DataPropertyName = "urunId";
            Column2.FillWeight = 87.91444F;
            Column2.HeaderText = "Ürün Sıra";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 75;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column3.DataPropertyName = "teminatTipAd";
            Column3.FillWeight = 87.91444F;
            Column3.HeaderText = "Teminat Tip";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 239;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column4.DataPropertyName = "teminatCinsAd";
            Column4.FillWeight = 87.91444F;
            Column4.HeaderText = "Teminat Cinsi";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 339;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column5.DataPropertyName = "teminatTutari";
            Column5.FillWeight = 87.91444F;
            Column5.HeaderText = "Teminat Tutarı";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 140;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column6.DataPropertyName = "dovizCinsi";
            Column6.FillWeight = 87.91444F;
            Column6.HeaderText = "Döviz Cinsi";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 116;
            // 
            // TeminatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 827);
            Controls.Add(teminatTablosu);
            Controls.Add(btnCikis);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "TeminatForm";
            Text = "TeminatForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)teminatTablosu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtKefil1Soyad;
        private TextBox txtKefil1Ad;
        private Label label3;
        private Label label2;
        private TextBox txtKefil1MusNo;
        private Label label1;
        private TextBox txtKefil2Soyad;
        private TextBox txtKefil2Ad;
        private Label label6;
        private Label label7;
        private TextBox txtKefil2MusNo;
        private Label label8;
        private GroupBox groupBox3;
        private Label label9;
        private TextBox txtTeminatTipAd;
        private TextBox txtTeminatCinsAd;
        private TextBox txtTeminatTutar;
        private TextBox txtTeminatCinsId;
        private TextBox txtTeminatTipId;
        private TextBox txtUrunAd;
        private Label label13;
        private Label label12;
        private Label label11;
        private GroupBox groupBox4;
        private Button btnCikar;
        private Button btnTemizle;
        private Button btnDuzenle;
        private Button btnEkle;
        private Button btnCinsSil;
        private Button btnCinsSec;
        private Button btnTipSil;
        private Button btnTipSec;
        private ComboBox comboDovizCinsi;
        private TextBox txtSatisTutari;
        private TextBox txtSatisTarihi;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private TextBox txtKaskoDegeri;
        private TextBox txtAracSasiNo;
        private TextBox txtAracModel;
        private TextBox txtAracModelYili;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label10;
        private ComboBox comboKonutTipi;
        private Label label22;
        private Label label21;
        private Label label23;
        private TextBox txtIpotekDerecesi;
        private Button btnCikis;
        private ComboBox comboEkspertizSekli;
        private ComboBox comboEnerjiKimlikSinifi;
        private DataGridView teminatTablosu;
        private DateTimePicker dateSatisTarihi;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}