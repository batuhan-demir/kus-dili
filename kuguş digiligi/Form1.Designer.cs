namespace kuguş_digiligi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.girilen = new System.Windows.Forms.RichTextBox();
            this.çıktı = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKus = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnFont = new System.Windows.Forms.Button();
            this.cbKopyaMetin = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelAyarlar = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnArkaplanRengi = new System.Windows.Forms.Button();
            this.cbUpdateOto = new System.Windows.Forms.CheckBox();
            this.cbKopyalandi = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEnterTusu = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblUpperCase = new System.Windows.Forms.Label();
            this.pbAyarKaydet = new System.Windows.Forms.PictureBox();
            this.pbGuncelleme = new System.Windows.Forms.PictureBox();
            this.pbAyarlar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbBurdurland = new System.Windows.Forms.PictureBox();
            this.lblDownCase = new System.Windows.Forms.Label();
            this.panelAyarlar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAyarKaydet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuncelleme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAyarlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBurdurland)).BeginInit();
            this.SuspendLayout();
            // 
            // girilen
            // 
            this.girilen.Location = new System.Drawing.Point(92, 39);
            this.girilen.MaxLength = 1000000;
            this.girilen.Name = "girilen";
            this.girilen.Size = new System.Drawing.Size(369, 108);
            this.girilen.TabIndex = 0;
            this.girilen.Text = "";
            // 
            // çıktı
            // 
            this.çıktı.Location = new System.Drawing.Point(92, 243);
            this.çıktı.Name = "çıktı";
            this.çıktı.ReadOnly = true;
            this.çıktı.Size = new System.Drawing.Size(369, 58);
            this.çıktı.TabIndex = 7;
            this.çıktı.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(92, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Normal Yazıdan Kuş Diline";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yazı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Çıktı:";
            // 
            // txtKus
            // 
            this.txtKus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKus.Location = new System.Drawing.Point(494, 189);
            this.txtKus.MaxLength = 10;
            this.txtKus.Name = "txtKus";
            this.txtKus.Size = new System.Drawing.Size(105, 20);
            this.txtKus.TabIndex = 3;
            this.txtKus.Text = "g";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 4;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(280, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Kuş Dilinden Normal Yazıya";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(504, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ayıraç:";
            // 
            // btnFont
            // 
            this.btnFont.BackColor = System.Drawing.Color.Transparent;
            this.btnFont.FlatAppearance.BorderSize = 3;
            this.btnFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFont.Location = new System.Drawing.Point(6, 157);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(115, 38);
            this.btnFont.TabIndex = 4;
            this.btnFont.Text = "Font Seç";
            this.btnFont.UseVisualStyleBackColor = false;
            this.btnFont.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbKopyaMetin
            // 
            this.cbKopyaMetin.AutoSize = true;
            this.cbKopyaMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKopyaMetin.Location = new System.Drawing.Point(6, 54);
            this.cbKopyaMetin.Name = "cbKopyaMetin";
            this.cbKopyaMetin.Size = new System.Drawing.Size(343, 17);
            this.cbKopyaMetin.TabIndex = 5;
            this.cbKopyaMetin.Text = "Kopyalanan Metni Otomatik Olarak Yazı Kısmına Yapıştır";
            this.cbKopyaMetin.UseVisualStyleBackColor = true;
            this.cbKopyaMetin.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelAyarlar
            // 
            this.panelAyarlar.BackColor = System.Drawing.Color.Orange;
            this.panelAyarlar.Controls.Add(this.groupBox1);
            this.panelAyarlar.Controls.Add(this.label5);
            this.panelAyarlar.Controls.Add(this.label4);
            this.panelAyarlar.Location = new System.Drawing.Point(193, 395);
            this.panelAyarlar.Name = "panelAyarlar";
            this.panelAyarlar.Size = new System.Drawing.Size(550, 310);
            this.panelAyarlar.TabIndex = 11;
            this.panelAyarlar.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnArkaplanRengi);
            this.groupBox1.Controls.Add(this.cbUpdateOto);
            this.groupBox1.Controls.Add(this.cbKopyalandi);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.cbEnterTusu);
            this.groupBox1.Controls.Add(this.btnFont);
            this.groupBox1.Controls.Add(this.cbKopyaMetin);
            this.groupBox1.Location = new System.Drawing.Point(10, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 252);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // btnArkaplanRengi
            // 
            this.btnArkaplanRengi.BackColor = System.Drawing.Color.Transparent;
            this.btnArkaplanRengi.FlatAppearance.BorderSize = 3;
            this.btnArkaplanRengi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArkaplanRengi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArkaplanRengi.Location = new System.Drawing.Point(6, 201);
            this.btnArkaplanRengi.Name = "btnArkaplanRengi";
            this.btnArkaplanRengi.Size = new System.Drawing.Size(115, 38);
            this.btnArkaplanRengi.TabIndex = 21;
            this.btnArkaplanRengi.Text = "Arkaplan Rengi";
            this.btnArkaplanRengi.UseVisualStyleBackColor = false;
            this.btnArkaplanRengi.Click += new System.EventHandler(this.btnArkaplanRengi_Click);
            // 
            // cbUpdateOto
            // 
            this.cbUpdateOto.AutoSize = true;
            this.cbUpdateOto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbUpdateOto.Location = new System.Drawing.Point(334, 100);
            this.cbUpdateOto.Name = "cbUpdateOto";
            this.cbUpdateOto.Size = new System.Drawing.Size(187, 30);
            this.cbUpdateOto.TabIndex = 20;
            this.cbUpdateOto.Text = "Başlangıçta Otomatik Olarak\r\n Güncellemeleri Kontrol Et";
            this.cbUpdateOto.UseVisualStyleBackColor = true;
            // 
            // cbKopyalandi
            // 
            this.cbKopyalandi.AutoSize = true;
            this.cbKopyalandi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKopyalandi.Location = new System.Drawing.Point(6, 115);
            this.cbKopyalandi.Name = "cbKopyalandi";
            this.cbKopyalandi.Size = new System.Drawing.Size(144, 17);
            this.cbKopyalandi.TabIndex = 19;
            this.cbKopyalandi.Text = "\"Kopyalandı\" Bildirisi";
            this.cbKopyalandi.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pbAyarKaydet);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(174, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(121, 86);
            this.panel3.TabIndex = 18;
            this.panel3.Click += new System.EventHandler(this.pbAyarKaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(33, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Kaydet";
            this.label7.Click += new System.EventHandler(this.pbAyarKaydet_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbGuncelleme);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(400, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 86);
            this.panel2.TabIndex = 17;
            this.panel2.Click += new System.EventHandler(this.pbGuncelleme_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(0, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Yeni Sürüm Kontrol";
            this.label6.Click += new System.EventHandler(this.pbGuncelleme_Click);
            // 
            // cbEnterTusu
            // 
            this.cbEnterTusu.AutoSize = true;
            this.cbEnterTusu.Enabled = false;
            this.cbEnterTusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbEnterTusu.Location = new System.Drawing.Point(6, 85);
            this.cbEnterTusu.Name = "cbEnterTusu";
            this.cbEnterTusu.Size = new System.Drawing.Size(287, 17);
            this.cbEnterTusu.TabIndex = 15;
            this.cbEnterTusu.Text = "Enter Tuşu Çeviri Yapsın (İleride Aktif Olacak)";
            this.cbEnterTusu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(192, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "AYARLAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(517, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.lblAyarKapat);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.DeepSkyBlue;
            // 
            // lblUpperCase
            // 
            this.lblUpperCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpperCase.Image = global::kuguş_digiligi.Properties.Resources.up;
            this.lblUpperCase.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUpperCase.Location = new System.Drawing.Point(121, 304);
            this.lblUpperCase.Name = "lblUpperCase";
            this.lblUpperCase.Size = new System.Drawing.Size(80, 45);
            this.lblUpperCase.TabIndex = 12;
            this.lblUpperCase.Text = "Büyük Harf";
            this.lblUpperCase.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblUpperCase.Click += new System.EventHandler(this.lblUpperCase_Click);
            // 
            // pbAyarKaydet
            // 
            this.pbAyarKaydet.Image = global::kuguş_digiligi.Properties.Resources.kaydet;
            this.pbAyarKaydet.Location = new System.Drawing.Point(3, 3);
            this.pbAyarKaydet.Name = "pbAyarKaydet";
            this.pbAyarKaydet.Size = new System.Drawing.Size(113, 66);
            this.pbAyarKaydet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAyarKaydet.TabIndex = 14;
            this.pbAyarKaydet.TabStop = false;
            this.pbAyarKaydet.Click += new System.EventHandler(this.pbAyarKaydet_Click);
            // 
            // pbGuncelleme
            // 
            this.pbGuncelleme.Image = global::kuguş_digiligi.Properties.Resources.guncelleme;
            this.pbGuncelleme.Location = new System.Drawing.Point(3, 3);
            this.pbGuncelleme.Name = "pbGuncelleme";
            this.pbGuncelleme.Size = new System.Drawing.Size(113, 66);
            this.pbGuncelleme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGuncelleme.TabIndex = 14;
            this.pbGuncelleme.TabStop = false;
            this.pbGuncelleme.Click += new System.EventHandler(this.pbGuncelleme_Click);
            // 
            // pbAyarlar
            // 
            this.pbAyarlar.Image = global::kuguş_digiligi.Properties.Resources.ayarlar;
            this.pbAyarlar.Location = new System.Drawing.Point(-21, 334);
            this.pbAyarlar.Name = "pbAyarlar";
            this.pbAyarlar.Size = new System.Drawing.Size(100, 50);
            this.pbAyarlar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAyarlar.TabIndex = 10;
            this.pbAyarlar.TabStop = false;
            this.pbAyarlar.Click += new System.EventHandler(this.pbAyarlar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::kuguş_digiligi.Properties.Resources.kopyala;
            this.pictureBox3.Location = new System.Drawing.Point(390, 304);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.label4_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::kuguş_digiligi.Properties.Resources.temizle;
            this.pictureBox2.Location = new System.Drawing.Point(464, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.label5_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // pbBurdurland
            // 
            this.pbBurdurland.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBurdurland.Image = global::kuguş_digiligi.Properties.Resources.porcay;
            this.pbBurdurland.Location = new System.Drawing.Point(525, 304);
            this.pbBurdurland.Name = "pbBurdurland";
            this.pbBurdurland.Size = new System.Drawing.Size(114, 80);
            this.pbBurdurland.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBurdurland.TabIndex = 6;
            this.pbBurdurland.TabStop = false;
            this.pbBurdurland.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblDownCase
            // 
            this.lblDownCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDownCase.Image = global::kuguş_digiligi.Properties.Resources.down;
            this.lblDownCase.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDownCase.Location = new System.Drawing.Point(225, 304);
            this.lblDownCase.Name = "lblDownCase";
            this.lblDownCase.Size = new System.Drawing.Size(80, 45);
            this.lblDownCase.TabIndex = 12;
            this.lblDownCase.Text = "Küçük Harf";
            this.lblDownCase.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblDownCase.Click += new System.EventHandler(this.lblDownCase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(622, 384);
            this.Controls.Add(this.panelAyarlar);
            this.Controls.Add(this.lblDownCase);
            this.Controls.Add(this.lblUpperCase);
            this.Controls.Add(this.pbAyarlar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbBurdurland);
            this.Controls.Add(this.txtKus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.çıktı);
            this.Controls.Add(this.girilen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kuş Dili Çevirici v2.1.1 ßy u/batu-_-batu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.panelAyarlar.ResumeLayout(false);
            this.panelAyarlar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAyarKaydet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuncelleme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAyarlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBurdurland)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.RichTextBox girilen;
        public System.Windows.Forms.RichTextBox çıktı;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtKus;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnFont;
        public System.Windows.Forms.PictureBox pbBurdurland;
        public System.Windows.Forms.CheckBox cbKopyaMetin;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.PictureBox pbAyarlar;
        public System.Windows.Forms.FontDialog fontDialog1;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelAyarlar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbGuncelleme;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.CheckBox cbEnterTusu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbAyarKaydet;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.CheckBox cbKopyalandi;
        public System.Windows.Forms.CheckBox cbUpdateOto;
        public System.Windows.Forms.Button btnArkaplanRengi;
        public System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblUpperCase;
        private System.Windows.Forms.Label lblDownCase;
    }
}

