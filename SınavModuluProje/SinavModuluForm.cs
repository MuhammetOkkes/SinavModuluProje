using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SınavModuluProje
{
    public partial class SinavModuluForm : Form
    {
        public string OgrenciTc;
        int durum = 0;
        int curr_ogrenciId = 0;
        int curr_soruId = 0;
        string dogruCevap = "D";
        int curr_kategoriId = 0;
        public Ogrenci ogrenci;
        OgrenciDAL ogrenciDAL = new OgrenciDAL();
        SinavDAL sinavDAL = new SinavDAL();
        int saat = 0, dakika = 0, saniye = 0;
        List<Soru> sorular = new List<Soru>();
        List<Soru> curr_sorular = new List<Soru>();
        List<int> secilenSorular = new List<int>();
        SoruDAL soruDAL = new SoruDAL();
        string secilenCevap = "";
        string dogruCevaplar = "";
        string yanlisCevaplar = "";
        int havuzCikisSüresi = 0;
        DateTime sinavBaslangic;
        bool isClosed = false;
        public SinavModuluForm()
        {
            InitializeComponent();
        }

        private void SecenekA_Click(object sender, EventArgs e)
        {
            secilenCevap = "A"; // cevap verilen secenek ata
            CevapVer();

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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // süre tutulur 10 dk olduğunda sınav sona erdirilir
            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
                if(dakika == 10) {
                    if(isClosed == false)
                    {
                        isClosed = true;
                        MessageBox.Show("Süreniz Bitmiştir. Sınav sona erdi");
                        SinavBitir();
                        dakika = 0;
                        OgrenciMenu ogrenciMenu = new OgrenciMenu();
                        ogrenciMenu.ogrenci = ogrenci;
                        this.Hide();
                        ogrenciMenu.ShowDialog();

                    }
                  
                    
                  
                }

            }
            if (dakika == 60)
            {
                dakika = 0;
                saniye = 0;
                saat++;
            }
            lblTimer.Text = String.Format("{0:D2}", saat) + ":" + String.Format("{0:D2}", dakika) + ":" + String.Format("{0:D2}", saniye);
           
            saniye ++;
        }

        private void SinavModuluForm_Load(object sender, EventArgs e)
        {
            
            ogrenci = CurrOgrenci(OgrenciTc); // sınava giren öğrenci girlir
            timer1.Start(); // timet başlar
            timer1.Interval = 1000; 
            SureBelirle(); // havuz soruları uygun tarihteyse havuzdan çıkartılır ve güncellenir
            sorular = soruDAL.GetAll(); // tüm sorular çekilir
            GuncelSorularıHazirla(); //
            SonrakiSoru();
            sinavBaslangic = DateTime.Now;
            HavuzCikar();
            
        }
        public Ogrenci CurrOgrenci(string TC)
        {
            return ogrenciDAL.GetOgrenci(TC); // öğrencinin bilgileri  güncellenir
        }
        int soruSayaç = 0;
        public void SonrakiSoru()
        {
            if (soruSayaç < 10)
            {
                curr_soruId = curr_sorular[soruSayaç].SoruNo; // anlık soru tutulur
                rtbxSoru.Text = curr_sorular[soruSayaç].SoruMetni; // soru metni doldurulur
                rtbxA.Text = curr_sorular[soruSayaç].SecenekA; // secenekler doldurulur
                rtbxB.Text = curr_sorular[soruSayaç].SecenekB;
                rtbxC.Text = curr_sorular[soruSayaç].SecenekC;
                dogruCevap = curr_sorular[soruSayaç].DogruCevap; // sorunun doğru cevabı doldurulur
                curr_kategoriId = curr_sorular[soruSayaç].KategoriId;
                soruSayaç++;
            }
            else
            {

                SinavBitir();
                MessageBox.Show("Tüm soruları cevapladınız. Sınav sona erdi");
                OgrenciMenu ogrenciMenu = new OgrenciMenu();
                ogrenciMenu.ogrenci = ogrenci;
                this.Hide();
                ogrenciMenu.ShowDialog();
            }

        }
        public void SinavBitir()
        {
            // sınav bitirilir ve sınav tablosuna sinavlar eklenir
            sinavDAL.Add(new Sinav
            {
                DogruCevaplar = dogruCevaplar,
                YanlisCevaplar = yanlisCevaplar,
                OgrenciId = ogrenci.OgrneciId, // sinava giren öğrenci idsi
                OgrenciAdi = ogrenci.OgrenciAdi,
                OgrenciSoyadi = ogrenci.OgrenciSoyadi,
                SinavBitis = DateTime.Now,
                SinavBaslangic = sinavBaslangic,
            });
            isClosed = true;
        }
        public void CevapVer() // soruya vebap verilir
        {
            if (dogruCevap == secilenCevap)
            {
                OgrenciKomboArttir(curr_soruId); // öğrencinin bir soruyu birden fazla kez üst üste doğru cevaplarsa çalışacak kombo
                dogruCevaplar += curr_soruId.ToString() + ","; // sinavda doğru bilinen doğru cevaplar  1,2,5,75 şeklinde yazılır
                SonrakiSoru(); // sonraki soruya geçilir

                MessageBox.Show("Doğru Cevap");

            }
            else
            {
                OgrenciKomboSifirla(curr_soruId); // soru yanlş olursa combo sıfırlanır 1-5,2-3, 1. soru yanlış olursa 1-0,2-3 olur
                yanlisCevaplar += curr_soruId.ToString() + ","; 
                SonrakiSoru();
                MessageBox.Show("Yanlış Cevap");
            }
        }
        public string ComboArttirmaUygunMu(int soruId)
        {
            string isMore = "aa";
            List<Sinav> sinavlar = sinavDAL.GetSinavByOgrenciId(ogrenci.OgrneciId); // öğrencini girdiği sınavlar çekilir
            for (int i = sinavlar.Count-1; i >=0; i--)
            {
                string[] rest = sinavlar[i].DogruCevaplar.Split(",");
                foreach (var item in rest)
                {
                    if (item == soruId.ToString())
                    {
                        isMore = "bb";
                        var diffInHours = (DateTime.Now - sinavlar[i].SinavBaslangic).TotalHours; 
                        
                        if(diffInHours > 2)
                        {
                            isMore = "true";
                            
                        }
                    }
                    if (isMore=="true")
                    {
                        break;
                    }
                }
                if (isMore== "true")
                {
                    break;
                }
            }
            return isMore;
        }
        public void OgrenciKomboArttir(int soruId)
        {
            if (ComboArttirmaUygunMu(soruId) != "bb") // eğer kombo arttırıma uygunsa gir
            {
                string[] rest = ogrenci.Sorular.Split(","); //  sorularını , e göre parçala arraye ata
                for (int i = 0; i < 100; i++) 
                {
                    string[] part = rest[i].Split("-");
                    if (soruId.ToString() == part[0]) 
                    {
                        part[1] = (Convert.ToInt32(part[1]) + 1).ToString(); // mevcut kombo sayısını 1 arttır  
                        //MessageBox.Show(part[0] + "asd" + part[1]);
                        HavuzAta(Convert.ToInt32(part[1]),curr_soruId); // havuza ata fonksiyonu çalıştır
                        string newStr = string.Join("-", part[0], part[1]); 
                        //MessageBox.Show("asd" + newStr);
                        rest[i] = newStr;
                    }
                }
                ogrenci.Sorular = string.Join(",", rest); // öğrencinin soruları son hali birleşip güncellenir
                ogrenciDAL.Update(ogrenci);
                OgrenciGuncelle();
                //MessageBox.Show(ogrenci.Sorular);
            }
        }
        public void OgrenciKomboSifirla(int soruId)
        {
            string[] rest = ogrenci.Sorular.Split(","); // eğer yanlış ccevap verirse yanlış verilen cevabın kombosu 0lanır
            for (int i = 0; i < sorular.Count; i++)
            {
                string[] part = rest[i].Split("-");
                if (soruId.ToString() == part[0])
                {
                    part[1] = 0.ToString(); // combo 0 lanır
                    string newStr = string.Join("-", part[0], part[1]); // güncel hali alınır
                    rest[i] = newStr;
                    
                }
            }
            ogrenci.Sorular = string.Join(",", rest); // güncellenir
            ogrenciDAL.Update(ogrenci);
            OgrenciGuncelle();
            // MessageBox.Show(ogrenci.Sorular);
        }

        public void GuncelSorularıHazirla()
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Soru secilenSoru = sorular[random.Next(1, sorular.Count)]; // tüm sorular içerisinden random soru seçer

                if (!HavuzSorusuMu(secilenSoru.SoruId)) 
                {
                    if (SoruListesindeMi(secilenSoru.SoruId))
                    {
                        i--; 
                       // MessageBox.Show("zaten var");
                    }
                    else
                    {
                        curr_sorular.Add(secilenSoru);
                        secilenSorular.Add(secilenSoru.SoruId);
                    }
                }
                else
                {
                    i--;
                   // MessageBox.Show("Havuz");
                }
            }

        }
        public bool SoruListesindeMi(int id) // daha önce seçilen soru mu kontrol eder
        {
            bool isStay = false;
            foreach (var item in secilenSorular)
            {
                if (item == id)
                {
                    isStay = true;
                }
            }
            return isStay;

        }
        public void HavuzAta(int comboSayisi,int soruId)
        {
            OgrenciGuncelle();
            if (comboSayisi == 6) // combo sayısı 6ysa içeri girer ve öğrencinin havuz sorularına eklenir
            {
                ogrenci.HavuzSorular += soruId + "-"+(DateTime.Now).ToString()+",";
                ogrenciDAL.Update(ogrenci);
            }
        }

        public void HavuzCikar()
        {
            string ogrenciHavuz = ogrenci.HavuzSorular; // ogrencinin havuzdaki sorular eklenir
            string[] parts = ogrenciHavuz.Split(","); // 1-15.05.2022 05:45,2-13.04.2022 05:45 şeklindedir ',' ile parçalanınca
            List<string> sorular = new List<string>();
            List<DateTime> tarihler = new List<DateTime>();
            
            if(parts[0] != "")
            {
                for (int i = 0; i < parts.Length; i++) 
                {
                    string[] arr = parts[i].Split("-");
                    if (arr[0] != "")
                    {
                        sorular.Add(arr[0]); // arr[0] hangi soru olduğunu
                        tarihler.Add(Convert.ToDateTime(arr[1])); // arr[1] hangi tarihte ve zamanda havuza atıldığını tutar
                       // MessageBox.Show(arr[0] + "  " + arr[1]);
                    }
                }
                string newHavuz = "";
                for (int i = 0; i < sorular.Count; i++)
                {

                    var diffInDays = (DateTime.Now - tarihler[i]).TotalDays; // eğer yeterli süre geçtiyse navuzdan çıkarılır
                    if (diffInDays < havuzCikisSüresi) 
                    {
                        newHavuz += sorular[i] + "-" + tarihler[i] + ",";
                    }
                }
                //MessageBox.Show("newhavuz: " + newHavuz);
                ogrenci.HavuzSorular = newHavuz; 
                ogrenciDAL.Update(ogrenci);
                ogrenci = ogrenciDAL.GetOgrenci(ogrenci.TcNo.ToString());
                OgrenciGuncelle();
            }
          
        }
        public void SureBelirle()
        {
            OgrenciGuncelle();
            int secim = ogrenci.Sure; // öğrencinin seçimine göre havuz sorularının çıkma tarihi belirlenir
            switch (secim)
            {
                case 1: // 1 gün
                    havuzCikisSüresi = 1;
                    break;
                case 2: // 1 hafta
                    havuzCikisSüresi = 7;
                    break;
                case 3: // 1 ay
                    havuzCikisSüresi = 30;
                    break;
                case 4: // 3 ay
                    havuzCikisSüresi = 90;
                    break;
                case 5: // 1 yıl
                    havuzCikisSüresi = 180;
                    break;
                case 6: // 1 yıl
                    havuzCikisSüresi = 365;
                    break;
                default:
                    havuzCikisSüresi = 1;
                    break;
            }
        }
        public void OgrenciGuncelle()
        {
            ogrenci = ogrenciDAL.GetOgrenci(ogrenci.TcNo);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            OgrenciGuncelle();
            OgrenciMenu ogrenciMenu = new OgrenciMenu();
            ogrenciMenu.ogrenci = ogrenci;
            this.Hide();
            ogrenciMenu.ShowDialog();
        }

        public bool HavuzSorusuMu(int soruNo) // seçilen soru eğer havuz sorusuysa sınav soruları içerisine alınmaz
        {
            bool isStay = false;
            OgrenciGuncelle();
            string ogrenciHavuz = ogrenci.HavuzSorular;
            string[] parts = ogrenciHavuz.Split(",");
            for (int i = 0; i < parts.Length; i++)
            {
                string[] arr = parts[i].Split("-");
                if (arr[0] == soruNo.ToString())
                {
                    isStay = true;
                    break;
                }
            }
           
            return isStay;
        }
        public void SonrakiSinav() // sinav biter bitmez ogrenci menusune yönlendirilir.
        {
            OgrenciMenu ogrenciMenu = new OgrenciMenu();
            ogrenciMenu.ogrenci = ogrenci;
            this.Hide();
            ogrenciMenu.ShowDialog();
        }
    }
}
