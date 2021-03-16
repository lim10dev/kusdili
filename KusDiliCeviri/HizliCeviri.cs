using System;
using System.Drawing;
using System.Linq;
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
            CevirMod.SelectedIndex = CevirMod_harf.SelectedIndex = 0;
            kopya.Enabled = false;
            this.Location = new Point(881, 546);
        }

        private void cevir_Click(object sender, EventArgs e)
        {
            // kusdil.cs aynısı
            ceviri.Text = "";
            string cvrln = cevrilen.Text;
            char[] sesli = { 'a', 'e', 'i', 'ı', 'u', 'ü', 'o', 'ö' };
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
            kopya.Enabled = !string.IsNullOrEmpty(ceviri.Text);
            // Eğer çeviride hiç bir şey yoksa kopyala butonunu devre dışı bırakır.
        }

        private void kopya_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ceviri.Text); // Çeviriyi panoya kopyala
        }

        private void yapistir_Click(object sender, EventArgs e)
        {
            cevrilen.SelectedText = Clipboard.GetText();
        }
    }
}
