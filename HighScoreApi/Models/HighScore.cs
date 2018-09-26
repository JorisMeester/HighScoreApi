using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HighScoreApi.Models
{
    public class HighScore
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public string UserName { get; set; }
    }
}