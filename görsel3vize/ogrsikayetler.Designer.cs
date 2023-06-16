namespace görsel3vize
{
    partial class ogrsikayetler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sikayetbak = new System.Windows.Forms.Button();
            this.sikayetsil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(251, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 38);
            this.label1.TabIndex = 45;
            this.label1.Text = "ŞİKAYET BİLDİR";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::görsel3vize.Properties.Resources.back_48px;
            this.pictureBox2.Location = new System.Drawing.Point(9, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::görsel3vize.Properties.Resources.close_64px;
            this.pictureBox1.Location = new System.Drawing.Point(735, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 360);
            this.dataGridView1.TabIndex = 46;
            // 
            // sikayetbak
            // 
            this.sikayetbak.Location = new System.Drawing.Point(688, 173);
            this.sikayetbak.Name = "sikayetbak";
            this.sikayetbak.Size = new System.Drawing.Size(97, 35);
            this.sikayetbak.TabIndex = 47;
            this.sikayetbak.Text = "Yanıt Bak";
            this.sikayetbak.UseVisualStyleBackColor = true;
            this.sikayetbak.Click += new System.EventHandler(this.sikayetbak_Click);
            // 
            // sikayetsil
            // 
            this.sikayetsil.Location = new System.Drawing.Point(688, 268);
            this.sikayetsil.Name = "sikayetsil";
            this.sikayetsil.Size = new System.Drawing.Size(97, 37);
            this.sikayetsil.TabIndex = 48;
            this.sikayetsil.Text = "Şikayet Sİl";
            this.sikayetsil.UseVisualStyleBackColor = true;
            this.sikayetsil.Click += new System.EventHandler(this.sikayetsil_Click);
            // 
            // ogrsikayetler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sikayetsil);
            this.Controls.Add(this.sikayetbak);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ogrsikayetler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ogrsikayetler";
            this.Load += new System.EventHandler(this.ogrsikayetler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sikayetbak;
        private System.Windows.Forms.Button sikayetsil;
    }
}