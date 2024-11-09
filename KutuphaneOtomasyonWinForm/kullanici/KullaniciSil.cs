﻿using System;
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
    public partial class KullaniciSil : Form
    {
        public KullaniciSil()
        {
            InitializeComponent();
        }
        kutuphaneOtomasyonuEntities db =new kutuphaneOtomasyonuEntities();

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


        private void KullaniciSil_Load(object sender, EventArgs e)
        {
            Liste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenID=Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);//hangi satırdaysak onun seçmini yapar.
            var kullanici=db.kullanicilar.Where(x =>x.kullanici_id==secilenID).FirstOrDefault();
            db.kullanicilar.Remove(kullanici);
            db.SaveChanges();
            Liste();
        }
    }
}
