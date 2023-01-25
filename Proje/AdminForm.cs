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

namespace M_Proje
{
    public partial class AdminForm : Form
    {
        UygulamaDbContext _db;
        public AdminForm()
        {
            InitializeComponent();
            _db = new UygulamaDbContext();
            rdoErkek.Checked = true;
        }
        private void Temizlik()
        {
            txtBAd.Text = "";
            txtBId.Text = "";
            txtBKalori.Text = "";
            txtBMiktar.Text = "";
            txtBOgunId.Text = "";
            txtBoy.Text = "";
            txtEAd.Text = "";
            txtEId.Text = "";
            txtESoyad.Text = "";
            txtKAd.Text = "";
            txtKAdSoyad.Text = "";
            txtKId.Text = "";
            txtKilo.Text = "";
            txtKullaniciEId.Text = "";
            txtKYas.Text = "";
            txtSifre.Text = "";            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanici kullanici = new Kullanici();
                kullanici.UserName = txtKAd.Text;
                kullanici.AdSoyad = txtKAdSoyad.Text;
                kullanici.Yas = Convert.ToInt32(txtKYas.Text);
                kullanici.Password = txtSifre.Text;
                kullanici.EgitmenId = Convert.ToInt32(txtKullaniciEId.Text);
                kullanici.Boy = Convert.ToDouble(txtBoy.Text);
                kullanici.Kilo = Convert.ToDouble(txtKilo.Text);
                if (rdoErkek.Checked)
                {
                    kullanici.Cinsiyet = "erkek";
                }
                else { kullanici.Cinsiyet = "kadın"; }

                _db.Kullanicilar.Add(kullanici);
                _db.SaveChanges();
                MessageBox.Show("Ekleme yapıldı.");
                dgvListe.DataSource = _db.Kullanicilar.ToList();
                Temizlik();
            }
            catch (Exception ex) { MessageBox.Show("Hata" + ex.Message); }
        }

        private void btnEekle_Click(object sender, EventArgs e)
        {
            try
            {
                Egitmen egitmen = new Egitmen();
                egitmen.Adı = txtEAd.Text;
                egitmen.Soyad = txtESoyad.Text;

                _db.Egitmenler.Add(egitmen);
                _db.SaveChanges();
                MessageBox.Show("Ekleme yapıldı");
                dgvListe.DataSource = _db.Kullanicilar.ToList();
                Temizlik();
            }
            catch (Exception ex) { MessageBox.Show("Hata" + ex.Message); }
        }

        private void btnKaldır_Click(object sender, EventArgs e)
        {
            try
            {
                var silinecekKullanici = _db.Kullanicilar.Find(Convert.ToInt32(txtKId.Text));
                _db.Kullanicilar.Remove(silinecekKullanici);
                _db.SaveChanges();
                MessageBox.Show("Silinmiştir");
                dgvListe.DataSource = _db.Kullanicilar.ToList();
                Temizlik();
            }
            catch (Exception ex) { MessageBox.Show("Hata" + ex.Message); }
        }

        private void btnGuncel_Click(object sender, EventArgs e)
        {
            try
            {
                var guncellemeKullanici = _db.Kullanicilar.Find(Convert.ToInt32(txtKId.Text));
                guncellemeKullanici.UserName = txtKAd.Text;
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

                _db.SaveChanges();
                MessageBox.Show("Güncellendi");
                dgvListe.DataSource = _db.Kullanicilar.ToList();
                Temizlik();
            }
            catch (Exception ex) { MessageBox.Show("Hata" + ex.Message); }

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvListe.DataSource = _db.Kullanicilar.ToList();
        }

        private void btnEkaldır_Click(object sender, EventArgs e)
        {
            try
            {
                var silinecekEgitmen = _db.Egitmenler.Find(Convert.ToInt32(txtEId.Text));
                _db.Egitmenler.Remove(silinecekEgitmen);
                _db.SaveChanges();
                MessageBox.Show("Kaldırıldı.");
                dgvListe.DataSource = _db.Egitmenler.ToList();
                Temizlik();
            }
            catch (Exception ex) { MessageBox.Show("Hata" + ex.Message); }
        }

        private void btnEGuncel_Click(object sender, EventArgs e)
        {
            try
            {
                var guncellemeEgitmen = _db.Egitmenler.Find(Convert.ToInt32(txtEId.Text));
                guncellemeEgitmen.Adı = txtEAd.Text;
                guncellemeEgitmen.Soyad = txtESoyad.Text;
                _db.SaveChanges();
                MessageBox.Show("Güncellendi.");
                Temizlik();
            }
            catch (Exception ex) { MessageBox.Show("Hata" + ex.Message); }
        }

        private void btnEListe_Click(object sender, EventArgs e)
        {
            dgvListe.DataSource = _db.Egitmenler.ToList();
        }

        private void btnBekle_Click(object sender, EventArgs e)
        {            
            try
            {
                if (!(_db.Besinler.Any(x => x.FoodName == txtBAd.Text)))
                {
                    Besin besin = new Besin();
                    besin.FoodName = txtBAd.Text;
                    besin.Kalori = Convert.ToDecimal(txtBKalori.Text);
                    besin.Miktar = Convert.ToDecimal(txtBMiktar.Text);
                    besin.OgunId = Convert.ToInt32(txtBOgunId.Text);
                    _db.Besinler.Add(besin);
                    _db.SaveChanges();
                    
                    MessageBox.Show("Ekleme yapıldı.");
                    dgvListe.DataSource = _db.Besinler.ToList();
                    Temizlik();
                }
                else
                {
                    MessageBox.Show("Hata!! Bu besin daha önce eklenmiştir");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
        }

        private void btnBKaldır_Click(object sender, EventArgs e)
        {
            try
            {
                var silinecekBesin = _db.Besinler.Find(Convert.ToInt32(txtBId.Text));
                _db.Besinler.Remove(silinecekBesin);
                _db.SaveChanges();
                MessageBox.Show("Kaldırıldı.");
                dgvListe.DataSource = _db.Besinler.ToList();
                Temizlik();
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Hata!"+ex.Message);
            }
        }

        private void btnBGuncel_Click(object sender, EventArgs e)
        {
            try
            {
                var guncellecekBesin = _db.Besinler.Find(Convert.ToInt32(txtBId.Text));
                guncellecekBesin.FoodName = txtBAd.Text;
                guncellecekBesin.Kalori = Convert.ToDecimal(txtBKalori.Text);
                guncellecekBesin.Miktar = Convert.ToDecimal(txtBMiktar.Text);
                guncellecekBesin.OgunId = Convert.ToInt32(txtBOgunId.Text);

                _db.Besinler.Add(guncellecekBesin);
                _db.SaveChanges();
                MessageBox.Show("Güncellendi");
                dgvListe.DataSource = _db.Besinler.ToList();
                Temizlik();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata"+ex.Message);
            }
        }

        private void btnBListele_Click(object sender, EventArgs e)
        {
            dgvListe.DataSource = _db.Besinler.ToList();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
