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
    public partial class SalesManagerForm : Form
    {
        public SalesManagerForm()
        {
            InitializeComponent();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();
            addClientForm.Show();
        }

        private void buttonSearchClient_Click(object sender, EventArgs e)
        {
            SearchClientForm searchClientForm = new SearchClientForm();
            searchClientForm.Show();
        }

        private void buttonListClients_Click(object sender, EventArgs e)
        {
            ListClientForm listClientForm = new ListClientForm();
            listClientForm.Show();
        }

        private void buttonSalesManagerLogout_Click(object sender, EventArgs e)
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
