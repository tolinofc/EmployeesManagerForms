using EmployeesManager.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class FormEmployee : Form
    {
        public Employee employee = new Employee();
        public FormEmployee()
        {
            InitializeComponent();
            LoadAllComboboxes();
        }

        public FormEmployee(Employee employee) : this()
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

            FormDepartment formDepartment = new FormDepartment();

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

                        LoadCombobox<Department>(this.comboBox_Department);
                    }
                }
            };
        }

        private void button_AddNewPosition_Click(object sender, EventArgs e)
        {
            BindingList<Position> listPosition = new BindingList<Position>();

            FormPosition formPosition = new FormPosition();

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

                        LoadCombobox<Position>(this.comboBox_Position);
                    }
                }
            };
        }

        private void button_AddNewProject_Click(object sender, EventArgs e)
        {
            BindingList<Project> listProject = new BindingList<Project>();

            FormProject formProject = new FormProject();

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

                        LoadCombobox<Project>(this.comboBox_Project);
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

        private void LoadAllComboboxes()
        {
            LoadCombobox<Department>(this.comboBox_Department);
            LoadCombobox<Position>(this.comboBox_Position);
            LoadCombobox<Project>(this.comboBox_Project);
        }

        private void LoadCombobox<TEntity>(ComboBox comboBox) where TEntity : class, IEntityWithName
        {
            using (var context = new MyContext())
            {
                var selectedId = comboBox.SelectedValue;

                comboBox.DataSource = context.Set<TEntity>().ToList();

                comboBox.DisplayMember = "Name";
                comboBox.ValueMember = "Id";

                if (selectedId != null)
                {
                    try
                    {
                        comboBox.SelectedValue = selectedId;
                    }
                    catch (ArgumentOutOfRangeException) { }
                }
            }
        }
    }
}
