namespace RandevuApp.Forms
{
    partial class DanisanForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanisanForm));
			gridPsikologlar = new DataGridView();
			gBPsikologlar = new GroupBox();
			tlbRandevu = new TableLayoutPanel();
			gBRandevular = new GroupBox();
			gridRandevular = new DataGridView();
			clmRanId = new DataGridViewTextBoxColumn();
			clmRanPsikologAdi = new DataGridViewTextBoxColumn();
			clmRanPasikologSoyadi = new DataGridViewTextBoxColumn();
			clmRanEPosta = new DataGridViewTextBoxColumn();
			clmRanTarih = new DataGridViewTextBoxColumn();
			clmRanDurumId = new DataGridViewTextBoxColumn();
			clmRanDurumAdi = new DataGridViewTextBoxColumn();
			clmPasifeCek = new DataGridViewImageColumn();
			clmId = new DataGridViewTextBoxColumn();
			clmAdi = new DataGridViewTextBoxColumn();
			clmSoyad = new DataGridViewTextBoxColumn();
			clmEPosta = new DataGridViewTextBoxColumn();
			clmGSM = new DataGridViewTextBoxColumn();
			btnRandevuAl = new DataGridViewImageColumn();
			((System.ComponentModel.ISupportInitialize)gridPsikologlar).BeginInit();
			gBPsikologlar.SuspendLayout();
			tlbRandevu.SuspendLayout();
			gBRandevular.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gridRandevular).BeginInit();
			SuspendLayout();
			// 
			// gridPsikologlar
			// 
			gridPsikologlar.AllowUserToAddRows = false;
			gridPsikologlar.AllowUserToDeleteRows = false;
			gridPsikologlar.BackgroundColor = Color.WhiteSmoke;
			gridPsikologlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridPsikologlar.Columns.AddRange(new DataGridViewColumn[] { clmId, clmAdi, clmSoyad, clmEPosta, clmGSM, btnRandevuAl });
			gridPsikologlar.Dock = DockStyle.Fill;
			gridPsikologlar.Location = new Point(5, 21);
			gridPsikologlar.Name = "gridPsikologlar";
			gridPsikologlar.ReadOnly = true;
			gridPsikologlar.Size = new Size(545, 525);
			gridPsikologlar.TabIndex = 0;
			gridPsikologlar.CellClick += gridPsikologlar_CellClick;
			// 
			// gBPsikologlar
			// 
			gBPsikologlar.BackColor = Color.Transparent;
			gBPsikologlar.Controls.Add(gridPsikologlar);
			gBPsikologlar.Dock = DockStyle.Fill;
			gBPsikologlar.Location = new Point(5, 5);
			gBPsikologlar.Margin = new Padding(5);
			gBPsikologlar.Name = "gBPsikologlar";
			gBPsikologlar.Padding = new Padding(5);
			gBPsikologlar.Size = new Size(555, 551);
			gBPsikologlar.TabIndex = 0;
			gBPsikologlar.TabStop = false;
			gBPsikologlar.Text = "AKTİF PSİKOLOGLAR";
			// 
			// tlbRandevu
			// 
			tlbRandevu.ColumnCount = 2;
			tlbRandevu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.79968F));
			tlbRandevu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.20032F));
			tlbRandevu.Controls.Add(gBPsikologlar, 0, 0);
			tlbRandevu.Controls.Add(gBRandevular, 1, 0);
			tlbRandevu.Dock = DockStyle.Fill;
			tlbRandevu.Location = new Point(0, 0);
			tlbRandevu.Name = "tlbRandevu";
			tlbRandevu.RowCount = 1;
			tlbRandevu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tlbRandevu.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tlbRandevu.Size = new Size(1234, 561);
			tlbRandevu.TabIndex = 1;
			// 
			// gBRandevular
			// 
			gBRandevular.BackColor = Color.Transparent;
			gBRandevular.Controls.Add(gridRandevular);
			gBRandevular.Dock = DockStyle.Fill;
			gBRandevular.Location = new Point(570, 5);
			gBRandevular.Margin = new Padding(5);
			gBRandevular.Name = "gBRandevular";
			gBRandevular.Padding = new Padding(5);
			gBRandevular.Size = new Size(659, 551);
			gBRandevular.TabIndex = 1;
			gBRandevular.TabStop = false;
			gBRandevular.Text = "RANDEVULAR";
			// 
			// gridRandevular
			// 
			gridRandevular.AllowUserToAddRows = false;
			gridRandevular.AllowUserToDeleteRows = false;
			gridRandevular.BackgroundColor = Color.WhiteSmoke;
			gridRandevular.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridRandevular.Columns.AddRange(new DataGridViewColumn[] { clmRanId, clmRanPsikologAdi, clmRanPasikologSoyadi, clmRanEPosta, clmRanTarih, clmRanDurumId, clmRanDurumAdi, clmPasifeCek });
			gridRandevular.Dock = DockStyle.Fill;
			gridRandevular.Location = new Point(5, 21);
			gridRandevular.Name = "gridRandevular";
			gridRandevular.ReadOnly = true;
			gridRandevular.Size = new Size(649, 525);
			gridRandevular.TabIndex = 0;
			gridRandevular.CellClick += gridRandevular_CellClick;
			// 
			// clmRanId
			// 
			clmRanId.DataPropertyName = "Id";
			clmRanId.HeaderText = "Id";
			clmRanId.Name = "clmRanId";
			clmRanId.ReadOnly = true;
			clmRanId.Visible = false;
			// 
			// clmRanPsikologAdi
			// 
			clmRanPsikologAdi.DataPropertyName = "Adi";
			clmRanPsikologAdi.HeaderText = "Psikolog Adı";
			clmRanPsikologAdi.Name = "clmRanPsikologAdi";
			clmRanPsikologAdi.ReadOnly = true;
			// 
			// clmRanPasikologSoyadi
			// 
			clmRanPasikologSoyadi.DataPropertyName = "Soyadi";
			clmRanPasikologSoyadi.HeaderText = "Psikolog Soyadi";
			clmRanPasikologSoyadi.Name = "clmRanPasikologSoyadi";
			clmRanPasikologSoyadi.ReadOnly = true;
			// 
			// clmRanEPosta
			// 
			clmRanEPosta.DataPropertyName = "EPosta";
			clmRanEPosta.HeaderText = "E-Posta";
			clmRanEPosta.Name = "clmRanEPosta";
			clmRanEPosta.ReadOnly = true;
			// 
			// clmRanTarih
			// 
			clmRanTarih.DataPropertyName = "RandevuTarihi";
			clmRanTarih.HeaderText = "Randevu Tarihi";
			clmRanTarih.Name = "clmRanTarih";
			clmRanTarih.ReadOnly = true;
			// 
			// clmRanDurumId
			// 
			clmRanDurumId.DataPropertyName = "RandevuDurumId";
			clmRanDurumId.HeaderText = "RandevuDurumId";
			clmRanDurumId.Name = "clmRanDurumId";
			clmRanDurumId.ReadOnly = true;
			clmRanDurumId.Visible = false;
			// 
			// clmRanDurumAdi
			// 
			clmRanDurumAdi.DataPropertyName = "RandevuDurumAdi";
			clmRanDurumAdi.HeaderText = "Randevu Durumu";
			clmRanDurumAdi.Name = "clmRanDurumAdi";
			clmRanDurumAdi.ReadOnly = true;
			// 
			// clmPasifeCek
			// 
			clmPasifeCek.HeaderText = "Randevu Iptal";
			clmPasifeCek.Image = (Image)resources.GetObject("clmPasifeCek.Image");
			clmPasifeCek.Name = "clmPasifeCek";
			clmPasifeCek.ReadOnly = true;
			// 
			// clmId
			// 
			clmId.DataPropertyName = "Id";
			clmId.HeaderText = "Id";
			clmId.Name = "clmId";
			clmId.ReadOnly = true;
			clmId.Visible = false;
			// 
			// clmAdi
			// 
			clmAdi.DataPropertyName = "Adi";
			clmAdi.HeaderText = "Adı";
			clmAdi.Name = "clmAdi";
			clmAdi.ReadOnly = true;
			// 
			// clmSoyad
			// 
			clmSoyad.DataPropertyName = "Soyadi";
			clmSoyad.HeaderText = "Soyadı";
			clmSoyad.Name = "clmSoyad";
			clmSoyad.ReadOnly = true;
			// 
			// clmEPosta
			// 
			clmEPosta.DataPropertyName = "EPosta";
			clmEPosta.HeaderText = "E-Posta";
			clmEPosta.Name = "clmEPosta";
			clmEPosta.ReadOnly = true;
			// 
			// clmGSM
			// 
			clmGSM.DataPropertyName = "GSM";
			clmGSM.HeaderText = "GSM";
			clmGSM.Name = "clmGSM";
			clmGSM.ReadOnly = true;
			// 
			// btnRandevuAl
			// 
			btnRandevuAl.HeaderText = "Randevu Al";
			btnRandevuAl.Image = (Image)resources.GetObject("btnRandevuAl.Image");
			btnRandevuAl.Name = "btnRandevuAl";
			btnRandevuAl.ReadOnly = true;
			btnRandevuAl.Resizable = DataGridViewTriState.True;
			// 
			// DanisanForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1234, 561);
			Controls.Add(tlbRandevu);
			Name = "DanisanForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "DanisanForm";
			Load += DanisanForm_Load;
			((System.ComponentModel.ISupportInitialize)gridPsikologlar).EndInit();
			gBPsikologlar.ResumeLayout(false);
			tlbRandevu.ResumeLayout(false);
			gBRandevular.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)gridRandevular).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox gBPsikologlar;
        private DataGridView gridPsikologlar;
        private TableLayoutPanel tlbRandevu;
        private GroupBox gBRandevular;
        private DataGridView gridRandevular;
        private DataGridViewTextBoxColumn clmRanId;
        private DataGridViewTextBoxColumn clmRanPsikologAdi;
        private DataGridViewTextBoxColumn clmRanPasikologSoyadi;
        private DataGridViewTextBoxColumn clmRanEPosta;
        private DataGridViewTextBoxColumn clmRanTarih;
        private DataGridViewTextBoxColumn clmRanDurumId;
        private DataGridViewTextBoxColumn clmRanDurumAdi;
        private DataGridViewImageColumn clmPasifeCek;
		private DataGridViewTextBoxColumn clmId;
		private DataGridViewTextBoxColumn clmAdi;
		private DataGridViewTextBoxColumn clmSoyad;
		private DataGridViewTextBoxColumn clmEPosta;
		private DataGridViewTextBoxColumn clmGSM;
		private DataGridViewImageColumn btnRandevuAl;
	}
}