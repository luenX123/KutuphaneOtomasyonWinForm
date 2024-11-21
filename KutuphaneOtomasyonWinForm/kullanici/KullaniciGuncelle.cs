using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm.kullanici
{
    public partial class KullaniciGuncelle : Form
    {
        public KullaniciGuncelle()
        {
            InitializeComponent();
        }

        kutuphaneOtomasyonuEntities db=new kutuphaneOtomasyonuEntities();
        public void Liste()//method oluşturma
        {
            kutuphaneOtomasyonuEntities db = new kutuphaneOtomasyonuEntities();
            var kullanicilar = db.kullanicilar.ToList();
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
        private void KullaniciGuncelle_Load(object sender, EventArgs e)
        {
            Liste();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kullaniciAdTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            kullaniciSoyadTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            kullaniciMailTxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            kullaniciTCTxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            kullaniciTelTxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            kullaniciCezaTxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();



            if (dataGridView1.CurrentRow.Cells[7].Value.ToString().Equals("E"))
            {
                radioButton1.Checked = true;
            }
            else
                radioButton2.Checked = true; 
            
                
           


        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            int secilenID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kullanici = db.kullanicilar.Where(x =>x.kullanici_id == secilenID).FirstOrDefault();

            kullanici.kullanici_ad = kullaniciAdTxt.Text;
            kullanici.kullanici_soyad = kullaniciSoyadTxt.Text;
            kullanici.kullanici_tc = kullaniciTCTxt.Text;
            kullanici.kullanici_tel = kullaniciTelTxt.Text;
            kullanici.kullanici_mail = kullaniciMailTxt.Text;
            kullanici.kullanici_ceza = Convert.ToDouble(kullaniciCezaTxt.Text);//Database de kullanici_ceza parametresini float olarak tanımladığımız için convert kullandım.



            if (radioButton1.Checked == true)
            {
                kullanici.kullanici_cinsiyet = "E";
            }
            else if (radioButton2.Checked == true)
            {
                kullanici.kullanici_cinsiyet = "K";
            }
            else
            {
                MessageBox.Show("Lütfen Cinsiyet Seçiniz!");
            }
            db.SaveChanges();
            Liste();

        }

        private void kullaniciCezaTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
