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
            button_AddNew = new Button();
            Name = new DataGridViewTextBoxColumn();
            Surname = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            Project = new DataGridViewTextBoxColumn();
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
            dataGridView_Employees.Size = new Size(776, 380);
            dataGridView_Employees.TabIndex = 0;
            // 
            // button_AddNew
            // 
            button_AddNew.Location = new Point(12, 415);
            button_AddNew.Name = "button_AddNew";
            button_AddNew.Size = new Size(75, 23);
            button_AddNew.TabIndex = 1;
            button_AddNew.Text = "Přidat";
            button_AddNew.UseVisualStyleBackColor = true;
            button_AddNew.Click += button_AddNew_Click;
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
            // EmployeeList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_AddNew);
            Controls.Add(dataGridView_Employees);
            Text = "EmployeeList";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Employees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_Employees;
        private Button button_AddNew;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn Project;
    }
}