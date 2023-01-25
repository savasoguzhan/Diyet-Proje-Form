using M_Proje.Class;
using M_Proje.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace M_Proje
{
    public partial class KullaniciBilgiDüzenle : Form
    {
        private readonly UygulamaDbContext cont;
        private readonly Kullanici kull;
        public KullaniciBilgiDüzenle(UygulamaDbContext db, Kullanici _kln=null)
        {
            InitializeComponent();
            cont = db;
            kull = _kln;
            lblUser.Text = cont.Kullanicilar.FirstOrDefault(x => x.UserName == kull.UserName).UserName.ToString();
            txtKAdSoyad.Text= cont.Kullanicilar.FirstOrDefault(x => x.UserName == kull.UserName).AdSoyad.ToString();
            txtKullaniciEId.Text= cont.Kullanicilar.FirstOrDefault(x => x.UserName == kull.UserName).EgitmenId.ToString();
            txtKYas.Text= cont.Kullanicilar.FirstOrDefault(x => x.UserName == kull.UserName).Yas.ToString();
            txtBoy.Text= cont.Kullanicilar.FirstOrDefault(x => x.UserName == kull.UserName).Boy.ToString();
            txtKilo.Text= cont.Kullanicilar.FirstOrDefault(x => x.UserName == kull.UserName).Kilo.ToString();
            var cinsiyet = cont.Kullanicilar.FirstOrDefault(x => x.UserName == kull.UserName).Cinsiyet.ToString();
            if (cinsiyet.ToLower().Trim() == "erkek")
            {
                rdoErkek.Checked= true;
            }
            else if(cinsiyet.ToLower().Trim()=="kadın")
            {
                rdoKadin.Checked= true;
            }

        }

        private void btnGuncel_Click(object sender, EventArgs e)
        {
            var guncellemeKullaniciID = cont.Kullanicilar.FirstOrDefault(x => x.UserName == kull.UserName).Id.ToString();
            var guncellemeKullanici = cont.Kullanicilar.Find(Convert.ToInt32(guncellemeKullaniciID));            
            guncellemeKullanici.AdSoyad = txtKAdSoyad.Text;
            guncellemeKullanici.EgitmenId = Convert.ToInt32(txtKullaniciEId.Text);
            guncellemeKullanici.Yas = Convert.ToInt32(txtKYas.Text);
            guncellemeKullanici.Boy = Convert.ToDouble(txtBoy.Text);
            guncellemeKullanici.Kilo = Convert.ToDouble(txtKilo.Text);
            if (rdoErkek.Checked)
            {
                guncellemeKullanici.Cinsiyet = "erkek";
            }
            else { guncellemeKullanici.Cinsiyet = "kadın"; }

            cont.SaveChanges();
            MessageBox.Show("Güncellendi");
        }
    }
}
