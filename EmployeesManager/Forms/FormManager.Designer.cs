namespace EmployeesManager.Forms
{
    partial class FormManager
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
            listBoxDepartment = new ListBox();
            listBoxPosition = new ListBox();
            listBoxProject = new ListBox();
            buttonDeleteDepartment = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonDeletePosition = new Button();
            buttonDeleteProject = new Button();
            SuspendLayout();
            // 
            // listBoxDepartment
            // 
            listBoxDepartment.FormattingEnabled = true;
            listBoxDepartment.ItemHeight = 15;
            listBoxDepartment.Location = new Point(12, 43);
            listBoxDepartment.Name = "listBoxDepartment";
            listBoxDepartment.Size = new Size(129, 214);
            listBoxDepartment.TabIndex = 0;
            // 
            // listBoxPosition
            // 
            listBoxPosition.FormattingEnabled = true;
            listBoxPosition.ItemHeight = 15;
            listBoxPosition.Location = new Point(147, 43);
            listBoxPosition.Name = "listBoxPosition";
            listBoxPosition.Size = new Size(129, 214);
            listBoxPosition.TabIndex = 0;
            // 
            // listBoxProject
            // 
            listBoxProject.FormattingEnabled = true;
            listBoxProject.ItemHeight = 15;
            listBoxProject.Location = new Point(282, 43);
            listBoxProject.Name = "listBoxProject";
            listBoxProject.Size = new Size(129, 214);
            listBoxProject.TabIndex = 0;
            // 
            // buttonDeleteDepartment
            // 
            buttonDeleteDepartment.Location = new Point(12, 264);
            buttonDeleteDepartment.Name = "buttonDeleteDepartment";
            buttonDeleteDepartment.Size = new Size(75, 23);
            buttonDeleteDepartment.TabIndex = 1;
            buttonDeleteDepartment.Text = "Odstranit";
            buttonDeleteDepartment.UseVisualStyleBackColor = true;
            buttonDeleteDepartment.Click += buttonDeleteDepartment_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 2;
            label1.Text = "Oddělení";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(147, 19);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 2;
            label2.Text = "Pozice";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(282, 19);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 2;
            label3.Text = "Projekt";
            // 
            // buttonDeletePosition
            // 
            buttonDeletePosition.Location = new Point(147, 263);
            buttonDeletePosition.Name = "buttonDeletePosition";
            buttonDeletePosition.Size = new Size(75, 23);
            buttonDeletePosition.TabIndex = 1;
            buttonDeletePosition.Text = "Odstranit";
            buttonDeletePosition.UseVisualStyleBackColor = true;
            buttonDeletePosition.Click += buttonDeletePosition_Click;
            // 
            // buttonDeleteProject
            // 
            buttonDeleteProject.Location = new Point(282, 263);
            buttonDeleteProject.Name = "buttonDeleteProject";
            buttonDeleteProject.Size = new Size(75, 23);
            buttonDeleteProject.TabIndex = 1;
            buttonDeleteProject.Text = "Odstranit";
            buttonDeleteProject.UseVisualStyleBackColor = true;
            buttonDeleteProject.Click += buttonDeleteProject_Click;
            // 
            // FormManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 301);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonDeleteProject);
            Controls.Add(buttonDeletePosition);
            Controls.Add(buttonDeleteDepartment);
            Controls.Add(listBoxProject);
            Controls.Add(listBoxPosition);
            Controls.Add(listBoxDepartment);
            Name = "FormManager";
            Text = "FormManager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxDepartment;
        private ListBox listBoxPosition;
        private ListBox listBoxProject;
        private Button buttonDeleteDepartment;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonDeletePosition;
        private Button buttonDeleteProject;
    }
}