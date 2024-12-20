using Npgsql;
using RandevuApp.Connection;
using RandevuApp.Entities;
using System.Data;

namespace RandevuApp.Forms
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void GirisForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Kullanici adi veya þifre boþ olamaz.");
                return;
            }

            string selectQuery = "SELECT * FROM public.\"Kullanici\" k where k.\"KullaniciAdi\" = @KullaniciAdi and  k.\"Þifre\" = @Þifre and k.\"AktifMi\" = @AktifMi  ;";

            var selectParms = new NpgsqlParameter[]
             {
                   new NpgsqlParameter("@KullaniciAdi", txtKullaniciAdi.Text),
                   new NpgsqlParameter("@Þifre", txtSifre.Text),
                   new NpgsqlParameter("@AktifMi", true),
             };

            var kullaniciKontrolSonuc = new SQL().ExecuteReader(selectQuery, selectParms);
            if (kullaniciKontrolSonuc.Rows.Count == 0)
            {
                MessageBox.Show("Böyle bir aktif kullanýcý yoktur!!!");
                return;
            }

            UserSession.Id = Convert.ToInt64(kullaniciKontrolSonuc.Rows[0]["Id"]);
            UserSession.Adi = kullaniciKontrolSonuc.Rows[0]["Adi"].ToString();
            UserSession.Soyadi = kullaniciKontrolSonuc.Rows[0]["Soyadi"].ToString();

            if (kullaniciKontrolSonuc.Rows[0]["KullaniciGrubuId"].ToString() == "2")
            {
                PsikologForm form = new PsikologForm();
                form.ShowDialog();
            }
            else if(kullaniciKontrolSonuc.Rows[0]["KullaniciGrubuId"].ToString() == "3")
            {
                DanisanForm form = new DanisanForm();
                form.ShowDialog();
            } 
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            KayitForm kayitForm = new KayitForm();
            kayitForm.ShowDialog();
        }
    }
}
