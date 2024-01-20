namespace KütüphaneYönetimi
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            buttonGiris = new Button();
            panel2 = new Panel();
            textBoxSifre = new TextBox();
            label4 = new Label();
            textBoxKullaniciAd = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._6796180;
            pictureBox1.Location = new Point(12, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 406);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Mongolian Baiti", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(7, 154, 170);
            label1.Location = new Point(45, 28);
            label1.Name = "label1";
            label1.Size = new Size(274, 31);
            label1.TabIndex = 1;
            label1.Text = "Kütüphane Yönetim";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 154, 170);
            panel1.Controls.Add(buttonGiris);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(482, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 519);
            panel1.TabIndex = 3;
            // 
            // buttonGiris
            // 
            buttonGiris.BackColor = Color.FromArgb(7, 154, 170);
            buttonGiris.FlatAppearance.BorderColor = Color.FromArgb(128, 202, 211);
            buttonGiris.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 202, 211);
            buttonGiris.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 202, 211);
            buttonGiris.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGiris.ForeColor = Color.White;
            buttonGiris.Location = new Point(132, 425);
            buttonGiris.Name = "buttonGiris";
            buttonGiris.Size = new Size(150, 46);
            buttonGiris.TabIndex = 8;
            buttonGiris.Text = "Giriş Yap";
            buttonGiris.UseVisualStyleBackColor = false;
            buttonGiris.Click += buttonGiris_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(textBoxSifre);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBoxKullaniciAd);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(24, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(359, 386);
            panel2.TabIndex = 7;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSifre.Location = new Point(45, 296);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(274, 34);
            textBoxSifre.TabIndex = 6;
            textBoxSifre.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(7, 154, 170);
            label4.Location = new Point(45, 263);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 5;
            label4.Text = "Şifre";
            // 
            // textBoxKullaniciAd
            // 
            textBoxKullaniciAd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxKullaniciAd.Location = new Point(45, 198);
            textBoxKullaniciAd.Name = "textBoxKullaniciAd";
            textBoxKullaniciAd.Size = new Size(274, 34);
            textBoxKullaniciAd.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(7, 154, 170);
            label2.Location = new Point(135, 59);
            label2.Name = "label2";
            label2.Size = new Size(94, 31);
            label2.TabIndex = 2;
            label2.Text = "Paneli";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(7, 154, 170);
            label3.Location = new Point(45, 165);
            label3.Name = "label3";
            label3.Size = new Size(134, 21);
            label3.TabIndex = 3;
            label3.Text = "Kullanici Adi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 202, 211);
            ClientSize = new Size(914, 559);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private TextBox textBoxKullaniciAd;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private TextBox textBoxSifre;
        private Label label4;
        private Button buttonGiris;
    }
}