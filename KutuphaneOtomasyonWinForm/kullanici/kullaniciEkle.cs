﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm.kullanici
{
    public partial class kullaniciEkle : Form
    {
        public kullaniciEkle()
        {
            InitializeComponent();
        }

        kutuphaneOtomasyonuEntities db =new kutuphaneOtomasyonuEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            kullanicilar kullanicilar = new kullanicilar();
            kullanicilar.kullanici_ad = kullaniciAdTxt.Text;
            kullanicilar.kullanici_soyad = kullaniciSoyadTxt.Text;
            kullanicilar.kullanici_tc=kullaniciTCTxt.Text;
            kullanicilar.kullanici_tel=kullaniciTelTxt.Text;
            kullanicilar.kullanici_mail=kullaniciMailTxt.Text;
            kullanicilar.kullanici_ceza = Convert.ToDouble(kullaniciCezaTxt.Text);//Database de kullanici_ceza parametresini float olarak tanımladığımız için convert kullandım.



            if (radioButton1.Checked == true)
            {
                kullanicilar.kullanici_cinsiyet = "E";
            }
            else if (radioButton2.Checked == true)
            {
                kullanicilar.kullanici_cinsiyet = "K";
            }
            else
            {
                MessageBox.Show("Lütfen Cinsiyet Seçiniz!");
            }
            db.kullanicilar.Add(kullanicilar);
            db.SaveChanges();
            Liste();


        }
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
        private void kullaniciEkle_Load(object sender, EventArgs e)
        {
            Liste();
        }
    }
}
