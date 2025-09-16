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
            textBox_EmployeeSurname.TabIndex = 0;
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
            label3.Location = new Point(34, 9);
            label3.Name = "label3";
            label3.Size = new Size(176, 28);
            label3.TabIndex = 2;
            label3.Text = "Nový zaměstnanec";
            // 
            // button_OK
            // 
            button_OK.Location = new Point(54, 121);
            button_OK.Name = "button_OK";
            button_OK.Size = new Size(75, 23);
            button_OK.TabIndex = 3;
            button_OK.Text = "Přidat";
            button_OK.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(135, 121);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(75, 23);
            button_Cancel.TabIndex = 4;
            button_Cancel.Text = "Zrušit";
            button_Cancel.UseVisualStyleBackColor = true;
            // 
            // NewEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(232, 168);
            Controls.Add(button_Cancel);
            Controls.Add(button_OK);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_EmployeeSurname);
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
    }
}