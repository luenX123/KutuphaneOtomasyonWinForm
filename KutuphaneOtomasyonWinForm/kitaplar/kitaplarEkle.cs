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
    public partial class kitaplarEkle : Form
    {
        public kitaplarEkle()
        {
            InitializeComponent();
        }

        kutuphaneOtomasyonuEntities db=new kutuphaneOtomasyonuEntities();
        private void kitaplarEkle_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kitaplarr kitaplarr = new kitaplarr();
            kitaplarr.kitap_ad =adKitaptxt.Text; 
            kitaplarr.kitap_yazar =yazarKitaptxt.Text;
            kitaplarr.kitap_yayinevi=yayineviKitaptxt.Text;
            kitaplarr.kitap_sayfasayisi = Convert.ToInt16(numericUpDown1.Value);
            kitaplarr.kitap_basimtarihi =tarihKitapDTP.Value;
            kitaplarr.kitap_turu=turKitaptxt.Text;

            db.kitaplarr.Add(kitaplarr);
            db.SaveChanges();


            var kliste= db.kitaplarr.ToList();
            dataGridView1.DataSource = kliste.ToList();


        }
    }
}
