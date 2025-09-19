using EmployeesManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManager
{
    public partial class FormPosition : Form
    {
        public Position position = new Position();
        public FormPosition()
        {
            InitializeComponent();
        }

        public FormPosition(Position position) : this()
        {
            this.position = position;

            this.textBox_PositionName.Text = position.Name;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                this.position.Name = textBox_PositionName.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidateTextbox(object sender, CancelEventArgs e)
        {
            if (e.Cancel) return;
            TextBox textBox = sender as TextBox;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                this.NewPositionValidate.SetError(textBox, "Pole je povinne");
            }
            else
            {
                this.NewPositionValidate.SetError(textBox, null);
            }
        }
    }
}
