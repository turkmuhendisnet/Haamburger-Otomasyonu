namespace Çalışma_Hamburger_Sistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcbMenuResmi = new System.Windows.Forms.PictureBox();
            this.cmbMenuListesi = new System.Windows.Forms.ComboBox();
            this.grbBoyutSecimi = new System.Windows.Forms.GroupBox();
            this.rdbBuyukBoyut = new System.Windows.Forms.RadioButton();
            this.rdbOrtaBoyut = new System.Windows.Forms.RadioButton();
            this.rdbKucukBoyut = new System.Windows.Forms.RadioButton();
            this.flpExtraMazemeSecimi = new System.Windows.Forms.FlowLayoutPanel();
            this.nupMenuAdedi = new System.Windows.Forms.NumericUpDown();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.lstSiparisSepeti = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSiparisiTamamla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenuResmi)).BeginInit();
            this.grbBoyutSecimi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupMenuAdedi)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbMenuResmi
            // 
            this.pcbMenuResmi.Location = new System.Drawing.Point(12, 12);
            this.pcbMenuResmi.Name = "pcbMenuResmi";
            this.pcbMenuResmi.Size = new System.Drawing.Size(253, 178);
            this.pcbMenuResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMenuResmi.TabIndex = 0;
            this.pcbMenuResmi.TabStop = false;
            // 
            // cmbMenuListesi
            // 
            this.cmbMenuListesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbMenuListesi.FormattingEnabled = true;
            this.cmbMenuListesi.Location = new System.Drawing.Point(12, 230);
            this.cmbMenuListesi.Name = "cmbMenuListesi";
            this.cmbMenuListesi.Size = new System.Drawing.Size(253, 21);
            this.cmbMenuListesi.TabIndex = 1;
            this.cmbMenuListesi.SelectedIndexChanged += new System.EventHandler(this.cmbMenuListesi_SelectedIndexChanged);
            // 
            // grbBoyutSecimi
            // 
            this.grbBoyutSecimi.Controls.Add(this.rdbBuyukBoyut);
            this.grbBoyutSecimi.Controls.Add(this.rdbOrtaBoyut);
            this.grbBoyutSecimi.Controls.Add(this.rdbKucukBoyut);
            this.grbBoyutSecimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbBoyutSecimi.ForeColor = System.Drawing.Color.White;
            this.grbBoyutSecimi.Location = new System.Drawing.Point(12, 271);
            this.grbBoyutSecimi.Name = "grbBoyutSecimi";
            this.grbBoyutSecimi.Size = new System.Drawing.Size(253, 82);
            this.grbBoyutSecimi.TabIndex = 2;
            this.grbBoyutSecimi.TabStop = false;
            this.grbBoyutSecimi.Text = "Boyut Seçimi";
            // 
            // rdbBuyukBoyut
            // 
            this.rdbBuyukBoyut.AutoSize = true;
            this.rdbBuyukBoyut.ForeColor = System.Drawing.Color.White;
            this.rdbBuyukBoyut.Location = new System.Drawing.Point(169, 37);
            this.rdbBuyukBoyut.Name = "rdbBuyukBoyut";
            this.rdbBuyukBoyut.Size = new System.Drawing.Size(65, 21);
            this.rdbBuyukBoyut.TabIndex = 2;
            this.rdbBuyukBoyut.Text = "Büyük";
            this.rdbBuyukBoyut.UseVisualStyleBackColor = true;
            // 
            // rdbOrtaBoyut
            // 
            this.rdbOrtaBoyut.AutoSize = true;
            this.rdbOrtaBoyut.Location = new System.Drawing.Point(92, 37);
            this.rdbOrtaBoyut.Name = "rdbOrtaBoyut";
            this.rdbOrtaBoyut.Size = new System.Drawing.Size(54, 21);
            this.rdbOrtaBoyut.TabIndex = 1;
            this.rdbOrtaBoyut.Text = "Orta";
            this.rdbOrtaBoyut.UseVisualStyleBackColor = true;
            // 
            // rdbKucukBoyut
            // 
            this.rdbKucukBoyut.AutoSize = true;
            this.rdbKucukBoyut.Checked = true;
            this.rdbKucukBoyut.Location = new System.Drawing.Point(6, 37);
            this.rdbKucukBoyut.Name = "rdbKucukBoyut";
            this.rdbKucukBoyut.Size = new System.Drawing.Size(65, 21);
            this.rdbKucukBoyut.TabIndex = 0;
            this.rdbKucukBoyut.TabStop = true;
            this.rdbKucukBoyut.Text = "Küçük";
            this.rdbKucukBoyut.UseVisualStyleBackColor = true;
            // 
            // flpExtraMazemeSecimi
            // 
            this.flpExtraMazemeSecimi.Location = new System.Drawing.Point(12, 395);
            this.flpExtraMazemeSecimi.Name = "flpExtraMazemeSecimi";
            this.flpExtraMazemeSecimi.Size = new System.Drawing.Size(253, 114);
            this.flpExtraMazemeSecimi.TabIndex = 3;
            // 
            // nupMenuAdedi
            // 
            this.nupMenuAdedi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.nupMenuAdedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nupMenuAdedi.Location = new System.Drawing.Point(12, 538);
            this.nupMenuAdedi.Name = "nupMenuAdedi";
            this.nupMenuAdedi.Size = new System.Drawing.Size(253, 23);
            this.nupMenuAdedi.TabIndex = 4;
            this.nupMenuAdedi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSepeteEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSepeteEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSepeteEkle.ForeColor = System.Drawing.Color.Red;
            this.btnSepeteEkle.Location = new System.Drawing.Point(12, 587);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(253, 34);
            this.btnSepeteEkle.TabIndex = 5;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = false;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // lstSiparisSepeti
            // 
            this.lstSiparisSepeti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lstSiparisSepeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSiparisSepeti.FormattingEnabled = true;
            this.lstSiparisSepeti.ItemHeight = 20;
            this.lstSiparisSepeti.Location = new System.Drawing.Point(298, 12);
            this.lstSiparisSepeti.Name = "lstSiparisSepeti";
            this.lstSiparisSepeti.Size = new System.Drawing.Size(615, 484);
            this.lstSiparisSepeti.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(295, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Toplam Tutar:";
            // 
            // btnSiparisiTamamla
            // 
            this.btnSiparisiTamamla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSiparisiTamamla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparisiTamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisiTamamla.ForeColor = System.Drawing.Color.Red;
            this.btnSiparisiTamamla.Location = new System.Drawing.Point(660, 587);
            this.btnSiparisiTamamla.Name = "btnSiparisiTamamla";
            this.btnSiparisiTamamla.Size = new System.Drawing.Size(253, 34);
            this.btnSiparisiTamamla.TabIndex = 8;
            this.btnSiparisiTamamla.Text = "Siparişi Tamamla";
            this.btnSiparisiTamamla.UseVisualStyleBackColor = false;
            this.btnSiparisiTamamla.Click += new System.EventHandler(this.btnSiparisiTamamla_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Adet";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Menü Seçimi";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Extra Malzeme Seçimi";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.ForeColor = System.Drawing.Color.White;
            this.lblToplamTutar.Location = new System.Drawing.Point(398, 540);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(23, 25);
            this.lblToplamTutar.TabIndex = 12;
            this.lblToplamTutar.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(927, 633);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSiparisiTamamla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSiparisSepeti);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.nupMenuAdedi);
            this.Controls.Add(this.flpExtraMazemeSecimi);
            this.Controls.Add(this.grbBoyutSecimi);
            this.Controls.Add(this.cmbMenuListesi);
            this.Controls.Add(this.pcbMenuResmi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenuResmi)).EndInit();
            this.grbBoyutSecimi.ResumeLayout(false);
            this.grbBoyutSecimi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupMenuAdedi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbMenuResmi;
        private System.Windows.Forms.ComboBox cmbMenuListesi;
        private System.Windows.Forms.GroupBox grbBoyutSecimi;
        private System.Windows.Forms.RadioButton rdbBuyukBoyut;
        private System.Windows.Forms.RadioButton rdbOrtaBoyut;
        private System.Windows.Forms.RadioButton rdbKucukBoyut;
        private System.Windows.Forms.FlowLayoutPanel flpExtraMazemeSecimi;
        private System.Windows.Forms.NumericUpDown nupMenuAdedi;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.ListBox lstSiparisSepeti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiparisiTamamla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplamTutar;
    }
}

