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

namespace KutuphaneOtomasyonWinForm.kayit
{
    public partial class oduncVer : Form
    {
        public oduncVer()
        {
            InitializeComponent();
        }
        kutuphaneOtomasyonuEntities db = new kutuphaneOtomasyonuEntities();

        public void Liste()//method oluşturma
        {

            

            //listeleme methodu yaptık (Kayıtları)
            kutuphaneOtomasyonuEntities db = new kutuphaneOtomasyonuEntities();
            var kayitList = db.kayitlar.ToList();
            dataGridView1.DataSource = kayitList.ToList();

            //istenmeyen kolonları gizledik
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            //kolon adlarını düzenledik
            dataGridView1.Columns[1].HeaderText = "Kullanıcı";
            dataGridView1.Columns[2].HeaderText = "Kitap Adı";
            dataGridView1.Columns[3].HeaderText = "Alış Tarihi";
            dataGridView1.Columns[4].HeaderText = "Teslim Tarihi";
            dataGridView1.Columns[5].HeaderText = "Teslim Durumu";

            var kitaplarlist =db.kitaplarr.ToList();
            dataGridView2.DataSource = kitaplarlist.ToList();




        }

        private void oduncVer_Load(object sender, EventArgs e)
        {
            Liste();

        }

        //NOT:isim soyisim ile aramada yapılacak aynı olan soyadları ve adları sıralama öğrenilecek.
        private void button1_Click(object sender, EventArgs e)
        {
            string secilentc =TcBultxt.Text;
            var kullaniciVarmi = db.kullanicilar.Where(x => x.kullanici_tc == secilentc).FirstOrDefault();


            if (kullaniciVarmi != null)
                label2.Text = kullaniciVarmi.kullanici_ad + " " + kullaniciVarmi.kullanici_soyad;
            else
                label2.Text = "Kullanıcı Bulunumadı!";

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string gelenAD=KitapBultTxt.Text;
            var bulunanKitaplar=db.kitaplarr.Where(x =>x.kitap_ad.Contains(gelenAD)).ToList();
            dataGridView2.DataSource= bulunanKitaplar.ToList();
        }
    }
}