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
    public partial class ogrekle : Form
    {

        public ogrekle()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            idarisayfa syf=new idarisayfa();
            syf.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ogrekle_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void ogrekle_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void ogrekle_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            



            SqlCommand cmd = new SqlCommand("insert into ögrenciler(ogrisim,ogrsoyisim,ogrtc,ogrtel,ogradres,kadi,sifre,annetelno,babatelno,odaID) values (@ogrisim,@ogrsoyisim,@ogrtc,@ogrtel,@ogradres,@kadi,@sifre,@annetelno,@babatelno,@oda)",sqlbaglantisi.connection);

            sqlbaglantisi.CheckConnection();

            cmd.Parameters.AddWithValue("@ogrisim",txtisim.Text);
            cmd.Parameters.AddWithValue("@ogrsoyisim",txtsoyisim.Text);
            cmd.Parameters.AddWithValue("@ogrtc",txttc.Text);
            cmd.Parameters.AddWithValue("@ogrtel",txttel.Text);
            cmd.Parameters.AddWithValue("@ogradres",txtadres.Text);
            cmd.Parameters.AddWithValue("@kadi",txtkadi.Text);
            cmd.Parameters.AddWithValue("@sifre",txtsifre.Text);
            cmd.Parameters.AddWithValue("@annetelno",txtannetel.Text);
            cmd.Parameters.AddWithValue("@babatelno",txtbabatel.Text);
            cmd.Parameters.AddWithValue("@oda",txtodano.Text);
            
            cmd.ExecuteNonQuery();
            sqlbaglantisi.connection.Close();
            MessageBox.Show("Öğrenci Başarıyla Eklendi","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);

            txtisim.Text = "";
            txtsoyisim.Text = "";
            txttc.Text = "";
            txttel.Text = "";
            txtadres.Text = "";
            txtkadi.Text = "";
            txtsifre.Text = "";
            txtannetel.Text = "";
            txtbabatel.Text = "";
            txtodano.Text = "";

        }

        private void ogrekle_Load(object sender, EventArgs e)
        {
            

        }
    }
}
