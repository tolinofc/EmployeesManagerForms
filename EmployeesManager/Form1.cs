using System.ComponentModel;

namespace EmployeesManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (!LoginCredentials.CheckLogin(textBox_Username.Text, textBox_Password.Text))
                {
                    MessageBox.Show("Zadane udaje nejsou spravne");
                }
            }
        }

        private void ValidateTextbox(object sender, CancelEventArgs e)
        {
            if (e.Cancel) return;
            TextBox textBox = sender as TextBox;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                this.checkLogin.SetError(textBox, "Pole je povinne");
            }
            else
            {
                this.checkLogin.SetError(textBox, null);
            }
        }
    }
}
