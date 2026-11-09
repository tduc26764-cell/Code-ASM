using System.Data.SqlClient;

namespace code_ko_keo_tha
{
    public static class DatabaseConnection
    {
        private static string connectionString =
            @"Data Source=localhost;
              Initial Catalog=PhoneShopDB_EN;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}