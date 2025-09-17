namespace EmployeesManager
{
    partial class NewEmployee
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
            textBox_EmployeeName = new TextBox();
            textBox_EmployeeSurname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button_OK = new Button();
            button_Cancel = new Button();
            textBox_Position = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox_Project = new TextBox();
            label6 = new Label();
            button_AddNewPosition = new Button();
            button_AddNewDepartment = new Button();
            button_AddNewProject = new Button();
            comboBox_Department = new ComboBox();
            SuspendLayout();
            // 
            // textBox_EmployeeName
            // 
            textBox_EmployeeName.Location = new Point(65, 54);
            textBox_EmployeeName.Name = "textBox_EmployeeName";
            textBox_EmployeeName.Size = new Size(145, 23);
            textBox_EmployeeName.TabIndex = 0;
            // 
            // textBox_EmployeeSurname
            // 
            textBox_EmployeeSurname.Location = new Point(65, 83);
            textBox_EmployeeSurname.Name = "textBox_EmployeeSurname";
            textBox_EmployeeSurname.Size = new Size(145, 23);
            textBox_EmployeeSurname.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 57);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Jméno";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 86);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Příjmení";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(33, 9);
            label3.Name = "label3";
            label3.Size = new Size(176, 28);
            label3.TabIndex = 2;
            label3.Text = "Nový zaměstnanec";
            // 
            // button_OK
            // 
            button_OK.Location = new Point(64, 199);
            button_OK.Name = "button_OK";
            button_OK.Size = new Size(75, 23);
            button_OK.TabIndex = 5;
            button_OK.Text = "Přidat";
            button_OK.UseVisualStyleBackColor = true;
            button_OK.Click += button_OK_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(145, 199);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(75, 23);
            button_Cancel.TabIndex = 6;
            button_Cancel.Text = "Zrušit";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // textBox_Position
            // 
            textBox_Position.Location = new Point(64, 112);
            textBox_Position.Name = "textBox_Position";
            textBox_Position.Size = new Size(145, 23);
            textBox_Position.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 115);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 1;
            label4.Text = "Pozice";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 144);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 1;
            label5.Text = "Oddeleni";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox_Project
            // 
            textBox_Project.Location = new Point(64, 170);
            textBox_Project.Name = "textBox_Project";
            textBox_Project.Size = new Size(145, 23);
            textBox_Project.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 173);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 1;
            label6.Text = "Projekt";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button_AddNewPosition
            // 
            button_AddNewPosition.Location = new Point(215, 111);
            button_AddNewPosition.Name = "button_AddNewPosition";
            button_AddNewPosition.Size = new Size(52, 23);
            button_AddNewPosition.TabIndex = 7;
            button_AddNewPosition.Text = "Přidat";
            button_AddNewPosition.UseVisualStyleBackColor = true;
            // 
            // button_AddNewDepartment
            // 
            button_AddNewDepartment.Location = new Point(215, 140);
            button_AddNewDepartment.Name = "button_AddNewDepartment";
            button_AddNewDepartment.Size = new Size(52, 23);
            button_AddNewDepartment.TabIndex = 7;
            button_AddNewDepartment.Text = "Přidat";
            button_AddNewDepartment.UseVisualStyleBackColor = true;
            button_AddNewDepartment.Click += button_AddNewDepartment_Click;
            // 
            // button_AddNewProject
            // 
            button_AddNewProject.Location = new Point(215, 170);
            button_AddNewProject.Name = "button_AddNewProject";
            button_AddNewProject.Size = new Size(52, 23);
            button_AddNewProject.TabIndex = 7;
            button_AddNewProject.Text = "Přidat";
            button_AddNewProject.UseVisualStyleBackColor = true;
            // 
            // comboBox_Department
            // 
            comboBox_Department.FormattingEnabled = true;
            comboBox_Department.Location = new Point(67, 141);
            comboBox_Department.Name = "comboBox_Department";
            comboBox_Department.Size = new Size(142, 23);
            comboBox_Department.TabIndex = 8;
            // 
            // NewEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 235);
            Controls.Add(comboBox_Department);
            Controls.Add(button_AddNewProject);
            Controls.Add(button_AddNewDepartment);
            Controls.Add(button_AddNewPosition);
            Controls.Add(button_Cancel);
            Controls.Add(button_OK);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(textBox_Project);
            Controls.Add(textBox_EmployeeSurname);
            Controls.Add(textBox_Position);
            Controls.Add(textBox_EmployeeName);
            Name = "NewEmployee";
            Text = "NewEmployeeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_EmployeeName;
        private TextBox textBox_EmployeeSurname;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button_OK;
        private Button button_Cancel;
        private TextBox textBox_Position;
        private Label label4;
        private Label label5;
        private TextBox textBox_Project;
        private Label label6;
        private Button button_AddNewPosition;
        private Button button_AddNewDepartment;
        private Button button_AddNewProject;
        private ComboBox comboBox_Department;
    }
}