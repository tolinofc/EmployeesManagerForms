namespace EmployeesManager.Forms
{
    partial class FormStats
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
            textBoxStats = new TextBox();
            SuspendLayout();
            // 
            // textBoxStats
            // 
            textBoxStats.Dock = DockStyle.Fill;
            textBoxStats.Location = new Point(0, 0);
            textBoxStats.Multiline = true;
            textBoxStats.Name = "textBoxStats";
            textBoxStats.ReadOnly = true;
            textBoxStats.ScrollBars = ScrollBars.Vertical;
            textBoxStats.Size = new Size(437, 349);
            textBoxStats.TabIndex = 0;
            // 
            // FormStats
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 349);
            Controls.Add(textBoxStats);
            MinimumSize = new Size(25, 25);
            Name = "FormStats";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Statistiky";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxStats;
    }
}