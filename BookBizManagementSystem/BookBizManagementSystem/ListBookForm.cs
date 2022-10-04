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
    public partial class ListBookForm : Form
    {
        readonly SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NQF55SP;Initial Catalog=bookBizDB;Integrated Security=True");

        public ListBookForm()
        {
            InitializeComponent();
        }

        private void ListBookForm_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT book.ISBN,bookTitle AS 'Title',unitPrice AS 'Unit Price',category AS 'Category',publisherName AS 'Publisher Name',firstName AS 'Author First Name',lastName AS 'Author Last Name' FROM book INNER JOIN writtenBy ON book.ISBN = writtenBy.ISBN INNER JOIN author ON author.authorID = writtenBy.authorID";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewBookList.DataSource = dt;
            con.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
