namespace ZaverecnyProjekt_Lanik
{
    partial class Login
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
            this.labelname = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(30, 138);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(102, 15);
            this.labelname.TabIndex = 0;
            this.labelname.Text = "Uživatelské jméno";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Cursor = System.Windows.Forms.Cursors.Cross;
            this.password.Location = new System.Drawing.Point(95, 187);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(37, 15);
            this.password.TabIndex = 1;
            this.password.Text = "Heslo";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(154, 223);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(235, 39);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Přihlásit se";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(154, 135);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(235, 29);
            this.txtUsername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(154, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Přihlášení";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(154, 179);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(235, 29);
            this.txtPassword.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 301);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.labelname);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelname;
        private Label password;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtPassword;
        public Button btn_login;
    }
}