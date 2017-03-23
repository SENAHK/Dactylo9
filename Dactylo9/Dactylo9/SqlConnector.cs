using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dactylo9
{
    class SqlConnector
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public SqlConnector()
        {
            server = "127.0.0.1";
            database = "dactylo9";
            uid = "adminDactylo9";
            password = "Super";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                this.connection.Open();
                    return true;
            }
            catch (MySqlException e)
            {

                MessageBox.Show("Erreur : " + e.Message);
                return false;
            }
        }

        public List<string> SelectTexts()
        {
            List<string> result = new List<string>();
            string query = "SELECT contenuTexte from textes";
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, this.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(reader["contenuTexte"] + "");
                }
            }
            return result;
        }
    }
}
