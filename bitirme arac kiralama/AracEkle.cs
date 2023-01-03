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
    public partial class AracEkle : Form
    {
        public AracEkle()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=localhost;Initial Catalog=OtoKiralama;Integrated Security=True";

        private void AracEkle_Load(object sender, EventArgs e)
        {

        }

        private void cbxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMarka.SelectedIndex == 0)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";
                cbxSeri.Items.Add("Corsa");
                cbxSeri.Items.Add("Astra");
                cbxSeri.Items.Add("İnsignia");

            }
            else if (cbxMarka.SelectedIndex == 1)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";
                cbxSeri.Items.Add("A-200");
                cbxSeri.Items.Add("C63");
                cbxSeri.Items.Add("S-400");
            }
            else if (cbxMarka.SelectedIndex == 2)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";
                cbxSeri.Items.Add("M 520");
                cbxSeri.Items.Add("M4 competition");
                cbxSeri.Items.Add("M 63");
            }
            else if (cbxMarka.SelectedIndex == 3)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";
                cbxSeri.Items.Add("Megane 6");
                cbxSeri.Items.Add("Clıo");
                cbxSeri.Items.Add("Fluence");
            }
            else if (cbxMarka.SelectedIndex == 4)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";
                cbxSeri.Items.Add("courier");
                cbxSeri.Items.Add("GT-500");
                cbxSeri.Items.Add("Mustang");
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Insert Into Araclar Values (@Plaka,@Marka,@Seri,@Model,@Renk,@Km,@Yakit,@Ucret,@Durum)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
            komut.Parameters.AddWithValue("@Marka", cbxMarka.SelectedItem);
            komut.Parameters.AddWithValue("@Seri", cbxSeri.SelectedItem);
            komut.Parameters.AddWithValue("@Model", txtModel.Text);
            komut.Parameters.AddWithValue("@Renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@Km", txtKm.Text);
            komut.Parameters.AddWithValue("@Yakit", cbxYakit.SelectedItem);
            komut.Parameters.AddWithValue("@Ucret", txtUcret.Text);
            komut.Parameters.AddWithValue("@Durum", cbxDurum.SelectedItem);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
