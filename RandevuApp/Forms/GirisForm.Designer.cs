namespace RandevuApp.Forms
{
    partial class GirisForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
			txtKullaniciAdi = new TextBox();
			txtSifre = new TextBox();
			btnGiris = new Button();
			btnKayit = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			SuspendLayout();
			// 
			// txtKullaniciAdi
			// 
			txtKullaniciAdi.BackColor = Color.White;
			txtKullaniciAdi.Location = new Point(42, 181);
			txtKullaniciAdi.Name = "txtKullaniciAdi";
			txtKullaniciAdi.PlaceholderText = "Kullanıcı Adı";
			txtKullaniciAdi.Size = new Size(250, 23);
			txtKullaniciAdi.TabIndex = 0;
			txtKullaniciAdi.TextAlign = HorizontalAlignment.Center;
			// 
			// txtSifre
			// 
			txtSifre.Location = new Point(42, 210);
			txtSifre.Name = "txtSifre";
			txtSifre.PasswordChar = '*';
			txtSifre.PlaceholderText = "Şifre";
			txtSifre.Size = new Size(250, 23);
			txtSifre.TabIndex = 1;
			txtSifre.TextAlign = HorizontalAlignment.Center;
			// 
			// btnGiris
			// 
			btnGiris.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
			btnGiris.Location = new Point(42, 246);
			btnGiris.Name = "btnGiris";
			btnGiris.Size = new Size(118, 48);
			btnGiris.TabIndex = 2;
			btnGiris.Text = "Giriş";
			btnGiris.UseVisualStyleBackColor = true;
			btnGiris.Click += btnGiris_Click;
			// 
			// btnKayit
			// 
			btnKayit.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
			btnKayit.Location = new Point(166, 246);
			btnKayit.Name = "btnKayit";
			btnKayit.Size = new Size(126, 48);
			btnKayit.TabIndex = 3;
			btnKayit.Text = "Yeni Kayıt";
			btnKayit.UseVisualStyleBackColor = true;
			btnKayit.Click += btnKayit_Click;
			// 
			// label1
			// 
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
			label1.Location = new Point(91, 61);
			label1.Name = "label1";
			label1.Size = new Size(154, 33);
			label1.TabIndex = 4;
			label1.Text = "PSYCHO PLAN";
			// 
			// label2
			// 
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Segoe UI", 8F, FontStyle.Italic | FontStyle.Underline);
			label2.Location = new Point(237, 405);
			label2.Name = "label2";
			label2.Size = new Size(85, 31);
			label2.TabIndex = 5;
			label2.Text = "ZEYNEP ERCAN İLAYDA AKDAĞ";
			// 
			// label3
			// 
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
			label3.Location = new Point(91, 115);
			label3.Name = "label3";
			label3.Size = new Size(154, 35);
			label3.TabIndex = 6;
			label3.Text = "HOŞGELDİNİZ!";
			// 
			// label4
			// 
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
			label4.Location = new Point(26, 85);
			label4.Name = "label4";
			label4.Size = new Size(296, 30);
			label4.TabIndex = 7;
			label4.Text = "Randevu Alma Uygulamasına";
			// 
			// GirisForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(334, 461);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btnKayit);
			Controls.Add(btnGiris);
			Controls.Add(txtSifre);
			Controls.Add(txtKullaniciAdi);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "GirisForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Giriş";
			Load += GirisForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnGiris;
        private Button btnKayit;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
	}
}
