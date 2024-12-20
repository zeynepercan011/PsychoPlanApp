namespace RandevuApp.Forms
{
    partial class PsikologForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PsikologForm));
			gBRandevular = new GroupBox();
			dataGridPskRand = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			Ad = new DataGridViewTextBoxColumn();
			Soyad = new DataGridViewTextBoxColumn();
			Eposta = new DataGridViewTextBoxColumn();
			GSM = new DataGridViewTextBoxColumn();
			RandevuTarih = new DataGridViewTextBoxColumn();
			RandevuDurumId = new DataGridViewTextBoxColumn();
			RandevuDurumAdi = new DataGridViewTextBoxColumn();
			btnOnay = new DataGridViewImageColumn();
			btnİptal = new DataGridViewImageColumn();
			btnTamamlandi = new DataGridViewImageColumn();
			gBRandevular.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridPskRand).BeginInit();
			SuspendLayout();
			// 
			// gBRandevular
			// 
			gBRandevular.Controls.Add(dataGridPskRand);
			gBRandevular.Location = new Point(3, 4);
			gBRandevular.Name = "gBRandevular";
			gBRandevular.Size = new Size(959, 447);
			gBRandevular.TabIndex = 0;
			gBRandevular.TabStop = false;
			gBRandevular.Text = "Randevular Listesi";
			// 
			// dataGridPskRand
			// 
			dataGridPskRand.AllowUserToAddRows = false;
			dataGridPskRand.AllowUserToDeleteRows = false;
			dataGridPskRand.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridPskRand.Columns.AddRange(new DataGridViewColumn[] { Id, Ad, Soyad, Eposta, GSM, RandevuTarih, RandevuDurumId, RandevuDurumAdi, btnOnay, btnİptal, btnTamamlandi });
			dataGridPskRand.Location = new Point(6, 21);
			dataGridPskRand.Name = "dataGridPskRand";
			dataGridPskRand.ReadOnly = true;
			dataGridPskRand.Size = new Size(935, 420);
			dataGridPskRand.TabIndex = 0;
			dataGridPskRand.CellClick += dataGridPskRand_CellClick;
			// 
			// Id
			// 
			Id.DataPropertyName = "Id";
			Id.HeaderText = "Id";
			Id.Name = "Id";
			Id.ReadOnly = true;
			Id.Visible = false;
			// 
			// Ad
			// 
			Ad.DataPropertyName = "Adi";
			Ad.HeaderText = "Danışan Ad";
			Ad.Name = "Ad";
			Ad.ReadOnly = true;
			// 
			// Soyad
			// 
			Soyad.DataPropertyName = "Soyadi";
			Soyad.HeaderText = "Danışan Soyad";
			Soyad.Name = "Soyad";
			Soyad.ReadOnly = true;
			// 
			// Eposta
			// 
			Eposta.DataPropertyName = "EPosta";
			Eposta.HeaderText = "Email";
			Eposta.Name = "Eposta";
			Eposta.ReadOnly = true;
			// 
			// GSM
			// 
			GSM.DataPropertyName = "GSM";
			GSM.HeaderText = "GSM";
			GSM.Name = "GSM";
			GSM.ReadOnly = true;
			// 
			// RandevuTarih
			// 
			RandevuTarih.DataPropertyName = "RandevuTarihi";
			RandevuTarih.HeaderText = "Randevu Tarihi";
			RandevuTarih.Name = "RandevuTarih";
			RandevuTarih.ReadOnly = true;
			// 
			// RandevuDurumId
			// 
			RandevuDurumId.DataPropertyName = "RandevuDurumId";
			RandevuDurumId.HeaderText = "RandevuDurumId";
			RandevuDurumId.Name = "RandevuDurumId";
			RandevuDurumId.ReadOnly = true;
			RandevuDurumId.Visible = false;
			// 
			// RandevuDurumAdi
			// 
			RandevuDurumAdi.DataPropertyName = "RandevuDurumAdi";
			RandevuDurumAdi.HeaderText = "Randevu Durumu";
			RandevuDurumAdi.Name = "RandevuDurumAdi";
			RandevuDurumAdi.ReadOnly = true;
			// 
			// btnOnay
			// 
			btnOnay.HeaderText = "Onayla";
			btnOnay.Image = (Image)resources.GetObject("btnOnay.Image");
			btnOnay.Name = "btnOnay";
			btnOnay.ReadOnly = true;
			// 
			// btnİptal
			// 
			btnİptal.HeaderText = "İptal Et";
			btnİptal.Image = (Image)resources.GetObject("btnİptal.Image");
			btnİptal.Name = "btnİptal";
			btnİptal.ReadOnly = true;
			// 
			// btnTamamlandi
			// 
			btnTamamlandi.HeaderText = "Tamamlandı";
			btnTamamlandi.Image = (Image)resources.GetObject("btnTamamlandi.Image");
			btnTamamlandi.Name = "btnTamamlandi";
			btnTamamlandi.ReadOnly = true;
			// 
			// PsikologForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(989, 457);
			Controls.Add(gBRandevular);
			Name = "PsikologForm";
			Text = "PsikologForm";
			Load += PsikologForm_Load;
			gBRandevular.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridPskRand).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox gBRandevular;
		private DataGridView dataGridPskRand;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Ad;
		private DataGridViewTextBoxColumn Soyad;
		private DataGridViewTextBoxColumn Eposta;
		private DataGridViewTextBoxColumn GSM;
		private DataGridViewTextBoxColumn RandevuTarih;
		private DataGridViewTextBoxColumn RandevuDurumId;
		private DataGridViewTextBoxColumn RandevuDurumAdi;
		private DataGridViewImageColumn btnOnay;
		private DataGridViewImageColumn btnİptal;
		private DataGridViewImageColumn btnTamamlandi;
	}
}