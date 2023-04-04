namespace ZaverecnyProjekt_Lanik
{
    partial class AdminForm
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
            this.listViewEmployees = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.buttonSearchEmployee = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.textBoxSearchEmployee = new System.Windows.Forms.TextBox();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.textBoxSearchUser = new System.Windows.Forms.TextBox();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.txtAddUser = new System.Windows.Forms.Button();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonSearchUser = new System.Windows.Forms.Button();
            this.textAssignedJob = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewEmployees
            // 
            this.listViewEmployees.AllowColumnReorder = true;
            this.listViewEmployees.AllowDrop = true;
            this.listViewEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8});
            this.listViewEmployees.FullRowSelect = true;
            this.listViewEmployees.GridLines = true;
            this.listViewEmployees.Location = new System.Drawing.Point(259, 33);
            this.listViewEmployees.Name = "listViewEmployees";
            this.listViewEmployees.Size = new System.Drawing.Size(529, 262);
            this.listViewEmployees.TabIndex = 2;
            this.listViewEmployees.UseCompatibleStateImageBehavior = false;
            this.listViewEmployees.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Pozice";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Jméno";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Příjmení";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Datum narození";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Email";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tel. číslo";
            // 
            // buttonSearchEmployee
            // 
            this.buttonSearchEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSearchEmployee.Location = new System.Drawing.Point(25, 230);
            this.buttonSearchEmployee.Name = "buttonSearchEmployee";
            this.buttonSearchEmployee.Size = new System.Drawing.Size(100, 23);
            this.buttonSearchEmployee.TabIndex = 3;
            this.buttonSearchEmployee.Text = "Najít";
            this.buttonSearchEmployee.UseVisualStyleBackColor = false;
            this.buttonSearchEmployee.Click += new System.EventHandler(this.buttonSearchEmployee_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jméno";
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(131, 91);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(100, 23);
            this.txtSecondName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Přijmení";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(131, 149);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(131, 178);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 23);
            this.txtPhone.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefonní číslo";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAdd.Location = new System.Drawing.Point(25, 259);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 36);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Přidat";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(131, 259);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(100, 36);
            this.buttonDeleteEmployee.TabIndex = 15;
            this.buttonDeleteEmployee.Text = "Smazat";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = false;
            this.buttonDeleteEmployee.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxSearchEmployee
            // 
            this.textBoxSearchEmployee.Location = new System.Drawing.Point(131, 230);
            this.textBoxSearchEmployee.Name = "textBoxSearchEmployee";
            this.textBoxSearchEmployee.Size = new System.Drawing.Size(100, 23);
            this.textBoxSearchEmployee.TabIndex = 16;
            this.textBoxSearchEmployee.TextChanged += new System.EventHandler(this.textBoxSearchEmployee_TextChanged);
            // 
            // listViewUsers
            // 
            this.listViewUsers.AllowColumnReorder = true;
            this.listViewUsers.AllowDrop = true;
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader13,
            this.columnHeader14});
            this.listViewUsers.FullRowSelect = true;
            this.listViewUsers.GridLines = true;
            this.listViewUsers.Location = new System.Drawing.Point(259, 334);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(529, 262);
            this.listViewUsers.TabIndex = 17;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Id";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Už. jméno";
            this.columnHeader13.Width = 80;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Role";
            // 
            // textBoxSearchUser
            // 
            this.textBoxSearchUser.Location = new System.Drawing.Point(131, 573);
            this.textBoxSearchUser.Name = "textBoxSearchUser";
            this.textBoxSearchUser.Size = new System.Drawing.Size(100, 23);
            this.textBoxSearchUser.TabIndex = 33;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteUser.Location = new System.Drawing.Point(131, 531);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(100, 36);
            this.buttonDeleteUser.TabIndex = 32;
            this.buttonDeleteUser.Text = "Smazat";
            this.buttonDeleteUser.UseVisualStyleBackColor = false;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // txtAddUser
            // 
            this.txtAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtAddUser.Location = new System.Drawing.Point(131, 418);
            this.txtAddUser.Name = "txtAddUser";
            this.txtAddUser.Size = new System.Drawing.Size(100, 36);
            this.txtAddUser.TabIndex = 31;
            this.txtAddUser.Text = "Přidat";
            this.txtAddUser.UseVisualStyleBackColor = false;
            this.txtAddUser.Click += new System.EventHandler(this.txtAddUser_Click);
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(131, 389);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(100, 23);
            this.txtRole.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Role";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(131, 360);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 23);
            this.txtPassword.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(83, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Heslo";
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(131, 331);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(100, 23);
            this.txtNickname.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(62, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Už. jméno";
            // 
            // buttonSearchUser
            // 
            this.buttonSearchUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSearchUser.Location = new System.Drawing.Point(25, 573);
            this.buttonSearchUser.Name = "buttonSearchUser";
            this.buttonSearchUser.Size = new System.Drawing.Size(100, 23);
            this.buttonSearchUser.TabIndex = 20;
            this.buttonSearchUser.Text = "Najít";
            this.buttonSearchUser.UseVisualStyleBackColor = false;
            this.buttonSearchUser.Click += new System.EventHandler(this.buttonSearchUser_Click);
            // 
            // textAssignedJob
            // 
            this.textAssignedJob.Location = new System.Drawing.Point(131, 33);
            this.textAssignedJob.Name = "textAssignedJob";
            this.textAssignedJob.Size = new System.Drawing.Size(100, 23);
            this.textAssignedJob.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Pozice";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Datum";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 23);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.Location = new System.Drawing.Point(688, 618);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 38;
            this.button1.Text = "Odhlásit se";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 675);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textAssignedJob);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearchUser);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.txtAddUser);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonSearchUser);
            this.Controls.Add(this.listViewUsers);
            this.Controls.Add(this.textBoxSearchEmployee);
            this.Controls.Add(this.buttonDeleteEmployee);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSearchEmployee);
            this.Controls.Add(this.listViewEmployees);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListView listViewEmployees;
        private Button buttonSearchEmployee;
        private TextBox txtName;
        private Label label2;
        private TextBox txtSecondName;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtPhone;
        private Label label5;
        private Button buttonAdd;
        private Button buttonDeleteEmployee;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private TextBox textBoxSearchEmployee;
        private ListView listViewUsers;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private TextBox textBoxSearchUser;
        private Button buttonDeleteUser;
        private Button txtAddUser;
        private TextBox txtRole;
        private Label label9;
        private TextBox txtPassword;
        private Label label10;
        private TextBox txtNickname;
        private Label label11;
        private Button buttonSearchUser;
        private ColumnHeader columnHeader8;
        private TextBox textAssignedJob;
        private Label label1;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Button button1;
    }
}