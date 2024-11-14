namespace RentAndSell.Car
{
    partial class RegisterPage
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
            groupBox1 = new GroupBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            txtPaswordAgain = new TextBox();
            btnKaydet = new Button();
            btnGiriseGit = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnGiriseGit);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(txtPaswordAgain);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(501, 396);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "YENİ KAYIT";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(28, 43);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "Adınız";
            txtFirstName.Size = new Size(251, 27);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(28, 76);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Soyadınız";
            txtLastName.Size = new Size(251, 27);
            txtLastName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(28, 109);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-Posta Adresiniz";
            txtEmail.Size = new Size(251, 27);
            txtEmail.TabIndex = 0;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(28, 142);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Kullanıcı Adınız";
            txtUserName.Size = new Size(251, 27);
            txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(28, 175);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Şifreniz";
            txtPassword.Size = new Size(251, 27);
            txtPassword.TabIndex = 0;
            // 
            // txtPaswordAgain
            // 
            txtPaswordAgain.Location = new Point(28, 208);
            txtPaswordAgain.Name = "txtPaswordAgain";
            txtPaswordAgain.PlaceholderText = "Şifreniz Tekrar";
            txtPaswordAgain.Size = new Size(251, 27);
            txtPaswordAgain.TabIndex = 0;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(28, 257);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(114, 31);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnGiriseGit
            // 
            btnGiriseGit.Location = new Point(165, 257);
            btnGiriseGit.Name = "btnGiriseGit";
            btnGiriseGit.Size = new Size(114, 31);
            btnGiriseGit.TabIndex = 1;
            btnGiriseGit.Text = "Girişe Git";
            btnGiriseGit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Location = new Point(285, 43);
            label1.Name = "label1";
            label1.Size = new Size(194, 245);
            label1.TabIndex = 2;
            label1.Text = "Message";
            // 
            // RegisterPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 442);
            Controls.Add(groupBox1);
            Name = "RegisterPage";
            Text = "RegisterPage";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtPaswordAgain;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label1;
        private Button btnGiriseGit;
        private Button btnKaydet;
    }
}