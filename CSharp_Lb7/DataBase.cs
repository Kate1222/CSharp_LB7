using Microsoft.Data.SqlClient;

namespace CSharp_Lb7
{
    public class DataBase
    {
        private SqlConnection _sqlConnection =
            new SqlConnection(
                @"Data Source=WINVLAD345406\SQLEXPRESS;Initial Catalog=db_CSharp_LB7; TrustServerCertificate=True; Integrated Security=True");

        public void openConnection()
        {
            if(_sqlConnection.State == System.Data.ConnectionState.Closed)
                _sqlConnection.Open();
        }
        
        public void closeConnection()
        {
            if(_sqlConnection.State == System.Data.ConnectionState.Open)
                _sqlConnection.Close();
        }

        public SqlConnection getConnection()
        {
            return _sqlConnection;
        }
    }
}