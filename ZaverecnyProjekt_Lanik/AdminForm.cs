using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ZaverecnyProjekt_Lanik
{
    public partial class AdminForm : Form
    {

        SqlRepository sql;
        private User user;
        private List<Employee> employees;
        private List<User> users;
        private string searchUser, searchEmployee;
        public AdminForm(User user)
        {
            InitializeComponent();
            sql = new SqlRepository();
            LoadUsers();
            LoadEmployees();
        }
        public void LoadUsers()
        {
            users = sql.GetUsers(searchUser);
            listViewUsers.Items.Clear();

            foreach (var user in users)
            {
                listViewUsers.Items.Add(user.ToListViewItem());
            }
        }
        private void buttonSearchUser_Click(object sender, EventArgs e)
        {
            searchUser = textBoxSearchUser.Text;
            LoadUsers();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            sql.AddEmployee(textAssignedJob.Text, txtName.Text, txtSecondName.Text, dateTimePicker1.Value.ToString(), txtEmail.Text, txtPhone.Text);
            LoadEmployees();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var row = listViewEmployees.SelectedItems[0];
            var id = row.SubItems[0].Text;
            sql.DeleteEmployee(Convert.ToInt32(id));
            listViewEmployees.SelectedItems[0].Remove();

            LoadUsers();
        }
        public void LoadEmployees()
        {
            employees = sql.GetEmployees(searchEmployee);
            listViewEmployees.Items.Clear();

            foreach (var employee in employees)
            {
                listViewEmployees.Items.Add(employee.ToListViewItem());
            }
        }

        private void txtAddUser_Click(object sender, EventArgs e)
        {
            if (txtRole.Text.ToString() == "admin" || txtRole.Text.ToLower() == "user")
            {
                sql.AddUser(txtNickname.Text, txtPassword.Text, txtRole.Text);
                LoadUsers();
            }
            else
            {
                MessageBox.Show("Role musí být 'user' nebo 'admin'.");
            }
          
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            var row = listViewUsers.SelectedItems[0];
            var id = row.SubItems[0].Text;
            sql.DeleteUser(Convert.ToInt32(id));
            listViewUsers.SelectedItems[0].Remove();

            LoadUsers();
        }

        private void textBoxSearchEmployee_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void buttonSearchEmployee_Click(object sender, EventArgs e)
        {
            searchEmployee = textBoxSearchEmployee.Text;
            LoadEmployees();
        }
    }
}
