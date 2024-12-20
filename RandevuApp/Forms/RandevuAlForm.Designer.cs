namespace RandevuApp.Forms
{
    partial class RandevuAlForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandevuAlForm));
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel2 = new TableLayoutPanel();
			dtpRandevuTarih = new DateTimePicker();
			tableLayoutPanel3 = new TableLayoutPanel();
			rb9_10 = new RadioButton();
			rb10_11 = new RadioButton();
			rb11_12 = new RadioButton();
			rb13_14 = new RadioButton();
			rb14_15 = new RadioButton();
			rb15_16 = new RadioButton();
			rb16_17 = new RadioButton();
			rb17_18 = new RadioButton();
			btnRandevuAl = new Button();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.BackColor = Color.Transparent;
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.587677F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.41232F));
			tableLayoutPanel1.Size = new Size(384, 211);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(dtpRandevuTarih, 0, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(3, 3);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel2.Size = new Size(378, 28);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// dtpRandevuTarih
			// 
			dtpRandevuTarih.Dock = DockStyle.Fill;
			dtpRandevuTarih.Location = new Point(3, 3);
			dtpRandevuTarih.MinDate = new DateTime(2024, 12, 15, 0, 0, 0, 0);
			dtpRandevuTarih.Name = "dtpRandevuTarih";
			dtpRandevuTarih.Size = new Size(183, 23);
			dtpRandevuTarih.TabIndex = 0;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 2;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Controls.Add(rb9_10, 0, 0);
			tableLayoutPanel3.Controls.Add(rb10_11, 0, 1);
			tableLayoutPanel3.Controls.Add(rb11_12, 0, 2);
			tableLayoutPanel3.Controls.Add(rb13_14, 0, 3);
			tableLayoutPanel3.Controls.Add(rb14_15, 1, 0);
			tableLayoutPanel3.Controls.Add(rb15_16, 1, 1);
			tableLayoutPanel3.Controls.Add(rb16_17, 1, 2);
			tableLayoutPanel3.Controls.Add(rb17_18, 1, 3);
			tableLayoutPanel3.Controls.Add(btnRandevuAl, 0, 4);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(3, 37);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 5;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel3.Size = new Size(378, 171);
			tableLayoutPanel3.TabIndex = 1;
			// 
			// rb9_10
			// 
			rb9_10.AutoSize = true;
			rb9_10.CheckAlign = ContentAlignment.MiddleRight;
			rb9_10.Dock = DockStyle.Fill;
			rb9_10.Location = new Point(3, 3);
			rb9_10.Name = "rb9_10";
			rb9_10.Size = new Size(183, 28);
			rb9_10.TabIndex = 0;
			rb9_10.TabStop = true;
			rb9_10.Tag = "9";
			rb9_10.Text = "09:00   -  10:00";
			rb9_10.TextAlign = ContentAlignment.MiddleCenter;
			rb9_10.UseVisualStyleBackColor = true;
			// 
			// rb10_11
			// 
			rb10_11.AutoSize = true;
			rb10_11.CheckAlign = ContentAlignment.MiddleRight;
			rb10_11.Dock = DockStyle.Fill;
			rb10_11.Location = new Point(3, 37);
			rb10_11.Name = "rb10_11";
			rb10_11.Size = new Size(183, 28);
			rb10_11.TabIndex = 1;
			rb10_11.TabStop = true;
			rb10_11.Tag = "10";
			rb10_11.Text = "10:00   -  11:00";
			rb10_11.TextAlign = ContentAlignment.MiddleCenter;
			rb10_11.UseVisualStyleBackColor = true;
			// 
			// rb11_12
			// 
			rb11_12.AutoSize = true;
			rb11_12.CheckAlign = ContentAlignment.MiddleRight;
			rb11_12.Dock = DockStyle.Fill;
			rb11_12.Location = new Point(3, 71);
			rb11_12.Name = "rb11_12";
			rb11_12.Size = new Size(183, 28);
			rb11_12.TabIndex = 2;
			rb11_12.TabStop = true;
			rb11_12.Tag = "11";
			rb11_12.Text = "11:00   -  12:00";
			rb11_12.TextAlign = ContentAlignment.MiddleCenter;
			rb11_12.UseVisualStyleBackColor = true;
			// 
			// rb13_14
			// 
			rb13_14.AutoSize = true;
			rb13_14.CheckAlign = ContentAlignment.MiddleRight;
			rb13_14.Dock = DockStyle.Fill;
			rb13_14.Location = new Point(3, 105);
			rb13_14.Name = "rb13_14";
			rb13_14.Size = new Size(183, 28);
			rb13_14.TabIndex = 3;
			rb13_14.TabStop = true;
			rb13_14.Tag = "13";
			rb13_14.Text = "13:00   -  14:00";
			rb13_14.TextAlign = ContentAlignment.MiddleCenter;
			rb13_14.UseVisualStyleBackColor = true;
			// 
			// rb14_15
			// 
			rb14_15.AutoSize = true;
			rb14_15.CheckAlign = ContentAlignment.MiddleRight;
			rb14_15.Dock = DockStyle.Fill;
			rb14_15.Location = new Point(192, 3);
			rb14_15.Name = "rb14_15";
			rb14_15.Size = new Size(183, 28);
			rb14_15.TabIndex = 4;
			rb14_15.TabStop = true;
			rb14_15.Tag = "14";
			rb14_15.Text = "14:00   -  15:00";
			rb14_15.TextAlign = ContentAlignment.MiddleCenter;
			rb14_15.UseVisualStyleBackColor = true;
			// 
			// rb15_16
			// 
			rb15_16.AutoSize = true;
			rb15_16.CheckAlign = ContentAlignment.MiddleRight;
			rb15_16.Dock = DockStyle.Fill;
			rb15_16.Location = new Point(192, 37);
			rb15_16.Name = "rb15_16";
			rb15_16.Size = new Size(183, 28);
			rb15_16.TabIndex = 5;
			rb15_16.TabStop = true;
			rb15_16.Tag = "15";
			rb15_16.Text = "15:00   -  16:00";
			rb15_16.TextAlign = ContentAlignment.MiddleCenter;
			rb15_16.UseVisualStyleBackColor = true;
			// 
			// rb16_17
			// 
			rb16_17.AutoSize = true;
			rb16_17.CheckAlign = ContentAlignment.MiddleRight;
			rb16_17.Dock = DockStyle.Fill;
			rb16_17.Location = new Point(192, 71);
			rb16_17.Name = "rb16_17";
			rb16_17.Size = new Size(183, 28);
			rb16_17.TabIndex = 6;
			rb16_17.TabStop = true;
			rb16_17.Tag = "16";
			rb16_17.Text = "16:00   -  17:00";
			rb16_17.TextAlign = ContentAlignment.MiddleCenter;
			rb16_17.UseVisualStyleBackColor = true;
			// 
			// rb17_18
			// 
			rb17_18.AutoSize = true;
			rb17_18.CheckAlign = ContentAlignment.MiddleRight;
			rb17_18.Dock = DockStyle.Fill;
			rb17_18.Location = new Point(192, 105);
			rb17_18.Name = "rb17_18";
			rb17_18.Size = new Size(183, 28);
			rb17_18.TabIndex = 7;
			rb17_18.TabStop = true;
			rb17_18.Tag = "17";
			rb17_18.Text = "17:00   -  18:00";
			rb17_18.TextAlign = ContentAlignment.MiddleCenter;
			rb17_18.UseVisualStyleBackColor = true;
			// 
			// btnRandevuAl
			// 
			btnRandevuAl.Dock = DockStyle.Fill;
			btnRandevuAl.Location = new Point(3, 139);
			btnRandevuAl.Name = "btnRandevuAl";
			btnRandevuAl.Size = new Size(183, 29);
			btnRandevuAl.TabIndex = 1;
			btnRandevuAl.Text = "Randevu Al";
			btnRandevuAl.UseVisualStyleBackColor = true;
			btnRandevuAl.Click += btnRandevuAl_Click;
			// 
			// RandevuAlForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(384, 211);
			Controls.Add(tableLayoutPanel1);
			DoubleBuffered = true;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "RandevuAlForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Randevu Al";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private DateTimePicker dtpRandevuTarih;
        private TableLayoutPanel tableLayoutPanel3;
        private RadioButton rb9_10;
        private RadioButton rb10_11;
        private RadioButton rb11_12;
        private RadioButton rb13_14;
        private RadioButton rb14_15;
        private RadioButton rb15_16;
        private RadioButton rb16_17;
        private RadioButton rb17_18;
        private Button btnRandevuAl;
    }
}