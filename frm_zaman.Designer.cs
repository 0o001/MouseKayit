namespace mousekayit
{
    partial class frm_zaman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_zaman));
            this.chk_zaman = new System.Windows.Forms.CheckBox();
            this.btn_dosya = new System.Windows.Forms.Button();
            this.lbl_dosya = new System.Windows.Forms.Label();
            this.btn_sifirla = new System.Windows.Forms.Button();
            this.nud_saat = new System.Windows.Forms.NumericUpDown();
            this.nud_dakika = new System.Windows.Forms.NumericUpDown();
            this.nud_saniye = new System.Windows.Forms.NumericUpDown();
            this.lbl_ikinokta = new System.Windows.Forms.Label();
            this.lbl_ikinokta2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_saat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dakika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_saniye)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_zaman
            // 
            this.chk_zaman.AutoSize = true;
            this.chk_zaman.Location = new System.Drawing.Point(12, 12);
            this.chk_zaman.Name = "chk_zaman";
            this.chk_zaman.Size = new System.Drawing.Size(85, 17);
            this.chk_zaman.TabIndex = 0;
            this.chk_zaman.Text = "Zaman Ayarı";
            this.chk_zaman.UseVisualStyleBackColor = true;
            this.chk_zaman.CheckedChanged += new System.EventHandler(this.chk_zaman_CheckedChanged);
            // 
            // btn_dosya
            // 
            this.btn_dosya.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_dosya.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dosya.FlatAppearance.BorderSize = 0;
            this.btn_dosya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dosya.ForeColor = System.Drawing.Color.White;
            this.btn_dosya.Location = new System.Drawing.Point(176, 48);
            this.btn_dosya.Name = "btn_dosya";
            this.btn_dosya.Size = new System.Drawing.Size(75, 23);
            this.btn_dosya.TabIndex = 1;
            this.btn_dosya.Text = "Aç";
            this.btn_dosya.UseVisualStyleBackColor = false;
            this.btn_dosya.Click += new System.EventHandler(this.btn_dosya_Click);
            // 
            // lbl_dosya
            // 
            this.lbl_dosya.Location = new System.Drawing.Point(9, 53);
            this.lbl_dosya.Name = "lbl_dosya";
            this.lbl_dosya.Size = new System.Drawing.Size(161, 18);
            this.lbl_dosya.TabIndex = 2;
            this.lbl_dosya.Text = "dosya";
            // 
            // btn_sifirla
            // 
            this.btn_sifirla.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_sifirla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sifirla.FlatAppearance.BorderSize = 0;
            this.btn_sifirla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sifirla.ForeColor = System.Drawing.Color.White;
            this.btn_sifirla.Location = new System.Drawing.Point(176, 148);
            this.btn_sifirla.Name = "btn_sifirla";
            this.btn_sifirla.Size = new System.Drawing.Size(75, 23);
            this.btn_sifirla.TabIndex = 3;
            this.btn_sifirla.Text = "Sıfırla";
            this.btn_sifirla.UseVisualStyleBackColor = false;
            this.btn_sifirla.Click += new System.EventHandler(this.btn_sifirla_Click);
            // 
            // nud_saat
            // 
            this.nud_saat.Location = new System.Drawing.Point(17, 93);
            this.nud_saat.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nud_saat.Name = "nud_saat";
            this.nud_saat.Size = new System.Drawing.Size(60, 20);
            this.nud_saat.TabIndex = 4;
            this.nud_saat.ValueChanged += new System.EventHandler(this.nud_saat_ValueChanged);
            // 
            // nud_dakika
            // 
            this.nud_dakika.Location = new System.Drawing.Point(99, 93);
            this.nud_dakika.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud_dakika.Name = "nud_dakika";
            this.nud_dakika.Size = new System.Drawing.Size(60, 20);
            this.nud_dakika.TabIndex = 5;
            this.nud_dakika.ValueChanged += new System.EventHandler(this.nud_saat_ValueChanged);
            // 
            // nud_saniye
            // 
            this.nud_saniye.Location = new System.Drawing.Point(181, 93);
            this.nud_saniye.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud_saniye.Name = "nud_saniye";
            this.nud_saniye.Size = new System.Drawing.Size(60, 20);
            this.nud_saniye.TabIndex = 6;
            this.nud_saniye.ValueChanged += new System.EventHandler(this.nud_saat_ValueChanged);
            // 
            // lbl_ikinokta
            // 
            this.lbl_ikinokta.AutoSize = true;
            this.lbl_ikinokta.Location = new System.Drawing.Point(83, 95);
            this.lbl_ikinokta.Name = "lbl_ikinokta";
            this.lbl_ikinokta.Size = new System.Drawing.Size(10, 13);
            this.lbl_ikinokta.TabIndex = 7;
            this.lbl_ikinokta.Text = ":";
            // 
            // lbl_ikinokta2
            // 
            this.lbl_ikinokta2.AutoSize = true;
            this.lbl_ikinokta2.Location = new System.Drawing.Point(165, 95);
            this.lbl_ikinokta2.Name = "lbl_ikinokta2";
            this.lbl_ikinokta2.Size = new System.Drawing.Size(10, 13);
            this.lbl_ikinokta2.TabIndex = 8;
            this.lbl_ikinokta2.Text = ":";
            // 
            // frm_zaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(263, 183);
            this.Controls.Add(this.lbl_ikinokta2);
            this.Controls.Add(this.lbl_ikinokta);
            this.Controls.Add(this.nud_saniye);
            this.Controls.Add(this.nud_dakika);
            this.Controls.Add(this.nud_saat);
            this.Controls.Add(this.btn_sifirla);
            this.Controls.Add(this.lbl_dosya);
            this.Controls.Add(this.btn_dosya);
            this.Controls.Add(this.chk_zaman);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_zaman";
            this.Text = "Zaman Ayarı";
            this.Load += new System.EventHandler(this.frm_zaman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_saat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dakika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_saniye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox chk_zaman;
        private System.Windows.Forms.Button btn_dosya;
        private System.Windows.Forms.Label lbl_dosya;
        private System.Windows.Forms.Button btn_sifirla;
        private System.Windows.Forms.NumericUpDown nud_saat;
        private System.Windows.Forms.NumericUpDown nud_dakika;
        private System.Windows.Forms.NumericUpDown nud_saniye;
        private System.Windows.Forms.Label lbl_ikinokta;
        private System.Windows.Forms.Label lbl_ikinokta2;

    }
}