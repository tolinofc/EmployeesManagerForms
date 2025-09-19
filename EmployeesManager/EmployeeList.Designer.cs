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
            Name = new DataGridViewTextBoxColumn();
            Surname = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            Project = new DataGridViewTextBoxColumn();
            buttonAdd = new Button();
            buttonEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Employees).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Employees
            // 
            dataGridView_Employees.AllowUserToAddRows = false;
            dataGridView_Employees.AllowUserToDeleteRows = false;
            dataGridView_Employees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Employees.Columns.AddRange(new DataGridViewColumn[] { Name, Surname, Department, Position, Project });
            dataGridView_Employees.Location = new Point(12, 12);
            dataGridView_Employees.Name = "dataGridView_Employees";
            dataGridView_Employees.ReadOnly = true;
            dataGridView_Employees.Size = new Size(543, 543);
            dataGridView_Employees.TabIndex = 0;
            dataGridView_Employees.CellContentDoubleClick += dataGridViewEmployees_CellContentDoubleClick;
            // 
            // Name
            // 
            Name.DataPropertyName = "Name";
            Name.HeaderText = "Jméno";
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // Surname
            // 
            Surname.DataPropertyName = "Surname";
            Surname.HeaderText = "Příjmení";
            Surname.Name = "Surname";
            Surname.ReadOnly = true;
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
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Přidat";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += button_AddNew_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(93, 561);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Spravovat";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // EmployeeList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 596);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridView_Employees);
            MaximumSize = new Size(583, 635);
            MinimumSize = new Size(583, 635);
            Text = "Správa zaměstnanců";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Employees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_Employees;
        private Button buttonAdd;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn Project;
        private Button buttonEdit;
    }
}