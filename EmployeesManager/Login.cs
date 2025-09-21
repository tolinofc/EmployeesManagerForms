using System.ComponentModel;

namespace EmployeesManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (!LoginCredentials.CheckLogin(textBox_Username.Text, textBox_Password.Text))
                {
                    MessageBox.Show("Zadane udaje nejsou spravne", "Neplatné údaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Visible = false;

                    EmployeeList employeeList = new EmployeeList();
                    employeeList.ShowDialog();

                    this.Close();
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
