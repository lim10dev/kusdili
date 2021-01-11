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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KusDilCeviri));
            this.cevrilen = new System.Windows.Forms.RichTextBox();
            this.ceviri = new System.Windows.Forms.RichTextBox();
            this.cevir = new System.Windows.Forms.Button();
            this.CevirMod = new System.Windows.Forms.ComboBox();
            this.CevirMod_harf = new System.Windows.Forms.ComboBox();
            this.kopya = new System.Windows.Forms.Button();
            this.yapistir = new System.Windows.Forms.Button();
            this.usttekal = new System.Windows.Forms.MenuStrip();
            this.sot = new System.Windows.Forms.ToolStripMenuItem();
            this.herZamanÜstteKalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.usttekal.SuspendLayout();
            this.SuspendLayout();
            // 
            // cevrilen
            // 
            this.cevrilen.Location = new System.Drawing.Point(12, 27);
            this.cevrilen.Name = "cevrilen";
            this.cevrilen.Size = new System.Drawing.Size(249, 57);
            this.cevrilen.TabIndex = 0;
            this.cevrilen.Text = "";
            this.cevrilen.TextChanged += new System.EventHandler(this.cevrilen_TextChanged);
            // 
            // ceviri
            // 
            this.ceviri.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ceviri.Location = new System.Drawing.Point(12, 148);
            this.ceviri.Name = "ceviri";
            this.ceviri.ReadOnly = true;
            this.ceviri.Size = new System.Drawing.Size(249, 75);
            this.ceviri.TabIndex = 2;
            this.ceviri.Text = "";
            // 
            // cevir
            // 
            this.cevir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cevir.Location = new System.Drawing.Point(12, 90);
            this.cevir.Name = "cevir";
            this.cevir.Size = new System.Drawing.Size(75, 52);
            this.cevir.TabIndex = 1;
            this.cevir.Text = "Çevir";
            this.cevir.UseVisualStyleBackColor = true;
            this.cevir.Click += new System.EventHandler(this.cevir_Click);
            // 
            // CevirMod
            // 
            this.CevirMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CevirMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CevirMod.FormattingEnabled = true;
            this.CevirMod.Items.AddRange(new object[] {
            "Türkçe\'den Kuş Dili\'ne",
            "Kuş Dili\'nden Türkçe\'ye"});
            this.CevirMod.Location = new System.Drawing.Point(94, 94);
            this.CevirMod.Name = "CevirMod";
            this.CevirMod.Size = new System.Drawing.Size(148, 21);
            this.CevirMod.TabIndex = 3;
            // 
            // CevirMod_harf
            // 
            this.CevirMod_harf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CevirMod_harf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CevirMod_harf.FormattingEnabled = true;
            this.CevirMod_harf.Items.AddRange(new object[] {
            "g",
            "b",
            "c",
            "f",
            "lf"});
            this.CevirMod_harf.Location = new System.Drawing.Point(93, 121);
            this.CevirMod_harf.Name = "CevirMod_harf";
            this.CevirMod_harf.Size = new System.Drawing.Size(53, 21);
            this.CevirMod_harf.TabIndex = 4;
            // 
            // kopya
            // 
            this.kopya.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kopya.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kopya.BackgroundImage")));
            this.kopya.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kopya.Location = new System.Drawing.Point(269, 176);
            this.kopya.Name = "kopya";
            this.kopya.Size = new System.Drawing.Size(23, 23);
            this.kopya.TabIndex = 5;
            this.kopya.UseVisualStyleBackColor = true;
            this.kopya.Click += new System.EventHandler(this.kopya_Click);
            // 
            // yapistir
            // 
            this.yapistir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.yapistir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yapistir.BackgroundImage")));
            this.yapistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yapistir.Location = new System.Drawing.Point(269, 47);
            this.yapistir.Name = "yapistir";
            this.yapistir.Size = new System.Drawing.Size(23, 23);
            this.yapistir.TabIndex = 6;
            this.yapistir.UseVisualStyleBackColor = true;
            this.yapistir.Click += new System.EventHandler(this.yapistir_Click);
            // 
            // usttekal
            // 
            this.usttekal.BackColor = System.Drawing.Color.Gray;
            this.usttekal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sot});
            this.usttekal.Location = new System.Drawing.Point(0, 0);
            this.usttekal.Name = "usttekal";
            this.usttekal.Size = new System.Drawing.Size(302, 24);
            this.usttekal.TabIndex = 7;
            this.usttekal.Text = "Görünüm";
            // 
            // sot
            // 
            this.sot.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.herZamanÜstteKalToolStripMenuItem,
            this.hakkinda});
            this.sot.ForeColor = System.Drawing.SystemColors.Info;
            this.sot.Name = "sot";
            this.sot.Size = new System.Drawing.Size(56, 20);
            this.sot.Text = "Ayarlar";
            // 
            // herZamanÜstteKalToolStripMenuItem
            // 
            this.herZamanÜstteKalToolStripMenuItem.CheckOnClick = true;
            this.herZamanÜstteKalToolStripMenuItem.Name = "herZamanÜstteKalToolStripMenuItem";
            this.herZamanÜstteKalToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.herZamanÜstteKalToolStripMenuItem.Text = "Her zaman üstte kal";
            // 
            // hakkinda
            // 
            this.hakkinda.Name = "hakkinda";
            this.hakkinda.Size = new System.Drawing.Size(178, 22);
            this.hakkinda.Text = "Hakkında";
            // 
            // KusDilCeviri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(302, 235);
            this.Controls.Add(this.yapistir);
            this.Controls.Add(this.kopya);
            this.Controls.Add(this.CevirMod_harf);
            this.Controls.Add(this.CevirMod);
            this.Controls.Add(this.cevir);
            this.Controls.Add(this.ceviri);
            this.Controls.Add(this.cevrilen);
            this.Controls.Add(this.usttekal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.usttekal;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(0, 274);
            this.Name = "KusDilCeviri";
            this.Text = "Beta - Kuş Dili Çevirici";
            this.Load += new System.EventHandler(this.KusDilCeviri_Load);
            this.SizeChanged += new System.EventHandler(this.KusDilCeviri_SizeChanged);
            this.usttekal.ResumeLayout(false);
            this.usttekal.PerformLayout();
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
        private System.Windows.Forms.MenuStrip usttekal;
        private System.Windows.Forms.ToolStripMenuItem sot;
        private System.Windows.Forms.ToolStripMenuItem herZamanÜstteKalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkinda;
    }
}

