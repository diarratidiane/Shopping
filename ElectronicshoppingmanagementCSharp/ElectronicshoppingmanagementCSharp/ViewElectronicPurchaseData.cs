﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ElectronicShoppingManagementSystemCSharp
{
    public partial class ViewElectronicPurchaseData : Form
    {
        public ViewElectronicPurchaseData()
        {
            InitializeComponent();
        }

        private void ViewElectronicPurchaseData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'electronicDataSet1.purchase' table. You can move, or remove it, as needed.
            this.purchaseTableAdapter.Fill(this.electronicDataSet1.purchase);
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\ElectronicShoppingManagementSystemCSharp\ElectronicShoppingManagementSystemCSharp\electronic.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM purchase";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
    }
}
