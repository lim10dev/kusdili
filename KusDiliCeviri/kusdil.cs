using System;
using System.Drawing;
using System.IO;
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
            // Program Şeysisi
            cevrilen.DragEnter += this.KusDilCeviri_DragEnter;
            cevrilen.DragLeave += this.KusDilCeviri_DragLeave;
            cevrilen.DragDrop += this.KusDilCeviri_DragDrop;
            // Çevrilen için sürükle-bırak özelliği
        }

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
            if (Properties.Settings.Default.crashOlduMu == true)
            {
                MessageBox.Show($"Kuş Dili Çeviricisi düzgün olarak kapatılmamış veya çökmüş. Daha detaylı bilgi için şu klasöre bakın:\nC:/users/{Environment.UserName}/AppData/Local/lim10dev/KusDili/crash-log\nLütfen bunu lim10dev'e bildirin (Ayarlar). Çok uzun yazıların programı zorladığını unutmayın.",
                    "Kuş Dili Çeviri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } // Uygulama en son doğru bir şekilde kapanmadıysa mesajla uyarır
            Properties.Settings.Default.crashOlduMu = true;
            Properties.Settings.Default.Save();
            // uygulamın çöküp çökmediğini anlamak için garip ama çalışan bir yol
            Directory.CreateDirectory($"C:/users/{Environment.UserName}/AppData/Local/lim10dev/KusDili/crash-log"); // çöküş raporlarımsısı?
            uygAc.Enabled = false; // Küçük simgedeki uyg aç butonu
            this.KusDilCeviri_SizeChanged(null, null); // Uygulamanın görünümünü tam olarak ayarlamak için
            if (Convert.ToBoolean(Properties.Settings.Default.ayarlar.Split(';')[5])) // Eğer enter tuşu çeviri yapıyorsa
            {
                this.AcceptButton = cevir;
            }
            else
            {
                this.AcceptButton = null;
            }
            UygKapa = !Convert.ToBoolean(Properties.Settings.Default.ayarlar.Split(';')[1]); // X butonuna tıklandığında uyg kapancak mı kapanmicak mı o ayarı ayarlıyor
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
            // seçenekleri yap ya da öyle bişi idk 
            cevir.Enabled = false;
            this.TopMost = Convert.ToBoolean(Properties.Settings.Default.ayarlar.Split(';')[2]);
            // Her şeyi ayarlara göre ayarlar
            if (Environment.GetCommandLineArgs().Length > 1)
            // Eğer bir kuş dili bir dosya ile açıldıysa
            {
                if (File.Exists(Environment.GetCommandLineArgs()[1]))
                {
                    string dosya = File.ReadAllText(Environment.GetCommandLineArgs()[1]);
                    if (dosya.Length < 1501)
                    {
                        cevrilen.Text = dosya;
                        cevrilen.SelectionStart = cevrilen.Text.Length;
                    }
                    else
                    {
                        MessageBox.Show("Dosyanızda 1500'den fazla karakter var", "Kuş Dili Çevirici", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
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
            // crash log için kodlar
            DateTime zaman = DateTime.Now;
            string crashPath = $"C:/users/{Environment.UserName}/AppData/Local/lim10dev/KusDili/crash-log/";
            string crashDosyaIsim = $"crash-log-{zaman.Year}{zaman.Month}{zaman.Day}{zaman.Hour}{zaman.Minute}{zaman.Second}.txt";
            string crashContents = $"[Uyarı] Kuş Dili Çeviricisi çeviri yaparken çöktü.\n[Bilgi] Ayarlar: " +
                $"{Properties.Settings.Default.ayarlar}\n[Bilgi] Çevrilen metin uzunluğu: {cevrilen.Text.Length}";
            File.Create(crashPath + crashDosyaIsim).Close();
            File.WriteAllText(crashPath + crashDosyaIsim, crashContents);
            // normal çeviri
            ceviri.Text = "";
            string cvrln = cevrilen.Text; // cvrln = çevrilecek metin.
            char[] sesli = { 'a', 'â', 'à', 'ã', 'e', 'ê', 'è', 'Ə', 'i', 'î', 'ì', 'ı', 'u', 'ù', 'û', 'ü', 'o', 'ô', 'ò', 'õ', 'ö' };
            string[] gelecekHarf = { "g", "b", "c", "f", "lf" };
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

                        }
                        else // Eğer harf büyük harfse:

                        {
                            try
                            {
                                if (char.IsLower(cvrln[i + 1])) // AGAbigi gibi garip harf düzenleri olmasın diye kod
                                {
                                    ceviri.Text += $"{cvrln[i]}{gelecekHarf[CevirMod_harf.SelectedIndex]}{char.ToLower(cvrln[i])}";
                                }
                                else
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

                    }
                    else // Eğer harf sessizse
                    {
                        ceviri.Text += cvrln[i].ToString(); // Çeviri'ye sessiz harfi ekler.
                    }
                }

            }
            else // Eğer Kuş Dili'nden Türkçe'ye Çevirme modu açıksa:
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
            File.Delete(crashPath + crashDosyaIsim);
            // eğer çökme olsaydı bu dosya silinemezdi, çökme yoks dosyayı siler ve kimsenin haberi olmaz
        }

        private void KusDilCeviri_SizeChanged(object sender, EventArgs e)
        {
            ceviri.Size = new Size(this.Size.Width - 45, ceviri.Size.Height);
            cevrilen.Size = new Size(this.Size.Width - 45, cevrilen.Size.Height);
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
                }
                else
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
                uygAc.Enabled = true;
            }
            else
            {
                // uygulama cidden kapanıyorsa crash olmamış demektir böylece de bunu false yapar
                Properties.Settings.Default.crashOlduMu = false;
                Properties.Settings.Default.Save();
            }
            e.Cancel = !UygKapa;
            // Uygulama kapanırken gerçekleşir, kapatma ayarına göre uygulamayı gerçekten kapatır ya da simge durumuna küçültür

        }

        private void uygAc_Click(object sender, EventArgs e)
        {
            this.Show();
            uygAc.Enabled = false;
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
            if (e.Button == MouseButtons.Left)
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

        private void KusDilCeviri_DragEnter(object sender, DragEventArgs e)
        {
            // sürükle bırak işlemi için fare forma geldiiinde
            bilgi_Label.Text = "Dosyanızı buraya bırakın...";
            e.Effect = DragDropEffects.Copy;
        }

        private void KusDilCeviri_DragLeave(object sender, EventArgs e)
        {
            // sürükle bırak işlemi için fare formdan geri gittiiinde
            bilgi_Label.Text = "lim10dev'den Kuş Dili Çevirici";
        }

        private void KusDilCeviri_DragDrop(object sender, DragEventArgs e)
        {
            // sürükle bırak gerçekleşip bittiğinde sanırım
            DateTime zaman = DateTime.Now; // crash log hazırla 
            string crashPath = $"C:/users/{Environment.UserName}/AppData/Local/lim10dev/KusDili/crash-log/";
            string crashDosyaIsim = $"crash-log-{zaman.Year}{zaman.Month}{zaman.Day}{zaman.Hour}{zaman.Minute}{zaman.Second}.txt";
            File.Create(crashPath + crashDosyaIsim).Close();
            bilgi_Label.Text = "lim10dev'den Kuş Dili Çevirici";
            try
            {
                // bırakılan dosyanın bilgilerini al
                var birakilanlar = e.Data.GetData(DataFormats.FileDrop);
                var dosyalar = birakilanlar as string[];

                if (birakilanlar != null && dosyalar.Length == 1)
                {
                    string dosyaMetni = string.Join("\n", File.ReadAllLines(dosyalar[0]));
                    if (dosyaMetni.Length < 1501)
                    {
                        cevrilen.Text = dosyaMetni;
                        string crashContents = $"[Uyarı] Kuş Dili Çeviricisi bir sürükle-bırak işlemi yaparken çöktü.\n[Bilgi] Ayarlar: " +
                        $"{Properties.Settings.Default.ayarlar}\n[Bilgi] Çevrilen metin uzunluğu: {dosyaMetni.Length}";

                        File.WriteAllText(crashPath + crashDosyaIsim, crashContents);
                        cevrilen.SelectionStart = cevrilen.Text.Length;
                    }
                    else
                    {
                        MessageBox.Show("Dosyanızda 1500'den fazla karakter var", "Kuş Dili Çevirici", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    File.Delete(crashPath + crashDosyaIsim);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dosyanın okunmasında bir sorunla karşılaşıldı.", "Kuş Dili Çevirici", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void kopyala_Click(object sender, EventArgs e)
        {
            if (cevrilen.SelectedText == string.Empty)
            {
                Clipboard.SetText(cevrilen.Text);
            }
            else
            {
                Clipboard.SetText(cevrilen.SelectedText);
            }
        }

        private void yapistir_Click(object sender, EventArgs e)
        {
            cevrilen.SelectedText = Clipboard.GetText();
        }

        private void ceviriKopyala_Click(object sender, EventArgs e)
        {
            if (ceviri.SelectedText == string.Empty)
            {
                Clipboard.SetText(ceviri.Text);
            }
            else
            {
                Clipboard.SetText(ceviri.SelectedText);
            }
        }

        private void ceviriIndir_Click(object sender, EventArgs e)
        {
            if (ceviriKaydet.ShowDialog() == DialogResult.OK)
            {
                File.Create(ceviriKaydet.FileName).Close();
                File.WriteAllText(ceviriKaydet.FileName, ceviri.Text);
                // ceviriyi kaydet
            }
        }

        private void ceviriKopyalaIndir_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ceviriIndir.Enabled = ceviriKopyala.Enabled = ceviri.Text != string.Empty; // Eğer çeviri boşsa indirme veya kopyalama çünkü hata veriyor
        }

        private void cevrilenKopyalaYapistir_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            kopyala.Enabled = cevrilen.Text != string.Empty; // çevrilen boşsa kopyalayı devre dışı bırakır
        }
    }
}
