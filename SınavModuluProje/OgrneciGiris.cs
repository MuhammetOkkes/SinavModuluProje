using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SınavModuluProje
{
    public partial class OgrneciGiris : Form
    {
        OgrenciDAL ogrenciDAL = new OgrenciDAL();
        public OgrneciGiris()
        {
            InitializeComponent();
        }

       
        private void btnGiris_Click(object sender, EventArgs e) 
        {
            Ogrenci ogrenci = ogrenciDAL.GetOgrenci(tbxTc.Text);
            if(ogrenci.TcNo != null)
            {
                if(ogrenci.TcNo == tbxTc.Text && ogrenci.Sifre == tbxSifre.Text)
                {
                   
                    OgrenciMenu ogrenciMenu = new OgrenciMenu();
                    ogrenciMenu.ogrenci = ogrenci;
                    this.Hide();
                    ogrenciMenu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı ya da hatalı giriş yaptınız");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı ya da hatalı giriş yaptınız");
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            OgrenciKayit ogrenciKayit = new OgrenciKayit();
            this.Hide();
            ogrenciKayit.ShowDialog();
        }
    }
}
