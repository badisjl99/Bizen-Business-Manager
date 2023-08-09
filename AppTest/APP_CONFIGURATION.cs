using MySql.Data.MySqlClient;

namespace AppTest
{
    public class APP_CONFIGURATION
    {
        //    -------     Connection Parameters    -------

        public static string DB_NAME = "app_db";
        public static string SERVER = "localhost";
        public static string USERNAME = "root";
        public static string PASSWORD = "";
        public static MySqlConnection connection;

        //    -------    Admins Table and Attributs    -------
        public static string ADMIN_TABLE = "admin_tables";
        public static string ADMIN_ID_ATTRIBUT = "id";
        public static string ADMIN_PASSWORD_ATTRIBUT = "password";






        public static MySqlConnection ESTABLISH_DB_CONNECTION()
        {
            string connectionString = $"server={SERVER};user={USERNAME};password={PASSWORD};database={DB_NAME};";
            connection = new MySqlConnection(connectionString);

            connection.Open();

            return connection;
        }
    }

}
