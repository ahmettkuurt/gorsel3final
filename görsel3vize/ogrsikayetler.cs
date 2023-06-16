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
    public partial class ogrsikayetler : Form
    {
        public ogrsikayetler()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ogrsikayet sy = new ogrsikayet();
            sy.Show();
            this.Hide();
        }

        private void ogrsikayetler_Load(object sender, EventArgs e)
        {
            sqlbaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("select sikayetID,sikayet,cevap from sikayet where ogrID=@id", sqlbaglantisi.connection);
            komut.Parameters.AddWithValue("@id", ogrgiris.kid);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds, "sikayet");
            dataGridView1.DataSource = ds.Tables[0];
            sqlbaglantisi.connection.Close();
        }

        private void sikayetbak_Click(object sender, EventArgs e)
        {
            ogrsikayetbak sy=new ogrsikayetbak();
            sy.sikayet= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            sy.yanit= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            sy.Show();
            this.Hide();
        }

        private void sikayetsil_Click(object sender, EventArgs e)
        {
            ogrsikayetsil sl= new ogrsikayetsil();
            sl.lbl= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            sl.Show();
            this.Hide();
        }
    }
}
