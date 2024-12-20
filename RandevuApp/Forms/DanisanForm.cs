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
    public partial class DanisanForm : Form
    {
        public DanisanForm()
        {
            InitializeComponent();
        }

        private void DanisanForm_Load(object sender, EventArgs e)
        {
            this.Text = "Danışan (" + UserSession.Adi?.ToUpper() + " " + UserSession.Soyadi?.ToUpper() + ")";
            PsikologlariGetir();
            RandevulariGetir();

        }
        private void gridPsikologlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridPsikologlar.Columns[e.ColumnIndex].Name == "btnRandevuAl" && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = gridPsikologlar.Rows[e.RowIndex];

                var psikologId = Convert.ToInt64(selectedRow.Cells["clmId"].Value);
                var danisanId = UserSession.Id;

                RandevuAlForm form = new RandevuAlForm(danisanId, psikologId);
                form.ShowDialog();

                RandevulariGetir();
            }
        }

        private void PsikologlariGetir()
        {
            string selectQuery = "SELECT * FROM public.\"Kullanici\" k where k.\"KullaniciGrubuId\" = 2 and k.\"AktifMi\" = @AktifMi ;";

            var selectParms = new NpgsqlParameter[]
             {
                   new NpgsqlParameter("@AktifMi", true),
             };

            var psikologDataTable = new SQL().ExecuteReader(selectQuery, selectParms);
            gridPsikologlar.DataSource = psikologDataTable;
        }
        private void RandevulariGetir()
        {
            string selectQuery = "SELECT r.\"Id\", k.\"Adi\",k.\"Soyadi\",k.\"EPosta\",k.\"GSM\",r.\"RandevuTarihi\",r.\"RandevuDurumId\",rd.\"Adi\" as \"RandevuDurumAdi\" FROM public.\"Randevu\" r " +
                "INNER JOIN public.\"Kullanici\" k on r.\"PsikologId\" = k.\"Id\" " +
                "INNER JOIN public.\"RandevuDurumu\" rd on rd.\"Id\" = r.\"RandevuDurumId\" " +
                "where r.\"DanisanId\" = @DanisanId ;";

            var selectParms = new NpgsqlParameter[]
             {
                   new NpgsqlParameter("@DanisanId", UserSession.Id),
             };

            var randevuTable = new SQL().ExecuteReader(selectQuery, selectParms);
            gridRandevular.DataSource = randevuTable;
        }

        private void gridRandevular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridRandevular.Columns[e.ColumnIndex].Name == "clmPasifeCek" && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = gridRandevular.Rows[e.RowIndex];

                var randevuDurumId = Convert.ToInt64(selectedRow.Cells["clmRanDurumId"].Value);
                var randevuId = Convert.ToInt64(selectedRow.Cells["clmRanId"].Value);

                if (randevuDurumId != 1)
                {
                    MessageBox.Show("Sadece randevu durumu \"Randevu Alındı\" durumunda olanlar iptal edilebilir!!!");
                    return;
                }

                DialogResult result = MessageBox.Show("Randevu'yu iptal etmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    return;
                }

                var updateQuery = "UPDATE public.\"Randevu\"  SET \"RandevuDurumId\" = @RandevuDurumId WHERE  \"Id\"  = @Id";
                var parameters = new NpgsqlParameter[]
                {
                new NpgsqlParameter("@RandevuDurumId", randevuDurumId),
                new NpgsqlParameter("@Id", randevuId),
                };

                var kayitSonuc = new SQL().ExecuteNonQuery(updateQuery, parameters);
                if (kayitSonuc == 0)
                {
                    MessageBox.Show("Kayıt Başarısız!!!");
                }

                MessageBox.Show("Kayıt Başarılı.");


                RandevulariGetir();
            }

        }
    }
}
