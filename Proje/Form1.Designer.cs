namespace Proje
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_filtrele = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tutar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cari = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_gdr_tip = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rd_btn_gider = new System.Windows.Forms.RadioButton();
            this.rd_btn_gelir = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rd_f_hepsi = new System.Windows.Forms.RadioButton();
            this.rd_f_gider = new System.Windows.Forms.RadioButton();
            this.rd_f_gelir = new System.Windows.Forms.RadioButton();
            this.btn_istatistik = new System.Windows.Forms.Button();
            this.btn_hatırlatıcı = new System.Windows.Forms.Button();
            this.btn_aktar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(465, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(898, 596);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.btn_filtrele);
            this.groupBox1.Controls.Add(this.btn_guncelle);
            this.groupBox1.Controls.Add(this.btn_kapat);
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Controls.Add(this.btn_sil);
            this.groupBox1.Controls.Add(this.txt_aciklama);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_tutar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_cari);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmb_gdr_tip);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rd_btn_gider);
            this.groupBox1.Controls.Add(this.rd_btn_gelir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 596);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Tan;
            this.btn_ekle.Location = new System.Drawing.Point(350, 161);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(65, 24);
            this.btn_ekle.TabIndex = 19;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_filtrele
            // 
            this.btn_filtrele.BackColor = System.Drawing.Color.Tan;
            this.btn_filtrele.Location = new System.Drawing.Point(333, 437);
            this.btn_filtrele.Name = "btn_filtrele";
            this.btn_filtrele.Size = new System.Drawing.Size(100, 45);
            this.btn_filtrele.TabIndex = 20;
            this.btn_filtrele.Text = "Filtrele";
            this.btn_filtrele.UseVisualStyleBackColor = false;
            this.btn_filtrele.Click += new System.EventHandler(this.btn_filtrele_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.Tan;
            this.btn_guncelle.Location = new System.Drawing.Point(218, 437);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(100, 45);
            this.btn_guncelle.TabIndex = 19;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Tan;
            this.btn_kapat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_kapat.Location = new System.Drawing.Point(3, 511);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(453, 82);
            this.btn_kapat.TabIndex = 17;
            this.btn_kapat.Text = "Programı Kapat";
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.Tan;
            this.btn_kaydet.Location = new System.Drawing.Point(112, 437);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(100, 45);
            this.btn_kaydet.TabIndex = 16;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Tan;
            this.btn_sil.Location = new System.Drawing.Point(6, 437);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(100, 45);
            this.btn_sil.TabIndex = 15;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(135, 304);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(194, 98);
            this.txt_aciklama.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(15, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Açıklama:";
            // 
            // txt_tutar
            // 
            this.txt_tutar.Location = new System.Drawing.Point(135, 251);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Size = new System.Drawing.Size(102, 22);
            this.txt_tutar.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tutar:";
            // 
            // txt_cari
            // 
            this.txt_cari.Location = new System.Drawing.Point(135, 208);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(149, 22);
            this.txt_cari.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cari:";
            // 
            // cmb_gdr_tip
            // 
            this.cmb_gdr_tip.FormattingEnabled = true;
            this.cmb_gdr_tip.Items.AddRange(new object[] {
            "Yemek ",
            "Ulaşım",
            "Kira",
            "Elektrik",
            "Su ",
            "Doğalgaz",
            "İnternet ",
            "Kredi Faizleri",
            "Banka Masrafları",
            "Sigorta Primleri",
            "Uçak Tren veya Otobüs Biletleri",
            "Otel Konaklamaları",
            "Yurt Dışı Seyahat Harcamaları",
            "Abonelik ve Üyelik Ücretleri"});
            this.cmb_gdr_tip.Location = new System.Drawing.Point(135, 161);
            this.cmb_gdr_tip.Name = "cmb_gdr_tip";
            this.cmb_gdr_tip.Size = new System.Drawing.Size(198, 24);
            this.cmb_gdr_tip.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gider ise tipi:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tarih:";
            // 
            // rd_btn_gider
            // 
            this.rd_btn_gider.AutoSize = true;
            this.rd_btn_gider.Location = new System.Drawing.Point(197, 80);
            this.rd_btn_gider.Name = "rd_btn_gider";
            this.rd_btn_gider.Size = new System.Drawing.Size(61, 20);
            this.rd_btn_gider.TabIndex = 4;
            this.rd_btn_gider.TabStop = true;
            this.rd_btn_gider.Text = "Gider";
            this.rd_btn_gider.UseVisualStyleBackColor = true;
            // 
            // rd_btn_gelir
            // 
            this.rd_btn_gelir.AutoSize = true;
            this.rd_btn_gelir.Location = new System.Drawing.Point(135, 81);
            this.rd_btn_gelir.Name = "rd_btn_gelir";
            this.rd_btn_gelir.Size = new System.Drawing.Size(56, 20);
            this.rd_btn_gelir.TabIndex = 3;
            this.rd_btn_gelir.TabStop = true;
            this.rd_btn_gelir.Text = "Gelir";
            this.rd_btn_gelir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "İşlem tipi:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(135, 33);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(149, 22);
            this.txt_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kayıt No:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rd_f_hepsi);
            this.panel1.Controls.Add(this.rd_f_gider);
            this.panel1.Controls.Add(this.rd_f_gelir);
            this.panel1.Location = new System.Drawing.Point(462, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 46);
            this.panel1.TabIndex = 2;
            // 
            // rd_f_hepsi
            // 
            this.rd_f_hepsi.AutoSize = true;
            this.rd_f_hepsi.Location = new System.Drawing.Point(177, 23);
            this.rd_f_hepsi.Name = "rd_f_hepsi";
            this.rd_f_hepsi.Size = new System.Drawing.Size(64, 20);
            this.rd_f_hepsi.TabIndex = 20;
            this.rd_f_hepsi.TabStop = true;
            this.rd_f_hepsi.Text = "Hepsi";
            this.rd_f_hepsi.UseVisualStyleBackColor = true;
            this.rd_f_hepsi.CheckedChanged += new System.EventHandler(this.rd_f_hepsi_CheckedChanged);
            // 
            // rd_f_gider
            // 
            this.rd_f_gider.AutoSize = true;
            this.rd_f_gider.Location = new System.Drawing.Point(100, 23);
            this.rd_f_gider.Name = "rd_f_gider";
            this.rd_f_gider.Size = new System.Drawing.Size(61, 20);
            this.rd_f_gider.TabIndex = 20;
            this.rd_f_gider.TabStop = true;
            this.rd_f_gider.Text = "Gider";
            this.rd_f_gider.UseVisualStyleBackColor = true;
            this.rd_f_gider.CheckedChanged += new System.EventHandler(this.rd_f_hepsi_CheckedChanged);
            // 
            // rd_f_gelir
            // 
            this.rd_f_gelir.AutoSize = true;
            this.rd_f_gelir.Location = new System.Drawing.Point(20, 23);
            this.rd_f_gelir.Name = "rd_f_gelir";
            this.rd_f_gelir.Size = new System.Drawing.Size(56, 20);
            this.rd_f_gelir.TabIndex = 4;
            this.rd_f_gelir.TabStop = true;
            this.rd_f_gelir.Text = "Gelir";
            this.rd_f_gelir.UseVisualStyleBackColor = true;
            this.rd_f_gelir.CheckedChanged += new System.EventHandler(this.rd_f_hepsi_CheckedChanged);
            // 
            // btn_istatistik
            // 
            this.btn_istatistik.BackColor = System.Drawing.Color.Tan;
            this.btn_istatistik.Location = new System.Drawing.Point(19, 12);
            this.btn_istatistik.Name = "btn_istatistik";
            this.btn_istatistik.Size = new System.Drawing.Size(91, 35);
            this.btn_istatistik.TabIndex = 16;
            this.btn_istatistik.Text = "İstatistik";
            this.btn_istatistik.UseVisualStyleBackColor = false;
            this.btn_istatistik.Click += new System.EventHandler(this.btn_istatistik_Click);
            // 
            // btn_hatırlatıcı
            // 
            this.btn_hatırlatıcı.BackColor = System.Drawing.Color.Tan;
            this.btn_hatırlatıcı.Location = new System.Drawing.Point(135, 12);
            this.btn_hatırlatıcı.Name = "btn_hatırlatıcı";
            this.btn_hatırlatıcı.Size = new System.Drawing.Size(91, 35);
            this.btn_hatırlatıcı.TabIndex = 17;
            this.btn_hatırlatıcı.Text = "Hatırlatıcı";
            this.btn_hatırlatıcı.UseVisualStyleBackColor = false;
            this.btn_hatırlatıcı.Click += new System.EventHandler(this.btn_hatırlatıcı_Click);
            // 
            // btn_aktar
            // 
            this.btn_aktar.BackColor = System.Drawing.Color.Tan;
            this.btn_aktar.Location = new System.Drawing.Point(256, 12);
            this.btn_aktar.Name = "btn_aktar";
            this.btn_aktar.Size = new System.Drawing.Size(91, 35);
            this.btn_aktar.TabIndex = 18;
            this.btn_aktar.Text = "Aktar";
            this.btn_aktar.UseVisualStyleBackColor = false;
            this.btn_aktar.Click += new System.EventHandler(this.btn_aktar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1360, 647);
            this.Controls.Add(this.btn_aktar);
            this.Controls.Add(this.btn_hatırlatıcı);
            this.Controls.Add(this.btn_istatistik);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelir Gider Takip Uygulaması";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tutar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_gdr_tip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rd_btn_gider;
        private System.Windows.Forms.RadioButton rd_btn_gelir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rd_f_hepsi;
        private System.Windows.Forms.RadioButton rd_f_gider;
        private System.Windows.Forms.RadioButton rd_f_gelir;
        private System.Windows.Forms.Button btn_istatistik;
        private System.Windows.Forms.Button btn_filtrele;
        private System.Windows.Forms.Button btn_hatırlatıcı;
        private System.Windows.Forms.Button btn_aktar;
        private System.Windows.Forms.Button btn_ekle;
    }
}

