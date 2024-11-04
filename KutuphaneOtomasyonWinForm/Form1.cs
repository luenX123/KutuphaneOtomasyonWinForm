using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm
{
    public partial class Form1 : Form
    {
        kutuphaneOtomasyonuEntities db =new kutuphaneOtomasyonuEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void personelGirisbtn_Click(object sender, EventArgs e)
        {
            string gelenAd=personelGiristxt.Text; 
            string gelenSifre=personelSifretxt.Text;


            //linq sorgusu
            var personel = db.personeller.Where(x =>x.personel_ad.Equals(gelenAd)&&x.personel_Sifre.Equals(gelenSifre)).FirstOrDefault();
            if (personel == null)
            {
                MessageBox.Show("Kullanıcı adı ve şifre hatalı");
            }
            else
            {
                MessageBox.Show("Başarılı");               
                adminpanel panel = new adminpanel();
                panel.Show();
                this.Hide();
            } 
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Çıkmak istediğinize emin misiniz?",
                "Çıkış Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes) 
            {
                Application.Exit();
            }
        }
    }
}
