namespace Forms
{
    partial class TeminatTipForm
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
            label1 = new Label();
            label2 = new Label();
            txtUrunKod = new TextBox();
            btnSec = new Button();
            txtUrunAd = new TextBox();
            txtSiraNo = new TextBox();
            groupBox1 = new GroupBox();
            teminatTipTablosu = new DataGridView();
            tipId = new DataGridViewTextBoxColumn();
            teminatTipAd = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            btnCikis = new Button();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teminatTipTablosu).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 0;
            label1.Text = "Ürün Kodu/Sıra No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 64);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Ürün Adı";
            // 
            // txtUrunKod
            // 
            txtUrunKod.Location = new Point(146, 20);
            txtUrunKod.Name = "txtUrunKod";
            txtUrunKod.Size = new Size(59, 27);
            txtUrunKod.TabIndex = 2;
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
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(146, 53);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(361, 27);
            txtUrunAd.TabIndex = 6;
            // 
            // txtSiraNo
            // 
            txtSiraNo.Location = new Point(211, 20);
            txtSiraNo.Name = "txtSiraNo";
            txtSiraNo.Size = new Size(60, 27);
            txtSiraNo.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(teminatTipTablosu);
            groupBox1.Location = new Point(16, 148);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(497, 458);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // teminatTipTablosu
            // 
            teminatTipTablosu.AllowUserToAddRows = false;
            teminatTipTablosu.AllowUserToDeleteRows = false;
            teminatTipTablosu.AllowUserToResizeColumns = false;
            teminatTipTablosu.AllowUserToResizeRows = false;
            teminatTipTablosu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            teminatTipTablosu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teminatTipTablosu.Columns.AddRange(new DataGridViewColumn[] { tipId, teminatTipAd });
            teminatTipTablosu.Location = new Point(0, 26);
            teminatTipTablosu.MultiSelect = false;
            teminatTipTablosu.Name = "teminatTipTablosu";
            teminatTipTablosu.ReadOnly = true;
            teminatTipTablosu.RowHeadersVisible = false;
            teminatTipTablosu.RowHeadersWidth = 51;
            teminatTipTablosu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            teminatTipTablosu.Size = new Size(497, 501);
            teminatTipTablosu.TabIndex = 11;
            teminatTipTablosu.CellDoubleClick += teminatTipTablosu_CellDoubleClick;
            // 
            // tipId
            // 
            tipId.DataPropertyName = "tipId";
            tipId.FillWeight = 32.08556F;
            tipId.HeaderText = "Teminat Kod";
            tipId.MinimumWidth = 6;
            tipId.Name = "tipId";
            tipId.ReadOnly = true;
            // 
            // teminatTipAd
            // 
            teminatTipAd.DataPropertyName = "teminatTipAd";
            teminatTipAd.FillWeight = 167.914444F;
            teminatTipAd.HeaderText = "Teminat Ad";
            teminatTipAd.MinimumWidth = 6;
            teminatTipAd.Name = "teminatTipAd";
            teminatTipAd.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCikis);
            groupBox2.Controls.Add(btnSec);
            groupBox2.Location = new Point(16, 652);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(497, 78);
            groupBox2.TabIndex = 9;
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
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtUrunKod);
            groupBox3.Controls.Add(txtSiraNo);
            groupBox3.Controls.Add(txtUrunAd);
            groupBox3.Enabled = false;
            groupBox3.Location = new Point(16, 17);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(497, 125);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ürün Bilgileri";
            // 
            // TeminatTipForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 742);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "TeminatTipForm";
            Text = "TeminatTipForm";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)teminatTipTablosu).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUrunKod;
        private Button btnSec;
        private TextBox txtUrunAd;
        private TextBox txtSiraNo;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnCikis;
        private DataGridView teminatTipTablosu;
        private DataGridViewTextBoxColumn tipId;
        private DataGridViewTextBoxColumn teminatTipAd;
        private GroupBox groupBox3;
    }
}