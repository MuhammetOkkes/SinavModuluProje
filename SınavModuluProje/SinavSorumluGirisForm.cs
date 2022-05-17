using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SınavModuluProje
{
    public partial class SinavSorumluGirisForm : Form
    {
        SinavSorumluDal sorumluDal = new SinavSorumluDal();
        public SinavSorumluGirisForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SinavSorumlu sinavSorumlu = sorumluDal.GetSinavSorumlu(tbxKullaniciAdi.Text);
            if(sinavSorumlu.TcNo != null)
            {
                if(sinavSorumlu.TcNo == tbxKullaniciAdi.Text && sinavSorumlu.Sifre == tbxSifre.Text)
                {
                    OgrenciBilgileri ogrenciBilgileri = new OgrenciBilgileri();
                    this.Hide();
                    ogrenciBilgileri.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                }
               

            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı");
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void SinavSorumluGirisForm_Load(object sender, EventArgs e)
        {

        }
    }
}
