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
    public partial class NewObject : Form
    {
        public BindingList<Employee> list;

        public NewObject()
        {
            InitializeComponent();
        }

        public NewObject(BindingList<Employee> list) : this() 
        {
            this.list = list;
        }

        private void button_Employee_Click(object sender, EventArgs e)
        {
            NewEmployee formEmployee = new NewEmployee();

            formEmployee.ShowDialog();

            if (formEmployee.DialogResult == DialogResult.OK)
            {
                using (MyContext context = new MyContext())
                {
                    context.Employees.Add(formEmployee.employee);
                    this.list.Add(formEmployee.employee);
                    context.SaveChanges();

                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void button_Department_Click(object sender, EventArgs e)
        {
            NewDepartment formDepartment = new NewDepartment();

            formDepartment.ShowDialog();

            if (formDepartment.DialogResult == DialogResult.OK)
            {
                using (MyContext context = new MyContext())
                {
                    context.Departments.Add(formDepartment.department);
                    context.SaveChanges();

                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void button_Position_Click(object sender, EventArgs e)
        {

        }

        private void button_Project_Click(object sender, EventArgs e)
        {

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}
