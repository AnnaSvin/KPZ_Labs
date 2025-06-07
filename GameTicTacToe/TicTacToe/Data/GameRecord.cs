using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Data
{
    public class GameRecord
    {
        public int Id { get; set; }
        public string PlayerXName { get; set; }
        public string PlayerOName { get; set; }
        public string Winner { get; set; }
        public DateTime DatePlayed { get; set; }
        public string Moves { get; set; }
    }
}
