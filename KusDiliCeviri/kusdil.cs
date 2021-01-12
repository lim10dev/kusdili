using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KusDiliCeviri
{
    public partial class KusDilCeviri : Form
    {
        public KusDilCeviri()
        {
            InitializeComponent();
        } // Program şeysisi

        //
        //
        //           KUŞ DİLİ NEDİR?
        //           ---------------
        //           Kuş dili bir şifreleme yöntemidir,
        //           Kuş Dilinde her bir sesli harften sonra bir sessiz harf (örn. g),
        //           ondan sonra yeniden o sesli harf gelir.
        //           
        //           Örnek olarak: "Selam" kelimesini ele alalım.
        //           S harfi sessizdir, o yüzden onu geçebiliriz.
        //           e harfi ise sesli olduğundan ilk önce e yazılır, ardından g harfi getirilir ve yeniden e gelir.
        //   
        //           Bu böyle devam ederek elimize en sonda "Segelagam" kelimesi geçer.
        //                  
        //         

        private void KusDilCeviri_Load(object sender, EventArgs e)
            // Uygulama başladığında
        {
            cevir.Enabled = false;
            CevirMod.SelectedIndex = 0;
            CevirMod_harf.SelectedIndex = 0;
            kopya.Enabled = false;
            // Her şeyi varsayılanlara ayarlar.
            /*
            if (string.IsNullOrEmpty(Clipboard.GetText()))
            {
                yapistir.Enabled = false;
            } // Çalışacağını düşündüğüm ama çalıştırmadan çalışmayacağına karar verdiğim kod.
            */
            ((ToolStripMenuItem)sot.DropDownItems[0]).Checked = Properties.Settings.Default.topmost;
            this.TopMost = ((ToolStripMenuItem)sot.DropDownItems[0]).Checked;

            // Programın hep üstte gözükmesini önceki seçeneğe göre açar ya da kapatır.

            ((ToolStripMenuItem)sot.DropDownItems[0]).Click += new EventHandler(sot_Click);
            ((ToolStripMenuItem)sot.DropDownItems[1]).Click += new EventHandler(hakkinda_Click);
            // Form ayarları olan MenuStrip ögesi için tıklama olayları hazırlar
        }

        private void cevrilen_TextChanged(object sender, EventArgs e)
            // Çevrilen metin değiştiğinde gerçekleşir.
        {
            cevir.Enabled = !string.IsNullOrEmpty(cevrilen.Text);
            // Eğer metinde hiç bir şey yoksa çevir butonunu devre dışı bırakır.
        }

        private void cevir_Click(object sender, EventArgs e)
            // Çevir butonuna tıklandığında gerçekleşir.
        {
            ceviri.Text = "";
            string cvrln = cevrilen.Text; // cvrln = çevrilecek metin.
            char[] sesli = { 'a', 'e', 'i', 'ı', 'u', 'ü', 'o', 'ö'  };
            /*
             CevirMod.SelectedIndex:
            0= Türkçe'den Kuş Dili'ne
            1= Kuş Dili'nden Türkçe'ye
             CevirMod_harf.SelectedIndex:
            0= g
            1= b
            2= c
            3= f
            4= lf
             
             */
            if (CevirMod.SelectedIndex == 0) // Eğer Türkçe'den Kuş Dili'ne çevirme modu açıksa:
            {
                for (int i = 0; i < cvrln.Length; i++) // Çevrilecek metnin uzunluğu kadar alttaki kodları yap.
                {
                    if (sesli.Contains<char>(cvrln[i].ToString().ToLower()[0])) // Eğer harf sesliyse:
                    {
                        if (char.IsLower(cvrln[i])) // Eğer harf küçük harfse:
                        {
                            ceviri.Text += $"{cvrln[i]}{CevirMod_harf.SelectedItem}{cvrln[i]}";

                        } else // Eğer harf büyük harfse:

                        {
                            ceviri.Text += $"{cvrln[i]}{CevirMod_harf.SelectedItem.ToString().ToUpper()}{cvrln[i]}";
                        }
                        // Çeviri'ye sesli harf + seçilen kuş dili modu harfi + sesli harf yazısını ekler.

                    } else // Eğer harf sessizse
                    {
                        ceviri.Text += cvrln[i].ToString(); // Çeviri'ye sessiz harfi ekler.
                    }
                }

            } else // Eğer Kuş Dili'nden Türkçe'ye Çevirme modu açıksa:
            {
                for (int i = 0; i < cvrln.Length; i++) // Çevrilecek yazının uzunluğu kere tekrarla:
                {
                    ceviri.Text += cvrln[i]; // Çeviri'nin yazısına çevrilenin i'nci harfini ekle
                    if (sesli.Contains<char>(cvrln[i].ToString().ToLower()[0])) // Eğer harf sesliyse:
                    {
                        i += CevirMod_harf.SelectedItem.ToString().Length + 1;
                        // Eğer harf sesliyse bu "aga" şeklinde yazılmış demektir.
                        // i'ye 1 + seçilen harfin uzunluğunu (hırsız dili için böyle bir şey var) ekleyerek "g" ve "a" harflerini geçer,
                        // bir else durumunun olmamasının nedeni eğer harf örn "g" olsaydı buna bir işlem yapması gerekmezdi.

                    }
                }
            }
            kopya.Enabled = !string.IsNullOrEmpty(ceviri.Text);
            // Eğer çeviride hiç bir şey yoksa kopyala butonunu devre dışı bırakır.
        }

        private void kopya_Click(object sender, EventArgs e)
            // Kopyalama butonuna basıldığında gerçekleşir
        {
            Clipboard.SetText(ceviri.Text); // Çeviriyi panoya kopyala
        }

        private void yapistir_Click(object sender, EventArgs e)
            // Yapıştır butonuna basıldığında gerçekleşir.
        {
            cevrilen.Text = Clipboard.GetText(); // Pano'dan yazıyı alır.
        }

        private void sot_Click(object sender, EventArgs e)
            // Form ayarları olan MenuStrip ögesine tıklanıldığında gerçekleşir.
        {
            Properties.Settings.Default.topmost = ((ToolStripMenuItem)sot.DropDownItems[0]).Checked;
            Properties.Settings.Default.Save();
            this.TopMost = ((ToolStripMenuItem)sot.DropDownItems[0]).Checked;
            // Formun hep üstte kalıp kalmayacağını ayarlar.
        }

        private void hakkinda_Click(object sender, EventArgs e)
            // Hakkında ögesine tıklanınca gerçekleşir.
        {
            MessageBox.Show("Kuş Dili Çeviricisi - BETA v1.0.0\nBu program itch.io'dan lim10dev tarafından yapılmıştır.", "Kuş Dili Çevirici - Hakkında", MessageBoxButtons.OK);
            // Hakkında bilgilerini gösterir.
        }

        private void KusDilCeviri_SizeChanged(object sender, EventArgs e)
        {
            ceviri.Size = new Size(this.Size.Width - 66, ceviri.Size.Height);
            cevrilen.Size = new Size(this.Size.Width - 66, cevrilen.Size.Height);
            this.MaximumSize = new Size(this.Size.Width + 500, 274);
        }
    }
}
