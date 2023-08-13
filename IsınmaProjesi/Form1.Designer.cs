namespace IsınmaProjesi
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
            chcBoxVisible = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            txtBoxUserPassword = new TextBox();
            txtBoxUserName = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // chcBoxVisible
            // 
            chcBoxVisible.AutoSize = true;
            chcBoxVisible.Location = new Point(304, 116);
            chcBoxVisible.Name = "chcBoxVisible";
            chcBoxVisible.Size = new Size(96, 19);
            chcBoxVisible.TabIndex = 11;
            chcBoxVisible.Text = "Göster - Gizle";
            chcBoxVisible.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 116);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 10;
            label2.Text = "Kullanıcı Şifre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 73);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 9;
            label1.Text = "Kullanıcı Adı :";
            // 
            // txtBoxUserPassword
            // 
            txtBoxUserPassword.Location = new Point(198, 113);
            txtBoxUserPassword.Name = "txtBoxUserPassword";
            txtBoxUserPassword.Size = new Size(100, 23);
            txtBoxUserPassword.TabIndex = 8;
            // 
            // txtBoxUserName
            // 
            txtBoxUserName.Location = new Point(198, 70);
            txtBoxUserName.Name = "txtBoxUserName";
            txtBoxUserName.Size = new Size(100, 23);
            txtBoxUserName.TabIndex = 7;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Control;
            btnLogin.Location = new Point(198, 185);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 283);
            Controls.Add(chcBoxVisible);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoxUserPassword);
            Controls.Add(txtBoxUserName);
            Controls.Add(btnLogin);
            Name = "Form1";
            Text = "Giriş Yap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chcBoxVisible;
        private Label label2;
        private Label label1;
        private TextBox txtBoxUserPassword;
        private TextBox txtBoxUserName;
        private Button btnLogin;
    }
}