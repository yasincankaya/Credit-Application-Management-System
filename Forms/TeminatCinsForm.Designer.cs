namespace Forms
{
    partial class TeminatCinsForm
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
            groupBox2 = new GroupBox();
            btnCikis = new Button();
            btnSec = new Button();
            groupBox1 = new GroupBox();
            teminatCinsTablosu = new DataGridView();
            cinsId = new DataGridViewTextBoxColumn();
            cinsAd = new DataGridViewTextBoxColumn();
            txtUrunSiraNo = new TextBox();
            txtUrunAd = new TextBox();
            txtUrunTipKod = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            txtTeminatTipAd = new TextBox();
            txtTeminatTipId = new TextBox();
            label3 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teminatCinsTablosu).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCikis);
            groupBox2.Controls.Add(btnSec);
            groupBox2.Location = new Point(12, 766);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(497, 78);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Seçim";
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(311, 26);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(146, 29);
            btnCikis.TabIndex = 6;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnSec
            // 
            btnSec.Location = new Point(78, 26);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(144, 29);
            btnSec.TabIndex = 5;
            btnSec.Text = "Seç";
            btnSec.UseVisualStyleBackColor = true;
            btnSec.Click += btnSec_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(teminatCinsTablosu);
            groupBox1.Location = new Point(12, 174);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(506, 586);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // teminatCinsTablosu
            // 
            teminatCinsTablosu.AllowUserToAddRows = false;
            teminatCinsTablosu.AllowUserToDeleteRows = false;
            teminatCinsTablosu.AllowUserToResizeColumns = false;
            teminatCinsTablosu.AllowUserToResizeRows = false;
            teminatCinsTablosu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            teminatCinsTablosu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teminatCinsTablosu.Columns.AddRange(new DataGridViewColumn[] { cinsId, cinsAd });
            teminatCinsTablosu.Location = new Point(0, 11);
            teminatCinsTablosu.MultiSelect = false;
            teminatCinsTablosu.Name = "teminatCinsTablosu";
            teminatCinsTablosu.ReadOnly = true;
            teminatCinsTablosu.RowHeadersVisible = false;
            teminatCinsTablosu.RowHeadersWidth = 51;
            teminatCinsTablosu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            teminatCinsTablosu.Size = new Size(506, 569);
            teminatCinsTablosu.TabIndex = 11;
            teminatCinsTablosu.CellDoubleClick += teminatCinsTablosu_CellDoubleClick;
            // 
            // cinsId
            // 
            cinsId.DataPropertyName = "cinsId";
            cinsId.FillWeight = 32.08556F;
            cinsId.HeaderText = "Teminat Cins Kod";
            cinsId.MinimumWidth = 6;
            cinsId.Name = "cinsId";
            cinsId.ReadOnly = true;
            // 
            // cinsAd
            // 
            cinsAd.DataPropertyName = "cinsAd";
            cinsAd.FillWeight = 167.914444F;
            cinsAd.HeaderText = "Teminat Cins Ad";
            cinsAd.MinimumWidth = 6;
            cinsAd.Name = "cinsAd";
            cinsAd.ReadOnly = true;
            // 
            // txtUrunSiraNo
            // 
            txtUrunSiraNo.Location = new Point(202, 30);
            txtUrunSiraNo.Name = "txtUrunSiraNo";
            txtUrunSiraNo.Size = new Size(49, 27);
            txtUrunSiraNo.TabIndex = 14;
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(146, 63);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(354, 27);
            txtUrunAd.TabIndex = 13;
            // 
            // txtUrunTipKod
            // 
            txtUrunTipKod.Location = new Point(146, 30);
            txtUrunTipKod.Name = "txtUrunTipKod";
            txtUrunTipKod.Size = new Size(50, 27);
            txtUrunTipKod.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 66);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 11;
            label2.Text = "Ürün Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 10;
            label1.Text = "Ürün Kodu/Sıra No";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTeminatTipAd);
            groupBox3.Controls.Add(txtTeminatTipId);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtUrunTipKod);
            groupBox3.Controls.Add(txtUrunSiraNo);
            groupBox3.Controls.Add(txtUrunAd);
            groupBox3.Enabled = false;
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(506, 156);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sıralama Şekli";
            // 
            // txtTeminatTipAd
            // 
            txtTeminatTipAd.Location = new Point(202, 96);
            txtTeminatTipAd.Name = "txtTeminatTipAd";
            txtTeminatTipAd.Size = new Size(298, 27);
            txtTeminatTipAd.TabIndex = 17;
            // 
            // txtTeminatTipId
            // 
            txtTeminatTipId.Location = new Point(146, 96);
            txtTeminatTipId.Name = "txtTeminatTipId";
            txtTeminatTipId.Size = new Size(50, 27);
            txtTeminatTipId.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 103);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 15;
            label3.Text = "Teminat Tipi";
            // 
            // TeminatCinsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 856);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "TeminatCinsForm";
            Text = "TeminatCinsForm";
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)teminatCinsTablosu).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button btnCikis;
        private Button btnSec;
        private GroupBox groupBox1;
        private DataGridView teminatCinsTablosu;
        private TextBox txtUrunSiraNo;
        private TextBox txtUrunAd;
        private TextBox txtUrunTipKod;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private TextBox txtTeminatTipId;
        private Label label3;
        private TextBox txtTeminatTipAd;
        private DataGridViewTextBoxColumn cinsId;
        private DataGridViewTextBoxColumn cinsAd;
    }
}