using KutuphaneOtomasyonWinForm.kayit;
using KutuphaneOtomasyonWinForm.kitaplar;
using KutuphaneOtomasyonWinForm.kullanici;
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
    public partial class adminpanel : Form
    {
        public adminpanel()
        {
            InitializeComponent();
        }


        kutuphaneOtomasyonuEntities db=new kutuphaneOtomasyonuEntities();
        private void adminpanel_Load(object sender, EventArgs e)
        {
            //kullanıcı butonları girişte kapalı (ekle-güncelle-sil)
            ekleKullanicibtn.Visible = false;
            guncelleKullanicibtn.Visible=false;
            silKullanicibtn.Visible=false;

            //kitaplar butonları girişte kapalı.
            kitapEkleBtn.Visible=false;
            kitapGuncellebtn.Visible=false;
            kitapSilbtn.Visible=false;
            
        }

        //kullanıcı butonuna bastığımızda ekle,sil,güncelle butonlarının açılıp kapanması
        private void Kullanicibtn_Click(object sender, EventArgs e)
        {
            if (ekleKullanicibtn.Visible == false) 
            {
                ekleKullanicibtn.Visible = true;
                guncelleKullanicibtn.Visible = true;
                silKullanicibtn.Visible = true;
            }
            else
            {
                ekleKullanicibtn.Visible = false;
                guncelleKullanicibtn.Visible = false;
                silKullanicibtn.Visible = false;
            }
            KullaniciFormListe klisteform= new KullaniciFormListe();
            klisteform.MdiParent = this;
            klisteform.Show();

            




        }

        private void ekleKullanicibtn_Click(object sender, EventArgs e)
        {
            kullaniciEkle ekleform= new kullaniciEkle();
            ekleform.MdiParent= this;
            ekleform.Show();
        }

        private void silKullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciSil kSil = new KullaniciSil();
            kSil.MdiParent = this;
            kSil.Show();
        }

        private void guncelleKullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciGuncelle kGuncelle = new KullaniciGuncelle();
            kGuncelle.MdiParent = this;
            kGuncelle.Show();
        }

        private void kitapbtn_Click(object sender, EventArgs e)
        {
            if (kitapEkleBtn.Visible == false)
            {
                kitapEkleBtn.Visible = true;
                kitapGuncellebtn.Visible = true;
                kitapSilbtn.Visible = true;
            }
            else
            {
                kitapEkleBtn.Visible= false;
                kitapGuncellebtn.Visible= false;
                kitapSilbtn.Visible= false;
            }

            kitapliste kliste = new kitapliste();
            kliste.MdiParent=this;
            kliste.Show();
        }

        private void kitapEkleBtn_Click(object sender, EventArgs e)
        {
            kitaplarEkle kEkle = new kitaplarEkle();
            kEkle.MdiParent = this;
            kEkle.Show();
        }

        private void kitapSilbtn_Click(object sender, EventArgs e)
        {
            KitapSil kSil = new KitapSil();
            kSil.MdiParent = this;
            kSil.Show();
        }

        private void kitapGuncellebtn_Click(object sender, EventArgs e)
        {
            KitapGuncelle kGuncel = new KitapGuncelle();
            kGuncel.MdiParent=this;
            kGuncel.Show();
            
        }

        private void oduncVerbtn_Click(object sender, EventArgs e)
        {
            oduncVer oduncVer = new oduncVer();
            oduncVer.MdiParent = this;
            oduncVer.Show();
        }
    }
}
