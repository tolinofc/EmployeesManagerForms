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
            NewObject newObject = new NewObject(list);
            newObject.ShowDialog();

            if (DialogResult == DialogResult.OK)
            {
                this.list = newObject.list;
            }
        }
    }
}
