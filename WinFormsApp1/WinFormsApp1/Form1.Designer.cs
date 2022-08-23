namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.kisi_sehir = new System.Windows.Forms.TextBox();
            this.kisi_soyad = new System.Windows.Forms.TextBox();
            this.kisi_ad = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.delete_kisi_id = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.yeni_kisi_id = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.duzenle_button = new System.Windows.Forms.Button();
            this.yeni_kisi_sehir = new System.Windows.Forms.TextBox();
            this.yeni_kisi_soyad = new System.Windows.Forms.TextBox();
            this.yeni_kisi_ad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.Location = new System.Drawing.Point(-10, -1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(549, 710);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(615, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "kisi";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.kisi_sehir);
            this.groupBox1.Controls.Add(this.kisi_soyad);
            this.groupBox1.Controls.Add(this.kisi_ad);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(615, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 209);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "kisi Kayıt";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "sehir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "ad";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.Location = new System.Drawing.Point(147, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Kaydet";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // kisi_sehir
            // 
            this.kisi_sehir.BackColor = System.Drawing.Color.Green;
            this.kisi_sehir.Location = new System.Drawing.Point(147, 92);
            this.kisi_sehir.Name = "kisi_sehir";
            this.kisi_sehir.Size = new System.Drawing.Size(147, 27);
            this.kisi_sehir.TabIndex = 3;
            // 
            // kisi_soyad
            // 
            this.kisi_soyad.BackColor = System.Drawing.Color.Green;
            this.kisi_soyad.Location = new System.Drawing.Point(147, 59);
            this.kisi_soyad.Name = "kisi_soyad";
            this.kisi_soyad.Size = new System.Drawing.Size(147, 27);
            this.kisi_soyad.TabIndex = 2;
            // 
            // kisi_ad
            // 
            this.kisi_ad.BackColor = System.Drawing.Color.Green;
            this.kisi_ad.Location = new System.Drawing.Point(147, 26);
            this.kisi_ad.Name = "kisi_ad";
            this.kisi_ad.Size = new System.Drawing.Size(147, 27);
            this.kisi_ad.TabIndex = 1;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Controls.Add(this.button_delete);
            this.groupBox2.Controls.Add(this.delete_kisi_id);
            this.groupBox2.Controls.Add(this.id);
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(970, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 209);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kisi Sil";
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Green;
            this.button_delete.Location = new System.Drawing.Point(72, 116);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(138, 47);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "Kisi Sil";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // delete_kisi_id
            // 
            this.delete_kisi_id.BackColor = System.Drawing.Color.Green;
            this.delete_kisi_id.Location = new System.Drawing.Point(187, 33);
            this.delete_kisi_id.Name = "delete_kisi_id";
            this.delete_kisi_id.Size = new System.Drawing.Size(89, 27);
            this.delete_kisi_id.TabIndex = 1;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(19, 40);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(146, 20);
            this.id.TabIndex = 0;
            this.id.Text = "Silinecek Kişinin ID\'si";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox3.Controls.Add(this.yeni_kisi_id);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.duzenle_button);
            this.groupBox3.Controls.Add(this.yeni_kisi_sehir);
            this.groupBox3.Controls.Add(this.yeni_kisi_soyad);
            this.groupBox3.Controls.Add(this.yeni_kisi_ad);
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(970, 362);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 209);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kişi Düzenle";
            // 
            // yeni_kisi_id
            // 
            this.yeni_kisi_id.AutoSize = true;
            this.yeni_kisi_id.Location = new System.Drawing.Point(202, 33);
            this.yeni_kisi_id.Name = "yeni_kisi_id";
            this.yeni_kisi_id.Size = new System.Drawing.Size(17, 20);
            this.yeni_kisi_id.TabIndex = 12;
            this.yeni_kisi_id.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "yeni sehir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "yeni soyad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "yeni ad";
            // 
            // duzenle_button
            // 
            this.duzenle_button.BackColor = System.Drawing.Color.Green;
            this.duzenle_button.Location = new System.Drawing.Point(147, 166);
            this.duzenle_button.Name = "duzenle_button";
            this.duzenle_button.Size = new System.Drawing.Size(147, 40);
            this.duzenle_button.TabIndex = 4;
            this.duzenle_button.Text = "Kaydet";
            this.duzenle_button.UseVisualStyleBackColor = false;
            this.duzenle_button.Click += new System.EventHandler(this.duzenle_button_Click);
            // 
            // yeni_kisi_sehir
            // 
            this.yeni_kisi_sehir.BackColor = System.Drawing.Color.Green;
            this.yeni_kisi_sehir.Location = new System.Drawing.Point(153, 125);
            this.yeni_kisi_sehir.Name = "yeni_kisi_sehir";
            this.yeni_kisi_sehir.Size = new System.Drawing.Size(147, 27);
            this.yeni_kisi_sehir.TabIndex = 3;
            // 
            // yeni_kisi_soyad
            // 
            this.yeni_kisi_soyad.BackColor = System.Drawing.Color.Green;
            this.yeni_kisi_soyad.Location = new System.Drawing.Point(153, 92);
            this.yeni_kisi_soyad.Name = "yeni_kisi_soyad";
            this.yeni_kisi_soyad.Size = new System.Drawing.Size(147, 27);
            this.yeni_kisi_soyad.TabIndex = 2;
            // 
            // yeni_kisi_ad
            // 
            this.yeni_kisi_ad.BackColor = System.Drawing.Color.Green;
            this.yeni_kisi_ad.Location = new System.Drawing.Point(153, 59);
            this.yeni_kisi_ad.Name = "yeni_kisi_ad";
            this.yeni_kisi_ad.Size = new System.Drawing.Size(147, 27);
            this.yeni_kisi_ad.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1265, 684);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dünyayı Fethedecek Uygulama";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button button2;
        private GroupBox groupBox1;
        private Button button3;
        private TextBox kisi_sehir;
        private TextBox kisi_soyad;
        private TextBox kisi_ad;
        private Label label4;
        private Label label3;
        private Label label2;
        private ImageList ımageList1;
        private GroupBox groupBox2;
        private Button button_delete;
        private TextBox delete_kisi_id;
        private Label id;
        private GroupBox groupBox3;
        private Label label7;
        private Label label1;
        private Label label5;
        private Label label6;
        private Button duzenle_button;
        private TextBox yeni_kisi_sehir;
        private TextBox yeni_kisi_soyad;
        private TextBox yeni_kisi_ad;
        private Label yeni_kisi_id;
    }
}