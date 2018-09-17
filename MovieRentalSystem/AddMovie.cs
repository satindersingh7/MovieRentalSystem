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
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ValYear, ValCopies;

            if (Rating.Text == "" || Title.Text == "" || Year.Text == "" || Copies.Text == "" || Plot.Text == "" || Genre.Text == "")
            {
                MessageBox.Show("All fields are required");
            }
            else if (!int.TryParse(Year.Text, out ValYear) || !(int.TryParse(Copies.Text, out ValCopies)))
            {
                MessageBox.Show("Year and Copies must be a valid integer");
            }
            else
            {
                int Rental = 0;
                if ((DateTime.Now.Year - ValYear) > 5)
                {
                    Rental = 2;
                }
                else
                {
                    Rental = 5;
                }

                Database database = new Database();
                database.InsertMovie(Rating.Text, Title.Text, Year.Text, Rental.ToString(), Copies.Text, Plot.Text, Genre.Text);

                MessageBox.Show("Movie Added");
            }
        }
    }
}
