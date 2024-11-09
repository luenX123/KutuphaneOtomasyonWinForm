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
    public partial class kitapliste : Form
    {
        public kitapliste()
        {
            InitializeComponent();
        }
        kutuphaneOtomasyonuEntities db=new kutuphaneOtomasyonuEntities();

        private void kitapliste_Load(object sender, EventArgs e)
        {
            var kitaplar=db.kitaplarr.ToList();
            dataGridView1.DataSource = kitaplar.ToList();

            dataGridView1.Columns[7].Visible = false;


            dataGridView1.Columns[1].HeaderText = "Kitap Adı";
            dataGridView1.Columns[2].HeaderText = "Yazar";
            dataGridView1.Columns[3].HeaderText = "Yayınevi";
            dataGridView1.Columns[4].HeaderText = "Kitap Basım Tarihi";
            dataGridView1.Columns[5].HeaderText = "Kitap Sayfası";
            dataGridView1.Columns[6].HeaderText = "Kitap Türü";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
