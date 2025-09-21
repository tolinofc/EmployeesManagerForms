namespace EmployeesManager
{
    partial class EmployeeList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView_Employees = new DataGridView();
            FullName = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            Project = new DataGridViewTextBoxColumn();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonImportExport = new Button();
            buttonStats = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Employees).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Employees
            // 
            dataGridView_Employees.AllowUserToAddRows = false;
            dataGridView_Employees.AllowUserToDeleteRows = false;
            dataGridView_Employees.AllowUserToOrderColumns = true;
            dataGridView_Employees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Employees.Columns.AddRange(new DataGridViewColumn[] { FullName, Department, Position, Project });
            dataGridView_Employees.Location = new Point(12, 12);
            dataGridView_Employees.Name = "dataGridView_Employees";
            dataGridView_Employees.ReadOnly = true;
            dataGridView_Employees.Size = new Size(463, 543);
            dataGridView_Employees.TabIndex = 0;
            dataGridView_Employees.CellDoubleClick += dataGridView_Employees_CellDoubleClick;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Jméno";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // Department
            // 
            Department.DataPropertyName = "Department";
            Department.HeaderText = "Oddělení";
            Department.Name = "Department";
            Department.ReadOnly = true;
            // 
            // Position
            // 
            Position.DataPropertyName = "Position";
            Position.HeaderText = "Pozice";
            Position.Name = "Position";
            Position.ReadOnly = true;
            // 
            // Project
            // 
            Project.DataPropertyName = "Project";
            Project.HeaderText = "Projekt";
            Project.Name = "Project";
            Project.ReadOnly = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 561);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Přidat";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += button_AddNew_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(93, 561);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "Upravit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(174, 561);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Odstranit";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonImportExport
            // 
            buttonImportExport.Location = new Point(255, 561);
            buttonImportExport.Name = "buttonImportExport";
            buttonImportExport.Size = new Size(95, 23);
            buttonImportExport.TabIndex = 2;
            buttonImportExport.Text = "Import/Export";
            buttonImportExport.UseVisualStyleBackColor = true;
            buttonImportExport.Click += buttonImportExport_Click;
            // 
            // buttonStats
            // 
            buttonStats.Location = new Point(356, 561);
            buttonStats.Name = "buttonStats";
            buttonStats.Size = new Size(75, 23);
            buttonStats.TabIndex = 4;
            buttonStats.Text = "Statistiky";
            buttonStats.UseVisualStyleBackColor = true;
            buttonStats.Click += buttonStats_Click;
            // 
            // EmployeeList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 596);
            Controls.Add(buttonStats);
            Controls.Add(buttonImportExport);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridView_Employees);
            MaximumSize = new Size(506, 635);
            MinimumSize = new Size(506, 635);
            Name = "EmployeeList";
            Text = "Správa zaměstnanců";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Employees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_Employees;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn Project;
        private Button buttonImportExport;
        private Button buttonStats;
    }
}