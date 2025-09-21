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
    public enum ImportExportAction { None, Import, Export }

    public partial class FormImportExport : Form
    {
        public ImportExportAction SelectedAction { get; private set; }

        public FormImportExport()
        {
            InitializeComponent();
            SelectedAction = ImportExportAction.None;
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            // this.SelectedAction = ImportExportAction.Import;
            // this.DialogResult = DialogResult.OK;
            // this.Close();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            this.SelectedAction = ImportExportAction.Export;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
