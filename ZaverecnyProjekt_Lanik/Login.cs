using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ZaverecnyProjekt_Lanik
{
    public partial class Login : Form
    {
        SqlRepository sql;
        public Login()
        {
            InitializeComponent();
            sql = new SqlRepository();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var user = sql.LoginUser(txtUsername.Text.Trim());
                if (user != null)
                {
                    if (user.VerifyPassword(txtPassword.Text))
                    {
                        if (user.Role == "admin")
                        {
                            AdminForm admin = new AdminForm(user);
                            admin.Show();
                            this.Hide();
                            return;
                        }
                        else if (user.Role == "user")
                        {
                            UserForm userf = new UserForm();
                            userf.Show();
                            this.Hide();
                            return;
                        }
                    }
                }
                MessageBox.Show("Jméno nebo heslo je špatně.");
        }
    }
}