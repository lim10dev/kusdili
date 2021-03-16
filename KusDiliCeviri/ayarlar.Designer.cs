
namespace KusDiliCeviri
{
    partial class ayarlar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ayarlar));
            this.hatirla = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tamam = new System.Windows.Forms.Button();
            this.kaynakkod = new System.Windows.Forms.LinkLabel();
            this.kapanma = new System.Windows.Forms.CheckBox();
            this.usttekal = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Bilgi = new System.Windows.Forms.ToolTip(this.components);
            this.enterCeviri = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hatirla
            // 
            this.hatirla.AutoSize = true;
            this.hatirla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hatirla.Location = new System.Drawing.Point(12, 109);
            this.hatirla.Name = "hatirla";
            this.hatirla.Size = new System.Drawing.Size(123, 17);
            this.hatirla.TabIndex = 0;
            this.hatirla.Text = "Seçeneklerimi hatırla";
            this.Bilgi.SetToolTip(this.hatirla, "Seçtiğiniz çeviri modu ve harfini sonraki gelişleriniz için kaydeder");
            this.hatirla.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(95, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kuş Dili Çevirici";
            // 
            // tamam
            // 
            this.tamam.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tamam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tamam.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tamam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tamam.Location = new System.Drawing.Point(174, 174);
            this.tamam.Name = "tamam";
            this.tamam.Size = new System.Drawing.Size(69, 45);
            this.tamam.TabIndex = 3;
            this.tamam.Text = "Tamam";
            this.tamam.UseVisualStyleBackColor = false;
            this.tamam.Click += new System.EventHandler(this.tamam_Click);
            // 
            // kaynakkod
            // 
            this.kaynakkod.AutoSize = true;
            this.kaynakkod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kaynakkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaynakkod.Location = new System.Drawing.Point(145, 45);
            this.kaynakkod.Name = "kaynakkod";
            this.kaynakkod.Size = new System.Drawing.Size(87, 16);
            this.kaynakkod.TabIndex = 4;
            this.kaynakkod.TabStop = true;
            this.kaynakkod.Text = "Kaynak Kodu";
            this.Bilgi.SetToolTip(this.kaynakkod, "github.com/lim10dev/kusdili");
            this.kaynakkod.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.kaynakkod_LinkClicked);
            this.kaynakkod.MouseEnter += new System.EventHandler(this.kaynakkod_MouseEnter);
            this.kaynakkod.MouseLeave += new System.EventHandler(this.kaynakkod_MouseLeave);
            // 
            // kapanma
            // 
            this.kapanma.AutoSize = true;
            this.kapanma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kapanma.Location = new System.Drawing.Point(12, 133);
            this.kapanma.Name = "kapanma";
            this.kapanma.Size = new System.Drawing.Size(217, 17);
            this.kapanma.TabIndex = 7;
            this.kapanma.Text = "Kapatmak yerine simge durumuna küçült";
            this.Bilgi.SetToolTip(this.kapanma, "Programı kapat tuşuna bastığınızda uygulama arkaplan işlemi şekline geçer.\r\nHızlı" +
        " çeviri özelliğini kullanmak istiyorsanız önerilir");
            this.kapanma.UseVisualStyleBackColor = true;
            // 
            // usttekal
            // 
            this.usttekal.AutoSize = true;
            this.usttekal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usttekal.Location = new System.Drawing.Point(12, 157);
            this.usttekal.Name = "usttekal";
            this.usttekal.Size = new System.Drawing.Size(120, 17);
            this.usttekal.TabIndex = 8;
            this.usttekal.Text = "Her zaman üstte kal";
            this.Bilgi.SetToolTip(this.usttekal, "Uygulama her zaman üstte kalır, bir programın arkasına geçemez");
            this.usttekal.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(100, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "v1.2.0";
            // 
            // enterCeviri
            // 
            this.enterCeviri.AutoSize = true;
            this.enterCeviri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterCeviri.Location = new System.Drawing.Point(12, 180);
            this.enterCeviri.Name = "enterCeviri";
            this.enterCeviri.Size = new System.Drawing.Size(131, 17);
            this.enterCeviri.TabIndex = 11;
            this.enterCeviri.Text = "Enter tuşu çeviri yapar";
            this.Bilgi.SetToolTip(this.enterCeviri, "Enter tuşuna bastığınızda satırbaşı yapmak yerine çeviri yapar (satırbaşı için Ct" +
        "rl+Enter)");
            this.enterCeviri.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KusDiliCeviri.Properties.Resources.kusDil_iconPNG;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Discord: LIM10#5919";
            // 
            // ayarlar
            // 
            this.AcceptButton = this.tamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(254, 231);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enterCeviri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.usttekal);
            this.Controls.Add(this.kapanma);
            this.Controls.Add(this.kaynakkod);
            this.Controls.Add(this.tamam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hatirla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(270, 270);
            this.MinimumSize = new System.Drawing.Size(270, 270);
            this.Name = "ayarlar";
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.ayarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox hatirla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tamam;
        private System.Windows.Forms.LinkLabel kaynakkod;
        private System.Windows.Forms.CheckBox kapanma;
        private System.Windows.Forms.CheckBox usttekal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip Bilgi;
        private System.Windows.Forms.CheckBox enterCeviri;
        private System.Windows.Forms.Label label2;
    }
}