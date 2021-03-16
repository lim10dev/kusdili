using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KusDiliCeviri
{
    public partial class KusDilCeviri : Form
    {
        public bool UygKapa;
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
            kucukSimge.Visible = false;
            this.KusDilCeviri_SizeChanged(null, null);
            if (Convert.ToBoolean(Properties.Settings.Default.ayarlar.Split(';')[5])) 
            {
                this.AcceptButton = cevir;
            } else
            {
                this.AcceptButton = null;
            }
            UygKapa = !Convert.ToBoolean(Properties.Settings.Default.ayarlar.Split(';')[1]);
            CevirMod.SelectedIndex = CevirMod_harf.SelectedIndex = 0;
            if (Convert.ToBoolean(Properties.Settings.Default.ayarlar.Split(';')[0]))
            // Eğer seçenekler hatırlanıyorsa
            {
                CevirMod_harf.SelectedIndex = Convert.ToInt32(Properties.Settings.Default.ayarlar.Split(';')[3]);
                CevirMod.SelectedIndex = Convert.ToInt32(Properties.Settings.Default.ayarlar.Split(';')[4]);
                if (CevirMod.SelectedIndex == -1 || CevirMod_harf.SelectedIndex == -1)
                {
                    CevirMod.SelectedIndex = CevirMod_harf.SelectedIndex = 0;
                }
            }

            cevir.Enabled = false;
            kopya.Enabled = false;

            this.TopMost = Convert.ToBoolean(Properties.Settings.Default.ayarlar.Split(';')[2]);
            // Her şeyi ayarlara göre ayarlar
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
            string[] gelecekHarf = { "g", "b", "c","f", "lf" };
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
                    if (sesli.Contains<char>(char.ToLower(cvrln[i]))) // Eğer harf sesliyse:
                    {
                        if (char.IsLower(cvrln[i])) // Eğer harf küçük harfse:
                        {
                            ceviri.Text += $"{cvrln[i]}{gelecekHarf[CevirMod_harf.SelectedIndex]}{cvrln[i]}";

                        } else // Eğer harf büyük harfse:

                        {   
                            try
                            {
                                if(char.IsLower(cvrln[i+1])) // AGAbigi gibi garip harf düzenleri olmasın diye kod
                                {
                                    ceviri.Text += $"{cvrln[i]}{gelecekHarf[CevirMod_harf.SelectedIndex]}{char.ToLower(cvrln[i])}";
                                } else
                                {
                                    ceviri.Text += $"{cvrln[i]}{gelecekHarf[CevirMod_harf.SelectedIndex].ToUpper()}{cvrln[i]}";
                                }
                            }
                            catch (Exception)
                            {
                                ceviri.Text += $"{cvrln[i]}{gelecekHarf[CevirMod_harf.SelectedIndex].ToUpper()}{cvrln[i]}";
                            }
                            
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
                        i += gelecekHarf[CevirMod_harf.SelectedIndex].Length + 1;
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
                cevrilen.SelectedText = Clipboard.GetText();
        }

        private void KusDilCeviri_SizeChanged(object sender, EventArgs e)
        {
            ceviri.Size = new Size(this.Size.Width - 66, ceviri.Size.Height);
            cevrilen.Size = new Size(this.Size.Width - 66, cevrilen.Size.Height);
            bilgi.Size = new Size(this.Size.Width, 39);
            this.MaximumSize = new Size(int.MaxValue, 307);
            // Boyut ayarlaması
        }

        private void ayarlar_Btn_Click(object sender, EventArgs e)
        {
            ayarlar dialog = new ayarlar();
            this.TopMost = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.TopMost = Convert.ToBoolean(Properties.Settings.Default.ayarlar.Split(';')[2]);
                Properties.Settings.Default.Save();
                UygKapa = !Convert.ToBoolean(Properties.Settings.Default.ayarlar.Split(';')[1]);
                if (Convert.ToBoolean(Properties.Settings.Default.ayarlar.Split(';')[5]))
                {
                    this.AcceptButton = cevir;
                } else
                {
                    this.AcceptButton = null;
                }
            }
            // Ayarları gösterir ve sonuca göre ayarlamaları yapar
        }

        private void KusDilCeviri_FormClosing(object sender, FormClosingEventArgs e)
        {
            string ayarTxt = "";
            for (int i = 0; i < 3; i++)
            {
                ayarTxt += Properties.Settings.Default.ayarlar.Split(';')[i] + ";";
            }
            ayarTxt += CevirMod_harf.SelectedIndex + ";" + CevirMod.SelectedIndex + ";" + Properties.Settings.Default.ayarlar.Split(';')[5];
            Properties.Settings.Default.ayarlar = ayarTxt;
            Properties.Settings.Default.Save();

            if (!UygKapa)
            {
                this.Hide();
                kucukSimge.Visible = true;
            }
            e.Cancel = !UygKapa;
            // Uygulama kapanırken gerçekleşir, kapatma ayarına göre uygulamaı gerçekten kapatır ya da simge durumuna küçültür

        }

        private void uygAc_Click(object sender, EventArgs e)
        {
            this.Show();
            kucukSimge.Visible = false;
        }

        private void uygKapat_Click(object sender, EventArgs e)
        {
            UygKapa = true;
            this.Close();
        }

        private void hizliCeviri_Click(object sender, EventArgs e)
        {
            HizliCeviri hzlcvr = new HizliCeviri();
            hzlcvr.Show();
        }

        private void kucukSimge_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                new HizliCeviri().Show();
            }
        }

        private void hizliCeviri_MouseEnter(object sender, EventArgs e)
        {
            hizliCeviri.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void uygAc_MouseEnter(object sender, EventArgs e)
        {
            uygAc.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void uygKapat_MouseEnter(object sender, EventArgs e)
        {
            uygKapat.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void hizliCeviri_MouseLeave(object sender, EventArgs e)
        {
            hizliCeviri.ForeColor = Color.FromArgb(192, 255, 192);
        }

        private void uygKapat_MouseLeave(object sender, EventArgs e)
        {
            uygKapat.ForeColor = Color.FromArgb(255, 192, 192);
        }

        private void uygAc_MouseLeave(object sender, EventArgs e)
        {
            uygAc.ForeColor = Color.FromArgb(192, 255, 192);
        }
    }
}
