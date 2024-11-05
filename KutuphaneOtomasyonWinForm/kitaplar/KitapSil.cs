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
    public partial class KitapSil: Form
    {
        public KitapSil()
        {
            InitializeComponent();
        }
        kutuphaneOtomasyonuEntities db =new kutuphaneOtomasyonuEntities();
        private void KitapSil_Load(object sender, EventArgs e)
        {
            var kaynaklar = db.kitaplarr.ToList ();
            dataGridView1.DataSource = kaynaklar.ToList ();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenID = Convert.ToInt16( dataGridView1.CurrentRow.Cells [0].Value);
            var silinenKitaplar=db.kitaplarr.Where(x =>x.kitap_id == secilenID).FirstOrDefault();
            db.kitaplarr.Remove(silinenKitaplar);
            db.SaveChanges();


            var kaynaklar = db.kitaplarr.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();

        }
    }
}
