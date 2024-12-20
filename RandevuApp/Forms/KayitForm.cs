using Npgsql;
using RandevuApp.Connection;
using System.Data;
using System.Text;

namespace RandevuApp.Forms
{
	public partial class KayitForm : Form
	{
		public KayitForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			rbDanisan.Checked = true;
		}

		private void btnKayit_Click(object sender, EventArgs e)
		{
			StringBuilder sbUyari = ZorunluAlanKotrolEt();

			if (sbUyari.Length > 0)
			{
				MessageBox.Show(sbUyari.ToString());
				return;
			}

			string selectQuery = "SELECT * FROM public.\"Kullanici\" k where k.\"KullaniciAdi\" = @KullaniciAdi;";

			var selectParms = new NpgsqlParameter[]
			 {
				   new NpgsqlParameter("@KullaniciAdi", txtKullaniciAdi.Text),
			 };

			var kullaniciKontrolSonuc = new SQL().ExecuteReader(selectQuery, selectParms);
			if (kullaniciKontrolSonuc.Rows.Count > 0)
			{
				MessageBox.Show("Kullanici kodu ile daha önce kayýt yapýlmýþtýr.");
				return;
			}

			//	var insertQuery = "INSERT INTO public.\"Kullanici\" (\"KullaniciAdi\", \"Þifre\", \"KimlikNo\", \"Adi\", \"Soyadi\", \"EPosta\", \"GSM\", \"KullaniciGrubuId\", \"AktifMi\") " +
			//		" VALUES(@KullaniciAdi, @Sifre, @KimlikNo, @Adi, @Soyadi, @EPosta, @GSM, @KullaniciGrubuId, true);";

			//	var parameters = new NpgsqlParameter[]
			//	{
			//		new NpgsqlParameter("@KullaniciAdi", txtKullaniciAdi.Text),
			//		new NpgsqlParameter("@Sifre", txtSifre.Text),
			//		new NpgsqlParameter("@KimlikNo", txtKimlikNo.Text),
			//		new NpgsqlParameter("@Adi", txtAdi.Text),
			//		new NpgsqlParameter("@Soyadi", txtSoyad.Text),
			//		new NpgsqlParameter("@EPosta", txtEPosta.Text),
			//		new NpgsqlParameter("@GSM", txtGSM.Text),
			//		new NpgsqlParameter("@KullaniciGrubuId", rbPsikolog.Checked ? 2 : 3),
			//	};

			//	var result = new SQL().ExecuteNonQuery(insertQuery, parameters);

			//	if (result == 0)
			//	{
			//		MessageBox.Show("Kayýt Baþarýsýz!!!");
			//		return;
			//	}

			//	MessageBox.Show("Kayýt Baþarýlý.");
			//	this.Close();

			//}

			var storedProcedure = "CALL public.kullanici_ekle(@KullaniciAdi, @Sifre, @KimlikNo, @Adi, @Soyadi, @EPosta, @GSM, @KullaniciGrubuId, true);";

			var parameters = new NpgsqlParameter[]
			{
				new NpgsqlParameter("@KullaniciAdi", txtKullaniciAdi.Text),
				new NpgsqlParameter("@Sifre", txtSifre.Text),
				new NpgsqlParameter("@KimlikNo", txtKimlikNo.Text),
				new NpgsqlParameter("@Adi", txtAdi.Text),
				new NpgsqlParameter("@Soyadi", txtSoyad.Text),
				new NpgsqlParameter("@EPosta", txtEPosta.Text),
				new NpgsqlParameter("@GSM", txtGSM.Text),
				new NpgsqlParameter("@KullaniciGrubuId", rbPsikolog.Checked ? 2 : 3),
			};

			try
			{
				using (var connection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=12345;Database=Randevu;"))
				{
					connection.Open();
					using (var command = new NpgsqlCommand(storedProcedure, connection))
					{
						command.Parameters.AddRange(parameters);
						command.ExecuteNonQuery();
					}
				}

				MessageBox.Show("Kayýt Baþarýlý.");
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Kayýt Baþarýsýz! Hata: {ex.Message}");
			}
		}


		private StringBuilder ZorunluAlanKotrolEt()
		{
			StringBuilder sbUyari = new StringBuilder();

			if (rbPsikolog.Checked == false && rbDanisan.Checked == false)
				sbUyari.AppendLine("Kullanici türü seçiniz.");

			if (string.IsNullOrEmpty(txtKullaniciAdi.Text))
				sbUyari.AppendLine("Kullanici adi giriniz.");

			if (string.IsNullOrEmpty(txtSifre.Text))
				sbUyari.AppendLine("Þifre giriniz.");

			if (string.IsNullOrEmpty(txtAdi.Text))
				sbUyari.AppendLine("Ad giriniz.");

			if (string.IsNullOrEmpty(txtSoyad.Text))
				sbUyari.AppendLine("Soyad giriniz.");

			if (string.IsNullOrEmpty(txtKimlikNo.Text))
				sbUyari.AppendLine("Kimlik No giriniz.");

			if (string.IsNullOrEmpty(txtEPosta.Text))
				sbUyari.AppendLine("E-Posta giriniz.");

			if (string.IsNullOrEmpty(txtGSM.Text))
				sbUyari.AppendLine("GSM giriniz.");

			return sbUyari;
		}
	}
}
