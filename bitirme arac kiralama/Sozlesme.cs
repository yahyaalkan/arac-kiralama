using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bitirme_arac_kiralama
{
    public partial class Sozlesme : Form
    {
        public Sozlesme()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=localhost;Initial Catalog=OtoKiralama;Integrated Security=True";
        public void Arac_Listele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select * From Araclar where Durumu = 'Boş'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cbxArac.Items.Add(read["Plaka"]);
            }

        }
        public void Sozlesme_Listele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            String komutCumlesi = "Select * From Sözlesme";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select * From Musteriler where Tc_No like'" + txtTcAra.Text + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                txtTc.Text = read["Tc_No"].ToString();
                txtAdSoyad.Text = read["Ad_Soyad"].ToString();
                txtTel.Text = read["Telefon"].ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btnHesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gunfarki = DateTime.Parse(dateTimeDönüs.Text) - DateTime.Parse(dateTimeCikis.Text);
            int gunhesap = gunfarki.Days;
            txtGün.Text = gunhesap.ToString();
            txtTutar.Text = (gunhesap * int.Parse(txtKiraUcreti.Text)).ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Insert Into Sözlesme Values (@tcno,@adsoyad,@Telefon,@ehliyetno,@ehliyettarih,@plaka,@Marka,@Seri,@Model,@Renk,@kirasekli,@KiraÜcreti,@kiralanangunsayisi,@tutar,@cikistarih,@dönüstarih)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.Parameters.AddWithValue("@tcno", txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@Telefon", txtTel.Text);
            komut.Parameters.AddWithValue("@ehliyetno", txtEhliyetNo.Text);
            komut.Parameters.AddWithValue("@ehliyettarih", txtEhliyetTarihi.Text);
            komut.Parameters.AddWithValue("@plaka", cbxArac.Text);
            komut.Parameters.AddWithValue("@Marka", txtMarka.Text);
            komut.Parameters.AddWithValue("@Seri", txtSeri.Text);
            komut.Parameters.AddWithValue("@Model", txtModel.Text);
            komut.Parameters.AddWithValue("@Renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@kirasekli", cbxKiraSekli.SelectedItem);
            komut.Parameters.AddWithValue("@KiraÜcreti", txtKiraUcreti.Text);
            komut.Parameters.AddWithValue("@kiralanangunsayisi", txtGün.Text);
            komut.Parameters.AddWithValue("@tutar", txtTutar.Text);
            komut.Parameters.AddWithValue("@cikistarih", dateTimeCikis.Value);
            komut.Parameters.AddWithValue("@dönüstarih", dateTimeDönüs.Value);

            string komutCumlesiUp = "Update Araclar set Durumu = 'Dolu' where Plaka ='" + cbxArac.SelectedItem + "'";
            SqlCommand komutUp = new SqlCommand(komutCumlesiUp, baglanti);

            komutUp.ExecuteNonQuery();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Sozlesme_Listele();
            Arac_Listele();
            MessageBox.Show("Kayıt Başarılı");
        }

        private void btnAracTeslim_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
            int ucret = int.Parse(satir.Cells["Kira_Ücreti"].Value.ToString());
            int tutar = int.Parse(satir.Cells["Tutar"].Value.ToString());
            DateTime cikis = DateTime.Parse(satir.Cells["Cikis_Tarih"].Value.ToString());
            TimeSpan gun = bugün - cikis;
            int gunu = gun.Days;
            int toplamtutar = gunu - ucret;

            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Delete from Sözlesme where Plaka = '" + satir.Cells["Plaka"].Value.ToString() + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.ExecuteNonQuery();


            string komutCumlesiUpd = "Update Araclar set Durumu = 'Boş' where Plaka = '" + satir.Cells["Plaka"].Value.ToString() + "'";
            SqlCommand komutUp = new SqlCommand(komutCumlesiUpd, baglanti);
            komutUp.ExecuteNonQuery();

            string komutCumlesiSatis = "Insert Into Satis Values (@tcno,@AdSoyad,@Telefon,@plaka,@gun,@kirasekli,@kiraücreti,@tutar,@cikistarih,@dönüstarih)'" + satir.Cells["Plaka"].Value.ToString() + "'";
            SqlCommand komutSatis = new SqlCommand(komutCumlesiSatis, baglanti);
            komutSatis.Parameters.AddWithValue("@tcno", satir.Cells["Tc_No"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@AdSoyad", satir.Cells["Ad_Soyad"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@Telefon", satir.Cells["Telefon"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@plaka", satir.Cells["Plaka"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@gun", gunu);
            komutSatis.Parameters.AddWithValue("@kirasekli", satir.Cells["Kira_Sekli"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@kiraücreti", ucret);
            komutSatis.Parameters.AddWithValue("@tutar", toplamtutar);
            komutSatis.Parameters.AddWithValue("@cikistarih", satir.Cells["Cikis_Tarih"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@dönüstarih", satir.Cells["Dönüs_Tarih"].Value.ToString());
            komutSatis.ExecuteNonQuery();

            MessageBox.Show("Araç Teslim Edildi");
        }

        private void cbxArac_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select * From Araclar where Plaka like '" + cbxArac.SelectedItem + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtMarka.Text = read["Marka"].ToString();
                txtSeri.Text = read["Seri"].ToString();
                txtModel.Text = read["Model"].ToString();
                txtRenk.Text = read["Renk"].ToString();
            }
        }

        private void cbxKiraSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select Kira_Ücreti From Araclar";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (cbxKiraSekli.SelectedIndex == 0)
                {
                    txtKiraUcreti.Text = (int.Parse(read["Kira_Ücreti"].ToString()) * 1).ToString();
                }
                else if (cbxKiraSekli.SelectedIndex == 1)
                {
                    txtKiraUcreti.Text = (int.Parse(read["Kira_Ücreti"].ToString()) * 0.80).ToString();
                }
                else if (cbxKiraSekli.SelectedIndex == 2)
                {
                    txtKiraUcreti.Text = (int.Parse(read["Kira_Ücreti"].ToString()) * 0.70).ToString();
                }

            }

        }

        private void Sözlesme_Load(object sender, EventArgs e)
        {
            Arac_Listele();
            Sozlesme_Listele();
        }
    }
}
