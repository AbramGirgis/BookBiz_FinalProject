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
    public partial class SearchUserForm : Form
    {
        readonly SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NQF55SP;Initial Catalog=bookBizDB;Integrated Security=True");

        public SearchUserForm()
        {
            InitializeComponent();
        }

        private void SearchUserForm_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT employeeID FROM employee WHERE role != 'employee'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("employeeID", typeof(string));
            dt.Load(rdr);
            comboBoxUserList.ValueMember = "employeeID";
            comboBoxUserList.DisplayMember = "employeeID";
            comboBoxUserList.DataSource = dt;
        }

        private void comboBoxUserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectItem = comboBoxUserList.Text;
            SqlCommand cmd = new SqlCommand("Select * from employee where role != 'employee' AND employeeID='" + selectItem + "'", con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewUser.DataSource = dt;
            con.Close();
        }

        //Back button
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
