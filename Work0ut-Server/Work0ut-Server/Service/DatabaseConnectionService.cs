using System.Data.SqlClient;

namespace Work0ut.Service
{
    public class DatabaseConnectionService
    {
        const string _connectionString = "localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;";

        public DatabaseConnectionService()
        {
            string connetionString;
            SqlConnection cnn;

            connetionString = @"Data Source=WIN-50GP30FGO75;Initial Catalog=Demodb ;User ID=sa;Password=demol23";

            cnn = new SqlConnection(connetionString);

            cnn.Open();

            Response.Write("Connection MAde");
            conn.Close();
        }

    }
}
