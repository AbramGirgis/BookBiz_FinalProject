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
    public partial class AddOrderForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NQF55SP;Initial Catalog=bookBizDB;Integrated Security=True");

        public AddOrderForm()
        {
            InitializeComponent();

            //Hide until the order is placed
            comboBoxISBN.Visible = false;
            labelISBN.Visible = false;
            labelQty.Visible = false;
            textBoxQuantity.Visible = false;
            groupBoxAddToOrder.Visible = false;
            buttonAddToOrder.Visible = false;
            labelOrderDetails.Visible = false;
            dataGridViewOrderDetails.Visible = false;
            labelOrderTotal.Visible = false;
            labelTotal.Visible = false;
        }
        

        //Place an Order, button
        private void buttonPlaceOrder_Click(object sender, EventArgs e)
        {
            
            comboBoxISBN.Visible = true;
            labelISBN.Visible = true;
            labelQty.Visible = true;
            textBoxQuantity.Visible = true;
            groupBoxAddToOrder.Visible = true;
            buttonAddToOrder.Visible = true;

            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT ISBN FROM book", con);
            SqlDataReader rdr2 = cmd2.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ISBN", typeof(string));
            dt2.Load(rdr2);
            comboBoxISBN.ValueMember = "ISBN";
            comboBoxISBN.DisplayMember = "ISBN";
            comboBoxISBN.DataSource = dt2;
            
            if (comboBoxEmployeeID.GetItemText(comboBoxEmployeeID.SelectedItem).Length == 0)
            {
                MessageBox.Show("Clerk ID is invalid. Please select your clerk ID", "Invalid Clerk ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxClientID.GetItemText(comboBoxClientID.SelectedItem).Length == 0)
            {
                MessageBox.Show("Client ID is invalid. Please select a client ID", "Invalid Client ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO orders (employeeID,clientID) VALUES ('" + comboBoxEmployeeID.GetItemText(comboBoxEmployeeID.SelectedItem) + "','" + comboBoxClientID.GetItemText(comboBoxClientID.SelectedItem) + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                buttonPlaceOrder.Visible = false;
            }
        }


        //Load with the form
        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            //Load employee (order clerk)
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT employeeID as'employee ID' FROM employee WHERE role ='Order Clerk'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("EmployeeID", typeof(string));
            dt.Load(rdr);
            comboBoxEmployeeID.ValueMember = "employee ID";
            comboBoxEmployeeID.DisplayMember = "employee ID";
            comboBoxEmployeeID.DataSource = dt;

            //client
            SqlCommand cmd1 = new SqlCommand("SELECT clientID as 'client ID' FROM client", con);
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("clientID", typeof(string));
            dt1.Load(rdr1);
            comboBoxClientID.ValueMember = "client ID";
            comboBoxClientID.DisplayMember = "client ID";
            comboBoxClientID.DataSource = dt1;
            con.Close();
        }


        //Add order details
        private void buttonAddToOrder_Click(object sender, EventArgs e)
        {
            int quantity=0; double creditLimit=0; int qtyTotalOrder=0;

            if (comboBoxISBN.GetItemText(comboBoxISBN.SelectedItem).Length == 0)
            {
                MessageBox.Show("ISBN is invalid. Please select an ISBN", "Invalid ISBN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Validator.NumIsValid(textBoxQuantity, 1, 5))
            {
                MessageBox.Show("Quantity is invalid. Please enter a valid Quantity (Quantity must have at least 1 digit)", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxQuantity.Focus();
            }
            else
            {
                con.Open();
                //since the number of the orders is autoincremented, the current order has the max ID order
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "SELECT MAX(orderID) from orders";
                int orderid = (int)cmd1.ExecuteScalar();
                con.Close();
                con.Open();
                //retreive the available qty
                SqlCommand cmd11 = con.CreateCommand();
                cmd11.CommandType = CommandType.Text;
                cmd11.CommandText = "SELECT cast(quantityOnHand as int) FROM book WHERE ISBN = '" + comboBoxISBN.GetItemText(comboBoxISBN.SelectedItem) + "'";
                quantity = (int)cmd11.ExecuteScalar();
                //MessageBox.Show("qtyA " + quantity);

                //check if the ordered quantity is available
                if (quantity >= Convert.ToInt32(textBoxQuantity.Text))
                {
                    int qtyOrd = Convert.ToInt32(textBoxQuantity.Text);
                    //retrieve the unit price
                    SqlCommand cmd111 = con.CreateCommand();
                    cmd111.CommandType = CommandType.Text;
                    cmd111.CommandText = "SELECT unitPrice FROM book WHERE ISBN = '" + comboBoxISBN.GetItemText(comboBoxISBN.SelectedItem) + "'";
                    double up = (double)cmd111.ExecuteScalar();
                    double total = (double)(qtyOrd * up);
                    //MessageBox.Show("" + total);
                    SqlCommand cmd22 = con.CreateCommand();
                    cmd22.CommandType = CommandType.Text;
                    cmd22.CommandText = "SELECT creditLimit FROM client WHERE clientID = '" + comboBoxClientID.GetItemText(comboBoxClientID.SelectedItem) + "' ";
                    creditLimit = (double)cmd22.ExecuteScalar();


                    if (creditLimit >= total)//if the current balance + current total< creditLimit
                    {
                        SqlCommand cmd2 = con.CreateCommand();
                        cmd2.CommandType = CommandType.Text;
                        cmd2.CommandText = "INSERT INTO orderDetails (orderID,ISBN,unitPrice,quantity) VALUES ('" + orderid + "' , '" + comboBoxISBN.GetItemText(comboBoxISBN.SelectedItem) + "','" + up + "','" + Convert.ToInt32(textBoxQuantity.Text) + "')";
                        int result = cmd2.ExecuteNonQuery();
                        if (result > 0) MessageBox.Show("The Book is successfully added to the current order", "Book is Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        double credi = creditLimit - total;
                        //MessageBox.Show("" + (creditLimit));
                        SqlCommand cmd4 = con.CreateCommand();
                        cmd4.CommandType = CommandType.Text;
                        cmd4.CommandText = "UPDATE client SET creditLimit =  '" + credi + "' WHERE clientID = '" + Convert.ToInt64(comboBoxClientID.GetItemText(comboBoxClientID.SelectedItem)) + "'";
                        cmd4.ExecuteNonQuery();
                        MessageBox.Show("The credit limit has been updated", "Credit Limit Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SqlCommand cmd5 = con.CreateCommand();

                        //MessageBox.Show("ordered qty " + qtyOrd);
                        cmd5.CommandType = CommandType.Text;
                        cmd5.CommandText = "UPDATE book SET quantityOnHand =  '" + (quantity - qtyOrd) + "' WHERE ISBN = '" + (comboBoxISBN.GetItemText(comboBoxISBN.SelectedItem)) + "'";
                        cmd5.ExecuteNonQuery();
                        MessageBox.Show("The quantity on hand of the Book has been updated", "Book Quantity Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Credit limit of this client is insufficent", "Credit Limit insufficient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("The ordred quantity exceeds the available quantity of that Book", "Quantity is not available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
                con.Open();
                SqlCommand cnd = con.CreateCommand();
                cnd.CommandType = CommandType.Text;
                cnd.CommandText = "SELECT cast(SUM (cast(unitPrice as int)*cast(quantity as int)) as int) FROM orderDetails WHERE orderID='"+orderid+"'";
                qtyTotalOrder = (int)cnd.ExecuteScalar();
                labelTotal.Text = qtyTotalOrder.ToString() + " $";
                labelOrderTotal.Visible = true;
                labelTotal.Visible = true;
                con.Close();
                dataGridViewOrderDetails.Visible = true;
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT orders.orderID,orders.clientID,orders.employeeID,orderDetails.ISBN,orderDetails.quantity,orderDetails.unitPrice FROM orderDetails INNER JOIN orders ON orderDetails.orderID = orders.orderID AND orders.orderID='" + orderid + "'", con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewOrderDetails.DataSource = dt;
                con.Close();
            }
        }


        //Back button
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}

