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
    public partial class SearchBookForm : Form
    {
        readonly SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NQF55SP;Initial Catalog=bookBizDB;Integrated Security=True");

        public SearchBookForm()
        {
            InitializeComponent();
        }


        private void SearchBookForm_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ISBN FROM book", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ISBN", typeof(string));
            dt.Load(rdr);
            comboBoxISBN.ValueMember = "ISBN";
            comboBoxISBN.DisplayMember = "ISBN";
            comboBoxISBN.DataSource = dt;
        }


        //select ISBN
        private void comboBoxISBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectItem = comboBoxISBN.Text;
            //SqlCommand cmd1 = new SqlCommand("SELECT * FROM book WHERE ISBN='" + curItem + "'", con);
            SqlCommand cmd = new SqlCommand("SELECT book.ISBN,bookTitle,unitPrice,category,publisherName,firstName as 'Author First Name',lastName as 'Author Last Name' FROM book INNER JOIN writtenBy ON book.ISBN = writtenBy.ISBN INNER JOIN author ON author.authorID = writtenBy.authorID AND book.ISBN='" + selectItem + "'", con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewBook.DataSource = dt;
            con.Close();
        }

        //Back button
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
