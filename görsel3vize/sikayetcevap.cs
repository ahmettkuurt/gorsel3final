using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
    public partial class sikayetcevap : Form
    {
        public sikayetcevap()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;
        public string a;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sikayetler s = new sikayetler();
            s.Show();
            this.Hide();
        }

        private void sikayet_Click(object sender, EventArgs e)
        {
            sqlbaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("update sikayet set cevap=@cvp where sikayetID="+a, sqlbaglantisi.connection);

            komut.Parameters.AddWithValue("@cvp",txtyanit.Text);

            komut.ExecuteNonQuery();

            sqlbaglantisi.connection.Close();
            MessageBox.Show("Yanıtınız Başarıyla Gönderilmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtyanit.Text = "";

            sikayetler s = new sikayetler();
            s.Show();
            this.Hide();

        }

        private void sikayet_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void sikayet_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void sikayet_MouseUp(object sender, MouseEventArgs e)
        {
            move=false;
        }
    }
}
