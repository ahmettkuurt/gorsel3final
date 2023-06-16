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
    public partial class sikayetler : Form
    {
        public sikayetler()
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

        private void sikayetler_Load(object sender, EventArgs e)
        {
            sqlbaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("select sikayetID,sikayet,cevap from sikayet",sqlbaglantisi.connection);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds, "sikayet");
            dataGridView1.DataSource = ds.Tables[0];
            sqlbaglantisi.connection.Close();

        }

        private void görüntüle_Click(object sender, EventArgs e)
        {
            sikayetgörüntüle sk = new sikayetgörüntüle();
            sk.sikayetbak= dataGridView1.CurrentRow.Cells[1].Value.ToString();

            sk.Show();
            this.Hide();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            sikayetsil sl = new sikayetsil();
            sl.lbl= dataGridView1.CurrentRow.Cells[0].Value.ToString();

            sl.Show();
            this.Hide();
        }

        private void sikayetler_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void sikayetler_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void sikayetler_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void cevapla_Click(object sender, EventArgs e)
        {
            sikayetcevap sc = new sikayetcevap();
            sc.a= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            sc.Show();
            this.Hide();
        }
    }
}
