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
    public partial class bilgiler : Form
    {
        public bilgiler()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;

        private void bilgiler_Load(object sender, EventArgs e)
        {
            
            ogrno.Enabled = false;
            txtisim.Enabled = false;
            txtsoyisim.Enabled = false;
            txttc.Enabled = false;
            txttel.Enabled = false;
            txtadres.Enabled = false;
            txtkadi.Enabled = false;
            txtsifre.Enabled = false;
            txtannetel.Enabled = false;
            txtbabatel.Enabled = false;
            txtoda.Enabled = false; 

            sqlbaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("select*from ögrenciler where ogrID=@id", sqlbaglantisi.connection);

            komut.Parameters.AddWithValue("@id",ogrgiris.kid.ToString());

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
                    txtoda.Text=dr["odano"].ToString();

                }
            }
            dr.Close();
            sqlbaglantisi.connection.Close();   







        }

        private void bilgiler_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void bilgiler_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void bilgiler_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ogrsayfa syf = new ogrsayfa();
            syf.Show();
            this.Hide();
        }
    }
}
