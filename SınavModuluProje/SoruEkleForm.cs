using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SınavModuluProje
{
    public partial class SoruEkleForm : Form
    {
        SoruDAL soruDAL = new SoruDAL();
        int kategoriId;
        public SoruEkleForm()
        {
            InitializeComponent();
        }

        private void SoruEkleForm_Load(object sender, EventArgs e) // Veritabanına admin tarafından veriler eklenir
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cbxKategori.Text =="Fen")
            {
                kategoriId = 1;
            }
            else if (cbxKategori.Text == "Hayat Bilgisi")
            {
                kategoriId = 2;
            }
            else if (cbxKategori.Text == "Matematik")
            {
                kategoriId = 3;

            }
            else if (cbxKategori.Text == "Türkçe")
            {
                kategoriId = 4;
            }
            soruDAL.Add(new Soru
            {

                SoruMetni = rtbxSoruMetni.Text,
                SecenekA = rtbxSecenekA.Text,
                SecenekB = rtbxSecenekB.Text,
                SecenekC = rtbxSecenekC.Text,
                DogruCevap = rtbxSecenekDogruSık.Text,
                KategoriId = kategoriId,
                SoruNo = soruDAL.GetAll().Count + 1,
            }) ;
            MessageBox.Show("Ürün Eklendi");
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }
    }
}
