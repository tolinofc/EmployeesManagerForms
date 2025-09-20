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

namespace EmployeesManager.Forms
{
    public partial class FormManager : Form
    {
        MyContext context;
        BindingList<Employee> employeeList;
        BindingList<Department> departmentList;
        BindingList<Position> positionList;
        BindingList<Project> projectList;

        public FormManager(MyContext context)
        {
            this.context = context;
            InitializeComponent();

            this.employeeList =   new BindingList<Employee>(this.context.Employees.ToList());
            this.departmentList = new BindingList<Department>(this.context.Departments.ToList());
            this.positionList =   new BindingList<Position>(this.context.Positions.ToList());
            this.projectList =    new BindingList<Project>(this.context.Projects.ToList());

            this.listBoxEmployee.DataSource =   this.employeeList;
            this.listBoxDepartment.DataSource = this.departmentList;
            this.listBoxPosition.DataSource =   this.positionList;
            this.listBoxProject.DataSource =    this.projectList;

        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            DeleteSelectedItem<Employee>(this.listBoxEmployee, this.employeeList);
        }

        private void buttonDeleteDepartment_Click(object sender, EventArgs e)
        {
            DeleteSelectedItem<Department>(this.listBoxDepartment, this.departmentList);
        }

        private void buttonDeletePosition_Click(object sender, EventArgs e)
        {
            DeleteSelectedItem<Position>(this.listBoxPosition, this.positionList);
        }

        private void buttonDeleteProject_Click(object sender, EventArgs e)
        {
            DeleteSelectedItem<Project>(this.listBoxProject, this.projectList);
        }

        private void DeleteSelectedItem<TEntity>(ListBox listBox, BindingList<TEntity> list) where TEntity : class, IEntityWithName
        {
            if (listBox.SelectedItem is not TEntity itemToDelete)
            {
                return;
            }

            var result = MessageBox.Show($"Opravdu si přejete smazat '{itemToDelete}'?", "Potvrzení smazání", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                using (MyContext context = new MyContext())
                {
                    var entityInDb = context.Set<TEntity>().Find(itemToDelete.Id);

                    if (entityInDb != null)
                    {
                        context.Set<TEntity>().Remove(entityInDb);
                        context.SaveChanges();
                        list.Remove(itemToDelete);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Položku nelze smazat, protože je k ní přiřazen nějaký zaměstnanec.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
