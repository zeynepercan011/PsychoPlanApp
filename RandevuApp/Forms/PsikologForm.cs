using Npgsql;
using RandevuApp.Connection;
using RandevuApp.Entities;
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
	public partial class PsikologForm : Form
	{
		public PsikologForm()
		{
			InitializeComponent();
		}

		private void PsikologForm_Load(object sender, EventArgs e)
		{
			this.Text = "Psikolog (" + UserSession.Adi?.ToUpper() + " " + UserSession.Soyadi?.ToUpper() + ")";
			Randevular();
		}

		private void Randevular()
		{
			string selectQuery = "SELECT r.\"Id\", k.\"Adi\", k.\"Soyadi\", k.\"EPosta\", k.\"GSM\", r.\"RandevuTarihi\", r.\"RandevuDurumId\", rd.\"Adi\" as \"RandevuDurumAdi\" " +
						 "FROM public.\"Randevu\" r " +
						 "INNER JOIN public.\"Kullanici\" k ON r.\"DanisanId\" = k.\"Id\" " +
						 "INNER JOIN public.\"RandevuDurumu\" rd ON rd.\"Id\" = r.\"RandevuDurumId\" " +
						 "WHERE r.\"PsikologId\" = @PsikologId;";

			var selectParms = new NpgsqlParameter[]
			 {
				   new NpgsqlParameter("@PsikologId", UserSession.Id),
			 };

			var randevuTable = new SQL().ExecuteReader(selectQuery, selectParms);
			dataGridPskRand.DataSource = randevuTable;

		}

		private void dataGridPskRand_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow selectedRow = dataGridPskRand.Rows[e.RowIndex];
				string clickedColumn = dataGridPskRand.Columns[e.ColumnIndex].Name;
				long randevuId = Convert.ToInt64(selectedRow.Cells["Id"].Value);

				if (clickedColumn == "btnOnay")
				{
					UpdateRandevuDurumu(randevuId, "Onaylandı" ,2);
				}
				else if (clickedColumn == "btnİptal")
				{
					UpdateRandevuDurumu(randevuId, "Reddedildi", 3);
				}
				else if (clickedColumn == "btnTamamlandi")
				{
					UpdateRandevuDurumu(randevuId, "Tamamlandı", 4);
				}
			}
		}

		private void UpdateRandevuDurumu(long randevuId, string yeniDurum, int durumId)
		{
			string updateQuery = "UPDATE public.\"Randevu\" SET \"RandevuDurumId\" = @RandevuDurumId WHERE \"Id\"  = @Id";

			var parameters = new NpgsqlParameter[]
				{
				new NpgsqlParameter("@RandevuDurumId", durumId),
				new NpgsqlParameter("@Id", randevuId),
				};

			var kayitSonuc = new SQL().ExecuteNonQuery(updateQuery, parameters);

			if (kayitSonuc > 0)
			{
				MessageBox.Show($"{yeniDurum} olarak güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Güncelleme sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			MessageBox.Show("Kayıt Başarılı.");
			Randevular();
		}
	}
}
