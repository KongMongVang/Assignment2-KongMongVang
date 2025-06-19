using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace J1Problem.Controllers;

[ApiController]
[Route("api/[controller]")]

public class J1Controller : ControllerBase
{
    /// <summary>
    /// Calculates the final score for the Deliv-e-droid game.
    /// Win 50 points for each package delivered.
    /// Lose 10 points for every collision.
    /// Receive 500 bonus points if deliveries are greater than collisions.
    /// </summary>
    /// 
    /// <param name="Collisions">Number of obstacle collisions</param>
    /// <param name="Deliveries">Number of packages delivered</param>
    /// 
    /// <returns>
    /// The final score at the end of the game
    /// </returns>
    /// 
    /// <example>
    /// "POST" -H "Content-Type: application/x-www-form-urlencoded" -d "Collisions=5&Deliveries=9" http://localhost:5262/api/J1/Delivedroid 
    /// response: 900
    /// "POST" -H "Content-Type: application/x-www-form-urlencoded" -d "Collisions=8&Deliveries=4" http://localhost:5262/api/J1/Delivedroid
    /// response: 120
    /// "POST" -H "Content-Type: application/x-www-form-urlencoded" -d "Collisions=23&Deliveries=42" http://localhost:5262/api/J1/Delivedroid
    /// response: 2370
    /// </example> 
   
  
    [HttpPost(template: "Delivedroid")]
    public int Post([FromForm] int Collisions, [FromForm] int Deliveries)
    {
        int score = (Deliveries * 50) - (Collisions * 10);

        if (Deliveries > Collisions)
        {
            score += 500;
        }
        return score;
    }
}