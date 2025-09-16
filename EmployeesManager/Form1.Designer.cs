namespace EmployeesManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox_Username = new TextBox();
            label1 = new Label();
            textBox_Password = new TextBox();
            label2 = new Label();
            button_Login = new Button();
            label3 = new Label();
            checkLogin = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)checkLogin).BeginInit();
            SuspendLayout();
            // 
            // textBox_Username
            // 
            textBox_Username.Location = new Point(120, 53);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(160, 23);
            textBox_Username.TabIndex = 0;
            textBox_Username.Validating += ValidateTextbox;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 1;
            label1.Text = "Uživatelské jméno";
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(120, 91);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.PasswordChar = '*';
            textBox_Password.Size = new Size(160, 23);
            textBox_Password.TabIndex = 2;
            textBox_Password.Validating += ValidateTextbox;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 94);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 3;
            label2.Text = "Heslo";
            // 
            // button_Login
            // 
            button_Login.Location = new Point(204, 132);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(75, 23);
            button_Login.TabIndex = 4;
            button_Login.Text = "Přihlásit se";
            button_Login.UseVisualStyleBackColor = true;
            button_Login.Click += button_Login_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(58, 9);
            label3.Name = "label3";
            label3.Size = new Size(190, 28);
            label3.TabIndex = 5;
            label3.Text = "Správa zaměstnanců";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkLogin
            // 
            checkLogin.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            checkLogin.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(315, 165);
            Controls.Add(label3);
            Controls.Add(button_Login);
            Controls.Add(label2);
            Controls.Add(textBox_Password);
            Controls.Add(label1);
            Controls.Add(textBox_Username);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)checkLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Username;
        private Label label1;
        private TextBox textBox_Password;
        private Label label2;
        private Button button_Login;
        private Label label3;
        private ErrorProvider checkLogin;
    }
}
