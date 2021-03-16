namespace KusDiliCeviri
{
    partial class KusDilCeviri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KusDilCeviri));
            this.cevrilen = new System.Windows.Forms.RichTextBox();
            this.ceviri = new System.Windows.Forms.RichTextBox();
            this.cevir = new System.Windows.Forms.Button();
            this.CevirMod = new System.Windows.Forms.ComboBox();
            this.CevirMod_harf = new System.Windows.Forms.ComboBox();
            this.bilgi_Label = new System.Windows.Forms.Label();
            this.ayarlar_Btn = new System.Windows.Forms.Button();
            this.kucukSimge = new System.Windows.Forms.NotifyIcon(this.components);
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hizliCeviri = new System.Windows.Forms.ToolStripMenuItem();
            this.uygAc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.uygKapat = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgi = new System.Windows.Forms.PictureBox();
            this.yapistir = new System.Windows.Forms.Button();
            this.kopya = new System.Windows.Forms.Button();
            this.blgi = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bilgi)).BeginInit();
            this.SuspendLayout();
            // 
            // cevrilen
            // 
            this.cevrilen.Location = new System.Drawing.Point(12, 12);
            this.cevrilen.Name = "cevrilen";
            this.cevrilen.Size = new System.Drawing.Size(249, 72);
            this.cevrilen.TabIndex = 0;
            this.cevrilen.Text = "";
            this.blgi.SetToolTip(this.cevrilen, "Çevrilecek metniniz");
            this.cevrilen.TextChanged += new System.EventHandler(this.cevrilen_TextChanged);
            // 
            // ceviri
            // 
            this.ceviri.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ceviri.Location = new System.Drawing.Point(12, 148);
            this.ceviri.Name = "ceviri";
            this.ceviri.ReadOnly = true;
            this.ceviri.Size = new System.Drawing.Size(249, 75);
            this.ceviri.TabIndex = 2;
            this.ceviri.Text = "";
            this.blgi.SetToolTip(this.ceviri, "Çeviri sonucunuz");
            // 
            // cevir
            // 
            this.cevir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cevir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cevir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cevir.Location = new System.Drawing.Point(12, 90);
            this.cevir.Name = "cevir";
            this.cevir.Size = new System.Drawing.Size(75, 52);
            this.cevir.TabIndex = 1;
            this.cevir.Text = "Çevir";
            this.blgi.SetToolTip(this.cevir, "Metninizi çevirin");
            this.cevir.UseVisualStyleBackColor = false;
            this.cevir.Click += new System.EventHandler(this.cevir_Click);
            // 
            // CevirMod
            // 
            this.CevirMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CevirMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CevirMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CevirMod.FormattingEnabled = true;
            this.CevirMod.Items.AddRange(new object[] {
            "Türkçe\'den Kuş Dili\'ne",
            "Kuş Dili\'nden Türkçe\'ye"});
            this.CevirMod.Location = new System.Drawing.Point(93, 90);
            this.CevirMod.Name = "CevirMod";
            this.CevirMod.Size = new System.Drawing.Size(148, 21);
            this.CevirMod.TabIndex = 3;
            this.blgi.SetToolTip(this.CevirMod, "Çevirme ayarınız (Eğer \'lf\' harfi seçildiyse Hırsız Dili seçilmiş olur)");
            // 
            // CevirMod_harf
            // 
            this.CevirMod_harf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CevirMod_harf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CevirMod_harf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CevirMod_harf.FormattingEnabled = true;
            this.CevirMod_harf.Items.AddRange(new object[] {
            "\' g \' harfi ile çevir",
            "\' b \' harfi ile çevir",
            "\' c \' harfi ile çevir",
            "\' f \' harfi ile çevir",
            "\' lf \' (Hırsız Dili)"});
            this.CevirMod_harf.Location = new System.Drawing.Point(93, 121);
            this.CevirMod_harf.Name = "CevirMod_harf";
            this.CevirMod_harf.Size = new System.Drawing.Size(148, 21);
            this.CevirMod_harf.TabIndex = 4;
            this.blgi.SetToolTip(this.CevirMod_harf, "Çeviride kullanılacak harf (Hırsız Dili için \' lf \' seçeneğini seçin)");
            // 
            // bilgi_Label
            // 
            this.bilgi_Label.AutoSize = true;
            this.bilgi_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bilgi_Label.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.bilgi_Label.Location = new System.Drawing.Point(9, 243);
            this.bilgi_Label.Name = "bilgi_Label";
            this.bilgi_Label.Size = new System.Drawing.Size(151, 13);
            this.bilgi_Label.TabIndex = 8;
            this.bilgi_Label.Text = "lim10dev\'den Kuş Dili Çeviricisi";
            this.blgi.SetToolTip(this.bilgi_Label, "lim10dev.itch.io");
            // 
            // ayarlar_Btn
            // 
            this.ayarlar_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ayarlar_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ayarlar_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ayarlar_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ayarlar_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ayarlar_Btn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.ayarlar_Btn.Location = new System.Drawing.Point(223, 237);
            this.ayarlar_Btn.Name = "ayarlar_Btn";
            this.ayarlar_Btn.Size = new System.Drawing.Size(67, 25);
            this.ayarlar_Btn.TabIndex = 9;
            this.ayarlar_Btn.Text = "Ayarlar";
            this.blgi.SetToolTip(this.ayarlar_Btn, "Uygulama ayarları");
            this.ayarlar_Btn.UseVisualStyleBackColor = false;
            this.ayarlar_Btn.Click += new System.EventHandler(this.ayarlar_Btn_Click);
            // 
            // kucukSimge
            // 
            this.kucukSimge.BalloonTipText = "Hızlı çeviri için bir kez tıklayın";
            this.kucukSimge.BalloonTipTitle = "Kuş Dili Çeviricisi";
            this.kucukSimge.ContextMenuStrip = this.menu;
            this.kucukSimge.Icon = ((System.Drawing.Icon)(resources.GetObject("kucukSimge.Icon")));
            this.kucukSimge.Text = "Hızlı çeviri için bir kez tıklayın";
            this.kucukSimge.Visible = true;
            this.kucukSimge.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kucukSimge_MouseClick);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator2,
            this.hizliCeviri,
            this.uygAc,
            this.toolStripSeparator1,
            this.uygKapat});
            this.menu.Name = "menu";
            this.menu.ShowImageMargin = false;
            this.menu.Size = new System.Drawing.Size(168, 126);
            // 
            // hizliCeviri
            // 
            this.hizliCeviri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.hizliCeviri.Name = "hizliCeviri";
            this.hizliCeviri.Size = new System.Drawing.Size(167, 22);
            this.hizliCeviri.Text = "Hızlı Çeviri";
            this.hizliCeviri.Click += new System.EventHandler(this.hizliCeviri_Click);
            this.hizliCeviri.MouseEnter += new System.EventHandler(this.hizliCeviri_MouseEnter);
            this.hizliCeviri.MouseLeave += new System.EventHandler(this.hizliCeviri_MouseLeave);
            // 
            // uygAc
            // 
            this.uygAc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.uygAc.Name = "uygAc";
            this.uygAc.Size = new System.Drawing.Size(167, 22);
            this.uygAc.Text = "Uygulamayı Aç";
            this.uygAc.Click += new System.EventHandler(this.uygAc_Click);
            this.uygAc.MouseEnter += new System.EventHandler(this.uygAc_MouseEnter);
            this.uygAc.MouseLeave += new System.EventHandler(this.uygAc_MouseLeave);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // uygKapat
            // 
            this.uygKapat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.uygKapat.Name = "uygKapat";
            this.uygKapat.ShortcutKeyDisplayString = "";
            this.uygKapat.Size = new System.Drawing.Size(167, 22);
            this.uygKapat.Text = "Kapat";
            this.uygKapat.Click += new System.EventHandler(this.uygKapat_Click);
            this.uygKapat.MouseEnter += new System.EventHandler(this.uygKapat_MouseEnter);
            this.uygKapat.MouseLeave += new System.EventHandler(this.uygKapat_MouseLeave);
            // 
            // bilgi
            // 
            this.bilgi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bilgi.Location = new System.Drawing.Point(-7, 229);
            this.bilgi.Name = "bilgi";
            this.bilgi.Size = new System.Drawing.Size(324, 39);
            this.bilgi.TabIndex = 7;
            this.bilgi.TabStop = false;
            // 
            // yapistir
            // 
            this.yapistir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.yapistir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.yapistir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yapistir.BackgroundImage")));
            this.yapistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yapistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yapistir.Location = new System.Drawing.Point(267, 32);
            this.yapistir.Name = "yapistir";
            this.yapistir.Size = new System.Drawing.Size(23, 26);
            this.yapistir.TabIndex = 6;
            this.blgi.SetToolTip(this.yapistir, "Metninizi yapıştırın (CTRL+V)");
            this.yapistir.UseVisualStyleBackColor = false;
            this.yapistir.Click += new System.EventHandler(this.yapistir_Click);
            // 
            // kopya
            // 
            this.kopya.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kopya.BackColor = System.Drawing.SystemColors.ControlLight;
            this.kopya.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kopya.BackgroundImage")));
            this.kopya.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kopya.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kopya.Location = new System.Drawing.Point(267, 175);
            this.kopya.Name = "kopya";
            this.kopya.Size = new System.Drawing.Size(23, 23);
            this.kopya.TabIndex = 5;
            this.blgi.SetToolTip(this.kopya, "Metninizi kopyalayın (CTRL+C)");
            this.kopya.UseVisualStyleBackColor = false;
            this.kopya.Click += new System.EventHandler(this.kopya_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(164, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeyDisplayString = "v1.2.0";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItem1.Text = "Kuş Dili Çevirici";
            // 
            // KusDilCeviri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(302, 268);
            this.Controls.Add(this.ayarlar_Btn);
            this.Controls.Add(this.bilgi_Label);
            this.Controls.Add(this.bilgi);
            this.Controls.Add(this.yapistir);
            this.Controls.Add(this.kopya);
            this.Controls.Add(this.CevirMod_harf);
            this.Controls.Add(this.CevirMod);
            this.Controls.Add(this.cevir);
            this.Controls.Add(this.ceviri);
            this.Controls.Add(this.cevrilen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(16, 307);
            this.Name = "KusDilCeviri";
            this.Text = "Kuş Dili Çevirici";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KusDilCeviri_FormClosing);
            this.Load += new System.EventHandler(this.KusDilCeviri_Load);
            this.SizeChanged += new System.EventHandler(this.KusDilCeviri_SizeChanged);
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bilgi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox cevrilen;
        private System.Windows.Forms.RichTextBox ceviri;
        private System.Windows.Forms.Button cevir;
        private System.Windows.Forms.ComboBox CevirMod;
        private System.Windows.Forms.ComboBox CevirMod_harf;
        private System.Windows.Forms.Button kopya;
        private System.Windows.Forms.Button yapistir;
        private System.Windows.Forms.PictureBox bilgi;
        private System.Windows.Forms.Label bilgi_Label;
        private System.Windows.Forms.Button ayarlar_Btn;
        private System.Windows.Forms.NotifyIcon kucukSimge;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem uygKapat;
        private System.Windows.Forms.ToolStripMenuItem uygAc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem hizliCeviri;
        private System.Windows.Forms.ToolTip blgi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

