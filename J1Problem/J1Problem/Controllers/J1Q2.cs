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
    /// <param name="Dates" enter the date using numbers </param>
    /// <param name="Months" Enter the month using numbers</param>
    /// 
    /// <returns>
    /// Will output Before, After, or Special depending on the comparison with February 18
    /// </returns>
    /// 
    /// <example>
    /// "POST" -H "Content-Type: application/x-www-form-urlencoded" -d "Dates=28&Months=1" http://localhost:5262/api/J1Q2/SpecialDay
    /// responds: Before
    /// "POST" -H "Content-Type: application/x-www-form-urlencoded" -d "Dates=15&Months=03" http://localhost:5262/api/J1Q2/SpecialDay
    /// responds: After
    /// "POST" -H "Content-Type: application/x-www-form-urlencoded" -d "Dates=18&Months=2" http://localhost:5262/api/J1Q2/SpecialDay
    /// responds: Special                                                                                                                                                  
    /// </example>



    [HttpPost(template: "SpecialDay")]
    public string SpecialDay([FromForm] int Dates, [FromForm] int Months)
    {
        if (Months == 2 && Dates == 18)
        {
            return "Special";
        }
        if (Months < 2 || Dates < 18 && Months == 2)
        {
            return "Before";
        }
        return "After";
    }

}
