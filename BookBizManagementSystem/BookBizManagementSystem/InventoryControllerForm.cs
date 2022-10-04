using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBizManagementSystem
{
    public partial class InventoryControllerForm : Form
    {
        public InventoryControllerForm()
        {
            InitializeComponent();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.Show();
        }

        private void buttonSearchBook_Click(object sender, EventArgs e)
        {
            SearchBookForm searchBookForm = new SearchBookForm();
            searchBookForm.Show();
        }

        private void buttonListBooks_Click(object sender, EventArgs e)
        {
            ListBookForm listBookForm = new ListBookForm();
            listBookForm.Show();
        }

        private void buttonInventoryControllerLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
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
    }
}
