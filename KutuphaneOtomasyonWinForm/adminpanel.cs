using KutuphaneOtomasyonWinForm.kayit;
using KutuphaneOtomasyonWinForm.kitaplar;
using KutuphaneOtomasyonWinForm.kullanici;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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

        private KullaniciFormListe klisteform; 
        private void Kullanicibtn_Click(object sender, EventArgs e)
        {
            
            if (ekleKullanicibtn.Visible == false) 
            {
                ekleKullanicibtn.Visible = true;
                guncelleKullanicibtn.Visible = true;
                silKullanicibtn.Visible = true;

                klisteform= new KullaniciFormListe();
                klisteform.MdiParent = this;
                klisteform.Show();
            }
            else
            {
                ekleKullanicibtn.Visible = false;
                guncelleKullanicibtn.Visible = false;
                silKullanicibtn.Visible = false;
                klisteform.Close();
            }
            

            




        }
        private kullaniciEkle ekleform;
        private bool kullaniciEkleDurum=false;
        private void ekleKullanicibtn_Click(object sender, EventArgs e)
        {   if (kullaniciEkleDurum == false)
            {
                ekleform = new kullaniciEkle();
                ekleform.MdiParent= this;
                ekleform.Show();
                kullaniciEkleDurum=true;

            }
            else
            {
                ekleform.Close();
                kullaniciEkleDurum = false;
            }
        }
        private KullaniciSil kullaniciSil;
        private bool kullaniciSilDurum = false;
        private void silKullanicibtn_Click(object sender, EventArgs e)
        {
            if (kullaniciSilDurum == false)
            {   
                kullaniciSil = new KullaniciSil();
                kullaniciSil.MdiParent = this;
                kullaniciSil.Show();
                kullaniciSilDurum = true;

            }
            else
            {
                kullaniciSil.Close();
                kullaniciSilDurum=false;
            }

            
        }


        private KullaniciGuncelle kGuncelle;
        private bool KullaniciGuncelleDurum = false;
        private void guncelleKullanicibtn_Click(object sender, EventArgs e)
        {
            if (KullaniciGuncelleDurum == false)
            {

                kGuncelle = new KullaniciGuncelle();
                kGuncelle.MdiParent = this;
                kGuncelle.Show();
                KullaniciGuncelleDurum=true;
            }
            else
            {
                kGuncelle.Close();
                KullaniciGuncelleDurum=false;
            }
        }
        
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        private kitapliste kliste;
        private void kitapbtn_Click(object sender, EventArgs e)
        {
            if (kitapEkleBtn.Visible == false)
            {
                kitapEkleBtn.Visible = true;
                kitapGuncellebtn.Visible = true;
                kitapSilbtn.Visible = true;
                kliste= new kitapliste();
                kliste.MdiParent = this;
                kliste.Show();
            }
            else
            {
                kitapEkleBtn.Visible= false;
                kitapGuncellebtn.Visible= false;
                kitapSilbtn.Visible= false;
                kliste.Close();
            }

            
            
        }
        private kitaplarEkle kEkle;
        private bool ekleKitapDurum = false;
        private void kitapEkleBtn_Click(object sender, EventArgs e)
        {if (ekleKitapDurum == false)
            {               
                kEkle= new kitaplarEkle();
                kEkle.MdiParent = this;
                kEkle.Show();
                ekleKitapDurum= true;
            }
            else
            {
                kEkle.Close();
                ekleKitapDurum= false; 
            }
        
            
        }
        private KitapSil kSil;
        private bool kitapSilDurum= false;
        private void kitapSilbtn_Click(object sender, EventArgs e)
        {
            if (kitapSilDurum == false)
            {
                kSil = new KitapSil();
                kSil.MdiParent = this;
                kSil.Show();
                kitapSilDurum= true;
            }
            else
            {
                kSil.Close();
                kitapSilDurum = false;
            }
            
        }
        private KitapGuncelle kitapGuncelle;
        private bool kitapGuncelleDurum = false;
        private void kitapGuncellebtn_Click(object sender, EventArgs e)
        {   if(kitapGuncelleDurum == false)
            {
                kitapGuncelle = new KitapGuncelle();
                kitapGuncelle.MdiParent=this;
                kitapGuncelle.Show();
                kitapGuncelleDurum= true;
            }
            else
            {
                kitapGuncelle.Close();
                kitapGuncelleDurum= false; 
            }
            

            
        }

        private void oduncVerbtn_Click(object sender, EventArgs e)
        {
            oduncVer oduncVer = new oduncVer();
            oduncVer.MdiParent = this;
            oduncVer.Show();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeriAl geri=new GeriAl();
            geri.MdiParent = this;
            geri.Show();
        }

        private void kullaniciBilgiPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
