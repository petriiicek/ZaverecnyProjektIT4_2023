using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaverecnyProjekt_Lanik
{
    public partial class UserForm : Form
    {
        SqlRepository sql;
        List<Employee> employees;
        string searchEmployee;
        public UserForm()
        {
            InitializeComponent();
            sql = new SqlRepository();
            LoadEmployees();
        }

        private void buttonSearchEmployee_Click(object sender, EventArgs e)
        {
            searchEmployee = textBoxSearchEmployee.Text;
            LoadEmployees();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
