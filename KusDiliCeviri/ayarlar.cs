using System;
using System.Drawing;
using System.Windows.Forms;

namespace KusDiliCeviri
{
    public partial class ayarlar : Form
    {
        // Ayarlar menüsü kodu


        public int harfIndex = 0;
        public int modIndex = 0;
        /*
         * 
         * Ayar 0 = Hatırla
         * Ayar 1 = Küçük simge
         * Ayar 2 = Her zaman üstte kal
         * Ayar 3-4 = Harf-Mod index
         * Ayar 5 = Enter tuşu çevirir
         * 
         */
        public ayarlar()
        {
            InitializeComponent();
        }

        void Link(string url, bool Onay = false) 
        {
            // linkleri kolaylaştırmak için
            if (Onay)
            {
                if(MessageBox.Show($"Bu sizi {url} adresine gönderecek. Devam etmek istiyor musunuz?", "Kuş Dili Çeviri", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(url);
                }
            }
            else
            {
                System.Diagnostics.Process.Start(url);
            }
        }

        private void ayarlar_Load(object sender, EventArgs e)
        {
            tamam.DialogResult = DialogResult.OK;
            // ayarları yaz
            hatirla.Checked = Convert.ToBoolean( Properties.Settings.Default.ayarlar.Split(';')[0] );
            kapanma.Checked = Convert.ToBoolean( Properties.Settings.Default.ayarlar.Split(';')[1] );
            usttekal.Checked = Convert.ToBoolean( Properties.Settings.Default.ayarlar.Split(';')[2] );
            harfIndex = Convert.ToInt32( Properties.Settings.Default.ayarlar.Split(';')[3] );
            modIndex = Convert.ToInt32( Properties.Settings.Default.ayarlar.Split(';')[4] );
            enterCeviri.Checked = Convert.ToBoolean(Properties.Settings.Default.ayarlar.Split(';')[5]) ;
        }

        private void tamam_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ayarlar = $"{hatirla.Checked};{kapanma.Checked};{usttekal.Checked};{harfIndex};{modIndex};{enterCeviri.Checked}";
            Properties.Settings.Default.Save();
        }

        private void kaynakkod_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Link("https://github.com/lim10dev/kusdili", true);
        }

        private void discordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Link("https://discord.com/invite/guchhN5wcn", true);
        }

        private void twitterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Link("https://twitter.com/lim10dev", true);
        }

        private void youtubeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Link("https://www.youtube.com/channel/UCT4eI71R1QwvstWb28Y8vxw/", true);
        }
    }
}
