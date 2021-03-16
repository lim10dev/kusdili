using System;
using System.Linq;
using System.Windows.Forms;

namespace KusDiliCeviri
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        
        const int SWVar = 5;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            // Bundan aşşşşağısı stackoverflow kodu https://stackoverflow.com/a/66585197/14033383
            var currentProcess = System.Diagnostics.Process.GetCurrentProcess();

            // search for another process with the same name
            var anotherProcess = System.Diagnostics.Process.GetProcesses().FirstOrDefault(p => p.ProcessName == currentProcess.ProcessName && p.Id != currentProcess.Id);

            if (anotherProcess != null)
            {
                if(!ShowWindow(anotherProcess.MainWindowHandle, SWVar))
                MessageBox.Show(text: "Kuş Dili Çeviricisi zaten çalışmakta.\nKapatmak yerine küçük simgeye dönüş ayarınız açıksa simgeleri kontrol edin.", "Hata", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);

                return; // don't continue to run your application.
            }
            Application.Run(new KusDilCeviri());
        }
    }
}
