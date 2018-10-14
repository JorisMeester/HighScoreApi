using HighScoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HighScoreApi.Controllers
{
    public class HighScoresController : ApiController
    {
        HighScore[] highScores = new HighScore[]
        {
            new HighScore { Id = 1, Score = 1000, UserName = "Henk" },
            new HighScore { Id = 2, Score = 100, UserName = "Klaas" },
            new HighScore { Id = 3, Score = 10, UserName = "Piet" }
        };

        public IEnumerable<HighScore> GetAllHighScores()
        {
            return highScores;
        }

        public IHttpActionResult GetHighScore(int id)
        {
            var highScore = highScores.FirstOrDefault(p => p.Id == id);
            if (highScore == null)
            {
                return NotFound();
            }
            return Ok(highScore);
        }

        //[HttpPost]
        //public IHttpActionResult PostHighScore(string highScore)
        //{
        //    return Ok(highScore);
        //}

        public void Post(HighScore highScore)
        {
        }
    }
}