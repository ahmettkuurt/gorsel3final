namespace görsel3vize
{
    partial class anasayfa
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ogrgiris = new System.Windows.Forms.Button();
            this.idarigiris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(224, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = " YURT  SİSTEMİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(102, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "İDARİ GİRİŞ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(499, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "ÖĞRENCİ GİRİŞ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::görsel3vize.Properties.Resources.close_64px1;
            this.pictureBox1.Location = new System.Drawing.Point(751, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ogrgiris
            // 
            this.ogrgiris.ForeColor = System.Drawing.Color.Transparent;
            this.ogrgiris.Image = global::görsel3vize.Properties.Resources.male_user_100px1;
            this.ogrgiris.Location = new System.Drawing.Point(504, 132);
            this.ogrgiris.Name = "ogrgiris";
            this.ogrgiris.Size = new System.Drawing.Size(174, 164);
            this.ogrgiris.TabIndex = 1;
            this.ogrgiris.UseVisualStyleBackColor = true;
            this.ogrgiris.Click += new System.EventHandler(this.ogrgiris_Click);
            // 
            // idarigiris
            // 
            this.idarigiris.Image = global::görsel3vize.Properties.Resources.male_user_100px1;
            this.idarigiris.Location = new System.Drawing.Point(91, 132);
            this.idarigiris.Name = "idarigiris";
            this.idarigiris.Size = new System.Drawing.Size(174, 164);
            this.idarigiris.TabIndex = 0;
            this.idarigiris.UseVisualStyleBackColor = true;
            this.idarigiris.Click += new System.EventHandler(this.idarigiris_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ogrgiris);
            this.Controls.Add(this.idarigiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yurt Kayıt Sistemi";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.anasayfa_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.anasayfa_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.anasayfa_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button idarigiris;
        private System.Windows.Forms.Button ogrgiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}