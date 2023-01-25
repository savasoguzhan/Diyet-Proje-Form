using M_Proje.Class;
using M_Proje.Context;
using Microsoft.EntityFrameworkCore;
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
    public partial class EgitmenForm : Form
    {
        UygulamaDbContext _db;
        public EgitmenForm()
        {
            InitializeComponent();
            _db = new UygulamaDbContext();
            dgvTakip.DataSource = _db.Kullanicilar.ToList();
            //KullanicilarOgunleriyle();
        }
        private void Temizlik()
        {
            txtBAd.Text = "";
            txtBId.Text = "";
            txtBKalori.Text = "";
            txtBMiktar.Text = "";
            txtBOgunId.Text = "";
            txtKullanici.Text = "";
        }
        private void btnBekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKullanici.Text != "" && txtBOgunId.Text != "")
                {
                    var ogun = (Ogun)_db.Ogunler.FirstOrDefault(x => x.Id == Convert.ToInt32(txtBOgunId.Text));
                    var kullanici = (Kullanici)_db.Kullanicilar.FirstOrDefault(x => x.Id == Convert.ToInt32(txtKullanici.Text));
                    kullanici.Ogunler.Add(ogun);
                    _db.SaveChanges();
                    MessageBox.Show("Öğün Eklendi");
                }
                else
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
                        Temizlik();
                        MessageBox.Show("Ekleme yapıldı.");
                        dgvBesinler.DataSource = _db.Besinler.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Hata!! Bu besin daha önce eklenmiştir");
                    }
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
                Temizlik();
                MessageBox.Show("Kaldırıldı.");
                dgvTakip.DataSource = _db.Besinler.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message);
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
                _db.SaveChanges();
                Temizlik();
                MessageBox.Show("Güncellendi");
                dgvTakip.DataSource = _db.Besinler.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
        }

        private void btnBListele_Click(object sender, EventArgs e)
        {
            dgvBesinler.DataSource = _db.Besinler.ToList();
            Temizlik();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            try
            {
                dgvTakip.ClearSelection();
                #region Kullanıcı ıd ye göre getirme
                //var kullanici = (Kullanici)_db.Kullanicilar.FirstOrDefault(x => x.UserName == txtTakip.Text);
                //_db.Entry(kullanici).Collection(x => x.Ogunler).Load();
                //dgvTakip.DataSource = kullanici.Ogunler.ToList(); 
                #endregion
                KullanicilarOgunleriyle();
                Temizlik();
            }
            catch (Exception ex)
            {               
                MessageBox.Show("Hata" + ex.Message);               
            }
           
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                decimal toplamKalori = 0m;
                foreach (DataGridViewRow item in dgvBesinler.Rows)
                {
                    toplamKalori += Convert.ToDecimal(item.Cells[2].Value) * Convert.ToDecimal(item.Cells[3].Value);
                }
                lblKalori.Text = toplamKalori.ToString() + " Kalori";
                Temizlik();
            }
            catch (Exception ex) { MessageBox.Show("Hata" + ex.Message); }
        }
        private void KullanicilarOgunleriyle()
        {
            dgvTakip.DataSource = _db.Kullanicilar.Select(
                k => new
                {
                    Id = k.Id,
                    User = k.UserName,
                    Ogunler = string.Join(", ", k.Ogunler.Select(o => o.Zaman))
                }
                ).ToList();
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
                Temizlik();
            }
            catch (Exception ex) { MessageBox.Show("Hata" + ex.Message); }
        }

        private void dgvTakip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvTakip.SelectedRows.Count == 0)
                    dgvOgunler.DataSource = null;

                else
                {
                    var takip = (Kullanici)dgvTakip.SelectedRows[0].DataBoundItem;     
                    _db.Entry(takip).Collection(x => x.Ogunler).Load(); // EXPLICIT LOADING
                    dgvOgunler.DataSource = takip.Ogunler.ToList();
                }
                Temizlik();
            }
            catch (Exception )
            {
                MessageBox.Show("Data seçime uygun değildir.Kullanıcı Listele sayfasına yönlendiriliyorsunuz " );
            }
            finally
            {
                dgvTakip.DataSource=_db.Kullanicilar.ToList();
            }
        }

        private void btnKullaniciListele_Click(object sender, EventArgs e)
        {
            try
            {
                dgvTakip.DataSource = _db.Kullanicilar.ToList();

                //dgvTakip.DataSource = _db.Kullanicilar.Select(
                //k => new
                //{
                //    Id = k.Id,
                //    User = k.UserName,
                //    Ogunler = string.Join(", ", k.Ogunler.Select(o => o.Zaman))
                //}
                //).ToList();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata"+ex.Message);
            }
        }
    }
}
