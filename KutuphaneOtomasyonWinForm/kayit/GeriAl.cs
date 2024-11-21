using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm.kayit
{
    public partial class GeriAl : Form
    {
        public GeriAl()
        {
            InitializeComponent();
        }
        kutuphaneOtomasyonuEntities db =new kutuphaneOtomasyonuEntities();

        public void KayitDurumliste()
        {
            
            
            var kayitlar = db.kayitlar.Where(x => x.kayit_durum == false).ToList();
            dataGridView1.DataSource = kayitlar.ToList();

            
            

            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;


        }
        private void GeriAl_Load(object sender, EventArgs e)
        {
            KayitDurumliste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenKayit=Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var kayit=db.kayitlar.Where(x =>x.kayit_id == secilenKayit).FirstOrDefault();
            kayit.kayit_durum=true;
            //liste tazele
            db.SaveChanges();
            KayitDurumliste();
        }
    }
}
