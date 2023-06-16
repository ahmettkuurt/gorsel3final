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
    public partial class sikayetgörüntüle : Form
    {
        public sikayetgörüntüle()
        {
            InitializeComponent();
        }
        public string sikayetbak;
        bool move;
        int mouse_x;
        int mouse_y;

        private void sikayetgörüntüle_Load(object sender, EventArgs e)
        {
            skybak.Enabled = false;

            skybak.Text = sikayetbak;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sikayetler s = new sikayetler();
            s.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sikayetgörüntüle_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void sikayetgörüntüle_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void sikayetgörüntüle_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
