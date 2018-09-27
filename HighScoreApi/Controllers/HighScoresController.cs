using HighScoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace HighScoreApi.Controllers
{
    public class HighScoresController : ApiController
    {
        HighScore[] highscores = new HighScore[]
        {
            new HighScore { Id = 1, Score = 1000, UserName = "Henk" },
            new HighScore { Id = 2, Score = 100, UserName = "Klaas" },
            new HighScore { Id = 3, Score = 10, UserName = "Piet" }
        };

        public IEnumerable<HighScore> GetAllHighScores()
        {
            return highscores;
        }

        public IHttpActionResult GetHighScore(int id)
        {
            var highscore = highscores.FirstOrDefault((p) => p.Id == id);
            if (highscore == null)
            {
                return NotFound();
            }
            return Ok(highscore);
        }
    }
}