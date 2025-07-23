namespace Forms
{
    partial class BasvuruIptalForm
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            btnIptalEt = new Button();
            btnCikis = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Eksik veya Yanlış Bilgi / Belgeler", "Kredi Notunun Yetersizliği", "Mevcut Borçluluk Durumu", "İç Politikalar ve Risk Değerlendirmesi", "Diğer" });
            comboBox1.Location = new Point(193, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(575, 36);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(36, 33);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 1;
            label1.Text = "İptal Nedeni";
            // 
            // btnIptalEt
            // 
            btnIptalEt.Location = new Point(512, 114);
            btnIptalEt.Name = "btnIptalEt";
            btnIptalEt.Size = new Size(114, 41);
            btnIptalEt.TabIndex = 2;
            btnIptalEt.Text = "İptal Et";
            btnIptalEt.UseVisualStyleBackColor = true;
            btnIptalEt.Click += btnIptalEt_Click;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(654, 114);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(114, 41);
            btnCikis.TabIndex = 3;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // BasvuruIptalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 182);
            Controls.Add(btnCikis);
            Controls.Add(btnIptalEt);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "BasvuruIptalForm";
            Text = "BasvuruIptalForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Button btnIptalEt;
        private Button btnCikis;
    }
}