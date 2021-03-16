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

        private void ayarlar_Load(object sender, EventArgs e)
        {
            tamam.DialogResult = DialogResult.OK;

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

        private void kaynakkod_MouseEnter(object sender, EventArgs e)
        {
            kaynakkod.Font = new Font(kaynakkod.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void kaynakkod_MouseLeave(object sender, EventArgs e)
        {
            kaynakkod.Font = new Font(kaynakkod.Font, FontStyle.Regular);
        }

        private void kaynakkod_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/lim10dev/kusdili");
        }
    }
}
