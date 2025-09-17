namespace EmployeesManager
{
    partial class NewProject
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
            button_Cancel = new Button();
            button_OK = new Button();
            label3 = new Label();
            label1 = new Label();
            textBox_ProjectName = new TextBox();
            textBox_ProjectDescription = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(152, 151);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(75, 23);
            button_Cancel.TabIndex = 19;
            button_Cancel.Text = "Zrušit";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // button_OK
            // 
            button_OK.Location = new Point(71, 151);
            button_OK.Name = "button_OK";
            button_OK.Size = new Size(75, 23);
            button_OK.TabIndex = 18;
            button_OK.Text = "Přidat";
            button_OK.UseVisualStyleBackColor = true;
            button_OK.Click += button_OK_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(61, 9);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 14;
            label3.Text = "Nový projekt";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 57);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 12;
            label1.Text = "Název";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox_ProjectName
            // 
            textBox_ProjectName.Location = new Point(76, 54);
            textBox_ProjectName.Name = "textBox_ProjectName";
            textBox_ProjectName.Size = new Size(145, 23);
            textBox_ProjectName.TabIndex = 7;
            // 
            // textBox_ProjectDescription
            // 
            textBox_ProjectDescription.Location = new Point(76, 83);
            textBox_ProjectDescription.Multiline = true;
            textBox_ProjectDescription.Name = "textBox_ProjectDescription";
            textBox_ProjectDescription.Size = new Size(145, 62);
            textBox_ProjectDescription.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 86);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 12;
            label2.Text = "Popis";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NewProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 184);
            Controls.Add(button_Cancel);
            Controls.Add(button_OK);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_ProjectDescription);
            Controls.Add(textBox_ProjectName);
            Name = "NewProject";
            Text = "NewDepartment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Cancel;
        private Button button_OK;
        private Label label3;
        private Label label1;
        private TextBox textBox_ProjectName;
        private TextBox textBox_ProjectDescription;
        private Label label2;
    }
}