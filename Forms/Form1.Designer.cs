namespace Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMusteriID = new TextBox();
            txtTCKN = new TextBox();
            btnSearch = new Button();
            label4 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            basvuruTablosu = new DataGridView();
            referansNo = new DataGridViewTextBoxColumn();
            onayDurumu = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            btnAddBasvuru = new Button();
            btnDetay = new Button();
            btnTemizle = new Button();
            btnCikis = new Button();
            btnIptal = new Button();
            ((System.ComponentModel.ISupportInitialize)basvuruTablosu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 0;
            label1.Text = "Müşteri  / kimlik bilgisi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 40);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Müşteri No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 72);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 2;
            label3.Text = "TC Kimlik No";
            // 
            // txtMusteriID
            // 
            txtMusteriID.Location = new Point(182, 37);
            txtMusteriID.Name = "txtMusteriID";
            txtMusteriID.Size = new Size(150, 27);
            txtMusteriID.TabIndex = 3;
            // 
            // txtTCKN
            // 
            txtTCKN.Location = new Point(182, 69);
            txtTCKN.Name = "txtTCKN";
            txtTCKN.Size = new Size(150, 27);
            txtTCKN.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(338, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(69, 61);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Ara";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(605, 40);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 7;
            label4.Text = "Ad/Soyad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(686, 37);
            txtAd.Name = "txtAd";
            txtAd.ReadOnly = true;
            txtAd.Size = new Size(223, 27);
            txtAd.TabIndex = 8;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(915, 37);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.ReadOnly = true;
            txtSoyad.Size = new Size(233, 27);
            txtSoyad.TabIndex = 9;
            // 
            // basvuruTablosu
            // 
            basvuruTablosu.AllowUserToAddRows = false;
            basvuruTablosu.AllowUserToDeleteRows = false;
            basvuruTablosu.AllowUserToResizeColumns = false;
            basvuruTablosu.AllowUserToResizeRows = false;
            basvuruTablosu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            basvuruTablosu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            basvuruTablosu.Columns.AddRange(new DataGridViewColumn[] { referansNo, onayDurumu, Column4, Column8, Column9, Column10, Column11, Column12 });
            basvuruTablosu.Location = new Point(19, 127);
            basvuruTablosu.MultiSelect = false;
            basvuruTablosu.Name = "basvuruTablosu";
            basvuruTablosu.ReadOnly = true;
            basvuruTablosu.RowHeadersVisible = false;
            basvuruTablosu.RowHeadersWidth = 51;
            basvuruTablosu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            basvuruTablosu.Size = new Size(1128, 303);
            basvuruTablosu.TabIndex = 10;
            basvuruTablosu.CellDoubleClick += basvuruTablosu_CellDoubleClick;
            // 
            // referansNo
            // 
            referansNo.DataPropertyName = "referansNo";
            referansNo.HeaderText = "Referans No";
            referansNo.MinimumWidth = 6;
            referansNo.Name = "referansNo";
            referansNo.ReadOnly = true;
            // 
            // onayDurumu
            // 
            onayDurumu.DataPropertyName = "onayDurumu";
            onayDurumu.HeaderText = "Onay Durumu";
            onayDurumu.MinimumWidth = 6;
            onayDurumu.Name = "onayDurumu";
            onayDurumu.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column4.DataPropertyName = "basvuruTarihi";
            Column4.HeaderText = "Başvuru Tarih/Zaman";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 161;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "tip";
            Column8.HeaderText = "Ürün Tip";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "tipKod";
            Column9.HeaderText = "Ürün Kod";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "tutar";
            Column10.HeaderText = "Tutar";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column11
            // 
            Column11.DataPropertyName = "vade";
            Column11.HeaderText = "Tak. Adet";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // Column12
            // 
            Column12.DataPropertyName = "urunAd";
            Column12.HeaderText = "Ürün Ad";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            // 
            // btnAddBasvuru
            // 
            btnAddBasvuru.Location = new Point(11, 523);
            btnAddBasvuru.Name = "btnAddBasvuru";
            btnAddBasvuru.Size = new Size(143, 29);
            btnAddBasvuru.TabIndex = 11;
            btnAddBasvuru.Text = "Yeni Başvuru";
            btnAddBasvuru.UseVisualStyleBackColor = true;
            btnAddBasvuru.Click += btnAddBasvuru_Click;
            // 
            // btnDetay
            // 
            btnDetay.Location = new Point(182, 523);
            btnDetay.Name = "btnDetay";
            btnDetay.Size = new Size(142, 29);
            btnDetay.TabIndex = 12;
            btnDetay.Text = "Detay";
            btnDetay.UseVisualStyleBackColor = true;
            btnDetay.Click += btnDetay_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(350, 523);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(137, 29);
            btnTemizle.TabIndex = 14;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnCikis
            // 
            btnCikis.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCikis.Location = new Point(931, 523);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(194, 29);
            btnCikis.TabIndex = 15;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(515, 523);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(137, 29);
            btnIptal.TabIndex = 16;
            btnIptal.Text = "İptal Et";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 560);
            Controls.Add(btnIptal);
            Controls.Add(btnCikis);
            Controls.Add(btnTemizle);
            Controls.Add(btnDetay);
            Controls.Add(btnAddBasvuru);
            Controls.Add(basvuruTablosu);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label4);
            Controls.Add(btnSearch);
            Controls.Add(txtTCKN);
            Controls.Add(txtMusteriID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)basvuruTablosu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMusteriID;
        private TextBox txtTCKN;
        private Button btnSearch;
        private Label label4;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private DataGridView basvuruTablosu;
        private Button btnAddBasvuru;
        private Button btnDetay;
        private Button btnTemizle;
        private Button btnCikis;
        private DataGridViewTextBoxColumn referansNo;
        private DataGridViewTextBoxColumn onayDurumu;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private Button btnIptal;
    }
}
