using M_Proje.Class;
using M_Proje.Context;
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

namespace M_Proje
{
    public partial class RaporForm : Form
    {
        private readonly UygulamaDbContext cont;
        private readonly Kullanici kull;




        public RaporForm(UygulamaDbContext _db, Kullanici _kln)
        {
            InitializeComponent();
            cont = _db;
            kull = _kln;


        }

        private void RaporForm_Load(object sender, EventArgs e)
        {
            decimal sayi = KullaniciForm.GünlükBilgi;
            var Cinsiyet = cont.Kullanicilar.FirstOrDefault(x => x.UserName == kull.UserName).Cinsiyet.ToString();
            if (KullaniciForm.GünlükBilgi != 0)
            {                
                lblRapor.Text = KullaniciForm.GünlükBilgi.ToString();
                if (Cinsiyet == "erkek")
                {
                    if (sayi >= 3000)
                    {
                        lblTavsiye.Text = "Günlük 3000 kalori miktarı aşıldı lütfen öğünlerinizi gözden geçiriniz";
                    }
                    else if (sayi < 3000 && sayi >= 2000)
                    {
                        lblTavsiye.Text = "İdeal kalori tüketimi lütfen programa uymaya böyle devam ediniz";
                    }
                    else if (sayi < 2000)
                    {
                        lblTavsiye.Text = "Günlük 2000 den az kalori aldınız. Yetersiz kalori tüketimi lütfen öğünlerinizi gözden geçiriniz ";
                    }
                }
                else if (Cinsiyet == "kadın")
                {
                    if (sayi >= 2500)
                    {
                        lblTavsiye.Text = "Günlük 2500 kalori miktarı aşıldı lütfen öğünlerinizi gözden geçiriniz";
                    }
                    else if (sayi < 2500 && sayi >= 2000)
                    {
                        lblTavsiye.Text = "İdeal kalori tüketimi lütfen programa uymaya böyle devam ediniz";
                    }
                    else if (sayi < 2000)
                    {
                        lblTavsiye.Text = "Günlük 2000 den az kalori aldınız. Yetersiz kalori tüketimi lütfen öğünlerinizi gözden geçiriniz ";
                    }
                }
            }
             if (KullaniciForm.HaftalıkBilgi != 0)
            {
                lblRapor.Text = KullaniciForm.HaftalıkBilgi.ToString();
                if (Cinsiyet == "erkek")
                {
                    if (sayi >= 21000)
                    {
                        lblTavsiye.Text = "Haftalık 21000 kalori miktarı aşıldı lütfen öğünlerinizi gözden geçiriniz";
                    }
                    else if (sayi < 21000 && sayi >= 14000)
                    {
                        lblTavsiye.Text = "Haftalık olarak ideal kalori tüketimi lütfen programa uymaya böyle devam ediniz";
                    }
                    else if (sayi < 14000)
                    {
                        lblTavsiye.Text = "Haftalık 14000 den az kalori aldınız. Yetersiz kalori tüketimi lütfen öğünlerinizi gözden geçiriniz ";
                    }
                }
                else if (Cinsiyet == "kadın")
                {
                    if (sayi >= 17500)
                    {
                        lblTavsiye.Text = "Haftalık 17500 kalori miktarı aşıldı lütfen öğünlerinizi gözden geçiriniz";
                    }
                    else if (sayi < 17500 && sayi >= 14000)
                    {
                        lblTavsiye.Text = "Haftalık olarak ideal kalori tüketimi lütfen programa uymaya böyle devam ediniz";
                    }
                    else if (sayi < 14000)
                    {
                        lblTavsiye.Text = "Haftalık 14000 den az kalori aldınız. Yetersiz kalori tüketimi lütfen öğünlerinizi gözden geçiriniz ";
                    }
                }
            }
             if (KullaniciForm.AylıkBilgi != 0)
            {
                lblRapor.Text = KullaniciForm.AylıkBilgi.ToString();
                if (Cinsiyet == "erkek")
                {
                    if (sayi >= 90000)
                    {
                        lblTavsiye.Text = "Aylık 90000 kalori miktarı aşıldı lütfen öğünlerinizi gözden geçiriniz";
                    }
                    else if (sayi < 90000 && sayi >= 60000)
                    {
                        lblTavsiye.Text = "İdeal kalori tüketimi lütfen programa uymaya böyle devam ediniz";
                    }
                    else if (sayi < 60000)
                    {
                        lblTavsiye.Text = "Aylık 60000 den az kalori aldınız. Yetersiz kalori tüketimi lütfen öğünlerinizi gözden geçiriniz ";
                    }
                }
                else if (Cinsiyet == "kadın")
                {
                    if (sayi >= 75000)
                    {
                        lblTavsiye.Text = "Aylık 75000 kalori miktarı aşıldı lütfen öğünlerinizi gözden geçiriniz";
                    }
                    else if (sayi < 75000 && sayi >= 60000)
                    {
                        lblTavsiye.Text = "İdeal kalori tüketimi lütfen programa uymaya böyle devam ediniz";
                    }
                    else if (sayi < 60000)
                    {
                        lblTavsiye.Text = "Aylık 60000 den az kalori aldınız. Yetersiz kalori tüketimi lütfen öğünlerinizi gözden geçiriniz ";
                    }
                }
            }


        }
    }
}
