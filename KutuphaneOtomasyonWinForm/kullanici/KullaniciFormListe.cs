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
        }
        private void KullaniciFormListe_Load(object sender, EventArgs e)
        {
          Liste();
        }
    }
}
