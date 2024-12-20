using Npgsql;
using RandevuApp.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandevuApp.Forms
{
	public partial class RandevuAlForm : Form
	{
		public readonly long DanismanId;
		public readonly long PsikologId;

		public RandevuAlForm(long danismanId, long psikologId)
		{
			InitializeComponent();
			DanismanId = danismanId;
			PsikologId = psikologId;
			dtpRandevuTarih.MinDate = DateTime.Now;
			rb9_10.Checked = true;
		}

		private void btnRandevuAl_Click(object sender, EventArgs e)
		{
			int startHour = BaslangicSaatiniGetir();

			DateTime randevuDate = new DateTime(dtpRandevuTarih.Value.Year, dtpRandevuTarih.Value.Month, dtpRandevuTarih.Value.Day, startHour, 0, 0);

			if (randevuDate <= DateTime.Now)
			{
				MessageBox.Show("Randevu saati geçmiştir.");
				return;
			}

			string selectQuery = "SELECT * FROM public.\"Randevu\" r where r.\"PsikologId\" = @PsikologId and r.\"RandevuTarihi\" = @RandevuTarihi and r.\"RandevuDurumId\" <> @RandevuDurumId and r.\"AktifMi\" = true;";
			var selectParms = new NpgsqlParameter[]
			 {
				   new NpgsqlParameter("@PsikologId", PsikologId),
				   new NpgsqlParameter("@RandevuTarihi", randevuDate),
				   new NpgsqlParameter("@RandevuDurumId", 3),
			 };

			var randevuKontrolSonuc = new SQL().ExecuteReader(selectQuery, selectParms);
			if (randevuKontrolSonuc.Rows.Count > 0)
			{
				MessageBox.Show("Randevu daha önce alınmıştır.");
				return;
			}


			var insertQuery = "INSERT INTO public.\"Randevu\" (\"PsikologId\", \"DanisanId\", \"RandevuTarihi\", \"RandevuDurumId\", \"AktifMi\") " +
				"                       VALUES(@PsikologId, @DanisanId, @RandevuTarihi, @RandevuDurumId, @AktifMi);";
			var parameters = new NpgsqlParameter[]
			{
				new NpgsqlParameter("@PsikologId", PsikologId),
				new NpgsqlParameter("@DanisanId", DanismanId),
				new NpgsqlParameter("@RandevuTarihi", randevuDate),
				new NpgsqlParameter("@RandevuDurumId", 1),
				new NpgsqlParameter("@AktifMi", true),
			};

			var kayitSonuc = new SQL().ExecuteNonQuery(insertQuery, parameters);
			if (kayitSonuc == 0)
			{
				MessageBox.Show("Kayıt Başarısız!!!");
			}

			MessageBox.Show("Kayıt Başarılı.");
			this.Close();
		}

		private int BaslangicSaatiniGetir()
		{
			int startHour = 0;

			foreach (var item in tableLayoutPanel3.Controls)
			{
				if (item is RadioButton)
				{
					RadioButton radioButton = (RadioButton)item;

					if (radioButton.Checked)
					{
						startHour = Convert.ToInt32(radioButton.Tag);
						break;
					}
				}
			}

			return startHour;
		}
	}
}
