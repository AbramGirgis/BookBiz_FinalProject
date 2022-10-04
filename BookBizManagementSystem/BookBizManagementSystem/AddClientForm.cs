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
    public partial class AddClientForm : Form
    {
        readonly SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NQF55SP;Initial Catalog=bookBizDB;Integrated Security=True");

        public AddClientForm()
        {
            InitializeComponent();

            //this.FormBorderStyle = FormBorderStyle.None;
            //this.MaximizeBox = false;
        }

        //Reset button
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxClientName.Clear();
            maskedTextBoxPhoneNumber.Clear();
            maskedTextBoxFaxNumber.Clear();
            textBoxCreditLimit.Clear();
            textBoxStreetNumber.Clear();
            textBoxStreetName.Clear();
            textBoxCity.Clear();
            maskedTextBoxPostalCode.Clear();
            textBoxClientName.Focus();
        }

        //Add a new client, button
        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            //Validation
            float crdtLimit;
            if (!Validator.AlphapetIsValid(textBoxClientName,2,50)) 
            { MessageBox.Show("Client Name is invalid. Please enter a valid name (No numbers & Min. 2 letters)", "Invalid Client Name", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxClientName.Focus(); }
            else if (maskedTextBoxPhoneNumber.Text.Length != 14) 
            { MessageBox.Show("Phone Number is invalid. Please enter a valid Phone Number (Must be 10 digits)", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error); maskedTextBoxPhoneNumber.Focus(); }
            else if (maskedTextBoxFaxNumber.Text.Length != 14) 
            { MessageBox.Show("Fax Number is invalid. Please enter a valid Fax Number (Must be 10 digits)", "Invalid Fax Number", MessageBoxButtons.OK, MessageBoxIcon.Error); maskedTextBoxFaxNumber.Focus(); }
            else if (textBoxCreditLimit.Text.IndexOf(',') > 0 ||!float.TryParse(textBoxCreditLimit.Text, out crdtLimit)) 
            { MessageBox.Show("Credit Limit is invalid. Please enter a valid Credit Limit (Numbers/float)", "Invalid Credit Limit", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxCreditLimit.Focus(); }
            else if (!Validator.NumIsValid(textBoxStreetNumber,1,9)) 
            { MessageBox.Show("Street Number is invalid. Please enter a valid Street Number (Min. 1 digit)", "Invalid Street Number", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxStreetNumber.Focus(); }
            else if (!Validator.AlphaNumIsValid(textBoxStreetName,2,50)) 
            { MessageBox.Show("Street Name is invalid. Please enter a valid Street Name (Min. 2 alphanumerical characters)", "Invalid Street Name", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxStreetName.Focus(); }
            else if (!Validator.AlphapetIsValid(textBoxCity,2,50)) 
            { MessageBox.Show("City is invalid. Please enter a valid City (No numbers & Min. 2 letters)", "Invalid City", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxCity.Focus(); }
            else if (maskedTextBoxPostalCode.Text.Length != 7) 
            { MessageBox.Show("Postal Code is invalid. Please enter a valid Postal Code (eg. A8B 3C4)", "Invalid Postal Code", MessageBoxButtons.OK, MessageBoxIcon.Error); maskedTextBoxPostalCode.Focus(); }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO client (clientName,streetNumber,streetName,city,postalCode,phoneNumber,faxNumber,creditLimit) VALUES ('" + textBoxClientName.Text.Trim() + "','" + Convert.ToInt32(textBoxStreetNumber.Text.Trim()) + "','" + textBoxStreetName.Text.Trim() + "','" + textBoxCity.Text.Trim() + "','" + maskedTextBoxPostalCode.Text.Trim() + "','" + maskedTextBoxPhoneNumber.Text + "','" + maskedTextBoxFaxNumber.Text + "','" + Convert.ToInt32(textBoxCreditLimit.Text.Trim()) + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Client has been added successfully to DB", "Added Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Back button
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
