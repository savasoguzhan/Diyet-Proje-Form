using M_Proje.Class;
using M_Proje.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace M_Proje
{
    public partial class KayitForm : Form
    {
        UygulamaDbContext _db;
        public KayitForm()
        {
            InitializeComponent();
            _db = new UygulamaDbContext();
            cmbEgitmen.DataSource = _db.Egitmenler.ToList();
            rdoErkek.Checked = true;
            cmbEgitmen.Text = "Seçiniz";
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {

            try
            {

                if (_db.Kullanicilar.Any(x => x.UserName == txtUser.Text))
                {
                    MessageBox.Show("Bu kullanıcı Adı daha önce alınmıştır.Lütfen yeni bir Kullanıcı Adı deneyiniz");
                    Temizlik();
                    return;
                }
                else
                {
                    if (!(txtUser.Text.ToLower().Contains("@hotmail.com")) && !(txtUser.Text.ToLower().Contains("@gmail.com")) && !(txtUser.Text.ToLower().Contains("@bilgeadam.com")))
                    {
                        MessageBox.Show("Yanlıs formatta giriş yapıldı lütfen mail adresinizi kontrol ediniz");
                        Temizlik();
                        return;
                    }
                    else
                    {
                        Kullanici kullanici = new Kullanici();
                        kullanici.UserName = txtUser.Text;
                        kullanici.AdSoyad = txtAdSoyad.Text;
                        kullanici.Yas = Convert.ToInt32(txtYas.Text);
                        kullanici.EgitmenId = Convert.ToInt32(cmbEgitmen.SelectedIndex + 1);
                        string ySifre = sha256_hash(txtSifre.Text);
                        kullanici.Password = ySifre;
                        if (rdoErkek.Checked)
                        {
                            kullanici.Cinsiyet = "erkek";
                        }
                        else if (rdoKadin.Checked)
                        { kullanici.Cinsiyet = "kadın"; }

                        _db.Kullanicilar.Add(kullanici);
                        _db.SaveChanges();
                        lstKayit.Items.Add(kullanici.UserName);
                        lstKayit.Items.Add(kullanici.AdSoyad);
                        lstKayit.Items.Add(kullanici.Cinsiyet);
                        lstKayit.Items.Add(kullanici.Yas);                                             
                        MessageBox.Show("eklendi");
                        Temizlik();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata!" + ex.Message);
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sifre = txtSifre.Text;

                if (sifre.Length <= 6 || sifre.All(k => Char.IsDigit(k)) || sifre.All(k => Char.IsLetter(k)))
                {
                    lblZorluk.Text = "DÜŞÜK";
                    lblZorluk.ForeColor = Color.Red;

                }
                else if (sifre.Length == 7 && sifre.Any(k => Char.IsDigit(k)) && sifre.Any(k => Char.IsLetter(k)))
                {
                    lblZorluk.Text = "ORTA";
                    lblZorluk.ForeColor = Color.Orange;
                }
                else if (sifre.Length >= 8 && sifre.Any(k => Char.IsDigit(k)) && sifre.Any(k => Char.IsLetter(k)))
                {
                    lblZorluk.Text = "YÜKSEK";
                    lblZorluk.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata!" + ex.Message);
            }
        }
        private void Temizlik()
        {
            txtUser.Text = "";
            txtYas.Text = "";
            txtSifre.Text = "";
            txtAdSoyad.Text = "";
            cmbEgitmen.Text = "Seçiniz";
            rdoErkek.Checked = true;
            lstKayit.Items.Clear();
        }
        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            { return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2"))); }
        }
    }
}
