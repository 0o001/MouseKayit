using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mousekayit
{
    public partial class frm_zaman : Form
    {
        public frm_zaman()
        {
            InitializeComponent();
            if (Properties.Settings.Default.zaman) //Eğer zaman ayarı varsa
            {
                chk_zaman.Checked = true;
                lbl_dosya.Text = Properties.Settings.Default.dosya;
            }
        }
        
        private void btn_dosya_Click(object sender, EventArgs e)
        {
            OpenFileDialog ac = new OpenFileDialog();
            if (DialogResult.OK == ac.ShowDialog())
            {
                lbl_dosya.Text = ac.FileName;
                Properties.Settings.Default.dosya = ac.FileName; //Dosya yerini kaydet
                Properties.Settings.Default.Save();
            }
        }

        private void chk_zaman_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_zaman.Checked)
            {
                foreach (Control item in this.Controls)
                {
                    if (item.Name != "chk_zaman")
                        item.Enabled = false;
                }
               Properties.Settings.Default.zaman = true;
            }
            else
            {
                foreach (Control item in this.Controls)
                {
                    if (item.Name != "chk_zaman")
                        item.Enabled = true;
                }
                Properties.Settings.Default.zaman = false;
            }
            Properties.Settings.Default.Save();
        }

        private void btn_sifirla_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.zaman = false;
            Properties.Settings.Default.dosya = "";
            nud_saat.Value = DateTime.Now.Hour;
            nud_dakika.Value = DateTime.Now.Minute;
            nud_saniye.Value = DateTime.Now.Second;
            lbl_dosya.Text = "dosya";
            Properties.Settings.Default.saat = "";
            Properties.Settings.Default.Save();
        }

        private void frm_zaman_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.zaman == false) //Eğer zaman ayarı yoksa
            {
                nud_saat.Value = DateTime.Now.Hour;
                nud_dakika.Value = DateTime.Now.Minute;
                nud_saniye.Value = DateTime.Now.Second;
            }
            else //Zaman ayarı varsa kayıtlı zamanı göster
            {
                string[] saat = Properties.Settings.Default.saat.Split(':');
                nud_saat.Value = int.Parse(saat[0]);
                nud_dakika.Value = int.Parse(saat[1]);
                nud_saniye.Value = int.Parse(saat[2]);
            }
        }

        private void nud_saat_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.saat = nud_saat.Value + ":" + nud_dakika.Value + ":" + nud_saniye.Value;
        }
    }
}
