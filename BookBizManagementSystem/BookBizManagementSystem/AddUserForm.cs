using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BookBizManagementSystem.Validation;

namespace BookBizManagementSystem
{
    public partial class AddUserForm : Form
    {
        readonly SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NQF55SP;Initial Catalog=bookBizDB;Integrated Security=True");

        public AddUserForm()
        {
            InitializeComponent();
        }

        //Reset button
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxConfirmPassword.Clear();
        }

        //Adding a User to the DB, button
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text.Trim();
            string lastName = textBoxLastName.Text.Trim();
            string userName = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text;
            //Validation
            if (!Validator.AlphapetIsValid(textBoxFirstName, 2, 50))
            { MessageBox.Show("First Name is invalid. Please enter a valid name (No numbers & Min. 2 letters)", "Invalid First Name", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxFirstName.Focus(); }
            else if (!Validator.AlphapetIsValid(textBoxLastName, 2, 50))
            { MessageBox.Show("Last Name is invalid. Please enter a valid name (No numbers & Min. 2 letters)", "Invalid Last Name", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxLastName.Focus(); }
            else if (comboBoxRole.GetItemText(comboBoxRole.SelectedItem).Length == 0) 
            { MessageBox.Show("Role is invalid. Please select a role", "Role not selected", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else if (!Validator.AlphaNumIsValid(textBoxUsername, 2, 20))
            { MessageBox.Show("Username is invalid. Please enter a valid Username (2 to 20 Alphanumeric characters)", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxLastName.Focus(); }
            else if (!Validator.AlphaNumIsValid(textBoxPassword, 4,8)) 
            { MessageBox.Show("Password is invalid. Please enter a valid Password (4 to 8 Alphanumeric characters)", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxPassword.Focus(); }
            else if (!(textBoxPassword.Text.Equals(textBoxConfirmPassword.Text))) 
            { MessageBox.Show("Confirmation password does not match", "Re-type Confirmation password", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxFirstName.Focus(); }
            else
            {
                string role = comboBoxRole.GetItemText(comboBoxRole.SelectedItem);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO employee (role,firstName,lastName,username,password) VALUES ('" + role + "','" + firstName + "','" + lastName + "','" + userName + "','" + password + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User has been added successfully to DB", "Added User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxConfirmPassword.Clear();  
        }


        //Back button
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
