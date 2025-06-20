using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace J1Problem.Controllers;

[ApiController]
[Route("api/[controller]")]

public class J2Q2 : ControllerBase
{
    /// <summary>
    /// Decodes a given message
    /// User types types in message by writing positive integer and symbol
    /// </summary>
    /// 
    /// <param name="messages" enters message</param>
    /// 
    /// <returns> 
    /// Will decode the given message
    /// </returns>
    /// 
    /// <example>
    /// 'POST' \ 'http://localhost:5262/api/J2Q2/Decompress' \ -H 'accept: text/plain' \ -H 'Content-Type: application/json' \ -d '["3 a"]'
    /// response: ["aaa"]
    /// 'POST' \ 'http://localhost:5262/api/J2Q2/Decompress' \ -H 'accept: text/plain' \ -H 'Content-Type: application/json' \ -d '["9 +"]'
    /// response: ["+++++++++"]
    /// 'POST' \ 'http://localhost:5262/api/J2Q2/Decompress' \ -H 'accept: text/plain' \ -H 'Content-Type: application/json' \ -d '["3 -"]'
    /// response: ["---"]
    /// </example>


    [HttpPost("Decompress")]
    public List<string> DecodeMessage([FromBody] List<string> messages)
    {
        var output = new List<string>();

        foreach (var message in messages)
        {
            var parts = message.Split(' ');

            if (parts.Length < 2 || !int.TryParse(parts[0], out int count) || count <= 0 || count >= 100)
                continue;

            string word = parts[1];
            string repeated = "";

            for (int i = 0; i < count; i++)
            {
                repeated += word;
            }

            output.Add(repeated);
        }

        return output;
    }

}