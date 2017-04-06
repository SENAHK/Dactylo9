using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
        
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
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
                this.CloseConnection();
            }
            return result;
        }

        public void InsertGame(string player, int score)
        {
            string query = String.Format("INSERT INTO parties VALUES('','{0}','{1}')", player, score);
            if (this.OpenConnection())
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.ExecuteNonQuery();

                this.CloseConnection();
            }
        }

        public DataSet  GetScores()
        {
            string query = "SELECT joueur as \"Nom\", score as \"Score\" from parties";
            DataSet ds = new DataSet();

            if (this.OpenConnection())
            {
                MySqlDataAdapter adp = new MySqlDataAdapter(query, this.connection);

                adp.Fill(ds);
                this.CloseConnection();
            }
            return ds;
        }
    }
}
