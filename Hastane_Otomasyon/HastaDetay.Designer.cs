namespace Hastane_Otomasyon
{
    partial class HastaDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTc = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.rchşikayet = new System.Windows.Forms.RichTextBox();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.txtİd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.hastane_OtomasyonuDataSet = new Hastane_Otomasyon.Hastane_OtomasyonuDataSet();
            this.tabloRandevuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablo_RandevuTableAdapter = new Hastane_Otomasyon.Hastane_OtomasyonuDataSetTableAdapters.Tablo_RandevuTableAdapter();
            this.randevuİdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuSaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuBransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuDoktorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hastaTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaSikayetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_OtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabloRandevuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTc);
            this.groupBox1.Controls.Add(this.lblSoyad);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgileri ";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(145, 79);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(84, 16);
            this.lblTc.TabIndex = 15;
            this.lblTc.Text = "00000000000";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(145, 49);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(56, 16);
            this.lblSoyad.TabIndex = 14;
            this.lblSoyad.Text = "Null Null";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(145, 18);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(56, 16);
            this.lblAd.TabIndex = 13;
            this.lblAd.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "TC Kimlik Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.rchşikayet);
            this.groupBox2.Controls.Add(this.cmbDoktor);
            this.groupBox2.Controls.Add(this.cmbBrans);
            this.groupBox2.Controls.Add(this.txtİd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 297);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(11, 266);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(103, 16);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Bilgileri Düzenle";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Randevu Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rchşikayet
            // 
            this.rchşikayet.Location = new System.Drawing.Point(93, 119);
            this.rchşikayet.Name = "rchşikayet";
            this.rchşikayet.Size = new System.Drawing.Size(121, 96);
            this.rchşikayet.TabIndex = 7;
            this.rchşikayet.Text = "";
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(93, 89);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(121, 24);
            this.cmbDoktor.TabIndex = 6;
            this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbDoktor_SelectedIndexChanged);
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(93, 59);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(121, 24);
            this.cmbBrans.TabIndex = 5;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // txtİd
            // 
            this.txtİd.Enabled = false;
            this.txtİd.Location = new System.Drawing.Point(92, 31);
            this.txtİd.Name = "txtİd";
            this.txtİd.Size = new System.Drawing.Size(122, 22);
            this.txtİd.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Şikayet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Doktor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Branş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "İd:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(320, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(739, 112);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Geçmişi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(733, 91);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(320, 143);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(739, 295);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.randevuİdDataGridViewTextBoxColumn,
            this.randevuTarihDataGridViewTextBoxColumn,
            this.randevuSaatDataGridViewTextBoxColumn,
            this.randevuBransDataGridViewTextBoxColumn,
            this.randevuDoktorDataGridViewTextBoxColumn,
            this.randevuDurumDataGridViewCheckBoxColumn,
            this.hastaTcDataGridViewTextBoxColumn,
            this.hastaSikayetDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tabloRandevuBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 18);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(733, 274);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // hastane_OtomasyonuDataSet
            // 
            this.hastane_OtomasyonuDataSet.DataSetName = "Hastane_OtomasyonuDataSet";
            this.hastane_OtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabloRandevuBindingSource
            // 
            this.tabloRandevuBindingSource.DataMember = "Tablo_Randevu";
            this.tabloRandevuBindingSource.DataSource = this.hastane_OtomasyonuDataSet;
            // 
            // tablo_RandevuTableAdapter
            // 
            this.tablo_RandevuTableAdapter.ClearBeforeFill = true;
            // 
            // randevuİdDataGridViewTextBoxColumn
            // 
            this.randevuİdDataGridViewTextBoxColumn.DataPropertyName = "Randevuİd";
            this.randevuİdDataGridViewTextBoxColumn.HeaderText = "Randevuİd";
            this.randevuİdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randevuİdDataGridViewTextBoxColumn.Name = "randevuİdDataGridViewTextBoxColumn";
            this.randevuİdDataGridViewTextBoxColumn.ReadOnly = true;
            this.randevuİdDataGridViewTextBoxColumn.Width = 125;
            // 
            // randevuTarihDataGridViewTextBoxColumn
            // 
            this.randevuTarihDataGridViewTextBoxColumn.DataPropertyName = "RandevuTarih";
            this.randevuTarihDataGridViewTextBoxColumn.HeaderText = "RandevuTarih";
            this.randevuTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randevuTarihDataGridViewTextBoxColumn.Name = "randevuTarihDataGridViewTextBoxColumn";
            this.randevuTarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // randevuSaatDataGridViewTextBoxColumn
            // 
            this.randevuSaatDataGridViewTextBoxColumn.DataPropertyName = "RandevuSaat";
            this.randevuSaatDataGridViewTextBoxColumn.HeaderText = "RandevuSaat";
            this.randevuSaatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randevuSaatDataGridViewTextBoxColumn.Name = "randevuSaatDataGridViewTextBoxColumn";
            this.randevuSaatDataGridViewTextBoxColumn.Width = 125;
            // 
            // randevuBransDataGridViewTextBoxColumn
            // 
            this.randevuBransDataGridViewTextBoxColumn.DataPropertyName = "RandevuBrans";
            this.randevuBransDataGridViewTextBoxColumn.HeaderText = "RandevuBrans";
            this.randevuBransDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randevuBransDataGridViewTextBoxColumn.Name = "randevuBransDataGridViewTextBoxColumn";
            this.randevuBransDataGridViewTextBoxColumn.Width = 125;
            // 
            // randevuDoktorDataGridViewTextBoxColumn
            // 
            this.randevuDoktorDataGridViewTextBoxColumn.DataPropertyName = "RandevuDoktor";
            this.randevuDoktorDataGridViewTextBoxColumn.HeaderText = "RandevuDoktor";
            this.randevuDoktorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randevuDoktorDataGridViewTextBoxColumn.Name = "randevuDoktorDataGridViewTextBoxColumn";
            this.randevuDoktorDataGridViewTextBoxColumn.Width = 125;
            // 
            // randevuDurumDataGridViewCheckBoxColumn
            // 
            this.randevuDurumDataGridViewCheckBoxColumn.DataPropertyName = "RandevuDurum";
            this.randevuDurumDataGridViewCheckBoxColumn.HeaderText = "RandevuDurum";
            this.randevuDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.randevuDurumDataGridViewCheckBoxColumn.Name = "randevuDurumDataGridViewCheckBoxColumn";
            this.randevuDurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // hastaTcDataGridViewTextBoxColumn
            // 
            this.hastaTcDataGridViewTextBoxColumn.DataPropertyName = "HastaTc";
            this.hastaTcDataGridViewTextBoxColumn.HeaderText = "HastaTc";
            this.hastaTcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastaTcDataGridViewTextBoxColumn.Name = "hastaTcDataGridViewTextBoxColumn";
            this.hastaTcDataGridViewTextBoxColumn.Width = 125;
            // 
            // hastaSikayetDataGridViewTextBoxColumn
            // 
            this.hastaSikayetDataGridViewTextBoxColumn.DataPropertyName = "HastaSikayet";
            this.hastaSikayetDataGridViewTextBoxColumn.HeaderText = "HastaSikayet";
            this.hastaSikayetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastaSikayetDataGridViewTextBoxColumn.Name = "hastaSikayetDataGridViewTextBoxColumn";
            this.hastaSikayetDataGridViewTextBoxColumn.Width = 125;
            // 
            // HastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1071, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HastaDetay";
            this.Text = "HastaDetay";
            this.Load += new System.EventHandler(this.HastaDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_OtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabloRandevuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rchşikayet;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.TextBox txtİd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private Hastane_OtomasyonuDataSet hastane_OtomasyonuDataSet;
        private System.Windows.Forms.BindingSource tabloRandevuBindingSource;
        private Hastane_OtomasyonuDataSetTableAdapters.Tablo_RandevuTableAdapter tablo_RandevuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuİdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuSaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuBransDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuDoktorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn randevuDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaSikayetDataGridViewTextBoxColumn;
    }
}