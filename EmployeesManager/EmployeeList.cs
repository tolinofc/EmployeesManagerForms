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
    public partial class EmployeeList : Form
    {
        MyContext context;

        public EmployeeList()
        {
            this.context = new MyContext();
            InitializeComponent();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            var employees = context.Employees.ToList();

            this.dataGridView_Employees.DataSource = employees;
        }

        private void button_AddNew_Click(object sender, EventArgs e)
        {
            NewEmployee newEmployee = new NewEmployee();

            newEmployee.Show();
            newEmployee.FormClosed += (sender, e) =>
            {
                if (newEmployee.DialogResult == DialogResult.OK)
                {
                    //context.Employees.Add(newEmployee);
                }
            };
        }
    }
}
