using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace MovieRentalSystem
{
    public class Database
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private string ConnectionString;

        public Database()
        {
            string DbFile = "Database.mdf";
            string DbPath = new Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath;
            for (int i = 0; i < 4; i++)
            {
                DbPath = Path.GetDirectoryName(DbPath);
            }
            DbPath = Path.Combine(DbPath, DbFile);
            if (File.Exists(DbPath))
            {
                ConnectionString = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0};Integrated Security=True", DbPath);
            }
            else
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            }
            connection = new SqlConnection(ConnectionString);
        }

        public bool CheckConnection()
        {
            bool Result = false;
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            Result = true;
            connection.Close();
            return Result;
        }

        public void InsertCustomer(string FirstName, string LastName, string Address, string Phone)
        {
            string Query = "INSERT INTO [Customer] VALUES (@FirstName, @LastName, @Address, @Phone)";
            command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateCustomer(string FirstName, string LastName, string Address, string Phone, string CustID)
        {
            string Query = "UPDATE [Customer] SET [FirstName] = @FirstName, [LastName] = @LastName, [Address] = @Address, [Phone] = @Phone WHERE [CustID] = @CustID";
            command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@CustID", CustID);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteCustomer(string CustID)
        {
            string Query = "DELETE FROM [Customer] WHERE [CustID] = @CustID";
            command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CustID", CustID);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable GetCustomers()
        {
            string Query = "SELECT * FROM [Customer]";
            command = new SqlCommand(Query, connection);
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        public DataTable GetCustomer(string CustID)
        {
            string Query = "SELECT * FROM [Customer] WHERE [CustID] = @CustID";
            command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CustID", CustID);
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        public DataTable GetTopCustomers()
        {
            string Query = "SELECT *, ISNULL((SELECT COUNT(RMID) FROM RentedMovies WHERE CustIDFK = CustID), 0) AS RentedMovies FROM Customer ORDER BY RentedMovies DESC";
            command = new SqlCommand(Query, connection);
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        public void InsertMovie(string Rating, string Title, string Year, string Rental_Cost, string Copies, string Plot, string Genre)
        {
            string Query = "INSERT INTO [Movies] VALUES (@Rating, @Title, @Year, @Rental_Cost, @Copies, @Plot, @Genre)";
            command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Rating", Rating);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Year", Year);
            command.Parameters.AddWithValue("@Rental_Cost", Rental_Cost);
            command.Parameters.AddWithValue("@Copies", Copies);
            command.Parameters.AddWithValue("@Plot", Plot);
            command.Parameters.AddWithValue("@Genre", Genre);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateMovie(string Rating, string Title, string Year, string Rental_Cost, string Copies, string Plot, string Genre, string MovieID)
        {
            string Query = "UPDATE [Movies] SET [Rating] = @Rating, [Title] = @Title, [Year] = @Year, [Rental_Cost] = @Rental_Cost, [Copies] = @Copies, [Plot] =  @Plot, [Genre] = @Genre WHERE [MovieID] = @MovieID";
            command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Rating", Rating);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Year", Year);
            command.Parameters.AddWithValue("@Rental_Cost", Rental_Cost);
            command.Parameters.AddWithValue("@Copies", Copies);
            command.Parameters.AddWithValue("@Plot", Plot);
            command.Parameters.AddWithValue("@Genre", Genre);
            command.Parameters.AddWithValue("@MovieID", MovieID);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteMovie(string MovieID)
        {
            string Query = "DELETE FROM [Movies] WHERE [MovieID] = @MovieID";
            command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@MovieID", MovieID);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable GetMovies()
        {
            string Query = "SELECT * FROM [Movies]";
            command = new SqlCommand(Query, connection);
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        public DataTable GetMovie(string MovieId)
        {
            string Query = "SELECT * FROM [Movies] WHERE [MovieID] = @MovieID";
            command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@MovieID", MovieId);
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        public DataTable GetTopMovies()
        {
            string Query = "SELECT *, ISNULL((SELECT COUNT (RMID) FROM RentedMovies WHERE MovieIDFK = MovieID), 0) AS TimesRented FROM Movies ORDER BY TimesRented DESC";
            command = new SqlCommand(Query, connection);
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        public void InsertRental(string MovieID, string CustID, string DateRented)
        {
            string Query = "INSERT INTO [RentedMovies] (MovieIDFK, CustIDFK, DateRented) VALUES (@MovieIDFK, @CustIDFK, @DateRented)";
            command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@MovieIDFK", MovieID);
            command.Parameters.AddWithValue("@CustIDFK", CustID);
            command.Parameters.AddWithValue("@DateRented", DateRented);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateRental(string DateReturned, string RMID)
        {
            string Query = "UPDATE [RentedMovies] SET [DateReturned] = @DateReturned WHERE [RMID] = @RMID";
            command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@DateReturned", DateReturned);
            command.Parameters.AddWithValue("@RMID", RMID);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public int CheckAvaliableCopies(int MovieID)
        {
            string Query = "SELECT (SELECT Copies FROM Movies WHERE MovieID = @MovieID) - (SELECT ISNULL(COUNT(MovieIDFK), 0) FROM RentedMovies WHERE MovieIDFK = @MovieID AND DateReturned IS NULL)";
            command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@MovieID", MovieID);
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return Convert.ToInt32(table.Rows[0][0]);
        }

        public DataTable GetPendingRentals()
        {
            string Query = "SELECT RMID, Customer.FirstName, Customer.LastName, Customer.[Address], Movies.Title, Movies.Rental_Cost, RentedMovies.DateRented, RentedMovies.DateReturned FROM RentedMovies INNER JOIN Movies ON RentedMovies.MovieIDFK = Movies.MovieID INNER JOIN Customer ON RentedMovies.CustIDFK = Customer.CustID WHERE RentedMovies.DateReturned IS NULL";
            command = new SqlCommand(Query, connection);
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
    }
}
