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
    public partial class AddEmployeeForm : Form
    {
        readonly SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NQF55SP;Initial Catalog=bookBizDB;Integrated Security=True");

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        //Reset button
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
        }

        //Add Employee to DB, button
        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text.Trim();
            string lastName = textBoxLastName.Text.Trim();

            if (!Validator.AlphapetIsValid(textBoxFirstName, 2, 50)) 
            { MessageBox.Show("First Name is invalid. Please enter a valid name (No numbers & Min. 2 letters)", "Invalid First Name", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxFirstName.Focus(); }
            else if (!Validator.AlphapetIsValid(textBoxLastName, 2, 50)) 
            { MessageBox.Show("Last Name is invalid. Please enter a valid name (No numbers & Min. 2 letters)", "Invalid Last Name", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxLastName.Focus(); }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO employee (role,firstName,lastName) VALUES ('employee','" + firstName + "','" + lastName + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Employee has been added successfully to DB", "Added Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                textBoxFirstName.Clear();
                textBoxLastName.Clear();
            }
        }

        //Back button
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
