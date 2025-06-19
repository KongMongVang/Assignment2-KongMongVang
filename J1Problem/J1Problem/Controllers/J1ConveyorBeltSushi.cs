using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace J1ConveyorBeltSushi.Controllers;

[ApiController]
[Route("api/J1/ConveyorBeltSushi")]
public class ConveyorBeltSushi : ControllerBase
{
    /// <summary>
    /// Calculates much your sushi meal costs
    /// You tell it how many red, green, and blue plates you picked
    /// Red plates cost $3 each, green ones $4, and blue ones $5 
    /// It then adds everything up and shows you the total price
    /// </summary>
    /// 
    /// <returns>The final score at the end of the game</returns>
    /// 
    /// <example>'POST' \'http://localhost:5262/api/J1/Delivedroid' \
    /// -H 'accept: */*' \
    /// -H 'Content-Type: multipart/form-data' \
    /// -F 'Collisions=2' \
    /// -F 'Deliveries=5' -> Score: 730
    /// </example>
    ///
    /// <param name="Collisions">Number of obstacle collisions</param>
    /// <param name="Deliveries">Number of packages delivered</param>
}