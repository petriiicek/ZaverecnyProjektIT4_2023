using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjekt_Lanik
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string AssignedRole { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Employee(int employeeId, string assignedRole, string fName, string lName, DateTime birthdate, string email, string phoneNumber)
        {
            EmployeeId = employeeId;
            AssignedRole = assignedRole;
            FirstName = fName;
            LastName = lName;
            BirthDate = birthdate;
            Email = email;
            PhoneNumber = phoneNumber;
        }
        public ListViewItem ToListViewItem()
        {
            return new ListViewItem(new string[] { EmployeeId.ToString(), AssignedRole, FirstName, LastName, BirthDate.Date.ToString("dd.MM.yyyy"), Email, PhoneNumber });
        }

    }
}
