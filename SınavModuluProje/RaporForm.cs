using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SınavModuluProje
{
    public partial class RaporForm : Form
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
        int basarisizKategoriId=0;
        double FenYuzde;
        double HayatYuzde;
        double MatYuzde;
        double TurkceYuzde;
        Dictionary<int, double> degerlendirme = new Dictionary<int, double>();
        public RaporForm()
        {
            InitializeComponent();
        }
        private void RaporForm_Load(object sender, EventArgs e)
        {
            ogrenci = ogrenciDAL.GetOgrenci(ogrenci.TcNo); // raporun hangi öğrenciye aiit olduğunun tutlduğu kısım
            sinavs = sinavDAL.GetSinavByOgrenciId(ogrenci.OgrneciId); // öğrencinin girdiği tüm sınavları listede tutar
            tumSorular = soruDAL.GetAll(); // veritabanındaki tüm soruları  dogru yanlis olarak tutar
            KategoriyeGoreAyir(); // tüm soruları hangi derse aitse kategori idsine göre filtreler
            dogruSayisi = FenDogru.Count + HayatDogru.Count + MatematikDogru.Count + TurkceDogru.Count; // tüm sınavlardaki doğru cevapları tutar
            yanlisSayisi = FenYanlis.Count + HayatYanlis.Count + MatematikYanlis.Count + TurkceYanlis.Count; // tüm sınavlardaki yanlıs cevapları tutar
            soruSayisi = dogruSayisi + yanlisSayisi; // total cevaplanan soru sayisi
            lblFenDogru.Text = FenDogru.Count.ToString(); 
            lblFenYanlis.Text = FenYanlis.Count.ToString();
            FenYuzde = (Convert.ToDouble(FenDogru.Count) / Convert.ToDouble((FenDogru.Count + FenYanlis.Count))) * 100; // yüzdesel başarı hesaplanır
            lblFenYuzde.Text = (FenYuzde).ToString("0.##") + "%";
            lblHayatDogru.Text = HayatDogru.Count.ToString();
            lblHayatYanlis.Text = HayatYanlis.Count.ToString();
            HayatYuzde = (Convert.ToDouble(HayatDogru.Count) / Convert.ToDouble((HayatDogru.Count + HayatYanlis.Count))) * 100;
            lblHayatYuzde.Text = (HayatYuzde).ToString("0.##") + "%";
            lblMatDogru.Text = MatematikDogru.Count.ToString();
            lblMatYanlis.Text = MatematikYanlis.Count.ToString();
            MatYuzde = (Convert.ToDouble(MatematikDogru.Count) / Convert.ToDouble((MatematikDogru.Count + MatematikYanlis.Count))) * 100;
            lblMatYuzde.Text =(MatYuzde).ToString("0.##") + "%";
            lblTurkceDogru.Text = TurkceDogru.Count.ToString();
            lblTurkceYanlis.Text = TurkceYanlis.Count.ToString();
            TurkceYuzde = (Convert.ToDouble(TurkceDogru.Count) / Convert.ToDouble((TurkceDogru.Count + TurkceYanlis.Count))) * 100;
            lblTurkceYuzde.Text =  (TurkceYuzde).ToString("0.##") + "%";
            lblGenelDogru.Text = dogruSayisi.ToString();
            lblGenelYanlis.Text = yanlisSayisi.ToString();
            lblGenelYuzde.Text = ((Convert.ToDouble(dogruSayisi) / Convert.ToDouble((soruSayisi))) * 100).ToString("0.##") + "%";
            degerlendirme.Add(1, FenYuzde); // en kötü olduğu dersi bulmak için tüm yüzdelik başarıları idsi ile beraber değerlendirme listesidne tutar
            degerlendirme.Add(2, HayatYuzde);
            degerlendirme.Add(3, MatYuzde);
            degerlendirme.Add(4, TurkceYuzde);
            lblAdSoyad.Text = ogrenci.OgrenciAdi + " " + ogrenci.OgrenciSoyadi;
            lblTcNo.Text = ogrenci.TcNo;
            BaşarısızKonuBelirle(); // en kötü dersi seçer
        }
        public void KategoriyeGoreAyir()
        {
            foreach (var item in sinavs)
            {
                string[] dogrular = item.DogruCevaplar.Split(",");
                // arraye atadık
                string[] yanlislar = item.YanlisCevaplar.Split(","); 
                for (int i = 0; i < dogrular.Length-1; i++) // 1 Fen 2 hayat bilgisi 3 matematik 4 türkçe
                {
                   
                    if (KategoriÇek(Convert.ToInt32(dogrular[i])) == 1) // doğru cevabın hangi derse ait olduğuna göre eklemeler yapılır
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
            
            foreach (var item in degerlendirme) // en kötü ders bulunur
            {
                if(item.Value < enDusukYuzde)
                {
                    enDusukYuzde = item.Value;
                    basarisizKategoriId = item.Key;
                }
            }
            //MessageBox.Show("Basarisiz kategori Id"+basarisizKategoriId);


           
        }
        public int KategoriÇek(int soruId)
        {
            int kategoriID = 0;
            foreach (var item in tumSorular)
            {
                if(item.SoruNo == soruId)
                {
                    kategoriID = item.KategoriId;
                }
            }
            
            return kategoriID;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        Bitmap bitmap;
        private void btnPrint_Click(object sender, EventArgs e)
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

        private void btnSinavModul_Click(object sender, EventArgs e)
        {
            SinavEksikModul sinavEksikModul = new SinavEksikModul();
            this.Hide();
            sinavEksikModul.ogrenci = ogrenci;
            sinavEksikModul.kategoriId = basarisizKategoriId;
            sinavEksikModul.ShowDialog();
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
