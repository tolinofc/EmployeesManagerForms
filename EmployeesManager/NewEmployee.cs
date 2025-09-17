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
            LoadCombobox();
        }

        public NewEmployee(Employee employee) : this()
        {
            this.employee = employee;

            this.textBox_EmployeeName.Text = employee.Name;
            this.textBox_EmployeeSurname.Text = employee.Surname;
            this.textBox_Position.Text = employee.PositionId.ToString();
            this.textBox_Project.Text = employee.ProjectId.ToString();

            if (employee.DepartmentId > 0)
            {
                this.comboBox_Department.SelectedValue = employee.DepartmentId;
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            this.employee.Name = textBox_EmployeeName.Text;
            this.employee.Surname = textBox_EmployeeSurname.Text;
            this.employee.DepartmentId = (int)this.comboBox_Department.SelectedValue;
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

        private void button_AddNewDepartment_Click(object sender, EventArgs e)
        {
            BindingList<Department> listDepartment = new BindingList<Department>();

            NewDepartment formDepartment = new NewDepartment();

            formDepartment.Show();

            formDepartment.FormClosed += (sender, e) =>
            {
                using (MyContext context = new MyContext())
                {
                    if (formDepartment.DialogResult == DialogResult.OK)
                    {
                        context.Departments.Add(formDepartment.department);
                        listDepartment.Add(formDepartment.department);
                        context.SaveChanges();
                    }
                }
            };
        }

        private void LoadCombobox()
        {
            MyContext context = new MyContext();

            List<Department> departmentList = context.Departments.ToList();
            this.comboBox_Department.DataSource = departmentList;
            this.comboBox_Department.DisplayMember = "Name";
            this.comboBox_Department.ValueMember = "Id";
        }
    }
}
