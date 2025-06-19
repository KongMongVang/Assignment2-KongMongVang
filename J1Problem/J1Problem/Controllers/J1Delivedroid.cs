using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace J1Delivedroid.Controllers;

[ApiController]
[Route("api/J1/Delivedroid")]
public class J1Delivedroi : ControllerBase
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
    /// <example>'POST' \'http://localhost:5262/api/J1/Delivedroid' \
    /// -H 'accept: */*' \
    /// -H 'Content-Type: multipart/form-data' \
    /// -F 'Collisions=2' \
    /// -F 'Deliveries=5' -> Score: 730
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
