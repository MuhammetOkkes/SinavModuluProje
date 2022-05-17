using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SınavModuluProje
{
    public partial class AdminGirisForm : Form
    {
        AdminDAL adminDAL = new AdminDAL();
        public AdminGirisForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e) // text boxa girilen bilgilere göre admin girişi sağlanır. Admin veritabanına elle eklenir
        {
            Admin admin = adminDAL.GetAdmin(tbxKullaniciAdi.Text); // girilen tc ye göre veritabanından admin çekilde
            if(admin.KullaniciAdi != null) // eğer bilgilere uygun admin varsa ifin içine girer yoksa ekrana hata mesajı yazdırır
            {
                if(admin.KullaniciAdi == tbxKullaniciAdi.Text && admin.Sifre == tbxSifre.Text)
                {
                    SoruEkleForm soruEkleForm = new SoruEkleForm(); // soru ekleme formuna geçer
                    this.Hide(); // açık olan formu kapatır
                    soruEkleForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Hesap bulunamadı ya da geçersiz şifre");
                }
              
            }
            else
            {
                MessageBox.Show("Hesap bulunamadı ya da geçersiz şifre1");
            }
        }

        private void btnGeri_Click(object sender, EventArgs e) // geri gitme butonu
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void AdminGirisForm_Load(object sender, EventArgs e)
        {

        }
    }
}
