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
        BindingList<Department> departmentList;
        BindingList<Position> positionList;
        BindingList<Project> projectList;
        public FormManager(MyContext context)
        {
            this.context = context;
            InitializeComponent();

            this.departmentList = new BindingList<Department>(this.context.Departments.ToList());
            this.positionList = new BindingList<Position>(this.context.Positions.ToList());
            this.projectList = new BindingList<Project>(this.context.Projects.ToList());

            this.listBoxDepartment.DataSource = this.departmentList;
            this.listBoxPosition.DataSource = this.positionList;
            this.listBoxProject.DataSource = this.projectList;

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

        private void DeleteSelectedItem<TEntity>(ListBox listBox, BindingList<TEntity> list) where TEntity : class
        {
            if (listBox.SelectedItem is not TEntity itemToDelete)
            {
                MessageBox.Show("Prosím, vyberte položku ke smazání.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show($"Opravdu si přejete smazat '{itemToDelete}'?", "Potvrzení smazání", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                this.context.Set<TEntity>().Remove(itemToDelete);

                this.context.SaveChanges();

                list.Remove(itemToDelete);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Položku nelze smazat, protože je používána v jiné části aplikace.\n\n" + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
