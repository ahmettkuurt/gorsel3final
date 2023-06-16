namespace görsel3vize
{
    partial class sikayetEtme
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
            this.txtsikayet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sikayet = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(255, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 38);
            this.label1.TabIndex = 39;
            this.label1.Text = "ŞİKAYET BİLDİR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtsikayet
            // 
            this.txtsikayet.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsikayet.Location = new System.Drawing.Point(191, 82);
            this.txtsikayet.Multiline = true;
            this.txtsikayet.Name = "txtsikayet";
            this.txtsikayet.Size = new System.Drawing.Size(550, 336);
            this.txtsikayet.TabIndex = 41;
            this.txtsikayet.TextChanged += new System.EventHandler(this.txtsikayet_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 28);
            this.label2.TabIndex = 42;
            this.label2.Text = "ŞİKAYETİNİZ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // sikayet
            // 
            this.sikayet.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sikayet.Image = global::görsel3vize.Properties.Resources.tik32;
            this.sikayet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sikayet.Location = new System.Drawing.Point(25, 275);
            this.sikayet.Name = "sikayet";
            this.sikayet.Size = new System.Drawing.Size(118, 48);
            this.sikayet.TabIndex = 40;
            this.sikayet.Text = "Gönder";
            this.sikayet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sikayet.UseVisualStyleBackColor = true;
            this.sikayet.Click += new System.EventHandler(this.sikayet_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::görsel3vize.Properties.Resources.back_48px;
            this.pictureBox2.Location = new System.Drawing.Point(13, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::görsel3vize.Properties.Resources.close_64px;
            this.pictureBox1.Location = new System.Drawing.Point(739, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sikayetEtme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsikayet);
            this.Controls.Add(this.sikayet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sikayetEtme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sikayetEtme";
            this.Load += new System.EventHandler(this.sikayetEtme_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sikayetEtme_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sikayetEtme_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sikayetEtme_MouseUp);
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
        private System.Windows.Forms.TextBox txtsikayet;
        private System.Windows.Forms.Label label2;
    }
}