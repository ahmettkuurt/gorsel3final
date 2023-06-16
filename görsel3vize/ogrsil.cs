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
    public partial class ogrsil : Form
    {
        public ogrsil()
        {
            InitializeComponent();
        }
        public string ad,id;
        bool move;
        int mouse_x;
        int mouse_y;

        private void sil_Click(object sender, EventArgs e)
        {
            sqlbaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("delete from ögrenciler where ogrID=@id",sqlbaglantisi.connection);

            komut.Parameters.AddWithValue("@id",lblid.Text);

            komut.ExecuteNonQuery();
            sqlbaglantisi.connection.Close();
            MessageBox.Show("Öğrencinin Kaydı Başarıyla Silindi","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            idarisayfa syf = new idarisayfa();
            MessageBox.Show("Kayıt Silme İşlemi İptal Edildi","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            syf.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            idarisayfa syf = new idarisayfa();
            syf.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ogrsil_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void ogrsil_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void ogrsil_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
            
        }

        private void ogrsil_Load(object sender, EventArgs e)
        {
            lblad.Text = ad;
            lblid.Text = id;
        }
    }
}
