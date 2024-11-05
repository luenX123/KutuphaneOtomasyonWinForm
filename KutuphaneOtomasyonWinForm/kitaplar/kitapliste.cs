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

        }
    }
}
