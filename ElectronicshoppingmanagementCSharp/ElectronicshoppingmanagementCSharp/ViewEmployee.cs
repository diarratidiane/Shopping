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

namespace ElectronicShoppingManagementSystemCSharp
{
    public partial class ViewEmployee : Form
    {
        public ViewEmployee()
        {
            InitializeComponent();
        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'electronicDataSet2.emp' table. You can move, or remove it, as needed.
            this.empTableAdapter.Fill(this.electronicDataSet2.emp);
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\ElectronicShoppingManagementSystemCSharp\ElectronicShoppingManagementSystemCSharp\electronic.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM emp";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\ElectronicShoppingManagementSystemCSharp\ElectronicShoppingManagementSystemCSharp\electronic.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM emp where id='" + textBox1.Text + "'";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
    }
}
