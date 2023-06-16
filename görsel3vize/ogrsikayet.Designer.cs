namespace görsel3vize
{
    partial class ogrsikayet
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
            this.ogrsikayett = new System.Windows.Forms.Button();
            this.sikayetet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ogrsikayett
            // 
            this.ogrsikayett.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrsikayett.Location = new System.Drawing.Point(85, 132);
            this.ogrsikayett.Name = "ogrsikayett";
            this.ogrsikayett.Size = new System.Drawing.Size(237, 227);
            this.ogrsikayett.TabIndex = 0;
            this.ogrsikayett.Text = "Şikayetler";
            this.ogrsikayett.UseVisualStyleBackColor = true;
            this.ogrsikayett.Click += new System.EventHandler(this.ogrsikayett_Click);
            // 
            // sikayetet
            // 
            this.sikayetet.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold);
            this.sikayetet.Location = new System.Drawing.Point(471, 132);
            this.sikayetet.Name = "sikayetet";
            this.sikayetet.Size = new System.Drawing.Size(237, 227);
            this.sikayetet.TabIndex = 1;
            this.sikayetet.Text = "Şikayet Et";
            this.sikayetet.UseVisualStyleBackColor = true;
            this.sikayetet.Click += new System.EventHandler(this.sikayetet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(251, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 38);
            this.label1.TabIndex = 42;
            this.label1.Text = "ŞİKAYET BİLDİR";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::görsel3vize.Properties.Resources.back_48px;
            this.pictureBox2.Location = new System.Drawing.Point(9, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::görsel3vize.Properties.Resources.close_64px;
            this.pictureBox1.Location = new System.Drawing.Point(735, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ogrsikayet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sikayetet);
            this.Controls.Add(this.ogrsikayett);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ogrsikayet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ogrsikayet";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ogrsikayet_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ogrsikayet_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ogrsikayet_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ogrsikayett;
        private System.Windows.Forms.Button sikayetet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}