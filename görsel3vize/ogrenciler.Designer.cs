namespace görsel3vize
{
    partial class ogrenciler
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ograrama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ögrencilerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.görsel3vizeDataSet1 = new görsel3vize.görsel3finalDataSet();
            this.görsel3vizeDataSet = new görsel3vize.görsel3finalDataSet();
            this.ögrencilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ögrencilerTableAdapter = new görsel3vize.görsel3finalDataSetTableAdapters.ögrencilerTableAdapter();
            this.güncelle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.ogrIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrsoyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrtcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrtelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogradresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annetelnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.babatelnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ögrencilerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.görsel3vizeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.görsel3vizeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ögrencilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(373, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 38);
            this.label1.TabIndex = 17;
            this.label1.Text = "ÖĞRENCİLER";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::görsel3vize.Properties.Resources.back_48px;
            this.pictureBox2.Location = new System.Drawing.Point(11, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::görsel3vize.Properties.Resources.close_64px;
            this.pictureBox1.Location = new System.Drawing.Point(826, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ograrama
            // 
            this.ograrama.Location = new System.Drawing.Point(279, 104);
            this.ograrama.Name = "ograrama";
            this.ograrama.Size = new System.Drawing.Size(156, 20);
            this.ograrama.TabIndex = 18;
            this.ograrama.TextChanged += new System.EventHandler(this.ograrama_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Öğrenci Adı Soyadı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrIDDataGridViewTextBoxColumn,
            this.ogrisimDataGridViewTextBoxColumn,
            this.ogrsoyisimDataGridViewTextBoxColumn,
            this.ogrtcDataGridViewTextBoxColumn,
            this.ogrtelDataGridViewTextBoxColumn,
            this.ogradresDataGridViewTextBoxColumn,
            this.annetelnoDataGridViewTextBoxColumn,
            this.babatelnoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ögrencilerBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(31, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(845, 386);
            this.dataGridView1.TabIndex = 20;
            // 
            // ögrencilerBindingSource1
            // 
            this.ögrencilerBindingSource1.DataMember = "ögrenciler";
            this.ögrencilerBindingSource1.DataSource = this.görsel3vizeDataSet1;
            // 
            // görsel3vizeDataSet1
            // 
            this.görsel3vizeDataSet1.DataSetName = "görsel3vizeDataSet";
            this.görsel3vizeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // görsel3vizeDataSet
            // 
            this.görsel3vizeDataSet.DataSetName = "görsel3vizeDataSet";
            this.görsel3vizeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ögrencilerBindingSource
            // 
            this.ögrencilerBindingSource.DataMember = "ögrenciler";
            this.ögrencilerBindingSource.DataSource = this.görsel3vizeDataSet;
            // 
            // ögrencilerTableAdapter
            // 
            this.ögrencilerTableAdapter.ClearBeforeFill = true;
            // 
            // güncelle
            // 
            this.güncelle.Image = global::görsel3vize.Properties.Resources.musteri_duzenle;
            this.güncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.güncelle.Location = new System.Drawing.Point(530, 88);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(102, 50);
            this.güncelle.TabIndex = 21;
            this.güncelle.Text = "Güncelle";
            this.güncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.güncelle.UseVisualStyleBackColor = true;
            this.güncelle.Click += new System.EventHandler(this.güncelle_Click);
            // 
            // sil
            // 
            this.sil.Image = global::görsel3vize.Properties.Resources.musteri_sil;
            this.sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sil.Location = new System.Drawing.Point(692, 88);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(77, 50);
            this.sil.TabIndex = 22;
            this.sil.Text = "Sİl";
            this.sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // ogrIDDataGridViewTextBoxColumn
            // 
            this.ogrIDDataGridViewTextBoxColumn.DataPropertyName = "ogrID";
            this.ogrIDDataGridViewTextBoxColumn.HeaderText = "ogrID";
            this.ogrIDDataGridViewTextBoxColumn.Name = "ogrIDDataGridViewTextBoxColumn";
            this.ogrIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrisimDataGridViewTextBoxColumn
            // 
            this.ogrisimDataGridViewTextBoxColumn.DataPropertyName = "ogrisim";
            this.ogrisimDataGridViewTextBoxColumn.HeaderText = "ogrisim";
            this.ogrisimDataGridViewTextBoxColumn.Name = "ogrisimDataGridViewTextBoxColumn";
            this.ogrisimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrsoyisimDataGridViewTextBoxColumn
            // 
            this.ogrsoyisimDataGridViewTextBoxColumn.DataPropertyName = "ogrsoyisim";
            this.ogrsoyisimDataGridViewTextBoxColumn.HeaderText = "ogrsoyisim";
            this.ogrsoyisimDataGridViewTextBoxColumn.Name = "ogrsoyisimDataGridViewTextBoxColumn";
            this.ogrsoyisimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrtcDataGridViewTextBoxColumn
            // 
            this.ogrtcDataGridViewTextBoxColumn.DataPropertyName = "ogrtc";
            this.ogrtcDataGridViewTextBoxColumn.HeaderText = "ogrtc";
            this.ogrtcDataGridViewTextBoxColumn.Name = "ogrtcDataGridViewTextBoxColumn";
            this.ogrtcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrtelDataGridViewTextBoxColumn
            // 
            this.ogrtelDataGridViewTextBoxColumn.DataPropertyName = "ogrtel";
            this.ogrtelDataGridViewTextBoxColumn.HeaderText = "ogrtel";
            this.ogrtelDataGridViewTextBoxColumn.Name = "ogrtelDataGridViewTextBoxColumn";
            this.ogrtelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogradresDataGridViewTextBoxColumn
            // 
            this.ogradresDataGridViewTextBoxColumn.DataPropertyName = "ogradres";
            this.ogradresDataGridViewTextBoxColumn.HeaderText = "ogradres";
            this.ogradresDataGridViewTextBoxColumn.Name = "ogradresDataGridViewTextBoxColumn";
            this.ogradresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // annetelnoDataGridViewTextBoxColumn
            // 
            this.annetelnoDataGridViewTextBoxColumn.DataPropertyName = "annetelno";
            this.annetelnoDataGridViewTextBoxColumn.HeaderText = "annetelno";
            this.annetelnoDataGridViewTextBoxColumn.Name = "annetelnoDataGridViewTextBoxColumn";
            this.annetelnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // babatelnoDataGridViewTextBoxColumn
            // 
            this.babatelnoDataGridViewTextBoxColumn.DataPropertyName = "babatelno";
            this.babatelnoDataGridViewTextBoxColumn.HeaderText = "babatelno";
            this.babatelnoDataGridViewTextBoxColumn.Name = "babatelnoDataGridViewTextBoxColumn";
            this.babatelnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrenciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(896, 565);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.güncelle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ograrama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ogrenciler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ogrenciler";
            this.Load += new System.EventHandler(this.ogrenciler_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ogrenciler_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ogrenciler_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ogrenciler_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ögrencilerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.görsel3vizeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.görsel3vizeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ögrencilerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ograrama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private görsel3finalDataSet görsel3vizeDataSet;
        private System.Windows.Forms.BindingSource ögrencilerBindingSource;
        private görsel3finalDataSetTableAdapters.ögrencilerTableAdapter ögrencilerTableAdapter;
        private System.Windows.Forms.Button güncelle;
        private System.Windows.Forms.Button sil;
        private görsel3finalDataSet görsel3vizeDataSet1;
        private System.Windows.Forms.BindingSource ögrencilerBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrsoyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogradresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annetelnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn babatelnoDataGridViewTextBoxColumn;
    }
}