using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagementSystem;
//using MySqlConnector;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;

namespace GymManagementSystem
{
    public class DBConnect
    {
        private readonly ILogger<DBConnect> _logger;
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DBConnect(ILogger<DBConnect> logger)
        {
            _logger = logger;
            Initialize();
        }

        private void Initialize()
        {
            server = "127.0.0.1";
            database = "project";
            uid = "root";
            password = "password";
            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                _logger.LogInformation("Database connection opened successfully.");
                return true;
            }
            catch (MySqlException ex)
            {
                _logger.LogError($"Error opening database connection: {ex.Message}");
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                _logger.LogInformation("Database connection closed.");
                return true;
            }
            catch (MySqlException ex)
            {
                _logger.LogError($"Error closing database connection: {ex.Message}");
                return false;
            }
        }
    }
}