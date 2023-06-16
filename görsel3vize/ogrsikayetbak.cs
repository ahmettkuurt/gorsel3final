using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    public partial class ogrsikayetbak : Form
    {
        public ogrsikayetbak()
        {
            InitializeComponent();
        }
        public string sikayet,yanit;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ogrsikayetler sy = new ogrsikayetler();
            sy.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ogrsikayetbak_Load(object sender, EventArgs e)
        {
            txtsikayet.Enabled = false;
            txtyanit.Enabled=false;
            txtsikayet.Text = sikayet;
            txtyanit.Text = yanit;

        }
    }
}
