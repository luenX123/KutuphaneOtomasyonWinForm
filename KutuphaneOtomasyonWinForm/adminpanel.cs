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
            ekleKullanicibtn.Visible = false;
            guncelleKullanicibtn.Visible=false;
            silKullanicibtn.Visible=false;
            
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
    }
}
