namespace ÖğrenciNotSistemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            TxtAdSoyad = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            TxtSinav1 = new TextBox();
            label4 = new Label();
            TxtSinav3 = new TextBox();
            label5 = new Label();
            TxtSinav2 = new TextBox();
            label6 = new Label();
            TxtOrtalama = new TextBox();
            label7 = new Label();
            BtnKaydet = new Button();
            BtnTemizle = new Button();
            BtnHesapla = new Button();
            listBox1 = new ListBox();
            label9 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            TxtDurum = new TextBox();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            BtnCizgi = new Button();
            BtnListeTemizle = new Button();
            label8 = new Label();
            TxtOgrenciSayisi = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kristen ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(246, 18);
            label1.Name = "label1";
            label1.Size = new Size(313, 29);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci Not Kayıt Sistemi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 112);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 1;
            label2.Text = "Ad-Soyad:";
            // 
            // TxtAdSoyad
            // 
            TxtAdSoyad.Location = new Point(105, 112);
            TxtAdSoyad.Name = "TxtAdSoyad";
            TxtAdSoyad.Size = new Size(182, 29);
            TxtAdSoyad.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 147);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 3;
            label3.Text = "Ders:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Algoritma", "Yapay Zeka", "Biçimsel Diller", "Mikroişlemciler" });
            comboBox1.Location = new Point(105, 147);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 29);
            comboBox1.TabIndex = 4;
            // 
            // TxtSinav1
            // 
            TxtSinav1.Location = new Point(400, 109);
            TxtSinav1.Name = "TxtSinav1";
            TxtSinav1.Size = new Size(73, 29);
            TxtSinav1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(332, 112);
            label4.Name = "label4";
            label4.Size = new Size(62, 21);
            label4.TabIndex = 5;
            label4.Text = "Sınav 1:";
            // 
            // TxtSinav3
            // 
            TxtSinav3.Location = new Point(400, 182);
            TxtSinav3.Name = "TxtSinav3";
            TxtSinav3.Size = new Size(73, 29);
            TxtSinav3.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(332, 188);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 7;
            label5.Text = "Sınav 3:";
            // 
            // TxtSinav2
            // 
            TxtSinav2.Location = new Point(400, 147);
            TxtSinav2.Name = "TxtSinav2";
            TxtSinav2.Size = new Size(73, 29);
            TxtSinav2.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(332, 150);
            label6.Name = "label6";
            label6.Size = new Size(65, 21);
            label6.TabIndex = 9;
            label6.Text = "Sınav 2:";
            // 
            // TxtOrtalama
            // 
            TxtOrtalama.Enabled = false;
            TxtOrtalama.Location = new Point(549, 109);
            TxtOrtalama.Name = "TxtOrtalama";
            TxtOrtalama.Size = new Size(73, 29);
            TxtOrtalama.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(505, 112);
            label7.Name = "label7";
            label7.Size = new Size(38, 21);
            label7.TabIndex = 11;
            label7.Text = "Ort:";
            // 
            // BtnKaydet
            // 
            BtnKaydet.Location = new Point(12, 245);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(111, 39);
            BtnKaydet.TabIndex = 14;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = true;
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // BtnTemizle
            // 
            BtnTemizle.Location = new Point(246, 245);
            BtnTemizle.Name = "BtnTemizle";
            BtnTemizle.Size = new Size(227, 39);
            BtnTemizle.TabIndex = 15;
            BtnTemizle.Text = "Girilen Verileri Temizle";
            BtnTemizle.UseVisualStyleBackColor = true;
            BtnTemizle.Click += BtnTemizle_Click;
            // 
            // BtnHesapla
            // 
            BtnHesapla.Location = new Point(129, 245);
            BtnHesapla.Name = "BtnHesapla";
            BtnHesapla.Size = new Size(111, 39);
            BtnHesapla.TabIndex = 16;
            BtnHesapla.Text = "Hesapla";
            BtnHesapla.UseVisualStyleBackColor = true;
            BtnHesapla.Click += BtnHesapla_Click;
            // 
            // listBox1
            // 
            listBox1.Enabled = false;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(12, 349);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(810, 172);
            listBox1.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 196);
            label9.Name = "label9";
            label9.Size = new Size(71, 21);
            label9.TabIndex = 19;
            label9.Text = "Numara:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(105, 188);
            maskedTextBox1.Mask = "0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.RightToLeft = RightToLeft.No;
            maskedTextBox1.Size = new Size(57, 29);
            maskedTextBox1.TabIndex = 20;
            // 
            // TxtDurum
            // 
            TxtDurum.Enabled = false;
            TxtDurum.Location = new Point(549, 147);
            TxtDurum.Name = "TxtDurum";
            TxtDurum.Size = new Size(73, 29);
            TxtDurum.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(480, 150);
            label10.Name = "label10";
            label10.Size = new Size(63, 21);
            label10.TabIndex = 21;
            label10.Text = "Durum:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(649, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // BtnCizgi
            // 
            BtnCizgi.Location = new Point(480, 245);
            BtnCizgi.Name = "BtnCizgi";
            BtnCizgi.Size = new Size(98, 37);
            BtnCizgi.TabIndex = 24;
            BtnCizgi.Text = "Çizgi";
            BtnCizgi.UseVisualStyleBackColor = true;
            BtnCizgi.Click += BtnCizgi_Click;
            // 
            // BtnListeTemizle
            // 
            BtnListeTemizle.Location = new Point(584, 244);
            BtnListeTemizle.Name = "BtnListeTemizle";
            BtnListeTemizle.Size = new Size(155, 37);
            BtnListeTemizle.TabIndex = 25;
            BtnListeTemizle.Text = "Listeyi Temizle";
            BtnListeTemizle.UseVisualStyleBackColor = true;
            BtnListeTemizle.Click += BtnListeTemizle_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 309);
            label8.Name = "label8";
            label8.Size = new Size(201, 21);
            label8.TabIndex = 26;
            label8.Text = "Kaydedilen Öğrenci Sayısı:";
            // 
            // TxtOgrenciSayisi
            // 
            TxtOgrenciSayisi.Enabled = false;
            TxtOgrenciSayisi.Location = new Point(219, 306);
            TxtOgrenciSayisi.Name = "TxtOgrenciSayisi";
            TxtOgrenciSayisi.Size = new Size(100, 29);
            TxtOgrenciSayisi.TabIndex = 27;
            TxtOgrenciSayisi.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 540);
            Controls.Add(TxtOgrenciSayisi);
            Controls.Add(label8);
            Controls.Add(BtnListeTemizle);
            Controls.Add(BtnCizgi);
            Controls.Add(pictureBox1);
            Controls.Add(TxtDurum);
            Controls.Add(label10);
            Controls.Add(maskedTextBox1);
            Controls.Add(label9);
            Controls.Add(listBox1);
            Controls.Add(BtnHesapla);
            Controls.Add(BtnTemizle);
            Controls.Add(BtnKaydet);
            Controls.Add(TxtOrtalama);
            Controls.Add(label7);
            Controls.Add(TxtSinav2);
            Controls.Add(label6);
            Controls.Add(TxtSinav3);
            Controls.Add(label5);
            Controls.Add(TxtSinav1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(TxtAdSoyad);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtAdSoyad;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox TxtSinav1;
        private Label label4;
        private TextBox TxtSinav3;
        private Label label5;
        private TextBox TxtSinav2;
        private Label label6;
        private TextBox TxtOrtalama;
        private Label label7;
        private Button BtnKaydet;
        private Button BtnTemizle;
        private Button BtnHesapla;
        private ListBox listBox1;
        private Label label9;
        private MaskedTextBox maskedTextBox1;
        private TextBox TxtDurum;
        private Label label10;
        private PictureBox pictureBox1;
        private Button BtnCizgi;
        private Button BtnListeTemizle;
        private Label label8;
        private TextBox TxtOgrenciSayisi;
    }
}