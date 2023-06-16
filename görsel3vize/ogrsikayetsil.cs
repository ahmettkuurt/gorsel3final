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
    public partial class ogrsikayetsil : Form
    {
        public ogrsikayetsil()
        {
            InitializeComponent();
        }
        public string lbl;
        bool move;
        int mouse_x;
        int mouse_y;

        private void ogrsikayetsil_Load(object sender, EventArgs e)
        {

        }

        private void sil_Click(object sender, EventArgs e)
        {
            sqlbaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("delete from sikayet where sikayetID='"+lbl+"'", sqlbaglantisi.connection);

            komut.ExecuteNonQuery();
            sqlbaglantisi.connection.Close();
            MessageBox.Show("Şikayet Kaydı Başarıyla Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ogrsikayetler syf = new ogrsikayetler();
            syf.Show();
            this.Hide();
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            ogrsikayetler syf = new ogrsikayetler();
            MessageBox.Show("Kayıt Silme İşlemi İptal Edildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            syf.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ogrsikayetler sy = new ogrsikayetler();
            sy.Show();
            this.Hide();
        }

        private void ogrsikayetsil_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void ogrsikayetsil_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void ogrsikayetsil_MouseUp(object sender, MouseEventArgs e)
        {
            move=false;
        }
    }
}
