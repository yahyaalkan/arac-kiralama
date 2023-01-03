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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }


        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle musterieklefrm = new MusteriEkle();
            musterieklefrm.ShowDialog();
        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            MusteriListele musteriListelefrm = new MusteriListele();
            musteriListelefrm.ShowDialog();
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            AracEkle araceklefrm = new AracEkle();
            araceklefrm.ShowDialog();
        }

        private void btnAracListele_Click(object sender, EventArgs e)
        {
            AracListele araclistelefrm = new AracListele();
            araclistelefrm.ShowDialog();
        }

        private void btnSözlesme_Click(object sender, EventArgs e)
        {
            Sozlesme sözlesmefrm = new Sozlesme();
            sözlesmefrm.ShowDialog();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            Satis satisfrm = new Satis();
            satisfrm.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
