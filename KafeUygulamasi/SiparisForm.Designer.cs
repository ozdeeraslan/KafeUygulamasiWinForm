namespace KafeUygulamasi
{
    partial class SiparisForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            cboUrun = new ComboBox();
            btnDetayEkle = new Button();
            dgvDetaylar = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            nudAdet = new NumericUpDown();
            cnbMasaNo = new ComboBox();
            label3 = new Label();
            btnMasaTasi = new Button();
            btnSiparisIptal = new Button();
            btnOdemeAl = new Button();
            btnAnasayfayaDon = new Button();
            label4 = new Label();
            lblOdemeTutari = new Label();
            lblMasaNo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(13, 21);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 0;
            label1.Text = "Ürün";
            // 
            // label2
            // 
            label2.Location = new Point(183, 21);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 1;
            label2.Text = "Adet";
            // 
            // cboUrun
            // 
            cboUrun.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUrun.FormattingEnabled = true;
            cboUrun.Location = new Point(12, 59);
            cboUrun.Name = "cboUrun";
            cboUrun.Size = new Size(151, 28);
            cboUrun.TabIndex = 2;
            // 
            // btnDetayEkle
            // 
            btnDetayEkle.Location = new Point(293, 61);
            btnDetayEkle.Name = "btnDetayEkle";
            btnDetayEkle.Size = new Size(139, 28);
            btnDetayEkle.TabIndex = 4;
            btnDetayEkle.Text = "EKLE";
            btnDetayEkle.UseVisualStyleBackColor = true;
            btnDetayEkle.Click += btnDetayEkle_Click;
            // 
            // dgvDetaylar
            // 
            dgvDetaylar.AllowUserToAddRows = false;
            dgvDetaylar.AllowUserToDeleteRows = false;
            dgvDetaylar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetaylar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetaylar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetaylar.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvDetaylar.Location = new Point(12, 106);
            dgvDetaylar.MultiSelect = false;
            dgvDetaylar.Name = "dgvDetaylar";
            dgvDetaylar.ReadOnly = true;
            dgvDetaylar.RowHeadersVisible = false;
            dgvDetaylar.RowHeadersWidth = 51;
            dgvDetaylar.RowTemplate.Height = 29;
            dgvDetaylar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetaylar.Size = new Size(420, 438);
            dgvDetaylar.TabIndex = 5;
            dgvDetaylar.KeyDown += dgvDetaylar_KeyDown;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "UrunAd";
            Column1.HeaderText = "Ürün Ad";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "BirimFiyat";
            dataGridViewCellStyle1.Format = "c2";
            Column2.DefaultCellStyle = dataGridViewCellStyle1;
            Column2.HeaderText = "Birim Fiyat";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Adet";
            Column3.HeaderText = "Adet";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "TutarTL";
            Column4.HeaderText = "Tutar";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(183, 61);
            nudAdet.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(91, 27);
            nudAdet.TabIndex = 6;
            nudAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cnbMasaNo
            // 
            cnbMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cnbMasaNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cnbMasaNo.FormattingEnabled = true;
            cnbMasaNo.Location = new Point(438, 59);
            cnbMasaNo.Name = "cnbMasaNo";
            cnbMasaNo.Size = new Size(121, 28);
            cnbMasaNo.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Location = new Point(440, 21);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 7;
            label3.Text = "Masa No:";
            // 
            // btnMasaTasi
            // 
            btnMasaTasi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMasaTasi.Location = new Point(565, 58);
            btnMasaTasi.Name = "btnMasaTasi";
            btnMasaTasi.Size = new Size(73, 28);
            btnMasaTasi.TabIndex = 9;
            btnMasaTasi.Text = "TASI";
            btnMasaTasi.UseVisualStyleBackColor = true;
            // 
            // btnSiparisIptal
            // 
            btnSiparisIptal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiparisIptal.BackColor = Color.Firebrick;
            btnSiparisIptal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiparisIptal.ForeColor = Color.White;
            btnSiparisIptal.Location = new Point(438, 396);
            btnSiparisIptal.Name = "btnSiparisIptal";
            btnSiparisIptal.Size = new Size(96, 54);
            btnSiparisIptal.TabIndex = 10;
            btnSiparisIptal.Text = "SIPARIS IPTAL";
            btnSiparisIptal.UseVisualStyleBackColor = false;
            btnSiparisIptal.Click += btnSiparisIptal_Click;
            // 
            // btnOdemeAl
            // 
            btnOdemeAl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOdemeAl.BackColor = Color.ForestGreen;
            btnOdemeAl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOdemeAl.ForeColor = Color.White;
            btnOdemeAl.Location = new Point(540, 396);
            btnOdemeAl.Name = "btnOdemeAl";
            btnOdemeAl.Size = new Size(98, 54);
            btnOdemeAl.TabIndex = 11;
            btnOdemeAl.Text = "ÖDEME AL";
            btnOdemeAl.UseVisualStyleBackColor = false;
            btnOdemeAl.Click += btnOdemeAl_Click;
            // 
            // btnAnasayfayaDon
            // 
            btnAnasayfayaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnasayfayaDon.BackColor = Color.Gold;
            btnAnasayfayaDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnasayfayaDon.ForeColor = Color.Brown;
            btnAnasayfayaDon.Location = new Point(438, 456);
            btnAnasayfayaDon.Name = "btnAnasayfayaDon";
            btnAnasayfayaDon.Size = new Size(200, 85);
            btnAnasayfayaDon.TabIndex = 12;
            btnAnasayfayaDon.Text = "ANASAYFAYA DÖN";
            btnAnasayfayaDon.UseVisualStyleBackColor = false;
            btnAnasayfayaDon.Click += btnAnasayfayaDon_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.Location = new Point(438, 325);
            label4.Name = "label4";
            label4.Size = new Size(82, 46);
            label4.TabIndex = 13;
            label4.Text = "Ödeme Tutari:";
            // 
            // lblOdemeTutari
            // 
            lblOdemeTutari.Anchor = AnchorStyles.Right;
            lblOdemeTutari.BorderStyle = BorderStyle.Fixed3D;
            lblOdemeTutari.Location = new Point(527, 325);
            lblOdemeTutari.Name = "lblOdemeTutari";
            lblOdemeTutari.Size = new Size(111, 25);
            lblOdemeTutari.TabIndex = 14;
            lblOdemeTutari.Text = "₺ 0.00";
            // 
            // lblMasaNo
            // 
            lblMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMasaNo.BackColor = Color.Tomato;
            lblMasaNo.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
            lblMasaNo.ForeColor = Color.WhiteSmoke;
            lblMasaNo.Location = new Point(438, 106);
            lblMasaNo.Name = "lblMasaNo";
            lblMasaNo.Size = new Size(200, 176);
            lblMasaNo.TabIndex = 15;
            lblMasaNo.Text = "00";
            lblMasaNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SiparisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 556);
            Controls.Add(lblMasaNo);
            Controls.Add(lblOdemeTutari);
            Controls.Add(label4);
            Controls.Add(btnAnasayfayaDon);
            Controls.Add(btnOdemeAl);
            Controls.Add(btnSiparisIptal);
            Controls.Add(btnMasaTasi);
            Controls.Add(cnbMasaNo);
            Controls.Add(label3);
            Controls.Add(nudAdet);
            Controls.Add(dgvDetaylar);
            Controls.Add(btnDetayEkle);
            Controls.Add(cboUrun);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(600, 386);
            Name = "SiparisForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Masa 0";
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboUrun;
        private Button btnDetayEkle;
        private DataGridView dgvDetaylar;
        private NumericUpDown nudAdet;
        private ComboBox cnbMasaNo;
        private Label label3;
        private Button btnMasaTasi;
        private Button btnSiparisIptal;
        private Button btnOdemeAl;
        private Button btnAnasayfayaDon;
        private Label label4;
        private Label lblOdemeTutari;
        private Label lblMasaNo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}