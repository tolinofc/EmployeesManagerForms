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
        public Employee employee = new Employee();
        public NewEmployee()
        {
            InitializeComponent();
        }

        public NewEmployee(Employee employee) : this()
        {
            this.employee = employee;

            this.textBox_EmployeeName.Text = employee.Name;
            this.textBox_EmployeeSurname.Text = employee.Surname;
            this.textBox_Department.Text = employee.DepartmentId.ToString();
            this.textBox_Position.Text = employee.PositionId.ToString();
            this.textBox_Project.Text = employee.ProjectId.ToString();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            this.employee.Name = textBox_EmployeeName.Text;
            this.employee.Surname = textBox_EmployeeSurname.Text;
            this.employee.DepartmentId = Int32.Parse(textBox_Department.Text);
            this.employee.ProjectId = Int32.Parse(textBox_Project.Text);
            this.employee.PositionId = Int32.Parse(textBox_Position.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
