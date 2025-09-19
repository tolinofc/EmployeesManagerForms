namespace EmployeesManager
{
    partial class FormDepartment
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
            components = new System.ComponentModel.Container();
            button_Cancel = new Button();
            button_OK = new Button();
            label3 = new Label();
            label1 = new Label();
            textBox_DepartmentName = new TextBox();
            NewDepartmentValidate = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)NewDepartmentValidate).BeginInit();
            SuspendLayout();
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(152, 93);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(75, 23);
            button_Cancel.TabIndex = 19;
            button_Cancel.Text = "Zrušit";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // button_OK
            // 
            button_OK.Location = new Point(71, 93);
            button_OK.Name = "button_OK";
            button_OK.Size = new Size(75, 23);
            button_OK.TabIndex = 18;
            button_OK.Text = "Uložit";
            button_OK.UseVisualStyleBackColor = true;
            button_OK.Click += button_OK_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(76, 9);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 14;
            label3.Text = "Oddělení";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 57);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 12;
            label1.Text = "Název*";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox_DepartmentName
            // 
            textBox_DepartmentName.Location = new Point(76, 54);
            textBox_DepartmentName.Name = "textBox_DepartmentName";
            textBox_DepartmentName.Size = new Size(145, 23);
            textBox_DepartmentName.TabIndex = 7;
            textBox_DepartmentName.Validating += ValidateTextbox;
            // 
            // NewDepartmentValidate
            // 
            NewDepartmentValidate.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            NewDepartmentValidate.ContainerControl = this;
            // 
            // FormDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(239, 125);
            Controls.Add(button_Cancel);
            Controls.Add(button_OK);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox_DepartmentName);
            KeyPreview = true;
            MaximumSize = new Size(255, 164);
            MinimumSize = new Size(255, 164);
            Name = "FormDepartment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Oddělení";
            ((System.ComponentModel.ISupportInitialize)NewDepartmentValidate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Cancel;
        private Button button_OK;
        private Label label3;
        private Label label1;
        private TextBox textBox_DepartmentName;
        private ErrorProvider NewDepartmentValidate;
    }
}