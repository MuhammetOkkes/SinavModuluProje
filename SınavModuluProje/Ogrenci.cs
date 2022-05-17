using System;
using System.Collections.Generic;
using System.Text;

namespace SınavModuluProje
{
    public class Ogrenci // Öğrenciye ait değişkenlerden oluşur
    {
        public int OgrneciId { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public string TcNo { get; set; }
        public string Sorular { get; set; }
        public string HavuzSorular { get; set; }
        public string Sifre { get; set; }
        public int Sure { get; set; }
    }
}
