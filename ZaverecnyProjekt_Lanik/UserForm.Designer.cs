namespace ZaverecnyProjekt_Lanik
{
    partial class UserForm
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
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.listViewEmployees = new System.Windows.Forms.ListView();
            this.textBoxSearchEmployee = new System.Windows.Forms.TextBox();
            this.buttonSearchEmployee = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.listViewEmployees.Location = new System.Drawing.Point(12, 12);
            this.listViewEmployees.Name = "listViewEmployees";
            this.listViewEmployees.Size = new System.Drawing.Size(529, 262);
            this.listViewEmployees.TabIndex = 18;
            this.listViewEmployees.UseCompatibleStateImageBehavior = false;
            this.listViewEmployees.View = System.Windows.Forms.View.Details;
            // 
            // textBoxSearchEmployee
            // 
            this.textBoxSearchEmployee.Location = new System.Drawing.Point(118, 280);
            this.textBoxSearchEmployee.Name = "textBoxSearchEmployee";
            this.textBoxSearchEmployee.Size = new System.Drawing.Size(100, 23);
            this.textBoxSearchEmployee.TabIndex = 20;
            // 
            // buttonSearchEmployee
            // 
            this.buttonSearchEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSearchEmployee.Location = new System.Drawing.Point(12, 280);
            this.buttonSearchEmployee.Name = "buttonSearchEmployee";
            this.buttonSearchEmployee.Size = new System.Drawing.Size(100, 23);
            this.buttonSearchEmployee.TabIndex = 19;
            this.buttonSearchEmployee.Text = "Najít";
            this.buttonSearchEmployee.UseVisualStyleBackColor = false;
            this.buttonSearchEmployee.Click += new System.EventHandler(this.buttonSearchEmployee_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.Location = new System.Drawing.Point(441, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 39;
            this.button1.Text = "Odhlásit se";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 323);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSearchEmployee);
            this.Controls.Add(this.buttonSearchEmployee);
            this.Controls.Add(this.listViewEmployees);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader8;
        private ListView listViewEmployees;
        private TextBox textBoxSearchEmployee;
        private Button buttonSearchEmployee;
        private Button button1;
    }
}