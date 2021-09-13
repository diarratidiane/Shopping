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
    public partial class HomeCust : Form
    {
        public HomeCust()
        {
            InitializeComponent();
        }

        private void PurchaseProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase obj = new ElectronicShoppingManagementSystemCSharp.Purchase();
            obj.ShowDialog();
        }

        private void ViewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewProduct obj = new ViewProduct();
            obj.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.ShowDialog();
        }
    }
}
