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

namespace KutuphaneOtomasyonWinForm.kayit
{
    public partial class oduncVer : Form
    {
        public oduncVer()
        {
            InitializeComponent();
        }
        kutuphaneOtomasyonuEntities db = new kutuphaneOtomasyonuEntities();

        public void Liste()//method oluşturma
        {
            var kayitList = from kayit in db.kayitlar select new { kayit.kayit_id, kayit.kullanicilar.kullanici_ad, kayit.kullanicilar.kullanici_soyad, kayit.kullanicilar.kullanici_mail, kayit.kullanicilar.kullanici_adres, kayit.kitaplarr.kitap_ad, kayit.alis_tarih, kayit.son_tarih, kayit.kayit_durum, kayit.kullanicilar.kullanici_ceza };
            dataGridView1.DataSource = kayitList.ToList();

            ////listeleme methodu yaptık (Kayıtları)
            //kutuphaneOtomasyonuEntities db = new kutuphaneOtomasyonuEntities();
            //var kayitList = db.kayitlar.ToList();
            //dataGridView1.DataSource = kayitList.ToList();


            ////kolon adlarını düzenledik
            dataGridView1.Columns[0].HeaderText = "Kayıt ID";
            dataGridView1.Columns[1].HeaderText = "Kullanıcı Adı";
            dataGridView1.Columns[2].HeaderText = "Kullanıcı Soyad";
            dataGridView1.Columns[3].HeaderText = "Kullanıcı Mail";
            dataGridView1.Columns[4].HeaderText = "Kitap Adı";
            dataGridView1.Columns[5].HeaderText = "Alış Tarihi";
            dataGridView1.Columns[6].HeaderText = "Son Tarih";
            dataGridView1.Columns[7].HeaderText = "Teslim Durumu";
            dataGridView1.Columns[8].HeaderText = "Kullanıcı Ceza Tutarı";
            dataGridView1.Columns[9].HeaderText = "Kullanıcı adres";

            var kitaplarlist = db.kitaplarr.ToList();
            dataGridView2.DataSource = kitaplarlist.ToList();




        }

        private void oduncVer_Load(object sender, EventArgs e)
        {
            Liste();

        }

        //NOT:isim soyisim ile aramada yapılacak aynı olan soyadları ve adları sıralama öğrenilecek.
        private void button1_Click(object sender, EventArgs e)
        {
            string secilentc = TcBultxt.Text;
            var kullaniciVarmi = db.kullanicilar.Where(x => x.kullanici_tc == secilentc).FirstOrDefault();


            if (kullaniciVarmi != null)
                label2.Text = kullaniciVarmi.kullanici_ad + " " + kullaniciVarmi.kullanici_soyad + ",  TC: " + kullaniciVarmi.kullanici_tc;
            else
                label2.Text = "Kullanıcı Bulunumadı!";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string gelenAD = KitapBultTxt.Text;
            var bulunanKitaplar = db.kitaplarr.Where(x => x.kitap_ad.Contains(gelenAD)).ToList();
            dataGridView2.DataSource = bulunanKitaplar.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kişiyi aldık
            string secilenKisiTC = TcBultxt.Text;
            var secilenKisi = db.kullanicilar.Where(x => x.kullanici_tc.Equals(secilenKisiTC)).FirstOrDefault();


            //kitabı aldık
            int secilenKitapId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            var secilenKitap = db.kitaplarr.Where(x => x.kitap_id == secilenKitapId).FirstOrDefault();

            if (secilenKitap != null)
            {
                label4.Text = $"{secilenKitap.kitap_ad} - Kitap'ı Ödünç Verildi!";// $ işareti C# dilinde string interpolasyonu yapmak için kullanılır.değişken veya ifade yazarak onları metne ekler
            }
            else
            {
                label4.Text = "Kitap bulunamadı.";
            }


            kayitlar yeniKayit = new kayitlar();
            yeniKayit.kitap_id = secilenKitap.kitap_id;
            yeniKayit.kullanici_id = secilenKisi.kullanici_id;
            yeniKayit.alis_tarih = DateTime.Today;
            yeniKayit.son_tarih = DateTime.Today.AddDays(30);
            yeniKayit.kayit_durum = false;
            db.kayitlar.Add(yeniKayit);
            db.SaveChanges();

            Liste();//yeniden kayıtlar listesini düzenler





        }

        private void oduncVerSilBtn_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.CurrentRow != null)
            {
                int secilenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var kayitlar = db.kayitlar.Where(x => x.kayit_id == secilenID).FirstOrDefault();

                
                if (kayitlar != null)
                {
                    db.kayitlar.Remove(kayitlar);
                    db.SaveChanges();
                    Liste(); 
                    MessageBox.Show("Kayıt başarıyla silindi.");
                }
                else
                {
                    MessageBox.Show("Silmek için geçerli bir kayıt bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
