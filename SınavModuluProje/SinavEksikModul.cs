using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SınavModuluProje
{
    public partial class SinavEksikModul : Form
    {
        OgrenciDAL ogrenciDAL = new OgrenciDAL();
        SoruDAL soruDAL = new SoruDAL();
        List<Soru> kategorizeSorular = new List<Soru>();
        public int kategoriId;
        public Ogrenci ogrenci;
        int curr_soruId = 0;
        string dogruCevap = "";
        int soruSayaç = 0;
        string secilenCevap="";
        List<string> dogruCevaplar = new List<string>();
        List<string> yanlisCevaplar = new List<string>();
        public SinavEksikModul()
        {
            InitializeComponent();
        }

        private void SinavEksikModul_Load(object sender, EventArgs e) /// öğrencinin eksik olduğu dersten havuz soruları da dahil sınav yapıldığı form
        {
            //MessageBox.Show(kategoriId.ToString()) ;
            kategorizeSorular = soruDAL.GetSoruByKategoriId(kategoriId);
            SonrakiSoru();
        }

        private void SecenekA_Click(object sender, EventArgs e)
        {
            secilenCevap = "A";
            CevapVer();// seçilen cevap atanır
        }

        private void SecenekB_Click(object sender, EventArgs e)
        {
            secilenCevap = "B";
            CevapVer();
        }

        private void SecenekC_Click(object sender, EventArgs e)
        {
            secilenCevap = "C";
            CevapVer();
        }
        public void SonrakiSoru() // bir sonraki soruya
        {
            if (soruSayaç <= kategorizeSorular.Count)
            {
              
                if(soruSayaç >= kategorizeSorular.Count) 
                {
                    MessageBox.Show("Sinav Bitti");
                    MessageBox.Show("Doğru Cevap Sayisi:" + dogruCevaplar.Count + "\n Yanlış Cevaplar Sayısı: " + yanlisCevaplar.Count);
                }
                else
                {
                    curr_soruId = kategorizeSorular[soruSayaç].SoruNo; // anlık sorulan soru
                    rtbxSoru.Text = kategorizeSorular[soruSayaç].SoruMetni; // soru metni richtextboxa atanır
                    rtbxA.Text = kategorizeSorular[soruSayaç].SecenekA; // şıklar uygun bir şekilde doldurulur
                    rtbxB.Text = kategorizeSorular[soruSayaç].SecenekB;
                    rtbxC.Text = kategorizeSorular[soruSayaç].SecenekC;
                    dogruCevap = kategorizeSorular[soruSayaç].DogruCevap;
                    // curr_kategoriId = curr_sorular[soruSayaç].KategoriId;
                }
                soruSayaç++;
            }

        }
        public void CevapVer() 
        {
            if (dogruCevap == secilenCevap) // Seçilen cevap doğru mu yanlış mı kontrol edilir
            {
                if(soruSayaç <= kategorizeSorular.Count)
                {
                    dogruCevaplar.Add(curr_soruId.ToString());
                    SonrakiSoru();
                    MessageBox.Show("Doğru Cevap");
                }
            }
            else
            {
                if (soruSayaç <= kategorizeSorular.Count)
                {
                    yanlisCevaplar.Add(curr_soruId.ToString());
                    SonrakiSoru();
                    MessageBox.Show("Yanlış Cevap");
                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            RaporForm raporForm = new RaporForm();
            this.Hide();
            raporForm.ogrenci = ogrenci;
            raporForm.ShowDialog();
        }
    }
}
