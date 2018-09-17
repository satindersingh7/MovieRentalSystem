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
    public partial class EditCustomer : Form
    {
        string Id;

        public EditCustomer()
        {
            InitializeComponent();
        }

        public EditCustomer(string Id)
        {
            this.Id = Id;
            DataTable table = new Database().GetCustomer(Id);
            InitializeComponent();
            FName.Text = table.Rows[0]["FirstName"].ToString();
            LName.Text = table.Rows[0]["LastName"].ToString();
            Address.Text = table.Rows[0]["Address"].ToString();
            PhoneNo.Text = table.Rows[0]["Phone"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FName.Text == "" || LName.Text == "" || Address.Text == "" || PhoneNo.Text == "")
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                Database database = new Database();
                database.UpdateCustomer(FName.Text, LName.Text, Address.Text, PhoneNo.Text, Id);
                MessageBox.Show("Customer Updated");
                Dispose();
            }
        }
    }
}
