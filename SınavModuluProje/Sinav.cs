using System;
using System.Collections.Generic;
using System.Text;

namespace SınavModuluProje
{
    public class Sinav
    {
        public int SinavId { get; set; }
        public int OgrenciId { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public string DogruCevaplar { get; set; }
        public string YanlisCevaplar { get; set; }
        public DateTime SinavBaslangic { get; set; }
        public DateTime SinavBitis { get; set; }
    }
}
