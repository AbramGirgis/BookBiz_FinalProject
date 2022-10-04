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
    public partial class SearchOrderForm : Form
    {
        readonly SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NQF55SP;Initial Catalog=bookBizDB;Integrated Security=True");

        public SearchOrderForm()
        {
            InitializeComponent();
        }

        private void SearchOrderForm_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT orderID FROM orders", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("orderID", typeof(string));
            dt.Load(rdr);
            comboBoxOrderID.ValueMember = "orderID";
            comboBoxOrderID.DisplayMember = "orderID";
            comboBoxOrderID.DataSource = dt;
        }

        private void comboBoxOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectItem = comboBoxOrderID.Text;
            SqlCommand cmd = new SqlCommand("SELECT orders.orderID,orders.clientID,orders.employeeID,orderDetails.ISBN,orderDetails.quantity,orderDetails.unitPrice FROM orderDetails INNER JOIN orders ON orderDetails.orderID = orders.orderID AND orderDetails.orderID='" + Convert.ToInt32(selectItem) + "'", con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewOrderDetails.DataSource = dt;
            //con.Close();
        }

        //Back button
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
