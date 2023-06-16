using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace görsel3vize
{
    /****************************************************************************
    **                       Düzce Üniversitesi
                             Akçakoca MYO
                             Bilgisayar Teknolojileri Bölümü
    ** Video Linki :
    **                       ÖDEV NUMARASI…...:
    **                       ÖĞRENCİ ADI......: Ahmet Kurt
    **                       ÖĞRENCİ NUMARASI.: 211501023
    **                       ÖĞRENİM TÜRÜ ....: Örgün Öğretim
    ****************************************************************************/
    public partial class idarisayfa : Form
    {
        public idarisayfa()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;

        private void ogrenciler_Click(object sender, EventArgs e)
        {
            ogrenciler ogr = new ogrenciler();
            ogr.Show();
            this.Hide();

        }

        private void ogrekle_Click(object sender, EventArgs e)
        {
            ogrekle ekle = new ogrekle();
            ekle.Show();
            this.Hide();
        }

        private void ogrduzenle_Click(object sender, EventArgs e)
        {
            ogrduzenle düzenle=new ogrduzenle();
            düzenle.Show();
            this.Hide();
        }

        private void ogrsil_Click(object sender, EventArgs e)
        {
            ogrsil sil=new ogrsil();
            sil.Show();
            this.Hide();
        }

        private void sikayetler_Click(object sender, EventArgs e)
        {
            sikayetler sikayet=new sikayetler();
            sikayet.Show();
            this.Hide();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            anasayfa syf = new anasayfa();
            MessageBox.Show("Oturum Kapatıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            syf.Show();
            this.Hide();
        }

        private void idarisayfa_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void idarisayfa_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void idarisayfa_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
