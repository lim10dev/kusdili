using System;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace KusDiliCeviri
{
    public partial class HizliCeviri : Form
    {
        public HizliCeviri()
        /// <summary>
        ///   Hızlı çeviriyi göster.
        /// </summary>
        {
            InitializeComponent();
        }

        private void HizliCeviri_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            otoKopya.Checked = Properties.Settings.Default.otoKopya;
            CevirMod.SelectedIndex = CevirMod_harf.SelectedIndex = 0;
            CevirMod_harf.SelectedIndex = Convert.ToInt32(Properties.Settings.Default.ayarlar.Split(';')[3]);
            CevirMod.SelectedIndex = Convert.ToInt32(Properties.Settings.Default.ayarlar.Split(';')[4]);
            if (CevirMod.SelectedIndex == -1 || CevirMod_harf.SelectedIndex == -1)
            {
                CevirMod.SelectedIndex = CevirMod_harf.SelectedIndex = 0;
            }
            kopya.Enabled = false;
            this.Location = new Point(900, 530);
        }

        private void cevir_Click(object sender, EventArgs e)
        {
            // kusdil.cs aynısı
            DateTime zaman = DateTime.Now;
            string crashPath = $"C:/users/{Environment.UserName}/AppData/Local/lim10dev/KusDili/crash-log/";
            string crashDosyaIsim = $"crash-log-{zaman.Year}{zaman.Month}{zaman.Day}{zaman.Hour}{zaman.Minute}{zaman.Second}.txt";
            string crashContents = $"[Uyarı] Kuş Dili Çeviricisi hızlı-çeviri yaparken çöktü.\n[Bilgi] Ayarlar: " +
                $"{Properties.Settings.Default.ayarlar}\n[Bilgi] Çevrilen metin uzunluğu: {cevrilen.Text.Length}";
            File.Create(crashPath + crashDosyaIsim).Close();
            File.WriteAllText(crashPath + crashDosyaIsim, crashContents);
            ceviri.Text = "";
            string cvrln = cevrilen.Text;
            char[] sesli = { 'a', 'â', 'à', 'ã', 'e', 'ê', 'è', 'Ə', 'i', 'î', 'ì', 'ı', 'u', 'ù', 'û', 'ü', 'o', 'ô', 'ò', 'õ', 'ö' };
            if (CevirMod.SelectedIndex == 0)
            {
                for (int i = 0; i < cvrln.Length; i++) 
                {
                    if (sesli.Contains<char>(cvrln[i].ToString().ToLower()[0]))
                    {
                        if (char.IsLower(cvrln[i]))
                        {
                            ceviri.Text += $"{cvrln[i]}{CevirMod_harf.SelectedItem}{cvrln[i]}";

                        }
                        else

                        {
                            try
                            {
                                if (char.IsLower(cvrln[i + 1]))
                                {
                                    ceviri.Text += $"{cvrln[i]}{CevirMod_harf.SelectedItem}{char.ToLower(cvrln[i])}";
                                }
                                else
                                {
                                    ceviri.Text += $"{cvrln[i]}{CevirMod_harf.SelectedItem.ToString().ToUpper()}{cvrln[i]}";
                                }
                            }
                            catch (Exception)
                            {
                                ceviri.Text += $"{cvrln[i]}{CevirMod_harf.SelectedItem.ToString().ToUpper()}{cvrln[i]}";
                            }
                        }

                    }
                    else
                    {
                        ceviri.Text += cvrln[i].ToString();
                    }
                }

            }
            else
            {
                for (int i = 0; i < cvrln.Length; i++)
                {
                    ceviri.Text += cvrln[i];
                    if (sesli.Contains<char>(cvrln[i].ToString().ToLower()[0]))
                    {
                        i += CevirMod_harf.SelectedItem.ToString().Length + 1;

                    }
                }
            }
            File.Delete(crashPath + crashDosyaIsim);
            kopya.Enabled = !string.IsNullOrEmpty(ceviri.Text);
            // Eğer çeviride hiç bir şey yoksa kopyala butonunu devre dışı bırakır.

            //BURASI OTOKOPYA İÇİN EKLENDİ, kusdil.cs İLE AYNI DEĞİL
            if (otoKopya.Checked) { Clipboard.SetText(ceviri.Text); }
        }

        private void kopya_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ceviri.Text); // Çeviriyi panoya kopyala
        }

        private void yapistir_Click(object sender, EventArgs e)
        {
            cevrilen.SelectedText = Clipboard.GetText();
        }

        private void otoKopya_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.otoKopya = otoKopya.Checked;
        }
    }
}
