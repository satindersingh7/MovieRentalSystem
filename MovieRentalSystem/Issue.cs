using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRentalSystem
{
    public partial class Issue : Form
    {
        private string Id;

        public Issue()
        {
            InitializeComponent();
        }

        public Issue(string Id)
        {
            this.Id = Id;
            InitializeComponent();
            MovieID.Text = Id;
        }

        private void Issue_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FirstName.Text == "")
            {
                MessageBox.Show("Enter valid Customer ID");
            }
            else
            {
                string Date = DateTime.Now.ToString("MM/dd/yyyy") + " " + DateTime.Now.ToShortTimeString();
                Database database = new Database();
                database.InsertRental(Id,CustID.Text,Date);

                MessageBox.Show("Movie Rented");
                Dispose();
            }
        }

        private void CustID_TextChanged(object sender, EventArgs e)
        {
            FirstName.Text = "";
            LastName.Text = "";
            Address.Text = "";
            Phone.Text = "";

            DataTable table = new Database().GetCustomer(CustID.Text);

            if(table.Rows.Count > 0)
            {
                FirstName.Text = table.Rows[0]["FirstName"].ToString();
                LastName.Text = table.Rows[0]["LastName"].ToString();
                Address.Text = table.Rows[0]["Address"].ToString();
                Phone.Text = table.Rows[0]["Phone"].ToString();
            }
        }
    }
}
