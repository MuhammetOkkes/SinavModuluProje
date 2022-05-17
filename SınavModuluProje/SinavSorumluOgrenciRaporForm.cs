using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SınavModuluProje
{
    public partial class SinavSorumluOgrenciRaporForm : Form
    {
        public Ogrenci ogrenci;
        OgrenciDAL ogrenciDAL = new OgrenciDAL();
        List<Sinav> sinavs = new List<Sinav>();
        SinavDAL sinavDAL = new SinavDAL();
        SoruDAL soruDAL = new SoruDAL();
        List<string> FenDogru = new List<string>();
        List<string> FenYanlis = new List<string>();
        List<string> HayatDogru = new List<string>();
        List<string> HayatYanlis = new List<string>();
        List<string> TurkceDogru = new List<string>();
        List<string> TurkceYanlis = new List<string>();
        List<string> MatematikDogru = new List<string>();
        List<string> MatematikYanlis = new List<string>();
        List<Soru> tumSorular = new List<Soru>();

        double soruSayisi = 0;
        double dogruSayisi = 0;
        double yanlisSayisi = 0;
        int basarisizKategoriId = 0;
        double FenYuzde;
        double HayatYuzde;
        double MatYuzde;
        double TurkceYuzde;
        Dictionary<int, double> degerlendirme = new Dictionary<int, double>();
        public SinavSorumluOgrenciRaporForm() 
        {
            InitializeComponent();
        }

        private void SinavSorumluOgrenciRaporForm_Load(object sender, EventArgs e)
        {
            ogrenci = ogrenciDAL.GetOgrenci(ogrenci.TcNo);
            sinavs = sinavDAL.GetSinavByOgrenciId(ogrenci.OgrneciId);
            tumSorular = soruDAL.GetAll();
            KategoriyeGoreAyir();
            dogruSayisi = FenDogru.Count + HayatDogru.Count + MatematikDogru.Count + TurkceDogru.Count;
            yanlisSayisi = FenYanlis.Count + HayatYanlis.Count + MatematikYanlis.Count + TurkceYanlis.Count;
            soruSayisi = dogruSayisi + yanlisSayisi;
            lblFenDogru.Text = FenDogru.Count.ToString();
            lblFenYanlis.Text = FenYanlis.Count.ToString();
            FenYuzde = (Convert.ToDouble(FenDogru.Count) / Convert.ToDouble((FenDogru.Count + FenYanlis.Count))) * 100;
            lblFenYuzde.Text = (FenYuzde).ToString("0.##") + "%";
            lblHayatDogru.Text = HayatDogru.Count.ToString();
            lblHayatYanlis.Text = HayatYanlis.Count.ToString();
            HayatYuzde = (Convert.ToDouble(HayatDogru.Count) / Convert.ToDouble((HayatDogru.Count + HayatYanlis.Count))) * 100;
            lblHayatYuzde.Text = (HayatYuzde).ToString("0.##") + "%";
            lblMatDogru.Text = MatematikDogru.Count.ToString();
            lblMatYanlis.Text = MatematikYanlis.Count.ToString();
            MatYuzde = (Convert.ToDouble(MatematikDogru.Count) / Convert.ToDouble((MatematikDogru.Count + MatematikYanlis.Count))) * 100;
            lblMatYuzde.Text = (MatYuzde).ToString("0.##") + "%";
            lblTurkceDogru.Text = TurkceDogru.Count.ToString();
            lblTurkceYanlis.Text = TurkceYanlis.Count.ToString();
            TurkceYuzde = (Convert.ToDouble(TurkceDogru.Count) / Convert.ToDouble((TurkceDogru.Count + TurkceYanlis.Count))) * 100;
            lblTurkceYuzde.Text = (TurkceYuzde).ToString("0.##") + "%";
            lblGenelDogru.Text = dogruSayisi.ToString();
            lblGenelYanlis.Text = yanlisSayisi.ToString();
            lblGenelYuzde.Text = ((Convert.ToDouble(dogruSayisi) / Convert.ToDouble((soruSayisi))) * 100).ToString("0.##") + "%";
            degerlendirme.Add(1, FenYuzde);
            degerlendirme.Add(2, HayatYuzde);
            degerlendirme.Add(3, MatYuzde);
            degerlendirme.Add(4, TurkceYuzde);
            lblAdSoyad.Text = ogrenci.OgrenciAdi + " " + ogrenci.OgrenciSoyadi;
            lblTcNo.Text = ogrenci.TcNo;
            BaşarısızKonuBelirle();
        }
        public void KategoriyeGoreAyir()
        {
            foreach (var item in sinavs)
            {
                string[] dogrular = item.DogruCevaplar.Split(",");
                string[] yanlislar = item.YanlisCevaplar.Split(",");
                for (int i = 0; i < dogrular.Length - 1; i++) // 1 Fen 2 hayat bilgisi 3 matematik 4 türkçe
                {

                    if (KategoriÇek(Convert.ToInt32(dogrular[i])) == 1)
                    {
                        FenDogru.Add(dogrular[i]);
                    }
                    else if (KategoriÇek(Convert.ToInt32(dogrular[i])) == 2)
                    {
                        HayatDogru.Add(dogrular[i]);
                    }
                    else if (KategoriÇek(Convert.ToInt32(dogrular[i])) == 3)
                    {
                        MatematikDogru.Add(dogrular[i]);
                    }
                    else if (KategoriÇek(Convert.ToInt32(dogrular[i])) == 4)
                    {
                        TurkceDogru.Add(dogrular[i]);
                    }
                    else
                    {
                        MessageBox.Show("Kategori yok");
                    }
                }
                for (int i = 0; i < yanlislar.Length - 1; i++) // 1 Fen 2 hayat bilgisi 3 matematik 4 türkçe
                {

                    if (KategoriÇek(Convert.ToInt32(yanlislar[i])) == 1)
                    {
                        FenYanlis.Add(yanlislar[i]);
                    }
                    else if (KategoriÇek(Convert.ToInt32(yanlislar[i])) == 2)
                    {
                        HayatYanlis.Add(yanlislar[i]);
                    }
                    else if (KategoriÇek(Convert.ToInt32(yanlislar[i])) == 3)
                    {
                        MatematikYanlis.Add(yanlislar[i]);
                    }
                    else if (KategoriÇek(Convert.ToInt32(yanlislar[i])) == 4)
                    {
                        TurkceYanlis.Add(yanlislar[i]);
                    }
                    else
                    {
                        MessageBox.Show("Kategori yok");
                    }
                }
            }
        }
        double enDusukYuzde = 100;
        public void BaşarısızKonuBelirle()
        {

            foreach (var item in degerlendirme)
            {
                if (item.Value < enDusukYuzde)
                {
                    enDusukYuzde = item.Value;
                    basarisizKategoriId = item.Key;
                }
            }
            //MessageBox.Show("asdad" + basarisizKategoriId);



        }
        public int KategoriÇek(int soruId)
        {
            int kategoriID = 0;
            foreach (var item in tumSorular)
            {
                if (item.SoruNo == soruId)
                {
                    kategoriID = item.KategoriId;
                }
            }

            return kategoriID;
        }

        Bitmap bitmap;
        private void btnPrint_Click(object sender, EventArgs e) // yazdırma işlemi burada yapılır
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);

            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            OgrenciBilgileri ogrenciBilgileri = new OgrenciBilgileri();
            this.Hide();
            ogrenciBilgileri.ShowDialog();
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
