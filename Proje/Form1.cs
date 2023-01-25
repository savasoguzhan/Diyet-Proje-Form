using M_Proje;
using M_Proje.Class;
using M_Proje.Context;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Proje
{
    public partial class Form1 : Form
    {
        UygulamaDbContext db;
        
        public Form1()
        {
            InitializeComponent();

            db = new UygulamaDbContext();
            txtSifre.PasswordChar = '*';
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            
            if (!(String.IsNullOrEmpty(txtSifre.Text) && String.IsNullOrEmpty(txtUserName.Text)))
            {
                if (txtUserName.Text.ToLower() == "admin" && txtSifre.Text.ToLower() == "admin")
                {
                    var frm = new AdminForm();
                    frm.ShowDialog();
                }
                else if (txtUserName.Text.ToLower().Contains("@bilgeadam.com"))
                {
                    string sifre = sha256_hash(txtSifre.Text);
                    if (db.Kullanicilar.Any(x => x.UserName == txtUserName.Text && x.Password == sifre))
                    {
                        var frm = new EgitmenForm();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Kullanýcý adý veya sifre hatalý");
                    }
                }
                else if (txtUserName.Text.ToLower().Contains("@gmail.com") || txtUserName.Text.ToLower().Contains("@hotmail.com"))
                {
                    string sifre = sha256_hash(txtSifre.Text);
                    if (db.Kullanicilar.Any(x => x.UserName == txtUserName.Text && x.Password == sifre))
                    {
                        Kullanici kln = new Kullanici();
                        kln.UserName= txtUserName.Text;
                        var frm = new KullaniciForm(db,kln);
                        DialogResult dr = frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Kullanýcý adý veya sifre hatalý");
                    }
                }
            }

            else
            {
                MessageBox.Show("Lütfen boþluklarý doldurunuz!");
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            var frm = new KayitForm();
            frm.ShowDialog();
        }

        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox iþaretli ise
            if (chkSifreGoster.Checked)
            {
                //karakteri göster.
                txtSifre.PasswordChar = '\0';
            }
            //deðilse karakterlerin yerine * koy.
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }
        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            { return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2"))); }
        }
    }
}