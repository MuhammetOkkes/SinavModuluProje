using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SınavModuluProje
{
    public partial class OgrenciProfilForm : Form
    {
        OgrenciDAL ogrenciDAL = new OgrenciDAL();
        public Ogrenci ogrenci = new Ogrenci();
        public OgrenciProfilForm()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e) // öğrencinin havuz sorularını ne zamn havuzdan çıkacağını belirler.
        {
            ogrenci.Sure = Convert.ToInt32(cbxSure.SelectedIndex+1); // yeni süre atanır
            ogrenciDAL.Update(ogrenci); // öğrencinin mevcut durumunu günceller
            ProfilGüncelle();
        }

        private void OgrenciProfilForm_Load(object sender, EventArgs e)
        {
            ProfilGüncelle(); // öğrenci bilgileri labellara yazdırlır.
        }
        public void ProfilGüncelle()
        {
            ogrenci = ogrenciDAL.GetOgrenci(ogrenci.TcNo);
            lblAd.Text = ogrenci.OgrenciAdi;
            lblSoyad.Text = ogrenci.OgrenciSoyadi;
            lblTc.Text = ogrenci.TcNo;
            cbxSure.SelectedIndex = ogrenci.Sure;
        }

       

        private void btnGeri_Click(object sender, EventArgs e)
        {
            OgrenciMenu ogrenciMenu = new OgrenciMenu();
            ogrenciMenu.ogrenci = ogrenci;
            this.Hide();
            ogrenciMenu.ShowDialog();
        }
    }
}
