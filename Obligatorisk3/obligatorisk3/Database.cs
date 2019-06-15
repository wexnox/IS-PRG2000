using System.Configuration;
using MySql.Data.MySqlClient;

namespace obligatorisk3
{
    public class Database
    {
        public MySqlConnection Conn;
        public MySqlDataReader Dreader;
        public string CS = ConfigurationManager.ConnectionStrings["trafikkskoleConnectionString"].ConnectionString;

        public Database()
        {
            Conn = new MySqlConnection(CS);
            Conn.Open();
        }
        // Bruker registrering
        public void RegisterUser(string username, string password)
        {
            string stmt = "INSERT INTO bruker (brukernavn, passord) VALUES ('@username','@password')";
            MySqlCommand cmd = new MySqlCommand(stmt, Conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            Dreader = cmd.ExecuteReader();
            Conn.Close();
        }

        // bruker validering
        public void ValidateUser(string username, string password)
        {
            string stmt = "SELECT * FROM bruker WHERE brukernavn = '@username' AND passord = '@password'";
            MySqlCommand cmd = new MySqlCommand(stmt, Conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            Dreader = cmd.ExecuteReader();

        }

    }
}