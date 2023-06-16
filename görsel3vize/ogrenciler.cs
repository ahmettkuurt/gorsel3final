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
    public partial class ogrenciler : Form
    {
        public ogrenciler()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;
        


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

        private void ogrenciler_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void ogrenciler_MouseMove(object sender, MouseEventArgs e)
        {
            if(move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void ogrenciler_MouseUp(object sender, MouseEventArgs e)
        {
            move=false;
        }

        private void ogrenciler_Load(object sender, EventArgs e)

        {
            // TODO: This line of code loads data into the 'görsel3vizeDataSet1.ögrenciler' table. You can move, or remove it, as needed.
            this.ögrencilerTableAdapter.Fill(this.görsel3vizeDataSet1.ögrenciler);
            // TODO: This line of code loads data into the 'görsel3vizeDataSet.ögrenciler' table. You can move, or remove it, as needed.
            this.ögrencilerTableAdapter.Fill(this.görsel3vizeDataSet.ögrenciler);

            
        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            ogrduzenle dzn = new ogrduzenle();
            dzn.isim= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dzn.soyisim= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dzn.tc= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dzn.tel= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dzn.adres= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dzn.annetel= dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dzn.babatel = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            dzn.ogrnoo= dataGridView1.CurrentRow.Cells[0].Value.ToString();

            dzn.Show();
            this.Hide();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            ogrsil sl = new ogrsil();
            sl.ad= dataGridView1.CurrentRow.Cells[1].Value.ToString() +" "+ dataGridView1.CurrentRow.Cells[2].Value.ToString();
            sl.id=dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
            sl.Show();
            this.Hide();
        }

        private void ograrama_TextChanged(object sender, EventArgs e)
        {
            string bul = "Select * from ögrenciler where ogrisim +ogrsoyisim like '%"+ograrama.Text+"%'";
            SqlDataAdapter adp = new SqlDataAdapter(bul, sqlbaglantisi.connection);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource= dt;
        }
    }
}
