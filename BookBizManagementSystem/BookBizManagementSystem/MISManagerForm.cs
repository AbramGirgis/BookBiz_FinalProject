using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBizManagementSystem
{
    public partial class MISManagerForm : Form
    {
        public MISManagerForm()
        {
            InitializeComponent();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
        }

        private void buttonSearchUser_Click(object sender, EventArgs e)
        {
            SearchUserForm searchUserForm = new SearchUserForm();
            searchUserForm.Show();
        }

        private void buttonListUsers_Click(object sender, EventArgs e)
        {
            ListUserForm listUserForm = new ListUserForm();
            listUserForm.Show();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.Show();
        }

        private void buttonSearchEmployee_Click(object sender, EventArgs e)
        {
            SearchEmployeeForm searchEmployeeForm = new SearchEmployeeForm();
            searchEmployeeForm.Show();
        }

        private void buttonListEmployees_Click(object sender, EventArgs e)
        {
            ListEmployeeForm listEmployeeForm = new ListEmployeeForm();
            listEmployeeForm.Show();
        }

        private void buttonMISManagerLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure to exit the application?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
