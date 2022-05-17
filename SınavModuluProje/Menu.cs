using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SınavModuluProje
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnOgrenciGiris_Click(object sender, EventArgs e) // Ogrenci giris formmuna yönlendirir
        {
            OgrneciGiris ogrneciGiris = new OgrneciGiris();
            this.Hide();
            ogrneciGiris.ShowDialog();
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e) //Admin Ogrenci giris formmuna yönlendirir
        {
            AdminGirisForm adminGirisForm = new AdminGirisForm();
            this.Hide();
            adminGirisForm.ShowDialog();
        }

        private void btnSinavSorum_Click(object sender, EventArgs e) // Sinav Sorumlusu formuna yönlendirir
        {
            SinavSorumluGirisForm sinavSorumluGirisForm = new SinavSorumluGirisForm();
            this.Hide();
            sinavSorumluGirisForm.ShowDialog();
        }
    }
}
