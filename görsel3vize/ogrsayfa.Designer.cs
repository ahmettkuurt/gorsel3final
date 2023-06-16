namespace görsel3vize
{
    partial class ogrsayfa
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sikayet = new System.Windows.Forms.Button();
            this.bilgidüzenle = new System.Windows.Forms.Button();
            this.bilgiler = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "ÖĞRENCİ SİSTEMİ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::görsel3vize.Properties.Resources.external_24px;
            this.pictureBox2.Location = new System.Drawing.Point(8, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::görsel3vize.Properties.Resources.close_64px;
            this.pictureBox1.Location = new System.Drawing.Point(734, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sikayet
            // 
            this.sikayet.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sikayet.Image = global::görsel3vize.Properties.Resources.urun;
            this.sikayet.Location = new System.Drawing.Point(572, 156);
            this.sikayet.Name = "sikayet";
            this.sikayet.Size = new System.Drawing.Size(192, 190);
            this.sikayet.TabIndex = 12;
            this.sikayet.Text = "ŞİKAYET";
            this.sikayet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sikayet.UseVisualStyleBackColor = true;
            this.sikayet.Click += new System.EventHandler(this.sikayet_Click);
            // 
            // bilgidüzenle
            // 
            this.bilgidüzenle.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgidüzenle.Image = global::görsel3vize.Properties.Resources.musteri_duzenle;
            this.bilgidüzenle.Location = new System.Drawing.Point(307, 156);
            this.bilgidüzenle.Name = "bilgidüzenle";
            this.bilgidüzenle.Size = new System.Drawing.Size(192, 190);
            this.bilgidüzenle.TabIndex = 13;
            this.bilgidüzenle.Text = "BİLGİLERİMİ DÜZENLE";
            this.bilgidüzenle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bilgidüzenle.UseVisualStyleBackColor = true;
            this.bilgidüzenle.Click += new System.EventHandler(this.bilgidüzenle_Click);
            // 
            // bilgiler
            // 
            this.bilgiler.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgiler.Image = global::görsel3vize.Properties.Resources.muster_bilgi;
            this.bilgiler.Location = new System.Drawing.Point(23, 156);
            this.bilgiler.Name = "bilgiler";
            this.bilgiler.Size = new System.Drawing.Size(192, 190);
            this.bilgiler.TabIndex = 14;
            this.bilgiler.Text = "BİLGİLERİM";
            this.bilgiler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bilgiler.UseVisualStyleBackColor = true;
            this.bilgiler.Click += new System.EventHandler(this.bilgiler_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblid.Location = new System.Drawing.Point(67, 84);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(35, 13);
            this.lblid.TabIndex = 15;
            this.lblid.Text = "label2";
            // 
            // ogrsayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.bilgiler);
            this.Controls.Add(this.bilgidüzenle);
            this.Controls.Add(this.sikayet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ogrsayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ogrsayfa";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ogrsayfa_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ogrsayfa_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ogrsayfa_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button sikayet;
        private System.Windows.Forms.Button bilgidüzenle;
        private System.Windows.Forms.Button bilgiler;
        private System.Windows.Forms.Label lblid;
    }
}