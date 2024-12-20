namespace RandevuApp.Forms
{
    partial class KayitForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitForm));
			txtKullaniciAdi = new TextBox();
			txtSifre = new TextBox();
			btnKayit = new Button();
			txtKimlikNo = new TextBox();
			txtAdi = new TextBox();
			txtSoyad = new TextBox();
			txtEPosta = new TextBox();
			txtGSM = new TextBox();
			tblKullaniciGrup = new TableLayoutPanel();
			rbPsikolog = new RadioButton();
			rbDanisan = new RadioButton();
			tblKullaniciGrup.SuspendLayout();
			SuspendLayout();
			// 
			// txtKullaniciAdi
			// 
			txtKullaniciAdi.BackColor = Color.White;
			txtKullaniciAdi.Location = new Point(40, 99);
			txtKullaniciAdi.MaxLength = 50;
			txtKullaniciAdi.Name = "txtKullaniciAdi";
			txtKullaniciAdi.PlaceholderText = "Kullanıcı Adı";
			txtKullaniciAdi.Size = new Size(250, 23);
			txtKullaniciAdi.TabIndex = 0;
			txtKullaniciAdi.TextAlign = HorizontalAlignment.Center;
			// 
			// txtSifre
			// 
			txtSifre.Location = new Point(40, 128);
			txtSifre.MaxLength = 50;
			txtSifre.Name = "txtSifre";
			txtSifre.PasswordChar = '*';
			txtSifre.PlaceholderText = "Şifre";
			txtSifre.Size = new Size(250, 23);
			txtSifre.TabIndex = 1;
			txtSifre.TextAlign = HorizontalAlignment.Center;
			// 
			// btnKayit
			// 
			btnKayit.BackColor = Color.White;
			btnKayit.Font = new Font("Segoe UI", 12F);
			btnKayit.Location = new Point(120, 317);
			btnKayit.Name = "btnKayit";
			btnKayit.Size = new Size(100, 51);
			btnKayit.TabIndex = 3;
			btnKayit.Text = "Kaydet";
			btnKayit.UseVisualStyleBackColor = false;
			btnKayit.Click += btnKayit_Click;
			// 
			// txtKimlikNo
			// 
			txtKimlikNo.Location = new Point(40, 157);
			txtKimlikNo.MaxLength = 11;
			txtKimlikNo.Name = "txtKimlikNo";
			txtKimlikNo.PlaceholderText = "Kimlik No";
			txtKimlikNo.Size = new Size(250, 23);
			txtKimlikNo.TabIndex = 4;
			txtKimlikNo.TextAlign = HorizontalAlignment.Center;
			// 
			// txtAdi
			// 
			txtAdi.Location = new Point(40, 186);
			txtAdi.MaxLength = 50;
			txtAdi.Name = "txtAdi";
			txtAdi.PlaceholderText = "Ad";
			txtAdi.Size = new Size(250, 23);
			txtAdi.TabIndex = 5;
			txtAdi.TextAlign = HorizontalAlignment.Center;
			// 
			// txtSoyad
			// 
			txtSoyad.Location = new Point(40, 215);
			txtSoyad.MaxLength = 50;
			txtSoyad.Name = "txtSoyad";
			txtSoyad.PlaceholderText = "Soyad";
			txtSoyad.Size = new Size(250, 23);
			txtSoyad.TabIndex = 6;
			txtSoyad.TextAlign = HorizontalAlignment.Center;
			// 
			// txtEPosta
			// 
			txtEPosta.Location = new Point(40, 244);
			txtEPosta.MaxLength = 50;
			txtEPosta.Name = "txtEPosta";
			txtEPosta.PlaceholderText = "E Posta";
			txtEPosta.Size = new Size(250, 23);
			txtEPosta.TabIndex = 7;
			txtEPosta.TextAlign = HorizontalAlignment.Center;
			// 
			// txtGSM
			// 
			txtGSM.Location = new Point(40, 273);
			txtGSM.MaxLength = 50;
			txtGSM.Name = "txtGSM";
			txtGSM.PlaceholderText = "GSM";
			txtGSM.Size = new Size(250, 23);
			txtGSM.TabIndex = 8;
			txtGSM.TextAlign = HorizontalAlignment.Center;
			// 
			// tblKullaniciGrup
			// 
			tblKullaniciGrup.BackColor = Color.Transparent;
			tblKullaniciGrup.ColumnCount = 2;
			tblKullaniciGrup.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tblKullaniciGrup.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tblKullaniciGrup.Controls.Add(rbPsikolog, 0, 0);
			tblKullaniciGrup.Controls.Add(rbDanisan, 1, 0);
			tblKullaniciGrup.Location = new Point(40, 40);
			tblKullaniciGrup.Name = "tblKullaniciGrup";
			tblKullaniciGrup.RowCount = 1;
			tblKullaniciGrup.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tblKullaniciGrup.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tblKullaniciGrup.Size = new Size(250, 28);
			tblKullaniciGrup.TabIndex = 9;
			// 
			// rbPsikolog
			// 
			rbPsikolog.AutoSize = true;
			rbPsikolog.Dock = DockStyle.Fill;
			rbPsikolog.Location = new Point(3, 3);
			rbPsikolog.Name = "rbPsikolog";
			rbPsikolog.Size = new Size(119, 22);
			rbPsikolog.TabIndex = 0;
			rbPsikolog.TabStop = true;
			rbPsikolog.Text = "Psikolog";
			rbPsikolog.TextAlign = ContentAlignment.MiddleCenter;
			rbPsikolog.UseVisualStyleBackColor = true;
			// 
			// rbDanisan
			// 
			rbDanisan.AutoSize = true;
			rbDanisan.Dock = DockStyle.Fill;
			rbDanisan.Location = new Point(128, 3);
			rbDanisan.Name = "rbDanisan";
			rbDanisan.Size = new Size(119, 22);
			rbDanisan.TabIndex = 1;
			rbDanisan.TabStop = true;
			rbDanisan.Text = "Danışan";
			rbDanisan.TextAlign = ContentAlignment.MiddleCenter;
			rbDanisan.UseVisualStyleBackColor = true;
			// 
			// KayitForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(334, 461);
			Controls.Add(tblKullaniciGrup);
			Controls.Add(txtGSM);
			Controls.Add(txtEPosta);
			Controls.Add(txtSoyad);
			Controls.Add(txtAdi);
			Controls.Add(txtKimlikNo);
			Controls.Add(btnKayit);
			Controls.Add(txtSifre);
			Controls.Add(txtKullaniciAdi);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "KayitForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Yeni Kayıt";
			Load += Form1_Load;
			tblKullaniciGrup.ResumeLayout(false);
			tblKullaniciGrup.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnKayit;
        private TextBox txtKimlikNo;
        private TextBox txtAdi;
        private TextBox txtSoyad;
        private TextBox txtEPosta;
        private TextBox txtGSM;
        private TableLayoutPanel tblKullaniciGrup;
        private RadioButton rbPsikolog;
        private RadioButton rbDanisan;
    }
}
