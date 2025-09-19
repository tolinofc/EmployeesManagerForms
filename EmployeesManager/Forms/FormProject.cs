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
    public partial class FormProject : Form
    {
        public Project project = new Project();
        public FormProject()
        {
            InitializeComponent();
        }

        public FormProject(Project project) : this()
        {
            this.project = project;

            this.textBox_ProjectName.Text = project.Name;
            this.textBox_ProjectDescription.Text = project.Description;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                this.project.Name = textBox_ProjectName.Text;
                this.project.Description = textBox_ProjectDescription.Text;

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
                this.NewProjectValidate.SetError(textBox, "Pole je povinne");
            }
            else
            {
                this.NewProjectValidate.SetError(textBox, null);
            }
        }
    }
}
