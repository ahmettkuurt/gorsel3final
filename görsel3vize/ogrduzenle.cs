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
    public partial class ogrduzenle : Form
    {
        public ogrduzenle()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;
        public string isim,soyisim,tc,tel,adres,annetel,babatel,ogrnoo;

        

        private void güncelle_Click(object sender, EventArgs e)
        {
            sqlbaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("update ögrenciler set ogrisim=@isim,ogrsoyisim=@soyisim,ogrtc=@tc,ogrtel=@tel,ogradres=@adres,annetelno=@annetel,babatelno=@babatel  where  ogrID=@id" ,sqlbaglantisi.connection);

            komut.Parameters.AddWithValue("@isim", txtisim.Text);
            komut.Parameters.AddWithValue("@soyisim", txtsoyisim.Text);
            komut.Parameters.AddWithValue("@tc", txttc.Text);
            komut.Parameters.AddWithValue("@tel", txttel.Text);
            komut.Parameters.AddWithValue("@adres", txtadres.Text);
            komut.Parameters.AddWithValue("@annetel", txtannetel.Text);
            komut.Parameters.AddWithValue("@babatel", txtbabatel.Text);
            komut.Parameters.AddWithValue("@id", ogrno.Text);

            komut.ExecuteNonQuery();
            sqlbaglantisi.connection.Close();
            MessageBox.Show("Öğrenci Bİlgileri Başarıyla Güncellendi" , "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ogrduzenle_MouseUp(object sender, MouseEventArgs e)
        {
            move=false;
            
        }

        private void ogrduzenle_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void ogrduzenle_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;

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

        private void ogrduzenle_Load(object sender, EventArgs e)
        {
            
            ogrno.Enabled=false;
           

            txtisim.Text = isim;
            txtsoyisim.Text = soyisim;
            txttc.Text = tc;
            txttel.Text = tel;
            txtadres.Text =adres;
            txtannetel.Text = annetel;
            txtbabatel.Text = babatel;
            ogrno.Text = ogrnoo;


        }
    }
}
