using HighScoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        HighScore[] highScores = new HighScore[]
        {
            new HighScore { Id = 1, Score = 1000, UserName = "Groceries" },
            new HighScore { Id = 2, Score = 100, UserName = "Groceries" },
            new HighScore { Id = 3, Score = 10, UserName = "Groceries" }
        };

        public IEnumerable<HighScore> GetAllHighScores()
        {
            return highScores;
        }

        public IHttpActionResult GetHighScore(int id)
        {
            var highScore = highScores.FirstOrDefault((p) => p.Id == id);
            if (highScore == null)
            {
                return NotFound();
            }
            return Ok(highScore);
        }
    }
}