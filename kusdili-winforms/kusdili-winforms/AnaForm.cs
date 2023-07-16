using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kusdili_winforms
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void çevirButton_Click(object sender, EventArgs e)
        {
            var çevrilen = çevrilenTextBox.Text;
            string sonuç;
            if (çeviriModuComboBox.SelectedIndex == 0)
            {
                sonuç = KuşDiliÇevirici.KuşDilineÇevir(çevrilen, harfComboBox.Text);
            }
            else
            {
                sonuç = KuşDiliÇevirici.KuşDilindenÇevir(çevrilen, harfComboBox.Text);
            }

            sonuçTextBox.Text = sonuç;
        }
    }
}
