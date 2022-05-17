using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SınavModuluProje
{
    public partial class OgrenciBilgileri : Form
    {
        string OgrenciTcNo=""; // datagridviewda tıklanılan öğrencinin tcsini tutar
        OgrenciDAL ogrenciDAL = new OgrenciDAL();
        Ogrenci ogrenci = new Ogrenci();
        public OgrenciBilgileri()
        {
            InitializeComponent();
        }
        private void OgrenciBilgileri_Load(object sender, EventArgs e)
        {
            dgwOgrenci.DataSource = ogrenciDAL.GetAll(); // veritabanındaki tüm öğrencileri datagridviewa gösterir
        }

        private void dgwOgrenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OgrenciTcNo =(dgwOgrenci.CurrentRow.Cells[3].Value).ToString();  // tıklanılan satırın 4. columda bulunan değeri alır (tc) 
            OgrenciRaporGöster();
        }
        public void OgrenciRaporGöster()
        {
            ogrenci = ogrenciDAL.GetOgrenci(OgrenciTcNo);
            SinavSorumluOgrenciRaporForm raporForm = new SinavSorumluOgrenciRaporForm();
            this.Hide();
            raporForm.ogrenci = ogrenci; 
            raporForm.ShowDialog();
            


        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }
    }
}
