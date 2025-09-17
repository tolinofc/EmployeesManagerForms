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
    public partial class NewProject : Form
    {
        public Project project = new Project();
        public NewProject()
        {
            InitializeComponent();
        }

        public NewProject(Project project) : this()
        {
            this.project = project;

            this.textBox_ProjectName.Text = project.Name;
            this.textBox_ProjectDescription.Text = project.Description;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            this.project.Name = textBox_ProjectName.Text;
            this.project.Description = textBox_ProjectDescription.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
