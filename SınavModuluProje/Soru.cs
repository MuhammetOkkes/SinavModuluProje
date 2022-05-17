using System;
using System.Collections.Generic;
using System.Text;

namespace SınavModuluProje
{
    public class Soru
    {
        public int SoruId { get; set; }
        public string SoruMetni { get; set; }
        public string SecenekA { get; set; }
        public string SecenekB { get; set; }
        public string SecenekC { get; set; }
        public string DogruCevap{ get; set; }
        public int KategoriId { get; set; }
        public int SoruNo { get; set; }

    }
}
