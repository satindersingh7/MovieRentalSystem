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
    public partial class EditMovie : Form
    {
        string MovieId;
        public EditMovie()
        {
            InitializeComponent();
        }

        public EditMovie(string Id)
        {
            MovieId = Id;
            InitializeComponent();
            DataTable table = new Database().GetMovie(MovieId);
            Rating.Text = table.Rows[0]["Rating"].ToString();
            Title.Text = table.Rows[0]["Title"].ToString();
            Year.Text = table.Rows[0]["Year"].ToString();
            Copies.Text = table.Rows[0]["Copies"].ToString();
            Plot.Text = table.Rows[0]["Plot"].ToString();
            Genre.Text = table.Rows[0]["Genre"].ToString();
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
                database.UpdateMovie(Rating.Text, Title.Text, Year.Text, Rental.ToString(), Copies.Text, Plot.Text, Genre.Text, MovieId);
                MessageBox.Show("Movie Updated");
                Dispose();
            }
        }
    }
}
