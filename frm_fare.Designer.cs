namespace mousekayit
{
    partial class frm_mouse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mouse));
            this.mns_menu = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamanAyarlıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baslangicaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kısayollarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herZamanÜstteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkindaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.btn_oynat = new System.Windows.Forms.Button();
            this.nti_alt = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms_alt = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.acpencereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mns_menu.SuspendLayout();
            this.cms_alt.SuspendLayout();
            this.SuspendLayout();
            // 
            // mns_menu
            // 
            this.mns_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.hakkindaToolStripMenuItem});
            this.mns_menu.Location = new System.Drawing.Point(0, 0);
            this.mns_menu.Name = "mns_menu";
            this.mns_menu.Size = new System.Drawing.Size(331, 24);
            this.mns_menu.TabIndex = 0;
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.acToolStripMenuItem,
            this.kaydetToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.yeniToolStripMenuItem.Text = "Yeni";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);
            // 
            // acToolStripMenuItem
            // 
            this.acToolStripMenuItem.Name = "acToolStripMenuItem";
            this.acToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.acToolStripMenuItem.Text = "Aç";
            this.acToolStripMenuItem.Click += new System.EventHandler(this.acToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamanAyarlıToolStripMenuItem,
            this.baslangicaEkleToolStripMenuItem,
            this.kısayollarToolStripMenuItem,
            this.herZamanÜstteToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // zamanAyarlıToolStripMenuItem
            // 
            this.zamanAyarlıToolStripMenuItem.Name = "zamanAyarlıToolStripMenuItem";
            this.zamanAyarlıToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.zamanAyarlıToolStripMenuItem.Text = "Zaman Ayarlı";
            this.zamanAyarlıToolStripMenuItem.Click += new System.EventHandler(this.zamanAyarlıToolStripMenuItem_Click);
            // 
            // baslangicaEkleToolStripMenuItem
            // 
            this.baslangicaEkleToolStripMenuItem.Name = "baslangicaEkleToolStripMenuItem";
            this.baslangicaEkleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.baslangicaEkleToolStripMenuItem.Text = "Başlangıça Ekle";
            this.baslangicaEkleToolStripMenuItem.Click += new System.EventHandler(this.baslangicaEkleToolStripMenuItem_Click);
            // 
            // kısayollarToolStripMenuItem
            // 
            this.kısayollarToolStripMenuItem.Name = "kısayollarToolStripMenuItem";
            this.kısayollarToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.kısayollarToolStripMenuItem.Text = "Kısayollar";
            this.kısayollarToolStripMenuItem.Click += new System.EventHandler(this.kısayollarToolStripMenuItem_Click);
            // 
            // herZamanÜstteToolStripMenuItem
            // 
            this.herZamanÜstteToolStripMenuItem.Name = "herZamanÜstteToolStripMenuItem";
            this.herZamanÜstteToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.herZamanÜstteToolStripMenuItem.Text = "Her Zaman Üstte";
            this.herZamanÜstteToolStripMenuItem.Click += new System.EventHandler(this.herZamanÜstteToolStripMenuItem_Click);
            // 
            // hakkindaToolStripMenuItem
            // 
            this.hakkindaToolStripMenuItem.Name = "hakkindaToolStripMenuItem";
            this.hakkindaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hakkindaToolStripMenuItem.Text = "Hakkında";
            this.hakkindaToolStripMenuItem.Click += new System.EventHandler(this.hakkindaToolStripMenuItem_Click);
            // 
            // btn_kayit
            // 
            this.btn_kayit.BackColor = System.Drawing.Color.White;
            this.btn_kayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kayit.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn_kayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kayit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayit.ForeColor = System.Drawing.Color.Brown;
            this.btn_kayit.Location = new System.Drawing.Point(12, 42);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(97, 46);
            this.btn_kayit.TabIndex = 1;
            this.btn_kayit.Text = "● Kayıt";
            this.btn_kayit.UseVisualStyleBackColor = false;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // btn_oynat
            // 
            this.btn_oynat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_oynat.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn_oynat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_oynat.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_oynat.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_oynat.Location = new System.Drawing.Point(222, 42);
            this.btn_oynat.Name = "btn_oynat";
            this.btn_oynat.Size = new System.Drawing.Size(97, 46);
            this.btn_oynat.TabIndex = 2;
            this.btn_oynat.Text = "► Oynat";
            this.btn_oynat.UseVisualStyleBackColor = true;
            this.btn_oynat.Click += new System.EventHandler(this.btn_oynat_Click);
            // 
            // nti_alt
            // 
            this.nti_alt.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.nti_alt.BalloonTipTitle = "Bilgi";
            this.nti_alt.ContextMenuStrip = this.cms_alt;
            this.nti_alt.Icon = ((System.Drawing.Icon)(resources.GetObject("nti_alt.Icon")));
            this.nti_alt.Text = "Mouse Kayıt";
            // 
            // cms_alt
            // 
            this.cms_alt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acpencereToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.cms_alt.Name = "cms_alt";
            this.cms_alt.Size = new System.Drawing.Size(100, 48);
            // 
            // acpencereToolStripMenuItem
            // 
            this.acpencereToolStripMenuItem.Name = "acpencereToolStripMenuItem";
            this.acpencereToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.acpencereToolStripMenuItem.Text = "Aç";
            this.acpencereToolStripMenuItem.Click += new System.EventHandler(this.acpencereToolStripMenuItem_Click);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.cikisToolStripMenuItem.Text = "Çıkış";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click_1);
            // 
            // frm_mouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(331, 103);
            this.Controls.Add(this.btn_oynat);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.mns_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mns_menu;
            this.MaximizeBox = false;
            this.Name = "frm_mouse";
            this.Text = "Mouse Kayıt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_mouse_FormClosing);
            this.Resize += new System.EventHandler(this.frm_mouse_Resize);
            this.mns_menu.ResumeLayout(false);
            this.mns_menu.PerformLayout();
            this.cms_alt.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mns_menu;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.Button btn_oynat;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baslangicaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kısayollarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon nti_alt;
        private System.Windows.Forms.ContextMenuStrip cms_alt;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acpencereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herZamanÜstteToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem zamanAyarlıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkindaToolStripMenuItem;
    }
}

