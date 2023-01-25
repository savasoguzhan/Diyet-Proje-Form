using M_Proje.Class;
using M_Proje.Context;
using Microsoft.EntityFrameworkCore;
using Proje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace M_Proje
{
    public partial class KullaniciForm : Form
    {
        private readonly UygulamaDbContext _db;
        private readonly Kullanici _kln;
        public List<Besin> besinlers = new List<Besin>();
        public static decimal GünlükBilgi=0 ;
        public static decimal AylıkBilgi=0 ;
        public static decimal HaftalıkBilgi=0 ;

        public KullaniciForm(UygulamaDbContext db, Kullanici kln = null)
        {
            _db = db;
            _kln = kln;
            InitializeComponent();
            var isim = _db.Kullanicilar.FirstOrDefault(x => x.UserName == _kln.UserName).AdSoyad.ToString();
            var yas = _db.Kullanicilar.FirstOrDefault(x => x.UserName == _kln.UserName).Yas.ToString();
            var kilo = _db.Kullanicilar.FirstOrDefault(x => x.UserName == _kln.UserName).Kilo.ToString();
            var boy = _db.Kullanicilar.FirstOrDefault(x => x.UserName == _kln.UserName).Boy.ToString();
            var Cinsiyet = _db.Kullanicilar.FirstOrDefault(x => x.UserName == _kln.UserName).Cinsiyet.ToString();

            lblKulanici.Text = $"HOŞGELDİNİZ {isim}";
            lstKullaniciBilgileri.Items.Add(isim);
            lstKullaniciBilgileri.Items.Add(yas);
            lstKullaniciBilgileri.Items.Add(kilo + " kg");
            lstKullaniciBilgileri.Items.Add(boy + " m");
            lstKullaniciBilgileri.Items.Add(Cinsiyet);

            double taban = Convert.ToDouble(boy) * Convert.ToDouble(boy);
            double bol = Convert.ToDouble(kilo);
            double sonuc = Math.Round(bol / taban, 2);
            lstKullaniciBilgileri.Items.Add("Vücut kitle indeksiniz: " + sonuc);


            dgvOgunler.DataSource = _db.Kullanicilar.Include(a => a.Ogunler).FirstOrDefault(x => x.UserName == _kln.UserName).Ogunler.ToList();
            string yorum;
            if (sonuc <= 18.5)
            {
                yorum = "Aşırı Zayıf";
            }
            else if (sonuc <= 24.9)
            {
                yorum = "Normal Fizik. ";
            }
            else if (sonuc <= 29.9)
            {
                yorum = "Hafif Kilolu";
            }
            else if (sonuc <= 39.9)
            {
                yorum = "Obez ";
            }
            else
                yorum = "Mobez ";



            lstKullaniciBilgileri.Items.Add(yorum);



        }

        private void güncelleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var frm = new KullaniciBilgiDüzenle(_db, _kln);
            frm.ShowDialog();
        }

        private void dgvOgunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvOgunler.SelectedRows.Count == 0)
                    dgvBesinler.DataSource = null;
                else
                {
                    var takip = (Ogun)dgvOgunler.SelectedRows[0].DataBoundItem;
                    _db.Entry(takip).Collection(x => x.Besinler).Load();
                    dgvBesinler.DataSource = takip.Besinler.ToList();
                }

            }
            catch (Exception ex) { MessageBox.Show("Hata" + ex.Message); }
        }



        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {

                var takip = (Besin)dgvBesinler.SelectedRows[0].DataBoundItem;
                _db.Entry(takip).GetDatabaseValues();
                takip.Miktar = Convert.ToDecimal(txtMiktar.Text);
                _db.SaveChanges();
                var ürün = _db.Besinler.Where(x => x.FoodName == takip.FoodName)/*.Select(
                        x => new
                        {
                            BesinID = x.Id,
                            BesinAdı = x.FoodName,
                            Kalorisi = x.Kalori,
                            Miktarı = x.Miktar,
                            Ogun = x.OgunId
                        })*/.ToList();
                besinlers.AddRange(ürün);
                dgvSecilenBesinler.DataSource = besinlers.ToList();

                decimal toplamKalori = 0m;
                foreach (DataGridViewRow item in dgvSecilenBesinler.Rows)
                {
                    toplamKalori += Convert.ToDecimal(item.Cells[2].Value) * Convert.ToDecimal(item.Cells[3].Value);
                }
                lblKalori.Text = toplamKalori.ToString() + " Kalori";



            }
            catch (Exception ex) { MessageBox.Show("Hata" + ex.Message); }
        }

        private void btnGunluk_Click(object sender, EventArgs e)
        {
            try
            {
                decimal toplamKalori = 0m;
                foreach (DataGridViewRow item in dgvSecilenBesinler.Rows)
                {
                    toplamKalori += Convert.ToDecimal(item.Cells[2].Value) * Convert.ToDecimal(item.Cells[3].Value);
                }
                GünlükBilgi = toplamKalori;
                RaporForm rpr = new RaporForm(_db,_kln);
                rpr.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata"+ex.Message);
            }
        }

        private void btnHaftalik_Click(object sender, EventArgs e)
        {
            try
            {
                decimal toplamKalori = 0m;
                foreach (DataGridViewRow item in dgvSecilenBesinler.Rows)
                {
                    toplamKalori += Convert.ToDecimal(item.Cells[2].Value) * Convert.ToDecimal(item.Cells[3].Value);
                }
                HaftalıkBilgi = toplamKalori*7;
                RaporForm rpr = new RaporForm(_db,_kln);
                rpr.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata" + ex.Message);
            }
        }

        private void btnAylik_Click(object sender, EventArgs e)
        {
            try
            {
                decimal toplamKalori = 0m;
                foreach (DataGridViewRow item in dgvSecilenBesinler.Rows)
                {
                    toplamKalori += Convert.ToDecimal(item.Cells[2].Value) * Convert.ToDecimal(item.Cells[3].Value);
                }
                AylıkBilgi = toplamKalori*30;
                RaporForm rpr = new RaporForm(_db,_kln);
                rpr.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata" + ex.Message);
            }
        }
    }
}
