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
    public partial class ListClientForm : Form
    {
        readonly SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NQF55SP;Initial Catalog=bookBizDB;Integrated Security=True");

        public ListClientForm()
        {
            InitializeComponent();
        }

        private void ListClientForm_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM client";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewClientList.DataSource = dt;
            con.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
