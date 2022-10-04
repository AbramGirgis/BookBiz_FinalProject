using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBizManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Application.Run(new AddClientForm()); //done
            //Application.Run(new AddUserForm()); //done
            //Application.Run(new AddEmployeeForm());//done
            //Application.Run(new AddBookForm()); //done
            //Application.Run(new AddOrderForm()); //done
            //Application.Run(new MISManagerForm());
            //Application.Run(new SalesManagerForm());
            //Application.Run(new InventoryControllerForm());
            //Application.Run(new OrderClerksForm());
            //Application.Run(new CancelOrderForm());

        }
    }
}
