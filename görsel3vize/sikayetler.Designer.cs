namespace görsel3vize
{
    partial class sikayetler
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sikayetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.görsel3vizeDataSet = new görsel3vize.görsel3finalDataSet();
            this.sikayetTableAdapter = new görsel3vize.görsel3finalDataSetTableAdapters.sikayetTableAdapter();
            this.cevapla = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.görüntüle = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sikayetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.görsel3vizeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 38);
            this.label1.TabIndex = 42;
            this.label1.Text = "ŞİKAYETLER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(672, 362);
            this.dataGridView1.TabIndex = 43;
            // 
            // sikayetBindingSource
            // 
            this.sikayetBindingSource.DataMember = "sikayet";
            this.sikayetBindingSource.DataSource = this.görsel3vizeDataSet;
            // 
            // görsel3vizeDataSet
            // 
            this.görsel3vizeDataSet.DataSetName = "görsel3vizeDataSet";
            this.görsel3vizeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sikayetTableAdapter
            // 
            this.sikayetTableAdapter.ClearBeforeFill = true;
            // 
            // cevapla
            // 
            this.cevapla.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevapla.Image = global::görsel3vize.Properties.Resources.ekle;
            this.cevapla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cevapla.Location = new System.Drawing.Point(723, 199);
            this.cevapla.Name = "cevapla";
            this.cevapla.Size = new System.Drawing.Size(126, 49);
            this.cevapla.TabIndex = 46;
            this.cevapla.Text = "Cevapla";
            this.cevapla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cevapla.UseVisualStyleBackColor = true;
            this.cevapla.Click += new System.EventHandler(this.cevapla_Click);
            // 
            // sil
            // 
            this.sil.Font = new System.Drawing.Font("Arial Black", 11F);
            this.sil.Image = global::görsel3vize.Properties.Resources.carpi32;
            this.sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sil.Location = new System.Drawing.Point(723, 282);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(126, 48);
            this.sil.TabIndex = 45;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // görüntüle
            // 
            this.görüntüle.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.görüntüle.Image = global::görsel3vize.Properties.Resources.ara;
            this.görüntüle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.görüntüle.Location = new System.Drawing.Point(723, 122);
            this.görüntüle.Name = "görüntüle";
            this.görüntüle.Size = new System.Drawing.Size(126, 49);
            this.görüntüle.TabIndex = 44;
            this.görüntüle.Text = "Görüntüle";
            this.görüntüle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.görüntüle.UseVisualStyleBackColor = true;
            this.görüntüle.Click += new System.EventHandler(this.görüntüle_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::görsel3vize.Properties.Resources.back_48px;
            this.pictureBox2.Location = new System.Drawing.Point(10, 9);
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
            this.pictureBox1.Location = new System.Drawing.Point(812, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sikayetler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(874, 453);
            this.Controls.Add(this.cevapla);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.görüntüle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sikayetler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sikayetler";
            this.Load += new System.EventHandler(this.sikayetler_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sikayetler_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sikayetler_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sikayetler_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sikayetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.görsel3vizeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private görsel3finalDataSet görsel3vizeDataSet;
        private System.Windows.Forms.BindingSource sikayetBindingSource;
        private görsel3finalDataSetTableAdapters.sikayetTableAdapter sikayetTableAdapter;
        private System.Windows.Forms.Button görüntüle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button cevapla;
    }
}