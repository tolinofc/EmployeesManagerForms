using EmployeesManager.Models;
using Google.Protobuf.Compiler;
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
            this.dataGridView_Employees.AutoGenerateColumns = false;
            this.dataGridView_Employees.DataSource = list;

            reloadData();
        }

        private void button_AddNew_Click(object sender, EventArgs e)
        {
            FormEmployee formEmployee = new FormEmployee();

            formEmployee.ShowDialog();

            if (formEmployee.DialogResult == DialogResult.OK)
            {
                context.Employees.Add(formEmployee.employee);
                this.list.Add(formEmployee.employee);
                this.context.SaveChanges();

                reloadData();
            }
        }

        private void reloadData()
        {
            this.list.Clear();

            var employeesFromDb = context.Employees.ToList().OrderBy(e => e.Id);

            foreach (Employee employee in employeesFromDb)
            {
                this.list.Add(employee);
            }
        }

        private void dataGridView_Employees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditSelectedItem(e.RowIndex, e.ColumnIndex);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView_Employees.CurrentCell != null)
            {
                int rowIndex = dataGridView_Employees.CurrentCell.RowIndex;
                int colIndex = dataGridView_Employees.CurrentCell.ColumnIndex;
                EditSelectedItem(rowIndex, colIndex);
            }
        }

        private void EditSelectedItem(int rowIndex, int columnIndex)
        {
            string columnName = this.dataGridView_Employees.Columns[columnIndex].Name;

            Employee employeeToEdit = this.list[rowIndex];

            switch (columnName)
            {
                case "Name":
                case "Surname":
                    FormEmployee formEmployee = new FormEmployee(employeeToEdit);

                    if (formEmployee.ShowDialog() == DialogResult.OK)
                    {
                        this.context.SaveChanges();
                        reloadData();
                    }
                    break;

                case "Department":
                    if (employeeToEdit.Department != null)
                    {
                        FormDepartment formDepartment = new FormDepartment(employeeToEdit.Department);
                        if (formDepartment.ShowDialog() == DialogResult.OK)
                        {
                            this.context.SaveChanges();
                            reloadData();
                        }
                    }
                    break;

                case "Position":
                    if (employeeToEdit.Position != null)
                    {
                        FormPosition formPosition = new FormPosition(employeeToEdit.Position);
                        if (formPosition.ShowDialog() == DialogResult.OK)
                        {
                            this.context.SaveChanges();
                            reloadData();
                        }
                    }
                    break;

                case "Project":
                    if (employeeToEdit.Project != null)
                    {
                        FormProject formProject = new FormProject(employeeToEdit.Project);
                        if (formProject.ShowDialog() == DialogResult.OK)
                        {
                            this.context.SaveChanges();
                            reloadData();
                        }
                    }
                    break;

                default: break;
            }
        }
    }
}
