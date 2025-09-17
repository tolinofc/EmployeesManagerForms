namespace EmployeesManager
{
    partial class NewObject
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
            button_Employee = new Button();
            button_Department = new Button();
            button_Position = new Button();
            button_Project = new Button();
            button_Cancel = new Button();
            SuspendLayout();
            // 
            // button_Employee
            // 
            button_Employee.Location = new Point(12, 12);
            button_Employee.Name = "button_Employee";
            button_Employee.Size = new Size(146, 23);
            button_Employee.TabIndex = 0;
            button_Employee.Text = "Zaměstnanec";
            button_Employee.UseVisualStyleBackColor = true;
            button_Employee.Click += button_Employee_Click;
            // 
            // button_Department
            // 
            button_Department.Location = new Point(12, 41);
            button_Department.Name = "button_Department";
            button_Department.Size = new Size(146, 23);
            button_Department.TabIndex = 0;
            button_Department.Text = "Oddělení";
            button_Department.UseVisualStyleBackColor = true;
            button_Department.Click += button_Department_Click;
            // 
            // button_Position
            // 
            button_Position.Location = new Point(12, 70);
            button_Position.Name = "button_Position";
            button_Position.Size = new Size(146, 23);
            button_Position.TabIndex = 0;
            button_Position.Text = "Pozice";
            button_Position.UseVisualStyleBackColor = true;
            button_Position.Click += button_Position_Click;
            // 
            // button_Project
            // 
            button_Project.Location = new Point(12, 99);
            button_Project.Name = "button_Project";
            button_Project.Size = new Size(146, 23);
            button_Project.TabIndex = 0;
            button_Project.Text = "Projekt";
            button_Project.UseVisualStyleBackColor = true;
            button_Project.Click += button_Project_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(83, 150);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(75, 23);
            button_Cancel.TabIndex = 1;
            button_Cancel.Text = "Zavřít";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // NewObject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(170, 188);
            Controls.Add(button_Cancel);
            Controls.Add(button_Project);
            Controls.Add(button_Position);
            Controls.Add(button_Department);
            Controls.Add(button_Employee);
            Name = "NewObject";
            Text = "NewObject";
            ResumeLayout(false);
        }

        #endregion

        private Button button_Employee;
        private Button button_Department;
        private Button button_Position;
        private Button button_Project;
        private Button button_Cancel;
    }
}