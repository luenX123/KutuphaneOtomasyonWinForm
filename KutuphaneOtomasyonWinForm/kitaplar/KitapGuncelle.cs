using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm.kitaplar
{
    public partial class KitapGuncelle : Form
    {
        public KitapGuncelle()
        {
            InitializeComponent();
        }
        kutuphaneOtomasyonuEntities db = new kutuphaneOtomasyonuEntities();
        public void Liste()//method oluşturma
        {
            kutuphaneOtomasyonuEntities db = new kutuphaneOtomasyonuEntities();
            var kitaplar = db.kitaplarr.ToList();
            dataGridView1.DataSource = kitaplar.ToList();


            dataGridView1.Columns[1].HeaderText ="Kitap Adı" ;
            dataGridView1.Columns[2].HeaderText ="Yazar";
            dataGridView1.Columns[3].HeaderText ="Yayınevi";
            dataGridView1.Columns[4].HeaderText ="Kitap Basım Tarihi" ;
            dataGridView1.Columns[5].HeaderText ="Kitap Sayfası";
            dataGridView1.Columns[6].HeaderText ="Kitap Türü";
            

        }
        

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            adKitaptxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            yazarKitaptxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            yayineviKitaptxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            sayfaKitapNumeric.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[5].Value);
            tarihKitapDTP.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
            turKitaptxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenKitap =Convert.ToInt16( dataGridView1.CurrentRow.Cells[0].Value);
            var guncellenecekKitap=db.kitaplarr.Where(x =>x.kitap_id==secilenKitap).FirstOrDefault();

            guncellenecekKitap.kitap_ad=adKitaptxt.Text;
            guncellenecekKitap.kitap_yazar = yazarKitaptxt.Text;
            guncellenecekKitap.kitap_yayinevi=yayineviKitaptxt.Text;
            guncellenecekKitap.kitap_sayfasayisi=Convert.ToInt16( sayfaKitapNumeric.Value);
            guncellenecekKitap.kitap_basimtarihi=tarihKitapDTP.Value;
            guncellenecekKitap.kitap_turu=turKitaptxt.Text;
            db.SaveChanges();
            Liste();


            

        }

        private void KitapGuncelle_Load(object sender, EventArgs e)
        {
            Liste();
        }
    }
}
