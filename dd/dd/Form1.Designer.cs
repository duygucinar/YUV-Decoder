namespace dd
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.width1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.goster = new System.Windows.Forms.Button();
            this.dosya = new System.Windows.Forms.Button();
            this.dosya_yolu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.frame1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.format1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.height1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.sayi = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.pic);
            this.groupBox1.Location = new System.Drawing.Point(357, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 680);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Görüntü";
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(6, 21);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(784, 653);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Genişlik";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // width1
            // 
            this.width1.Location = new System.Drawing.Point(108, 37);
            this.width1.Name = "width1";
            this.width1.Size = new System.Drawing.Size(100, 22);
            this.width1.TabIndex = 2;
            this.width1.TextChanged += new System.EventHandler(this.width1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.goster);
            this.groupBox2.Controls.Add(this.dosya);
            this.groupBox2.Controls.Add(this.dosya_yolu);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.frame1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.format1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.height1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.width1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(27, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 335);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dosya Bilgileri";
            // 
            // goster
            // 
            this.goster.Location = new System.Drawing.Point(108, 293);
            this.goster.Name = "goster";
            this.goster.Size = new System.Drawing.Size(71, 27);
            this.goster.TabIndex = 12;
            this.goster.Text = "Göster";
            this.goster.UseVisualStyleBackColor = true;
            this.goster.Click += new System.EventHandler(this.goster_Click);
            // 
            // dosya
            // 
            this.dosya.Location = new System.Drawing.Point(108, 164);
            this.dosya.Name = "dosya";
            this.dosya.Size = new System.Drawing.Size(100, 28);
            this.dosya.TabIndex = 11;
            this.dosya.Text = "Dosya Seç";
            this.dosya.UseVisualStyleBackColor = true;
            this.dosya.Click += new System.EventHandler(this.dosya_Click);
            // 
            // dosya_yolu
            // 
            this.dosya_yolu.Location = new System.Drawing.Point(108, 125);
            this.dosya_yolu.Name = "dosya_yolu";
            this.dosya_yolu.Size = new System.Drawing.Size(170, 22);
            this.dosya_yolu.TabIndex = 10;
            this.dosya_yolu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dosya Yolu";
            // 
            // frame1
            // 
            this.frame1.FormattingEnabled = true;
            this.frame1.Location = new System.Drawing.Point(108, 248);
            this.frame1.Name = "frame1";
            this.frame1.Size = new System.Drawing.Size(121, 24);
            this.frame1.TabIndex = 8;
            this.frame1.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Çerçeve";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // format1
            // 
            this.format1.FormattingEnabled = true;
            this.format1.Location = new System.Drawing.Point(108, 208);
            this.format1.Name = "format1";
            this.format1.Size = new System.Drawing.Size(121, 24);
            this.format1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Format";
            // 
            // height1
            // 
            this.height1.Location = new System.Drawing.Point(108, 78);
            this.height1.Name = "height1";
            this.height1.Size = new System.Drawing.Size(100, 22);
            this.height1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yükseklik";
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // sayi
            // 
            this.sayi.Location = new System.Drawing.Point(86, 622);
            this.sayi.Name = "sayi";
            this.sayi.Size = new System.Drawing.Size(183, 22);
            this.sayi.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 602);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Oynatılan Şuanki Görüntü";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 728);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sayi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YUV Çözücü";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox width1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox frame1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox format1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox height1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dosya_yolu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button goster;
        private System.Windows.Forms.Button dosya;
        private System.Windows.Forms.TextBox sayi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
    }
}

