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
    public partial class ogrsayfa : Form
    {
        public ogrsayfa()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            anasayfa syf = new anasayfa();  
            MessageBox.Show("Oturum Kapatıldı","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
            syf.Show();
            this.Hide();
        }

        private void ogrsayfa_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void ogrsayfa_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void ogrsayfa_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void bilgidüzenle_Click(object sender, EventArgs e)
        {
            bilgidüzenle dzn = new bilgidüzenle();
            dzn.Show();
        }

        

        private void bilgiler_Click(object sender, EventArgs e)
        {
            bilgiler blg = new bilgiler();
            blg.Show();
        }

        private void sikayet_Click(object sender, EventArgs e)
        {
            ogrsikayet skyt = new ogrsikayet();   
            skyt.Show();
        }
    }
}
