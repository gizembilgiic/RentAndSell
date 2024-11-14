namespace RentAndSell.Car
{
    partial class LoginPage
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
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btnKayitOl = new Button();
            groupBox1 = new GroupBox();
            btnGiris = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(18, 42);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.PlaceholderText = "Kullanıcı Adı";
            txtKullaniciAdi.Size = new Size(234, 27);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(18, 75);
            txtSifre.Name = "txtSifre";
            txtSifre.PlaceholderText = "Şifre";
            txtSifre.Size = new Size(234, 27);
            txtSifre.TabIndex = 0;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new Point(147, 120);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(105, 37);
            btnKayitOl.TabIndex = 1;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnGiris);
            groupBox1.Controls.Add(btnKayitOl);
            groupBox1.Controls.Add(txtKullaniciAdi);
            groupBox1.Controls.Add(txtSifre);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(529, 203);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(18, 120);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(105, 37);
            btnGiris.TabIndex = 1;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Location = new Point(269, 42);
            label1.Name = "label1";
            label1.Size = new Size(233, 115);
            label1.TabIndex = 2;
            label1.Text = "Mesajlar";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 224);
            Controls.Add(groupBox1);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnKayitOl;
        private GroupBox groupBox1;
        private Button btnGiris;
        private Label label1;
    }
}