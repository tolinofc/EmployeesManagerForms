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
    public partial class FormDepartment : Form
    {
        public Department department = new Department();
        public FormDepartment()
        {
            InitializeComponent();
        }

        public FormDepartment(Department department) : this()
        {
            this.department = department;

            this.textBox_DepartmentName.Text = department.Name;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()) 
            {
                this.department.Name = textBox_DepartmentName.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidateTextbox(object sender, CancelEventArgs e)
        {
            if (e.Cancel) return;
            TextBox textBox = sender as TextBox;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                this.NewDepartmentValidate.SetError(textBox, "Pole je povinne");
            }
            else
            {
                this.NewDepartmentValidate.SetError(textBox, null);
            }
        }
    }
}
