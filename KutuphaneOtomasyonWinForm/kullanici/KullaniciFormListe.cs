using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm
{
    public partial class KullaniciFormListe : Form
    {
        public KullaniciFormListe()
        {
            InitializeComponent();
        }
        public void Liste()//method oluşturma
        {
            kutuphaneOtomasyonuEntities db =new kutuphaneOtomasyonuEntities();
            var kullanicilar=db.kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();

            dataGridView1.Columns[8].Visible = false;


            dataGridView1.Columns[1].HeaderText = "Kullanıcı Ad";
            dataGridView1.Columns[2].HeaderText = "Kullanıcı Soyad";
            dataGridView1.Columns[3].HeaderText = "TC kimlik";
            dataGridView1.Columns[4].HeaderText = "Telefon Numarası";
            dataGridView1.Columns[5].HeaderText = "Kullanıcı E-mail";
            dataGridView1.Columns[6].HeaderText = "Ceza Tutarı (TL)";
            dataGridView1.Columns[7].HeaderText = "Kullanıcı Cinsiyet";
        }
        private void KullaniciFormListe_Load(object sender, EventArgs e)
        {
          Liste();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
