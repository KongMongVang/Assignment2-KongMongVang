using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace J1Problem.Controllers;

[ApiController]
[Route("api/[controller]")]

public class J1Q2 : ControllerBase
{
    /// <summary>
    /// checks if a given date is before, after, or exactly on February 18
    /// Will input two integers; month and day
    /// </summary>
    /// 
    /// <param name=" </param>
    /// <param name=" </param>
    /// 
    /// <returns>
    /// Will output Before, After, or Special depending on the comparison with February 18
    /// </returns>
    /// 
    /// <example>
    /// </example>



    [HttpPost(template: "SpecialDay")]


}
