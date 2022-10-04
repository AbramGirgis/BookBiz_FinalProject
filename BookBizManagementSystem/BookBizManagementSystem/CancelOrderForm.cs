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
    public partial class CancelOrderForm : Form
    {
        readonly SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NQF55SP;Initial Catalog=bookBizDB;Integrated Security=True");

        public CancelOrderForm()
        {
            InitializeComponent();
        }

        //load with the form
        private void CancelOrderForm_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT orders.orderID,orders.employeeID,orders.clientID, concat(employee.firstName, employee.lastName) AS 'Employee Full Name',clientName as 'Client Name' FROM employee INNER JOIN orders ON orders.employeeID = employee.employeeID INNER JOIN client ON orders.clientID = client.clientID";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewCancelOrder.DataSource = dt;
            SqlCommand cmd1 = new SqlCommand("SELECT orderID FROM orders", con);
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("orderID", typeof(string));
            dt1.Load(rdr1);
            comboBoxOrdersList.ValueMember = "orderID";
            comboBoxOrdersList.DisplayMember = "orderID";
            comboBoxOrdersList.DataSource = dt1;
            con.Close();
        }

        //Delete Order button
        private void buttonCancelOrder_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM orders WHERE orderID ='" + comboBoxOrdersList.GetItemText(comboBoxOrdersList.SelectedItem) + "'";
            int rowsaffected = cmd.ExecuteNonQuery();
            if (rowsaffected > 0) 
            { MessageBox.Show("Order is Cancelled/removed successfully", "Cancel order", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            con.Close();
            CancelOrderForm_Load(sender, e);
        }

        //Back button
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
