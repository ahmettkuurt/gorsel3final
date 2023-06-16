﻿using System;
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
    public partial class ogrgiris : Form
    {
        public ogrgiris()
        {
            InitializeComponent();
        }
        public static int kid;
        bool move;
        int mouse_x;
        int mouse_y;

        private void ogrgiris_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void ogrgiris_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void ogrgiris_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void giris_Click(object sender, EventArgs e)
        {
            

            SqlCommand koumut = new SqlCommand("select ö.ogrID from ögrenciler as ö where ö.kadi=@kadi and ö.sifre=@sifre", sqlbaglantisi.connection);
            sqlbaglantisi.CheckConnection();

            koumut.Parameters.AddWithValue("@kadi", kadi.Text);
            koumut.Parameters.AddWithValue("@sifre", sifre.Text);
            kid=Convert.ToInt32(koumut.ExecuteScalar());
            SqlDataReader dr =koumut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Hoş Geldiniz","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ogrsayfa syf = new ogrsayfa();
                syf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı !!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            sqlbaglantisi.connection.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            anasayfa syf = new anasayfa();
            syf.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void kadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox işaretli ise
            if (checkBox1.Checked)
            {
                //karakteri göster.
                sifre.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                sifre.PasswordChar = '*';
            }
        }
    }
}
