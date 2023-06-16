namespace görsel3vize
{
    partial class idarisayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sikayetler = new System.Windows.Forms.Button();
            this.ogrekle = new System.Windows.Forms.Button();
            this.ogrenciler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::görsel3vize.Properties.Resources.external_24px;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::görsel3vize.Properties.Resources.close_64px;
            this.pictureBox1.Location = new System.Drawing.Point(738, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sikayetler
            // 
            this.sikayetler.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sikayetler.Image = global::görsel3vize.Properties.Resources.urun;
            this.sikayetler.Location = new System.Drawing.Point(596, 152);
            this.sikayetler.Name = "sikayetler";
            this.sikayetler.Size = new System.Drawing.Size(154, 144);
            this.sikayetler.TabIndex = 4;
            this.sikayetler.Text = "Şikayetler";
            this.sikayetler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sikayetler.UseVisualStyleBackColor = true;
            this.sikayetler.Click += new System.EventHandler(this.sikayetler_Click);
            // 
            // ogrekle
            // 
            this.ogrekle.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrekle.Image = global::görsel3vize.Properties.Resources.musteri_ekle;
            this.ogrekle.Location = new System.Drawing.Point(310, 152);
            this.ogrekle.Name = "ogrekle";
            this.ogrekle.Size = new System.Drawing.Size(154, 144);
            this.ogrekle.TabIndex = 1;
            this.ogrekle.Text = "Öğrenci Ekle";
            this.ogrekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ogrekle.UseVisualStyleBackColor = true;
            this.ogrekle.Click += new System.EventHandler(this.ogrekle_Click);
            // 
            // ogrenciler
            // 
            this.ogrenciler.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenciler.Image = global::görsel3vize.Properties.Resources.musteri;
            this.ogrenciler.Location = new System.Drawing.Point(56, 152);
            this.ogrenciler.Name = "ogrenciler";
            this.ogrenciler.Size = new System.Drawing.Size(154, 144);
            this.ogrenciler.TabIndex = 0;
            this.ogrenciler.Text = "Öğrenciler";
            this.ogrenciler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ogrenciler.UseVisualStyleBackColor = true;
            this.ogrenciler.Click += new System.EventHandler(this.ogrenciler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(287, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "İDARİ SİSTEMİ";
            // 
            // idarisayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sikayetler);
            this.Controls.Add(this.ogrekle);
            this.Controls.Add(this.ogrenciler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "idarisayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.idarisayfa_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.idarisayfa_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.idarisayfa_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ogrenciler;
        private System.Windows.Forms.Button ogrekle;
        private System.Windows.Forms.Button sikayetler;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}