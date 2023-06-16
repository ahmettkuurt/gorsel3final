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
    public partial class sikayetsil : Form
    {
        public sikayetsil()
        {
            InitializeComponent();
        }
        public string lbl;
        bool move;
        int mouse_x;
        int mouse_y;

        private void sikayetsil_Load(object sender, EventArgs e)
        {
            lblid.Text = lbl;
        }

        private void sil_Click(object sender, EventArgs e)
        {
            sqlbaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("delete from sikayet where sikayetID=@id", sqlbaglantisi.connection);

            komut.Parameters.AddWithValue("@id", lblid.Text);

            komut.ExecuteNonQuery();
            sqlbaglantisi.connection.Close();
            MessageBox.Show("Şikayet Kaydı Başarıyla Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            sikayetler syf = new sikayetler();
            syf.Show();
            this.Hide();
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            sikayetler syf = new sikayetler();
            MessageBox.Show("Kayıt Silme İşlemi İptal Edildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            syf.Show();
            this.Hide();
        }

        private void iptal_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void iptal_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void iptal_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sikayetler s= new sikayetler();
            s.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblid_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
