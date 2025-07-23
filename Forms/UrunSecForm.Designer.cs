namespace Forms
{
    partial class UrunSecForm
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
            ihtiyac = new CheckBox();
            groupBox1 = new GroupBox();
            parafGencTroy = new CheckBox();
            paraflyTroy = new CheckBox();
            parafTroy = new CheckBox();
            parafGenc = new CheckBox();
            parafly = new CheckBox();
            paraf = new CheckBox();
            label1 = new Label();
            parafGencDual = new CheckBox();
            paraflyDual = new CheckBox();
            parafDual = new CheckBox();
            ipotekli = new CheckBox();
            cekTaahhut = new CheckBox();
            turev = new CheckBox();
            konut = new CheckBox();
            tasit = new CheckBox();
            groupBox2 = new GroupBox();
            btnTemizle = new Button();
            btnAra = new Button();
            txtUrunAd = new TextBox();
            label2 = new Label();
            urunTablosu = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnSec = new Button();
            btnCikis = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)urunTablosu).BeginInit();
            SuspendLayout();
            // 
            // ihtiyac
            // 
            ihtiyac.AutoSize = true;
            ihtiyac.Location = new Point(29, 45);
            ihtiyac.Name = "ihtiyac";
            ihtiyac.Size = new Size(134, 24);
            ihtiyac.TabIndex = 0;
            ihtiyac.Text = "İhtiyaç Kredileri";
            ihtiyac.UseVisualStyleBackColor = true;
            ihtiyac.CheckedChanged += ihtiyac_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(parafGencTroy);
            groupBox1.Controls.Add(paraflyTroy);
            groupBox1.Controls.Add(parafTroy);
            groupBox1.Controls.Add(parafGenc);
            groupBox1.Controls.Add(parafly);
            groupBox1.Controls.Add(paraf);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(parafGencDual);
            groupBox1.Controls.Add(paraflyDual);
            groupBox1.Controls.Add(parafDual);
            groupBox1.Controls.Add(ipotekli);
            groupBox1.Controls.Add(cekTaahhut);
            groupBox1.Controls.Add(turev);
            groupBox1.Controls.Add(konut);
            groupBox1.Controls.Add(tasit);
            groupBox1.Controls.Add(ihtiyac);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1017, 148);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Tipi Seçimi";
            // 
            // parafGencTroy
            // 
            parafGencTroy.AutoSize = true;
            parafGencTroy.Location = new Point(836, 106);
            parafGencTroy.Name = "parafGencTroy";
            parafGencTroy.Size = new Size(133, 24);
            parafGencTroy.TabIndex = 15;
            parafGencTroy.Text = "Paraf Genç Troy";
            parafGencTroy.UseVisualStyleBackColor = true;
            parafGencTroy.CheckedChanged += parafGencTroy_CheckedChanged;
            // 
            // paraflyTroy
            // 
            paraflyTroy.AutoSize = true;
            paraflyTroy.Location = new Point(836, 76);
            paraflyTroy.Name = "paraflyTroy";
            paraflyTroy.Size = new Size(107, 24);
            paraflyTroy.TabIndex = 14;
            paraflyTroy.Text = "Parafly Troy";
            paraflyTroy.UseVisualStyleBackColor = true;
            paraflyTroy.CheckedChanged += paraflyTroy_CheckedChanged;
            // 
            // parafTroy
            // 
            parafTroy.AutoSize = true;
            parafTroy.Location = new Point(836, 46);
            parafTroy.Name = "parafTroy";
            parafTroy.Size = new Size(96, 24);
            parafTroy.TabIndex = 13;
            parafTroy.Text = "Paraf Troy";
            parafTroy.UseVisualStyleBackColor = true;
            parafTroy.CheckedChanged += parafTroy_CheckedChanged;
            // 
            // parafGenc
            // 
            parafGenc.AutoSize = true;
            parafGenc.Location = new Point(505, 105);
            parafGenc.Name = "parafGenc";
            parafGenc.Size = new Size(101, 24);
            parafGenc.TabIndex = 12;
            parafGenc.Text = "Paraf Genç";
            parafGenc.UseVisualStyleBackColor = true;
            parafGenc.CheckedChanged += parafGenc_CheckedChanged;
            // 
            // parafly
            // 
            parafly.AutoSize = true;
            parafly.Location = new Point(505, 75);
            parafly.Name = "parafly";
            parafly.Size = new Size(75, 24);
            parafly.TabIndex = 11;
            parafly.Text = "Parafly";
            parafly.UseVisualStyleBackColor = true;
            parafly.CheckedChanged += parafly_CheckedChanged;
            // 
            // paraf
            // 
            paraf.AutoSize = true;
            paraf.Location = new Point(505, 46);
            paraf.Name = "paraf";
            paraf.Size = new Size(64, 24);
            paraf.TabIndex = 10;
            paraf.Text = "Paraf";
            paraf.UseVisualStyleBackColor = true;
            paraf.CheckedChanged += paraf_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(657, 13);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 9;
            label1.Text = "Kredi Kartları";
            // 
            // parafGencDual
            // 
            parafGencDual.AutoSize = true;
            parafGencDual.Location = new Point(657, 105);
            parafGencDual.Name = "parafGencDual";
            parafGencDual.Size = new Size(136, 24);
            parafGencDual.TabIndex = 8;
            parafGencDual.Text = "Paraf Genç Dual";
            parafGencDual.UseVisualStyleBackColor = true;
            parafGencDual.CheckedChanged += parafGencDual_CheckedChanged;
            // 
            // paraflyDual
            // 
            paraflyDual.AutoSize = true;
            paraflyDual.Location = new Point(657, 75);
            paraflyDual.Name = "paraflyDual";
            paraflyDual.Size = new Size(110, 24);
            paraflyDual.TabIndex = 7;
            paraflyDual.Text = "Parafly Dual";
            paraflyDual.UseVisualStyleBackColor = true;
            paraflyDual.CheckedChanged += paraflyDual_CheckedChanged;
            // 
            // parafDual
            // 
            parafDual.AutoSize = true;
            parafDual.Location = new Point(657, 45);
            parafDual.Name = "parafDual";
            parafDual.Size = new Size(99, 24);
            parafDual.TabIndex = 6;
            parafDual.Text = "Paraf Dual";
            parafDual.UseVisualStyleBackColor = true;
            parafDual.CheckedChanged += parafDual_CheckedChanged;
            // 
            // ipotekli
            // 
            ipotekli.AutoSize = true;
            ipotekli.Location = new Point(177, 105);
            ipotekli.Name = "ipotekli";
            ipotekli.Size = new Size(179, 24);
            ipotekli.TabIndex = 5;
            ipotekli.Text = "İpotekli Destek Kredisi";
            ipotekli.UseVisualStyleBackColor = true;
            ipotekli.CheckedChanged += ipotekli_CheckedChanged;
            // 
            // cekTaahhut
            // 
            cekTaahhut.AutoSize = true;
            cekTaahhut.Location = new Point(177, 75);
            cekTaahhut.Name = "cekTaahhut";
            cekTaahhut.Size = new Size(159, 24);
            cekTaahhut.TabIndex = 4;
            cekTaahhut.Text = "Çek Taahhüt Kredisi";
            cekTaahhut.UseVisualStyleBackColor = true;
            cekTaahhut.CheckedChanged += cekTaahhut_CheckedChanged;
            // 
            // turev
            // 
            turev.AutoSize = true;
            turev.Location = new Point(177, 45);
            turev.Name = "turev";
            turev.Size = new Size(172, 24);
            turev.TabIndex = 3;
            turev.Text = "Türev İşlemler Kredisi";
            turev.UseVisualStyleBackColor = true;
            turev.CheckedChanged += turev_CheckedChanged;
            // 
            // konut
            // 
            konut.AutoSize = true;
            konut.Location = new Point(29, 105);
            konut.Name = "konut";
            konut.Size = new Size(130, 24);
            konut.TabIndex = 2;
            konut.Text = "Konut Kredileri";
            konut.UseVisualStyleBackColor = true;
            konut.CheckedChanged += konut_CheckedChanged;
            // 
            // tasit
            // 
            tasit.AutoSize = true;
            tasit.Location = new Point(29, 75);
            tasit.Name = "tasit";
            tasit.Size = new Size(120, 24);
            tasit.TabIndex = 1;
            tasit.Text = "Taşıt Kredileri";
            tasit.UseVisualStyleBackColor = true;
            tasit.CheckedChanged += tasit_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTemizle);
            groupBox2.Controls.Add(btnAra);
            groupBox2.Controls.Add(txtUrunAd);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 178);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1017, 63);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(782, 20);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(94, 29);
            btnTemizle.TabIndex = 13;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(657, 20);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(94, 29);
            btnAra.TabIndex = 12;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(146, 20);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(489, 27);
            txtUrunAd.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 23);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 10;
            label2.Text = "Ürün Adı:";
            // 
            // urunTablosu
            // 
            urunTablosu.AllowUserToAddRows = false;
            urunTablosu.AllowUserToDeleteRows = false;
            urunTablosu.AllowUserToResizeColumns = false;
            urunTablosu.AllowUserToResizeRows = false;
            urunTablosu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            urunTablosu.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            urunTablosu.Location = new Point(12, 262);
            urunTablosu.MultiSelect = false;
            urunTablosu.Name = "urunTablosu";
            urunTablosu.ReadOnly = true;
            urunTablosu.RowHeadersVisible = false;
            urunTablosu.RowHeadersWidth = 51;
            urunTablosu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            urunTablosu.Size = new Size(1017, 239);
            urunTablosu.TabIndex = 3;
            urunTablosu.CellDoubleClick += urunTablosu_CellDoubleClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "tipKod";
            Column1.HeaderText = "Tip Kod";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "urunId";
            Column2.HeaderText = "Sıra No";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "urunAd";
            Column3.HeaderText = "Ürün Ad";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 614;
            // 
            // btnSec
            // 
            btnSec.Location = new Point(12, 521);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(141, 29);
            btnSec.TabIndex = 4;
            btnSec.Text = "Seç";
            btnSec.UseVisualStyleBackColor = true;
            btnSec.Click += btnSec_Click;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(907, 521);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(122, 29);
            btnCikis.TabIndex = 6;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // UrunSecForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 562);
            Controls.Add(btnCikis);
            Controls.Add(btnSec);
            Controls.Add(urunTablosu);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "UrunSecForm";
            Text = "UrunSec";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)urunTablosu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox ihtiyac;
        private GroupBox groupBox1;
        private Label label1;
        private CheckBox parafGencDual;
        private CheckBox paraflyDual;
        private CheckBox parafDual;
        private CheckBox ipotekli;
        private CheckBox cekTaahhut;
        private CheckBox turev;
        private CheckBox konut;
        private CheckBox tasit;
        private CheckBox parafGencTroy;
        private CheckBox paraflyTroy;
        private CheckBox parafTroy;
        private CheckBox parafGenc;
        private CheckBox parafly;
        private CheckBox paraf;
        private GroupBox groupBox2;
        private Button btnAra;
        private TextBox txtUrunAd;
        private Label label2;
        private Button btnTemizle;
        private DataGridView urunTablosu;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button btnSec;
        private Button btnCikis;
    }
}