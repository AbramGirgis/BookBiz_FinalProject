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
    public partial class SearchClientForm : Form
    {
        readonly SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NQF55SP;Initial Catalog=bookBizDB;Integrated Security=True");

        public SearchClientForm()
        {
            InitializeComponent();
        }

        private void SearchClientForm_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT clientID FROM client", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("clientID", typeof(string));
            dt.Load(rdr);
            comboBoxClientList.ValueMember = "clientID";
            comboBoxClientList.DisplayMember = "clientID";
            comboBoxClientList.DataSource = dt;
        }

        private void comboBoxClientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectItem = comboBoxClientList.Text;
            SqlCommand cmd = new SqlCommand("Select * from client where clientID='" + Convert.ToInt32(selectItem) + "'", con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewClient.DataSource = dt;
            con.Close();
        }

        //Back button
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
