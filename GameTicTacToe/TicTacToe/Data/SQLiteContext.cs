using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Data
{
    public class SQLiteContext
    {
        private const string DatabaseFile = "game_history.db";
        private const string ConnectionString = "Data Source=" + DatabaseFile;

        public SQLiteContext()
        {
            if (!File.Exists(DatabaseFile))
                InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText =
                @"CREATE TABLE IF NOT EXISTS GameRecords (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    PlayerXName TEXT NOT NULL,
                    PlayerOName TEXT NOT NULL,
                    Winner TEXT NOT NULL,
                    DatePlayed TEXT NOT NULL,
                    Moves TEXT NOT NULL
                );";
            command.ExecuteNonQuery();
        }

        public SqliteConnection GetConnection()
        {
            return new SqliteConnection(ConnectionString);
        }
    }
}
