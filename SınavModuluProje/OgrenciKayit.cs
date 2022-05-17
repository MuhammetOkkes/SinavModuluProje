using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SınavModuluProje
{
    public partial class OgrenciKayit : Form
    {
        OgrenciDAL ogrenciDAL = new OgrenciDAL();
        public OgrenciKayit()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            
                Ogrenci ogrenci = ogrenciDAL.GetOgrenci(tbxTc.Text);
                if (ogrenci.TcNo == null)
                {
                    ogrenciDAL.Add(new Ogrenci
                    {
                        OgrenciAdi = tbxAd.Text,
                        OgrenciSoyadi = tbxSoyad.Text,
                        HavuzSorular = "",
                        Sifre = tbxSifre.Text,
                        Sorular = SorularOlustur(),
                        Sure = 1,
                        TcNo = tbxTc.Text,
                    });
                MessageBox.Show("Kaydınız Gerçekleşti");
                }
                else
                {
                    MessageBox.Show("Zaten kayıtlısınız");
                }
        }
        public string SorularOlustur()
        {
            string sorular = "";
            for (int i = 1; i < 101; i++)
            {
                sorular += i + "-0,";
            }
           // MessageBox.Show(sorular);
            return sorular;
        }

        private void OgrenciKayit_Load(object sender, EventArgs e) // Öğrenci kayıt kısmı
        {
            SorularOlustur(); 
            
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            OgrneciGiris ogrneciGiris = new OgrneciGiris();
            this.Hide();
            ogrneciGiris.ShowDialog();
        }
    }
}
