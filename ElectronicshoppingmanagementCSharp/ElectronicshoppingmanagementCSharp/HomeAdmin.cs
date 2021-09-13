using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicShoppingManagementSystemCSharp
{
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product obj = new ElectronicShoppingManagementSystemCSharp.Product();
            obj.ShowDialog();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee obj = new ElectronicShoppingManagementSystemCSharp.Employee();
            obj.ShowDialog();
        }

        private void viewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCustomer obj = new ViewCustomer();
            obj.ShowDialog();
        }

        private void searchEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEmployee obj = new ElectronicShoppingManagementSystemCSharp.ViewEmployee();
            obj.ShowDialog();
        }

        private void viewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewProduct obj = new ViewProduct();
            obj.ShowDialog();
        }

        private void showPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewElectronicPurchaseData obj = new ViewElectronicPurchaseData();
            obj.ShowDialog();                
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new ElectronicShoppingManagementSystemCSharp.Form1();
            obj.ShowDialog();
        }
    }
}
