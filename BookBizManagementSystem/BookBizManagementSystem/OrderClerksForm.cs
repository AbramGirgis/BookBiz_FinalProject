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
    public partial class OrderClerksForm : Form
    {
        public OrderClerksForm()
        {
            InitializeComponent();
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            AddOrderForm addOrderForm = new AddOrderForm();
            addOrderForm.Show();
        }

        private void buttonSearchOrder_Click(object sender, EventArgs e)
        {
            SearchOrderForm searchOrderForm = new SearchOrderForm();
            searchOrderForm.Show();
        }

        private void buttonListOrders_Click(object sender, EventArgs e)
        {
            ListOrderForm listOrderForm = new ListOrderForm();
            listOrderForm.Show();
        }

        private void buttonCancelOrder_Click(object sender, EventArgs e)
        {
            CancelOrderForm cancelOrderForm = new CancelOrderForm();
            cancelOrderForm.Show();
        }

        private void buttonClerkLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

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
