using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Data
{
    public class GameHistoryService
    {
        private readonly SQLiteContext _context;

        public GameHistoryService()
        {
            _context = new SQLiteContext();
        }

        public void SaveRecord(GameRecord record)
        {
            using var connection = _context.GetConnection();
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText =
                @"INSERT INTO GameRecords (PlayerXName, PlayerOName, Winner, DatePlayed, Moves)
                  VALUES ($x, $o, $w, $d, $m);";
            command.Parameters.AddWithValue("$x", record.PlayerXName);
            command.Parameters.AddWithValue("$o", record.PlayerOName);
            command.Parameters.AddWithValue("$w", record.Winner);
            command.Parameters.AddWithValue("$d", record.DatePlayed.ToString("s"));
            command.Parameters.AddWithValue("$m", record.Moves);
            command.ExecuteNonQuery();
        }

        public List<GameRecord> LoadHistory()
        {
            var records = new List<GameRecord>();
            using var connection = _context.GetConnection();
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM GameRecords ORDER BY DatePlayed DESC;";

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                records.Add(new GameRecord
                {
                    Id = reader.GetInt32(0),
                    PlayerXName = reader.GetString(1),
                    PlayerOName = reader.GetString(2),
                    Winner = reader.GetString(3),
                    DatePlayed = DateTime.Parse(reader.GetString(4)),
                    Moves = reader.GetString(5)
                });
            }
            return records;
        }
    }
}
