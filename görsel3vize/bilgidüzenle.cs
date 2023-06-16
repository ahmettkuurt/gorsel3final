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
    public partial class bilgidüzenle : Form
    {
        public bilgidüzenle()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;
        private void btngüncelle_Click(object sender, EventArgs e)
        {
            sqlbaglantisi.CheckConnection();

            SqlCommand komut = new SqlCommand("update ögrenciler  set ogrisim=@isim,ogrsoyisim=@soyisim,ogrtc=@tc,ogrtel=@tel,ogradres=@adres,annetelno=@annetel,babatelno=@babatel,kadi=@kadi,sifre=@sifre where ogrID="+ ogrgiris.kid,sqlbaglantisi.connection);

            komut.Parameters.AddWithValue("@isim",txtisim.Text);
            komut.Parameters.AddWithValue("@soyisim",txtsoyisim.Text);
            komut.Parameters.AddWithValue("@tc",txttc.Text);
            komut.Parameters.AddWithValue("@tel",txttel.Text);
            komut.Parameters.AddWithValue("@adres",txtadres.Text);
            komut.Parameters.AddWithValue("@annetel",txtannetel.Text);
            komut.Parameters.AddWithValue("@babatel",txtbabatel.Text);
            komut.Parameters.AddWithValue("@kadi",txtkadi.Text);
            komut.Parameters.AddWithValue("@sifre",txtsifre.Text);

            komut.ExecuteNonQuery();

            sqlbaglantisi.connection.Close();

            MessageBox.Show("Öğrencinin Bilgileri Başarıyla Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bilgidüzenle_Load(object sender, EventArgs e)
        {
            ogrno.Enabled = false;
            txtoda.Enabled = false;
            sqlbaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("select*from ögrenciler where ogrID=@id", sqlbaglantisi.connection);

            komut.Parameters.AddWithValue("@id", ogrgiris.kid.ToString());

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtisim.Text = dr["ogrisim"].ToString();
                    txtsoyisim.Text = dr["ogrsoyisim"].ToString();
                    txttel.Text = dr["ogrtel"].ToString();
                    txtkadi.Text = dr["kadi"].ToString();
                    txtsifre.Text = dr["sifre"].ToString();
                    txttc.Text = dr["ogrtc"].ToString();
                    txtadres.Text = dr["ogradres"].ToString();
                    ogrno.Text = dr["ogrID"].ToString();
                    txtannetel.Text = dr["annetelno"].ToString();
                    txtbabatel.Text = dr["babatelno"].ToString();
                    txtoda.Text = dr["odano"].ToString();

                }
            }
            dr.Close();
            sqlbaglantisi.connection.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ogrsayfa syf = new ogrsayfa();
            syf.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bilgidüzenle_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void bilgidüzenle_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void bilgidüzenle_MouseUp(object sender, MouseEventArgs e)
        {
            move=false;
        }
    }
}
