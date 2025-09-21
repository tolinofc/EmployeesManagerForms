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
    public partial class FormStats : Form
    {
        public FormStats(BindingList<Employee> list)
        {
            InitializeComponent();
            CalculateAndDisplayStats(list);

            this.textBoxStats.SelectionStart = 0;
            this.textBoxStats.SelectionLength = 0;
        }

        private void CalculateAndDisplayStats(BindingList<Employee> list)
        {
            if (list == null)
            {
                this.textBoxStats.Text = "Nejsou k dispozici žádná data.";
                return;
            }

            StringBuilder statsBuilder = new StringBuilder();

            int totalEmployees = list.Count;
            statsBuilder.AppendLine($"Celkový počet zaměstnanců: {totalEmployees}");
            statsBuilder.AppendLine("------------------------------------");

            statsBuilder.AppendLine("Počet zaměstnanců podle oddělení:");
            var employeesByDepartment = list
                .Where(emp => emp.Department != null)
                .GroupBy(emp => emp.Department.Name)
                .OrderBy(group => group.Key);

            foreach (var group in employeesByDepartment)
            {
                statsBuilder.AppendLine($"- {group.Key}: {group.Count()} zaměstnanců");
            }

            statsBuilder.AppendLine("------------------------------------");
            statsBuilder.AppendLine("Počet zaměstnanců podle pozice:");
            var employeesByPosition = list
                .Where(emp => emp.Position != null)
                .GroupBy(emp => emp.Position.Name)
                .OrderBy(group => group.Key);

            foreach (var group in employeesByPosition)
            {
                statsBuilder.AppendLine($"- {group.Key}: {group.Count()} zaměstnanců");
            }

            statsBuilder.AppendLine("------------------------------------");
            statsBuilder.AppendLine("Počet zaměstnanců podle projektu:");
            var employeesByProject = list
                .Where(emp => emp.Project != null)
                .GroupBy(emp => emp.Project.Name)
                .OrderBy(group => group.Key);

            foreach (var group in employeesByProject)
            {
                statsBuilder.AppendLine($"- {group.Key}: {group.Count()} zaměstnanců");
            }

            this.textBoxStats.Text = statsBuilder.ToString();
        }
    }
}
