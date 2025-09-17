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
    public partial class NewPosition : Form
    {
        public Position position = new Position();
        public NewPosition()
        {
            InitializeComponent();
        }

        public NewPosition(Position position) : this()
        {
            this.position = position;

            this.textBox_PositionName.Text = position.Name;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            this.position.Name = textBox_PositionName.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
