using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SınavModuluProje
{
    public partial class OgrenciMenu : Form
    {
        public Ogrenci ogrenci;
        public OgrenciMenu()
        {
            InitializeComponent();
        }

        private void btnSinavModul_Click(object sender, EventArgs e) // öğrencinin sınava girdiği formu açar
        {
            SinavModuluForm sinavModuluForm = new SinavModuluForm();
            sinavModuluForm.OgrenciTc = ogrenci.TcNo; 
            this.Hide();
            sinavModuluForm.ShowDialog();

        }

        private void btnProfil_Click(object sender, EventArgs e) // öğrencinin profiline gider
        {
            OgrenciProfilForm ogrenciProfilForm = new OgrenciProfilForm();
            ogrenciProfilForm.ogrenci = ogrenci;
            this.Hide();
            ogrenciProfilForm.ShowDialog();

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            OgrneciGiris ogrneciGiris = new OgrneciGiris();
            this.Hide();
            ogrneciGiris.ShowDialog();
        }

        private void btnRapor_Click(object sender, EventArgs e) // öğrenciye ait sinav analizlerinin raporu gösterilir
        {
            RaporForm raporForm = new RaporForm();
            raporForm.ogrenci = ogrenci;
            this.Hide();
            raporForm.ShowDialog();
        }
    }
}
