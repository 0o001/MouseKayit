using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace mousekayit
{
    public partial class frm_mouse : Form
    {
        [DllImport("user32.dll")]
        static extern ushort GetAsyncKeyState(int vKey);

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        const uint MOUSEEVENTF_ABSOLUTE = 0x8000;
        const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        const uint MOUSEEVENTF_LEFTUP = 0x0004;
        const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        const uint MOUSEEVENTF_MIDDLEUP = 0x0040;
        const uint MOUSEEVENTF_MOVE = 0x0001;
        const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        const uint MOUSEEVENTF_XDOWN = 0x0080;
        const uint MOUSEEVENTF_XUP = 0x0100;
        const uint MOUSEEVENTF_WHEEL = 0x0800;
        const uint MOUSEEVENTF_HWHEEL = 0x01000;

        Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run"); //Başlangıçta çalış kayıt yeri
        frm_zaman ac;
        Timer tmr_zaman;
        public frm_mouse()
        {
            InitializeComponent();
            ac = new frm_zaman();
            if (Properties.Settings.Default.zaman) //Eğer zaman ayarı varsa zaman kontrolünü aç
            {
                tmr_zaman = new Timer();
                tmr_zaman.Tick += new EventHandler(tmr_zaman_Tick);
                tmr_zaman.Start();
            }
            ac.StartPosition = FormStartPosition.CenterParent;
            this.btn_oynat.Enabled = false;

            if (key.GetValue("Mouse Kayıt.exe") != null) //Eğer exe başlangıçta kayıtlı ise
            {
                ((ToolStripMenuItem)baslangicaEkleToolStripMenuItem).Checked = true; //Toolstripmenuitemın yanına tik koy
            }
            if (Properties.Settings.Default.zaman) //Eğer zaman ayarı varsa
            {
                ((ToolStripMenuItem)zamanAyarlıToolStripMenuItem).Checked = true; //Toolstripmenuitemın yanına tik koy
            }
            Timer tmr_kisayol = new Timer();
            tmr_kisayol.Tick += new EventHandler(tmr_kisayol_Tick);
            tmr_kisayol.Start();
        }

        void tmr_zaman_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.saat != "")
            {
                if (DateTime.Now.ToLongTimeString() == DateTime.Parse(Properties.Settings.Default.saat).ToLongTimeString()) //Kayıtlı zaman ile şimdiki zaman aynıysa
                {
                    try
                    {
                        tmr_kayit.Stop();
                        tmr_oynat.Stop();
                    }
                    catch
                    {
                    }
                    try
                    {
                        System.IO.StreamReader oku = new System.IO.StreamReader(Properties.Settings.Default.dosya); //Oynatılacak dosyayı oku
                        string[] pozisyonlar = oku.ReadToEnd().Split('\n');
                        lst_x = new List<int>();
                        lst_y = new List<int>();
                        lst_mouse = new List<int>();
                        for (int i = 0; i < pozisyonlar.Length - 1; i++)
                        {
                            string[] xy = pozisyonlar[i].Split(',');
                            lst_x.Add(int.Parse(xy[0])); //x
                            lst_y.Add(int.Parse(xy[1])); //y
                            lst_mouse.Add(int.Parse(xy[2])); //tık
                        }
                        btn_oynat.Enabled = true;
                        oku.Close();
                        btn_oynat_Click(sender, e);
                    }
                    catch
                    {
                        MessageBox.Show("Mouse Kayıt Dosyası Açılamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    tmr_zaman.Stop();

                }
            }
        }
        void tmr_kisayol_Tick(object sender, EventArgs e)
        {
            if (BasildiMi(Keys.F3)) //F3 e basılırsa kayıtı başlat ya da durdur
            {
                if (btn_kayit.Enabled)
                {
                    btn_kayit_Click(sender, e);
                }
            }
            if (BasildiMi(Keys.F4)) //F4 e basılırsa kayıtı oynat ya da durdur
            {
                if (btn_oynat.Enabled)
                {
                    btn_oynat_Click(sender,e);
                }
            }
        }

        Timer tmr_kayit;
        Timer tmr_oynat;

        bool durdur = false;
        List<int> lst_x, lst_y, lst_mouse;
        private void btn_kayit_Click(object sender, EventArgs e)
        {
            nti_alt.Visible = true;
            if (durdur)
            {
                btn_kayit.Text = "● Kayıt";
                ((ToolStripMenuItem)mns_menu.Items[0]).Enabled = true;
                btn_oynat.Enabled = true;
                tmr_kayit.Stop();
                nti_alt.BalloonTipText = "Mouse Kaydı Bitti..."; //Kayıt bittiğine dair bilgi balonu
                nti_alt.ShowBalloonTip(200);
                durdur = false;
            }
            else
            {
                btn_kayit.Text = "■ Durdur";
                ((ToolStripMenuItem)mns_menu.Items[0]).Enabled = false;
                tmr_kayit = new Timer();
                lst_x = new List<int>();
                lst_y = new List<int>();
                lst_mouse = new List<int>();
                tmr_kayit.Start();
                tmr_kayit.Tick += new EventHandler(tmr_kayit_Tick);
                tmr_kayit.Interval = 10;
                nti_alt.Visible = true;
                nti_alt.BalloonTipText = "Mouse Kaydı Başladı..."; //Kayıt başladığına dair bilgi balonu
                nti_alt.ShowBalloonTip(1000);
                btn_oynat.Enabled = false;
                durdur = true;
            }
        }

        public static bool BasildiMi(System.Windows.Forms.Keys tus)
        {
            return 0 != (GetAsyncKeyState((int)tus) & 0x8000);
        }

        void tmr_kayit_Tick(object sender, EventArgs e)
        {
            
            lst_x.Add(MousePosition.X);
            lst_y.Add(MousePosition.Y);
            if (BasildiMi(Keys.LButton))
            {
                System.Threading.Thread.Sleep(100);
                lst_mouse.Add(1);
            }
            else if (BasildiMi(Keys.RButton))
            {
                System.Threading.Thread.Sleep(100);
                lst_mouse.Add(2);
            }
            else
                lst_mouse.Add(0);
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn_kayit = new OpenFileDialog();
            opn_kayit.Filter = "Mouse Kayıt Dosyası|*.mkd";

            if (DialogResult.OK == opn_kayit.ShowDialog())
            {
                try
                {
                    System.IO.StreamReader oku = new System.IO.StreamReader(opn_kayit.FileName);
                    string[] pozisyonlar = oku.ReadToEnd().Split('\n');
                    lst_x = new List<int>();
                    lst_y = new List<int>();
                    lst_mouse = new List<int>();
                    for (int i = 0; i < pozisyonlar.Length - 1; i++)
                    {
                        string[] xy = pozisyonlar[i].Split(',');
                        lst_x.Add(int.Parse(xy[0]));
                        lst_y.Add(int.Parse(xy[1]));
                        lst_mouse.Add(int.Parse(xy[2]));
                    }
                    btn_oynat.Enabled = true;
                    oku.Close();
                }
                catch
                {
                    MessageBox.Show("Mouse Kayıt Dosyası Açılamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Application.ExecutablePath);
            }
            catch
            {
                MessageBox.Show("Yeni Mouse Kayıt Dosyası Açılamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_oynat_Click(object sender, EventArgs e)
        {
            btn_kayit.Enabled = false;
            btn_oynat.Enabled = false;
            tmr_oynat = new Timer();
            tmr_oynat.Interval = 10;
            tmr_oynat.Start();
            nti_alt.BalloonTipText = "Mouse Kaydı Oynatılıyor..."; //Kayıt oynatma başladığına dair bilgi balonu
            nti_alt.Visible = true;
            nti_alt.ShowBalloonTip(100);
            tmr_oynat.Tick += new EventHandler(tmr_oynat_Tick);
        }
        int oynat;
        void tmr_oynat_Tick(object sender, EventArgs e)
        {
            try
            {
                Cursor.Position = new Point(lst_x[oynat], lst_y[oynat]);

                if (lst_mouse[oynat] == 1) //Eğer okunan tık değeri 1 ise
                {
                    mouse_event(MOUSEEVENTF_LEFTUP | MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0); //Sol tık
                }

                else if (lst_mouse[oynat] == 2) //Eğer okunan tık değeri 2 ise
                {
                    mouse_event(MOUSEEVENTF_RIGHTUP | MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0); //Sağ tık
                }

                oynat++;
            }
            catch
            {
                oynat = 0;
                btn_kayit.Enabled = true;
                btn_oynat.Enabled = true;
                nti_alt.BalloonTipText = "Mouse Kaydı Oynatımı Bitti"; //Kayıt oynatma bittiğine dair bilgi balonu
                nti_alt.ShowBalloonTip(100);
                tmr_oynat.Stop();
            }
          
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Mouse Kayıt Dosyası|*.mkd";

            if (DialogResult.OK == sfd.ShowDialog())
            {
                try
                {
                    System.IO.StreamWriter kaydet = new System.IO.StreamWriter(sfd.FileName);
                    for (int i = 0; i < lst_x.Count; i++)
                    {
                        kaydet.WriteLine(lst_x[i] + "," + lst_y[i] + "," + lst_mouse[i]); //x,y,tık
                    }
                    kaydet.Close();
                    MessageBox.Show("Mouse Kayıt Dosyası Kaydedildi", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
                catch
                {
                    MessageBox.Show("Mouse Kayıt Dosyası Kaydedilemedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void frm_mouse_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) //Form kapatılırsa
            {
                e.Cancel = true;
                this.Hide();
                nti_alt.Visible = true;
                nti_alt.BalloonTipText = "Uygulama Çalışıyor..."; //Uygulamanın hala çalıştığına dair bilgi balonu
                nti_alt.ShowBalloonTip(1000);
            }
        }

        private void cikisToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult kapat = MessageBox.Show("Mouse Kayıt Programını Kapatmak İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (kapat == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frm_mouse_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                nti_alt.Visible = true;
            }
        }

        private void acpencereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nti_alt.Visible = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void herZamanÜstteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem)sender).Checked == true)
            {
                this.TopMost = false;
                ((ToolStripMenuItem)sender).Checked = false;
            }
            else
            {
                this.TopMost = true;
                ((ToolStripMenuItem)sender).Checked = true;
            }
        }

        private void zamanAyarlıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tmr_zaman.Start();
            }
            catch { }
            ac.ShowDialog();
        }

        string programdata = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Mouse Kayıt.exe"; //Programdata kayıt yeri
        private void baslangicaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem)sender).Checked == true)
            {
              DialogResult emin = MessageBox.Show("Mouse Kayıt Programını Başlangıçtan Kaldırmak İstediğinize Emin Misiniz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk);
              if (emin == DialogResult.Yes)
              {
                  key.DeleteValue("Mouse Kayıt.exe");
                  ((ToolStripMenuItem)sender).Checked = false;
              }
            }
            else
            {
                if (!System.IO.File.Exists(programdata))
                {
                    System.IO.File.Copy(Application.ExecutablePath.ToString(), programdata); //Programı programdataya kopyala
                }
                key.SetValue("Mouse Kayıt.exe", programdata);
                ((ToolStripMenuItem)sender).Checked = true;
            }
        }

        private void kısayollarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt/Durdur F3\nOynat F4", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void hakkindaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxManager.OK = "&Siteye Git...";
            MessageBoxManager.Cancel = "&Tamam";
            MessageBoxManager.Register();
            DialogResult git = MessageBox.Show("Bu program nullovy tarafından yapılmıştır.\nDestek almak ya da görüşlerinizi bildirmek için www.nullovy.com sitesine gidebilirsiniz.", "Hakkında", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            MessageBoxManager.Unregister();
            if (git == System.Windows.Forms.DialogResult.OK)
            {
                System.Diagnostics.Process.Start("http://www.nullovy.com");
            }
        }
    }
}
