namespace KafeUygulamasi
{
    partial class UrunlerForm
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
            txtUrunAd = new TextBox();
            label2 = new Label();
            nudUrunFiyat = new NumericUpDown();
            btnEkle = new Button();
            dgvUrunler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudUrunFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 26);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Ürün Adi";
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(24, 67);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(125, 27);
            txtUrunAd.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(174, 26);
            label2.Name = "label2";
            label2.Size = new Size(101, 31);
            label2.TabIndex = 2;
            label2.Text = "Birim Fiyati ₺";
            // 
            // nudUrunFiyat
            // 
            nudUrunFiyat.Location = new Point(174, 68);
            nudUrunFiyat.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudUrunFiyat.Name = "nudUrunFiyat";
            nudUrunFiyat.Size = new Size(88, 27);
            nudUrunFiyat.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(291, 69);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // dgvUrunler
            // 
            dgvUrunler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(24, 115);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.RowHeadersWidth = 51;
            dgvUrunler.RowTemplate.Height = 29;
            dgvUrunler.Size = new Size(360, 364);
            dgvUrunler.TabIndex = 5;
            // 
            // UrunlerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 491);
            Controls.Add(dgvUrunler);
            Controls.Add(btnEkle);
            Controls.Add(nudUrunFiyat);
            Controls.Add(label2);
            Controls.Add(txtUrunAd);
            Controls.Add(label1);
            Name = "UrunlerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)nudUrunFiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUrunAd;
        private Label label2;
        private NumericUpDown nudUrunFiyat;
        private Button btnEkle;
        private DataGridView dgvUrunler;
    }
}