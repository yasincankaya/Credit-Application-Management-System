namespace Forms
{
    partial class YeniBasvuruForm
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
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            txtBasvuruTarihi = new TextBox();
            label9 = new Label();
            txtReferansNo = new TextBox();
            txtMusteriID = new TextBox();
            groupBox2 = new GroupBox();
            txtGelir2 = new TextBox();
            comboGelirTip2 = new ComboBox();
            label8 = new Label();
            comboVade = new ComboBox();
            txtUrunNo = new TextBox();
            btnAsgari = new Button();
            txtGelir = new TextBox();
            groupBox3 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            comboGelirTip = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            txtUrunAd = new TextBox();
            btnUrunSec = new Button();
            label5 = new Label();
            txtTutar = new TextBox();
            txtUrunKod = new TextBox();
            label1 = new Label();
            label4 = new Label();
            btnTemizle = new Button();
            btnIptal = new Button();
            btnOnay = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 34);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Müşteri No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 67);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Referans No";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBasvuruTarihi);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtReferansNo);
            groupBox1.Controls.Add(txtMusteriID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(914, 114);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Başvuru Bilgileri";
            // 
            // txtBasvuruTarihi
            // 
            txtBasvuruTarihi.Location = new Point(389, 31);
            txtBasvuruTarihi.Name = "txtBasvuruTarihi";
            txtBasvuruTarihi.ReadOnly = true;
            txtBasvuruTarihi.Size = new Size(125, 27);
            txtBasvuruTarihi.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(284, 34);
            label9.Name = "label9";
            label9.Size = new Size(99, 20);
            label9.TabIndex = 5;
            label9.Text = "Başvuru Tarihi";
            // 
            // txtReferansNo
            // 
            txtReferansNo.Location = new Point(119, 64);
            txtReferansNo.Name = "txtReferansNo";
            txtReferansNo.ReadOnly = true;
            txtReferansNo.Size = new Size(125, 27);
            txtReferansNo.TabIndex = 4;
            // 
            // txtMusteriID
            // 
            txtMusteriID.Location = new Point(119, 31);
            txtMusteriID.Name = "txtMusteriID";
            txtMusteriID.ReadOnly = true;
            txtMusteriID.Size = new Size(125, 27);
            txtMusteriID.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtGelir2);
            groupBox2.Controls.Add(comboGelirTip2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(comboVade);
            groupBox2.Controls.Add(txtUrunNo);
            groupBox2.Controls.Add(btnAsgari);
            groupBox2.Controls.Add(txtGelir);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(comboGelirTip);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtUrunAd);
            groupBox2.Controls.Add(btnUrunSec);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtTutar);
            groupBox2.Controls.Add(txtUrunKod);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 143);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(914, 307);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ürün / Gelir / Teminat Bilgiler";
            // 
            // txtGelir2
            // 
            txtGelir2.Location = new Point(374, 202);
            txtGelir2.Name = "txtGelir2";
            txtGelir2.Size = new Size(125, 27);
            txtGelir2.TabIndex = 21;
            // 
            // comboGelirTip2
            // 
            comboGelirTip2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboGelirTip2.FormattingEnabled = true;
            comboGelirTip2.Items.AddRange(new object[] { "", "Ücretli", "Emekli", "Serbest", "Menkul", "Kira", "Zirai", "Part Time" });
            comboGelirTip2.Location = new Point(167, 201);
            comboGelirTip2.Name = "comboGelirTip2";
            comboGelirTip2.Size = new Size(189, 28);
            comboGelirTip2.TabIndex = 20;
            comboGelirTip2.SelectedIndexChanged += comboGelirTip2_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 204);
            label8.Name = "label8";
            label8.Size = new Size(146, 20);
            label8.TabIndex = 19;
            label8.Text = "Gelir Tip/Beyan Gelir";
            // 
            // comboVade
            // 
            comboVade.DropDownStyle = ComboBoxStyle.DropDownList;
            comboVade.FormattingEnabled = true;
            comboVade.Items.AddRange(new object[] { "3", "6", "9", "12", "18", "24", "30", "36", "42", "48" });
            comboVade.Location = new Point(127, 97);
            comboVade.Name = "comboVade";
            comboVade.Size = new Size(125, 28);
            comboVade.TabIndex = 18;
            // 
            // txtUrunNo
            // 
            txtUrunNo.Location = new Point(195, 31);
            txtUrunNo.Name = "txtUrunNo";
            txtUrunNo.ReadOnly = true;
            txtUrunNo.Size = new Size(57, 27);
            txtUrunNo.TabIndex = 17;
            // 
            // btnAsgari
            // 
            btnAsgari.BackColor = SystemColors.Highlight;
            btnAsgari.ForeColor = SystemColors.ButtonHighlight;
            btnAsgari.Location = new Point(774, 150);
            btnAsgari.Name = "btnAsgari";
            btnAsgari.Size = new Size(134, 42);
            btnAsgari.TabIndex = 16;
            btnAsgari.Text = "Asgari Ücret";
            btnAsgari.UseVisualStyleBackColor = false;
            btnAsgari.Click += btnAsgari_Click;
            // 
            // txtGelir
            // 
            txtGelir.Location = new Point(374, 163);
            txtGelir.Name = "txtGelir";
            txtGelir.Size = new Size(125, 27);
            txtGelir.TabIndex = 14;
            txtGelir.Text = "0";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Location = new Point(518, 150);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 125);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Emekli maaş tipi";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(11, 65);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 24);
            radioButton2.TabIndex = 21;
            radioButton2.TabStop = true;
            radioButton2.Text = "Diğer";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(11, 35);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(105, 24);
            radioButton1.TabIndex = 20;
            radioButton1.TabStop = true;
            radioButton1.Text = "Kendine ait";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboGelirTip
            // 
            comboGelirTip.DropDownStyle = ComboBoxStyle.DropDownList;
            comboGelirTip.FormattingEnabled = true;
            comboGelirTip.Items.AddRange(new object[] { "", "Ücretli", "Emekli", "Serbest", "Menkul", "Kira", "Zirai", "Part Time" });
            comboGelirTip.Location = new Point(167, 162);
            comboGelirTip.Name = "comboGelirTip";
            comboGelirTip.Size = new Size(189, 28);
            comboGelirTip.TabIndex = 11;
            comboGelirTip.SelectedIndexChanged += comboGelirTip_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 165);
            label7.Name = "label7";
            label7.Size = new Size(146, 20);
            label7.TabIndex = 9;
            label7.Text = "Gelir Tip/Beyan Gelir";
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(0, 137);
            label6.Name = "label6";
            label6.Size = new Size(914, 10);
            label6.TabIndex = 5;
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(313, 31);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.ReadOnly = true;
            txtUrunAd.Size = new Size(582, 27);
            txtUrunAd.TabIndex = 8;
            // 
            // btnUrunSec
            // 
            btnUrunSec.BackColor = SystemColors.Highlight;
            btnUrunSec.ForeColor = SystemColors.ButtonHighlight;
            btnUrunSec.Location = new Point(258, 28);
            btnUrunSec.Name = "btnUrunSec";
            btnUrunSec.Size = new Size(49, 32);
            btnUrunSec.TabIndex = 7;
            btnUrunSec.Text = "Seç";
            btnUrunSec.UseVisualStyleBackColor = false;
            btnUrunSec.Click += btnUrunSec_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 92);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 5;
            label5.Text = "Kredi Vadesi";
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(127, 64);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(125, 27);
            txtTutar.TabIndex = 4;
            txtTutar.Text = "0";
            // 
            // txtUrunKod
            // 
            txtUrunKod.Location = new Point(127, 31);
            txtUrunKod.Name = "txtUrunKod";
            txtUrunKod.ReadOnly = true;
            txtUrunKod.Size = new Size(57, 27);
            txtUrunKod.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 1;
            label1.Text = "Başvurulan Ürün";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 64);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 2;
            label4.Text = "Kredi Tutarı";
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = SystemColors.Highlight;
            btnTemizle.ForeColor = SystemColors.ButtonHighlight;
            btnTemizle.Location = new Point(652, 468);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(134, 42);
            btnTemizle.TabIndex = 17;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = SystemColors.Highlight;
            btnIptal.ForeColor = SystemColors.ButtonHighlight;
            btnIptal.Location = new Point(792, 468);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(134, 42);
            btnIptal.TabIndex = 18;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // btnOnay
            // 
            btnOnay.BackColor = SystemColors.Highlight;
            btnOnay.ForeColor = SystemColors.ButtonHighlight;
            btnOnay.Location = new Point(512, 468);
            btnOnay.Name = "btnOnay";
            btnOnay.Size = new Size(134, 42);
            btnOnay.TabIndex = 19;
            btnOnay.Text = "Onayla";
            btnOnay.UseVisualStyleBackColor = false;
            btnOnay.Click += btnOnay_Click;
            // 
            // YeniBasvuruForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 583);
            Controls.Add(btnOnay);
            Controls.Add(btnIptal);
            Controls.Add(btnTemizle);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "YeniBasvuruForm";
            Text = "YeniBasvuru";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox txtReferansNo;
        private TextBox txtMusteriID;
        private GroupBox groupBox2;
        private TextBox txtUrunAd;
        private Button btnUrunSec;
        private TextBox textBox5;
        private Label label5;
        private TextBox txtTutar;
        private TextBox txtUrunKod;
        private Label label1;
        private Label label4;
        private Label label6;
        private Label label7;
        private ComboBox comboGelirTip;
        private Button btnAsgari;
        private TextBox txtGelir;
        private Button btnTemizle;
        private Button btnIptal;
        private Button btnOnay;
        private TextBox txtBasvuruTarihi;
        private Label label9;
        private TextBox txtUrunNo;
        private ComboBox comboVade;
        private GroupBox groupBox3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox txtGelir2;
        private ComboBox comboGelirTip2;
        private Label label8;
    }
}