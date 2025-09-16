using EmployeesManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManager
{
    public partial class NewEmployee : Form
    {
        Employee employee = new Employee();
        public NewEmployee()
        {
            InitializeComponent();
        }

        public NewEmployee(Employee employee) : this()
        {
            this.employee = employee;

            this.textBox_EmployeeName.Text = employee.Name;
            this.textBox_EmployeeSurname.Text = employee.Surname;
        }
    }
}
