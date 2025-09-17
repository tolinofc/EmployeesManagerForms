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

            if (employee.DepartmentId > 0)
            {
                this.comboBox_Department.SelectedValue = employee.DepartmentId;
            }

            if (employee.PositionId > 0)
            {
                this.comboBox_Position.SelectedValue = employee.PositionId;
            }

            if (employee.PositionId > 0)
            {
                this.comboBox_Project.SelectedValue = employee.ProjectId;
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                this.employee.Name = textBox_EmployeeName.Text;
                this.employee.Surname = textBox_EmployeeSurname.Text;
                this.employee.DepartmentId = (int)this.comboBox_Department.SelectedValue;
                this.employee.ProjectId = (int)this.comboBox_Project.SelectedValue;
                this.employee.PositionId = (int)this.comboBox_Position.SelectedValue;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
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

            List<Position> positionList = context.Positions.ToList();
            this.comboBox_Position.DataSource = positionList;
            this.comboBox_Position.DisplayMember = "Name";
            this.comboBox_Position.ValueMember = "Id";


            List<Project> projectList = context.Projects.ToList();
            this.comboBox_Project.DataSource = projectList;
            this.comboBox_Project.DisplayMember = "Name";
            this.comboBox_Project.ValueMember = "Id";
        }

        private void button_AddNewPosition_Click(object sender, EventArgs e)
        {
            BindingList<Position> listPosition = new BindingList<Position>();

            NewPosition formPosition = new NewPosition();

            formPosition.Show();

            formPosition.FormClosed += (sender, e) =>
            {
                using (MyContext context = new MyContext())
                {
                    if (formPosition.DialogResult == DialogResult.OK)
                    {
                        context.Positions.Add(formPosition.position);
                        listPosition.Add(formPosition.position);
                        context.SaveChanges();
                    }
                }
            };
        }

        private void button_AddNewProject_Click(object sender, EventArgs e)
        {
            BindingList<Project> listProject = new BindingList<Project>();

            NewProject formProject = new NewProject();

            formProject.Show();

            formProject.FormClosed += (sender, e) =>
            {
                using (MyContext context = new MyContext())
                {
                    if (formProject.DialogResult == DialogResult.OK)
                    {
                        context.Projects.Add(formProject.project);
                        listProject.Add(formProject.project);
                        context.SaveChanges();
                    }
                }
            };
        }

        private void ValidateTextbox(object sender, CancelEventArgs e)
        {
            if (e.Cancel) return;
            TextBox textBox = sender as TextBox;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                this.NewEmployeeValidate.SetError(textBox, "Pole je povinne");
            }
            else
            {
                this.NewEmployeeValidate.SetError(textBox, null);
            }
        }
    }
}
