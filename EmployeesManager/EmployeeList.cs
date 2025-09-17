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
    public partial class EmployeeList : Form
    {
        private MyContext context;
        private BindingList<Employee> list = new BindingList<Employee>();

        public EmployeeList()
        {
            this.context = new MyContext();
            InitializeComponent();

            var employeesFromDb = context.Employees.ToList();
            this.list = new BindingList<Employee>(employeesFromDb);

            this.dataGridView_Employees.DataSource = list;
        }

        private void button_AddNew_Click(object sender, EventArgs e)
        {
            NewEmployee formEmployee = new NewEmployee();

            formEmployee.Show();
            formEmployee.FormClosed += (sender, e) =>
            {
                if (formEmployee.DialogResult == DialogResult.OK)
                {
                    context.Employees.Add(formEmployee.employee);
                    this.list.Add(formEmployee.employee);
                    this.context.SaveChanges();
                }
            };
        }
    }
}
