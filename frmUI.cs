using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace AutoScreenshot
{
    public partial class frmUI : Form
    {
        #region Imported DLLs

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int degistrici, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        #endregion

        public frmUI()
        {
            InitializeComponent();
            int id = 0;
            RegisterHotKey(this.Handle, id, 0, Keys.F9.GetHashCode());
            ekranGoruntusuAl.Click += ekranGoruntusuAl_Click;
            Cik.Click += cikis_Click;
        }

        private void ekranGoruntusuAl_Click(object sender, EventArgs e)
        {
            Message message = new Message
            {
                Msg = 0x0312
            };
            WndProc(ref message);
        }
        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                SendKeys.SendWait("^{PRTSC}");

                string yol = Path.GetPathRoot(Environment.SystemDirectory) + "users\\" + Environment.UserName + "\\Pictures\\Saved\\PrintScreenData_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".jpg";
                if (!Directory.Exists(Path.GetPathRoot(Environment.SystemDirectory) + "users\\" + Environment.UserName + "\\Pictures\\Saved"))
                {

                    Directory.CreateDirectory(Path.GetPathRoot(Environment.SystemDirectory) + "users\\" + Environment.UserName + "\\Pictures\\Saved");
                    if (Clipboard.ContainsImage())
                    {
                        Clipboard.GetImage().Save(yol, ImageFormat.Jpeg);
                    }
                    if (File.Exists(yol))
                    {
                        ntfSystemTray.ShowBalloonTip(2000, "Kaydetme başarılı", "Dosya: " + yol, ToolTipIcon.Info);
                    }
                }
                else
                {
                    if (Clipboard.ContainsImage())
                    {
                        Clipboard.GetImage().Save(yol, ImageFormat.Jpeg);

                    }
                    if (File.Exists(yol))
                    {
                        ntfSystemTray.ShowBalloonTip(2000, "Kaydetme başarılı", "Dosya: " + yol, ToolTipIcon.Info);
                    }

                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 0);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            ntfSystemTray.ShowBalloonTip(3000, "Program başladı.", "Artık Klavyenizden F9'u tuşlatarak ekran görüntüsü alabilirsiniz.", ToolTipIcon.Info);
        }



    }
}
