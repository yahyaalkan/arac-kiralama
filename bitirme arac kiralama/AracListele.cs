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
    public partial class AracListele : Form
    {
        public AracListele()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=localhost;Initial Catalog=OtoKiralama;Integrated Security=True";


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
        public void Arac_Listele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            String komutCumlesi = "Select * From Araclar";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Delete from Araclar where Plaka='" + dataGridView1.CurrentRow.Cells["Plaka"].Value.ToString() + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);

            komut.ExecuteNonQuery();
            baglanti.Close();
            Arac_Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Update Araclar set Marka=@marka,Seri=@seri,Model=@model,Renk=@renk,Kilometre=@km,Yakıt=@yakit,Kira_Ücreti=@ücret,Durumu=@Durum where Plaka=@plaka";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            komut.Parameters.AddWithValue("@marka", cbxMarka.Text);
            komut.Parameters.AddWithValue("@seri", cbxSeri.Text);
            komut.Parameters.AddWithValue("@model", txtModel.Text);
            komut.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@km", txtKm.Text);
            komut.Parameters.AddWithValue("@yakit", cbxYakit.Text);
            komut.Parameters.AddWithValue("@ücret", txtUcret.Text);
            komut.Parameters.AddWithValue("@durum", cbxDurum.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Arac_Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbxMarka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbxSeri.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtModel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtRenk.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtKm.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cbxYakit.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtUcret.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cbxDurum.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AracListele_Load(object sender, EventArgs e)
        {
            Arac_Listele();
        }
    }
}
