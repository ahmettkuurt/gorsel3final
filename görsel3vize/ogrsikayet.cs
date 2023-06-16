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
    public partial class ogrsikayet : Form
    {
        public ogrsikayet()
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
            ogrsayfa syf = new ogrsayfa();
            syf.Show();
            this.Hide();
        }

        private void ogrsikayet_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void ogrsikayet_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void ogrsikayet_MouseUp(object sender, MouseEventArgs e)
        {
            move=false;
        }

        private void sikayetet_Click(object sender, EventArgs e)
        {
            sikayetEtme sy = new sikayetEtme();
            sy.Show();
            this.Hide();

        }

        private void ogrsikayett_Click(object sender, EventArgs e)
        {
            ogrsikayetler st = new ogrsikayetler();
            st.Show();
            this.Hide();
        }
    }
}
