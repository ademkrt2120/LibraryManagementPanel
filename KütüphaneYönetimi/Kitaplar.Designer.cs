namespace KütüphaneYönetimi
{
    partial class Kitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitaplar));
            panel1 = new Panel();
            label15 = new Label();
            panel2 = new Panel();
            buttonVeriGetir = new Button();
            buttonAra = new Button();
            buttonTemizle = new Button();
            buttonSil = new Button();
            buttonGüncelle = new Button();
            buttonEkle = new Button();
            textBoxKitapTurKod = new TextBox();
            label8 = new Label();
            textBoxISBN = new TextBox();
            label7 = new Label();
            textBoxYazarSoyad = new TextBox();
            label6 = new Label();
            textBoxYazarAd = new TextBox();
            label5 = new Label();
            textBoxKitapAd = new TextBox();
            label4 = new Label();
            labelID = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            label9 = new Label();
            dateTimePickerTarih = new DateTimePicker();
            buttonOduncVer = new Button();
            textBoxOduncAlan = new TextBox();
            label13 = new Label();
            label16 = new Label();
            panel4 = new Panel();
            buttonİadeEt = new Button();
            label14 = new Label();
            labelGecikmeBedeli = new Label();
            buttonGecikmeHesapla = new Button();
            label11 = new Label();
            label12 = new Label();
            panel5 = new Panel();
            dataGridViewKitaplar = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 154, 170);
            panel1.Controls.Add(label15);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1191, 112);
            panel1.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe Print", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(378, 23);
            label15.Name = "label15";
            label15.Size = new Size(487, 61);
            label15.TabIndex = 0;
            label15.Text = "Kütüphane Yönetim Paneli";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(buttonVeriGetir);
            panel2.Controls.Add(buttonAra);
            panel2.Controls.Add(buttonTemizle);
            panel2.Controls.Add(buttonSil);
            panel2.Controls.Add(buttonGüncelle);
            panel2.Controls.Add(buttonEkle);
            panel2.Controls.Add(textBoxKitapTurKod);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBoxISBN);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBoxYazarSoyad);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBoxYazarAd);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBoxKitapAd);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(labelID);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(396, 466);
            panel2.TabIndex = 1;
            // 
            // buttonVeriGetir
            // 
            buttonVeriGetir.BackColor = Color.FromArgb(7, 154, 170);
            buttonVeriGetir.FlatAppearance.BorderColor = Color.FromArgb(7, 154, 170);
            buttonVeriGetir.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonVeriGetir.ForeColor = Color.White;
            buttonVeriGetir.Location = new Point(264, 410);
            buttonVeriGetir.Name = "buttonVeriGetir";
            buttonVeriGetir.Size = new Size(117, 44);
            buttonVeriGetir.TabIndex = 18;
            buttonVeriGetir.Text = "Veriyi Getir";
            buttonVeriGetir.UseVisualStyleBackColor = false;
            buttonVeriGetir.Click += buttonVeriGetir_Click;
            // 
            // buttonAra
            // 
            buttonAra.BackColor = Color.FromArgb(7, 154, 170);
            buttonAra.FlatAppearance.BorderColor = Color.FromArgb(7, 154, 170);
            buttonAra.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAra.ForeColor = Color.White;
            buttonAra.Location = new Point(264, 360);
            buttonAra.Name = "buttonAra";
            buttonAra.Size = new Size(117, 44);
            buttonAra.TabIndex = 17;
            buttonAra.Text = "Ara";
            buttonAra.UseVisualStyleBackColor = false;
            buttonAra.Click += buttonAra_Click;
            // 
            // buttonTemizle
            // 
            buttonTemizle.BackColor = Color.FromArgb(7, 154, 170);
            buttonTemizle.FlatAppearance.BorderColor = Color.FromArgb(7, 154, 170);
            buttonTemizle.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTemizle.ForeColor = Color.White;
            buttonTemizle.Location = new Point(141, 410);
            buttonTemizle.Name = "buttonTemizle";
            buttonTemizle.Size = new Size(117, 44);
            buttonTemizle.TabIndex = 16;
            buttonTemizle.Text = "Temizle";
            buttonTemizle.UseVisualStyleBackColor = false;
            buttonTemizle.Click += buttonTemizle_Click;
            // 
            // buttonSil
            // 
            buttonSil.BackColor = Color.FromArgb(7, 154, 170);
            buttonSil.FlatAppearance.BorderColor = Color.FromArgb(7, 154, 170);
            buttonSil.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSil.ForeColor = Color.White;
            buttonSil.Location = new Point(141, 360);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(117, 44);
            buttonSil.TabIndex = 15;
            buttonSil.Text = "Sil";
            buttonSil.UseVisualStyleBackColor = false;
            buttonSil.Click += buttonSil_Click;
            // 
            // buttonGüncelle
            // 
            buttonGüncelle.BackColor = Color.FromArgb(7, 154, 170);
            buttonGüncelle.FlatAppearance.BorderColor = Color.FromArgb(7, 154, 170);
            buttonGüncelle.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGüncelle.ForeColor = Color.White;
            buttonGüncelle.Location = new Point(18, 410);
            buttonGüncelle.Name = "buttonGüncelle";
            buttonGüncelle.Size = new Size(117, 44);
            buttonGüncelle.TabIndex = 14;
            buttonGüncelle.Text = "Güncelle";
            buttonGüncelle.UseVisualStyleBackColor = false;
            buttonGüncelle.Click += buttonGüncelle_Click;
            // 
            // buttonEkle
            // 
            buttonEkle.BackColor = Color.FromArgb(7, 154, 170);
            buttonEkle.FlatAppearance.BorderColor = Color.FromArgb(7, 154, 170);
            buttonEkle.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEkle.ForeColor = Color.White;
            buttonEkle.Location = new Point(18, 360);
            buttonEkle.Name = "buttonEkle";
            buttonEkle.Size = new Size(117, 44);
            buttonEkle.TabIndex = 13;
            buttonEkle.Text = "Ekle";
            buttonEkle.UseVisualStyleBackColor = false;
            buttonEkle.Click += buttonEkle_Click;
            // 
            // textBoxKitapTurKod
            // 
            textBoxKitapTurKod.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxKitapTurKod.Location = new Point(160, 302);
            textBoxKitapTurKod.Name = "textBoxKitapTurKod";
            textBoxKitapTurKod.Size = new Size(221, 30);
            textBoxKitapTurKod.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(18, 306);
            label8.Name = "label8";
            label8.Size = new Size(127, 21);
            label8.TabIndex = 11;
            label8.Text = "Kitap Tür Kod :";
            // 
            // textBoxISBN
            // 
            textBoxISBN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxISBN.Location = new Point(160, 252);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(221, 30);
            textBoxISBN.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(18, 256);
            label7.Name = "label7";
            label7.Size = new Size(57, 21);
            label7.TabIndex = 9;
            label7.Text = "ISBN :";
            // 
            // textBoxYazarSoyad
            // 
            textBoxYazarSoyad.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxYazarSoyad.Location = new Point(160, 203);
            textBoxYazarSoyad.Name = "textBoxYazarSoyad";
            textBoxYazarSoyad.Size = new Size(221, 30);
            textBoxYazarSoyad.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(18, 207);
            label6.Name = "label6";
            label6.Size = new Size(117, 21);
            label6.TabIndex = 7;
            label6.Text = "Yazar Soyadı :";
            // 
            // textBoxYazarAd
            // 
            textBoxYazarAd.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxYazarAd.Location = new Point(160, 154);
            textBoxYazarAd.Name = "textBoxYazarAd";
            textBoxYazarAd.Size = new Size(221, 30);
            textBoxYazarAd.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(18, 158);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 5;
            label5.Text = "Yazar Adı :";
            // 
            // textBoxKitapAd
            // 
            textBoxKitapAd.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxKitapAd.Location = new Point(160, 104);
            textBoxKitapAd.Name = "textBoxKitapAd";
            textBoxKitapAd.Size = new Size(221, 30);
            textBoxKitapAd.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 108);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 3;
            label4.Text = "Kitap Adı :";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelID.Location = new Point(160, 66);
            labelID.Name = "labelID";
            labelID.Size = new Size(16, 21);
            labelID.TabIndex = 2;
            labelID.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 66);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 1;
            label2.Text = "Kitap ID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(7, 154, 170);
            label1.Location = new Point(18, 18);
            label1.Name = "label1";
            label1.Size = new Size(251, 23);
            label1.TabIndex = 0;
            label1.Text = "Kitap Kayıt Ve Güncelleme";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(dateTimePickerTarih);
            panel3.Controls.Add(buttonOduncVer);
            panel3.Controls.Add(textBoxOduncAlan);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label16);
            panel3.Location = new Point(429, 128);
            panel3.Name = "panel3";
            panel3.Size = new Size(365, 466);
            panel3.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(18, 141);
            label9.Name = "label9";
            label9.Size = new Size(60, 21);
            label9.TabIndex = 16;
            label9.Text = "Tarih :";
            // 
            // dateTimePickerTarih
            // 
            dateTimePickerTarih.Location = new Point(84, 137);
            dateTimePickerTarih.Name = "dateTimePickerTarih";
            dateTimePickerTarih.Size = new Size(250, 27);
            dateTimePickerTarih.TabIndex = 15;
            // 
            // buttonOduncVer
            // 
            buttonOduncVer.BackColor = Color.FromArgb(7, 154, 170);
            buttonOduncVer.FlatAppearance.BorderColor = Color.FromArgb(7, 154, 170);
            buttonOduncVer.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOduncVer.ForeColor = Color.White;
            buttonOduncVer.Location = new Point(82, 226);
            buttonOduncVer.Name = "buttonOduncVer";
            buttonOduncVer.Size = new Size(187, 44);
            buttonOduncVer.TabIndex = 13;
            buttonOduncVer.Text = "Kitap Ödünç Ver";
            buttonOduncVer.UseVisualStyleBackColor = false;
            buttonOduncVer.Click += buttonOduncVer_Click;
            // 
            // textBoxOduncAlan
            // 
            textBoxOduncAlan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOduncAlan.Location = new Point(132, 85);
            textBoxOduncAlan.Name = "textBoxOduncAlan";
            textBoxOduncAlan.Size = new Size(163, 30);
            textBoxOduncAlan.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(18, 89);
            label13.Name = "label13";
            label13.Size = new Size(108, 21);
            label13.TabIndex = 3;
            label13.Text = "Ödünç Alan :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(7, 154, 170);
            label16.Location = new Point(18, 18);
            label16.Name = "label16";
            label16.Size = new Size(175, 23);
            label16.TabIndex = 0;
            label16.Text = "Kitap Ödünç Alma";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(buttonİadeEt);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(labelGecikmeBedeli);
            panel4.Controls.Add(buttonGecikmeHesapla);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(813, 128);
            panel4.Name = "panel4";
            panel4.Size = new Size(365, 466);
            panel4.TabIndex = 20;
            // 
            // buttonİadeEt
            // 
            buttonİadeEt.BackColor = Color.FromArgb(7, 154, 170);
            buttonİadeEt.FlatAppearance.BorderColor = Color.FromArgb(7, 154, 170);
            buttonİadeEt.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonİadeEt.ForeColor = Color.White;
            buttonİadeEt.Location = new Point(89, 211);
            buttonİadeEt.Name = "buttonİadeEt";
            buttonİadeEt.Size = new Size(187, 44);
            buttonİadeEt.TabIndex = 16;
            buttonİadeEt.Text = "İade Et";
            buttonİadeEt.UseVisualStyleBackColor = false;
            buttonİadeEt.Click += buttonİadeEt_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(226, 89);
            label14.Name = "label14";
            label14.Size = new Size(31, 21);
            label14.TabIndex = 15;
            label14.Text = "TL";
            // 
            // labelGecikmeBedeli
            // 
            labelGecikmeBedeli.AutoSize = true;
            labelGecikmeBedeli.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelGecikmeBedeli.Location = new Point(174, 89);
            labelGecikmeBedeli.Name = "labelGecikmeBedeli";
            labelGecikmeBedeli.Size = new Size(20, 21);
            labelGecikmeBedeli.TabIndex = 14;
            labelGecikmeBedeli.Text = "0";
            // 
            // buttonGecikmeHesapla
            // 
            buttonGecikmeHesapla.BackColor = Color.FromArgb(7, 154, 170);
            buttonGecikmeHesapla.FlatAppearance.BorderColor = Color.FromArgb(7, 154, 170);
            buttonGecikmeHesapla.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGecikmeHesapla.ForeColor = Color.White;
            buttonGecikmeHesapla.Location = new Point(90, 147);
            buttonGecikmeHesapla.Name = "buttonGecikmeHesapla";
            buttonGecikmeHesapla.Size = new Size(187, 44);
            buttonGecikmeHesapla.TabIndex = 13;
            buttonGecikmeHesapla.Text = "Bedel Hesapla";
            buttonGecikmeHesapla.UseVisualStyleBackColor = false;
            buttonGecikmeHesapla.Click += buttonGecikmeHesapla_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(18, 89);
            label11.Name = "label11";
            label11.Size = new Size(138, 21);
            label11.TabIndex = 3;
            label11.Text = "Gecikme Bedeli :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(7, 154, 170);
            label12.Location = new Point(18, 18);
            label12.Name = "label12";
            label12.Size = new Size(105, 23);
            label12.TabIndex = 0;
            label12.Text = "Kitap İade";
            // 
            // panel5
            // 
            panel5.Controls.Add(dataGridViewKitaplar);
            panel5.Location = new Point(12, 622);
            panel5.Name = "panel5";
            panel5.Size = new Size(1166, 232);
            panel5.TabIndex = 21;
            // 
            // dataGridViewKitaplar
            // 
            dataGridViewKitaplar.BackgroundColor = Color.White;
            dataGridViewKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKitaplar.Dock = DockStyle.Fill;
            dataGridViewKitaplar.Location = new Point(0, 0);
            dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            dataGridViewKitaplar.RowHeadersWidth = 51;
            dataGridViewKitaplar.RowTemplate.Height = 29;
            dataGridViewKitaplar.Size = new Size(1166, 232);
            dataGridViewKitaplar.TabIndex = 0;
            dataGridViewKitaplar.CellClick += dataGridViewKitaplar_CellClick;
            // 
            // Kitaplar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 202, 211);
            ClientSize = new Size(1191, 866);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Kitaplar";
            Text = "*";
            FormClosed += Kitaplar_FormClosed;
            Load += Kitaplar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Label labelID;
        private TextBox textBoxKitapTurKod;
        private Label label8;
        private TextBox textBoxISBN;
        private Label label7;
        private TextBox textBoxYazarSoyad;
        private Label label6;
        private TextBox textBoxYazarAd;
        private Label label5;
        private TextBox textBoxKitapAd;
        private Label label4;
        private Button buttonEkle;
        private Button buttonVeriGetir;
        private Button buttonAra;
        private Button buttonTemizle;
        private Button buttonSil;
        private Button buttonGüncelle;
        private Panel panel3;
        private Label label9;
        private DateTimePicker dateTimePickerTarih;
        private Button buttonOduncVer;
        private TextBox textBoxOduncAlan;
        private Label label13;
        private Label label16;
        private Panel panel4;
        private Button buttonGecikmeHesapla;
        private Label label11;
        private Label label12;
        private Button buttonİadeEt;
        private Label label14;
        private Label labelGecikmeBedeli;
        private Panel panel5;
        private DataGridView dataGridViewKitaplar;
        private Label label15;
    }
}