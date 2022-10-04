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

namespace BookBizManagementSystem
{
    public partial class Form1 : Form
    {
        readonly SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NQF55SP;Initial Catalog=bookBizDB;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        //Cancel button
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxUsername.Focus();
        }

        //Exit button
        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure to exit the application?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Sign in
        private void buttonSignin_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string role = comboBoxRole.GetItemText(comboBoxRole.SelectedItem.ToString());
                string querry = "";
                if (role == "MIS Manager")
                { querry = "SELECT username,password,role FROM employee  WHERE username = '" + textBoxUsername.Text + "' AND password = '" + textBoxPassword.Text + "' AND role = '" + role + "' AND role='MIS Manager'"; }
                else if (role == "Sales Manager")
                { querry = "SELECT username,password,role FROM employee  WHERE username = '" + textBoxUsername.Text + "' AND password = '" + textBoxPassword.Text + "' AND role = '" + role + "' AND role='Sales Manager'"; }
                else if (role == "Inventory Controller")
                { querry = "SELECT username,password,role FROM employee  WHERE username = '" + textBoxUsername.Text + "' AND password = '" + textBoxPassword.Text + "' AND role = '" + role + "' AND role='Inventory Controller'"; }
                else if (role == "Order Clerk")
                { querry = "SELECT username,password,role FROM employee  WHERE username = '" + textBoxUsername.Text + "' AND password = '" + textBoxPassword.Text + "' AND role = '" + role + "' AND role='Order Clerk'"; }

                SqlDataAdapter sda = new SqlDataAdapter(querry, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {

                    if (role == "MIS Manager")
                    {
                        this.Hide();
                        MISManagerForm mISManagerForm = new MISManagerForm();
                        mISManagerForm.Show();
                    }
                    else if (role == "Sales Manager")
                    {
                        this.Hide();
                        SalesManagerForm sISManagerForm = new SalesManagerForm();
                        sISManagerForm.Show();
                    }
                    else if (role == "Inventory Controller")
                    {
                        this.Hide();
                        InventoryControllerForm inventoryControllerForm = new InventoryControllerForm();
                        inventoryControllerForm.Show();
                    }
                    else if (role == "Order Clerk")
                    {
                        this.Hide();
                        OrderClerksForm orderClerksForm = new OrderClerksForm();
                        orderClerksForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Sign in is not successful. Username, password, or role is (are) incorrect!", "error authentication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                    textBoxUsername.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Exception thrown");
            }
            finally
            {
                con.Close();
            }
        }

    }
}
