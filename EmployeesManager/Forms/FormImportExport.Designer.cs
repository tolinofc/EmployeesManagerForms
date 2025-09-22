namespace EmployeesManager.Forms
{
    partial class FormImportExport
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
            label3 = new Label();
            buttonImport = new Button();
            buttonExport = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(26, 19);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 15;
            label3.Text = "Chcete data...";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonImport
            // 
            buttonImport.Cursor = Cursors.No;
            buttonImport.Enabled = false;
            buttonImport.Location = new Point(12, 60);
            buttonImport.Name = "buttonImport";
            buttonImport.Size = new Size(156, 23);
            buttonImport.TabIndex = 0;
            buttonImport.Text = "Importovat ze souboru";
            buttonImport.UseVisualStyleBackColor = true;
            buttonImport.Click += buttonImport_Click;
            // 
            // buttonExport
            // 
            buttonExport.Location = new Point(12, 89);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(156, 23);
            buttonExport.TabIndex = 1;
            buttonExport.Text = "Exportovat do souboru";
            buttonExport.UseVisualStyleBackColor = true;
            buttonExport.Click += buttonExport_Click;
            // 
            // FormImportExport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(182, 135);
            Controls.Add(buttonExport);
            Controls.Add(buttonImport);
            Controls.Add(label3);
            MaximumSize = new Size(198, 174);
            MinimumSize = new Size(198, 174);
            Name = "FormImportExport";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Import/Export";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button buttonImport;
        private Button buttonExport;
    }
}