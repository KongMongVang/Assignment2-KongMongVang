using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace J1Problem.Controllers;

[ApiController]
[Route("api/[controller]")]

public class J3Q1 : ControllerBase
{
    /// <summary>
    /// Takes distances between five cities and generates a table showing how far each city is from the others
    /// </summary>
    /// 
    /// <param name="distances" enters message</param>
    /// 
    /// <returns> 
    /// A set of 5 strings, each string giving the distances from one city to the rest
    /// </returns>
    /// 
    /// <example>
    /// 'POST' \ 'http://localhost:5262/api/J3Q1/AreWeThereYet' \ -H 'accept: text/plain' \ -H 'Content-Type: application/json' \ -d '[3, 10, 12, 5]
    /// response: ["0 3 13 25 30","3 0 10 22 27","13 10 0 12 17","25 22 12 0 5","30 27 17 5 0"]
    /// 'POST' \ 'http://localhost:5262/api/J3Q1/AreWeThereYet' \ -H 'accept: text/plain' \ -H 'Content-Type: application/json' \ -d '[6, 24, 18, 2]
    /// response: ["0 6 30 48 50","6 0 24 42 44","30 24 0 18 20","48 42 18 0 2","50 44 20 2 0"]
    /// </example>


    [HttpPost("AreWeThereYet")]
    public ActionResult<string[]> DistanceTable([FromBody] int[] distances)
    {
        int[] positions = new int[5];
        for (int i = 1; i < 5; i++)
        {
            positions[i] = positions[i - 1] + distances[i - 1];
        }

        string[] result = new string[5];
        for (int i = 0; i < 5; i++)
        {
            string row = "";
            for (int j = 0; j < 5; j++)
            {
                row += Math.Abs(positions[i] - positions[j]);
                if (j < 4) row += " ";
            }
            result[i] = row;
        }

        return result;
    }

}