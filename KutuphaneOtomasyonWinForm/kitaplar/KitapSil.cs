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

        public void Liste()//method oluşturma
        {
            kutuphaneOtomasyonuEntities db = new kutuphaneOtomasyonuEntities();
            var kitaplar = db.kitaplarr.ToList();
            dataGridView1.DataSource = kitaplar.ToList();

            dataGridView1.Columns[7].Visible = false;

            dataGridView1.Columns[1].HeaderText = "Kitap Adı";
            dataGridView1.Columns[2].HeaderText = "Yazar";
            dataGridView1.Columns[3].HeaderText = "Yayınevi";
            dataGridView1.Columns[4].HeaderText = "Kitap Basım Tarihi";
            dataGridView1.Columns[5].HeaderText = "Kitap Sayfası";
            dataGridView1.Columns[6].HeaderText = "Kitap Türü";

        }
        private void KitapSil_Load(object sender, EventArgs e)
        {
            Liste();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.CurrentRow != null)
            {               
                int secilenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var silinenKitap = db.kitaplarr.FirstOrDefault(x => x.kitap_id == secilenID);

                if (silinenKitap != null)
                {
                    db.kitaplarr.Remove(silinenKitap);
                    db.SaveChanges();
                    Liste();
                    MessageBox.Show("Kitap başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Silmek için geçerli bir kitap bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
