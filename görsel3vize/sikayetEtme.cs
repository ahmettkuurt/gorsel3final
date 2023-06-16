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
    public partial class sikayetEtme : Form
    {
        public sikayetEtme()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;

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

        private void sikayetEtme_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void sikayetEtme_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void sikayetEtme_MouseUp(object sender, MouseEventArgs e)
        {
            move=false;
        }

        private void sikayet_Click(object sender, EventArgs e)
        {
            sqlbaglantisi.CheckConnection();

            SqlCommand komut = new SqlCommand("insert into  sikayet(sikayet,ogrID) values (@sikayet,@id) ",sqlbaglantisi.connection);

            komut.Parameters.AddWithValue("@sikayet", txtsikayet.Text);
            komut.Parameters.AddWithValue("@id", ogrgiris.kid);
            komut.ExecuteNonQuery();

            sqlbaglantisi.connection.Close();   
            MessageBox.Show("Şikayetiniz Başarıyla İletilmiştir.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);

            txtsikayet.Text = "";

        }

        private void txtsikayet_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sikayetEtme_Load(object sender, EventArgs e)
        {

        }
    }
}
