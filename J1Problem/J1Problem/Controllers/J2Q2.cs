using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace J1Problem.Controllers;

[ApiController]
[Route("api/[controller]")]

public class J2Q2 : ControllerBase
{
    /// <summary>
    /// Adds up how spicy the chili is
    /// User types in pepper names
    /// </summary>
    /// 
    /// <param name="ingredients" enter the type of pepper from pepper list</param>
    /// 
    /// <returns> 
    /// Will shows the total spiciness
    /// </returns>
    /// 
    /// <example>
    /// GET "http://localhost:5262/api/J2Q1/ChiliPepper?Ingredients=Poblano%2CPoblano%2CPoblano%2CPoblano%2CPoblano%20"
    /// response: 6000
    /// GET "http://localhost:5262/api/J2Q1/ChiliPepper?Ingredients=Poblano%2CMirasol%2CSerrano%2CCayenne%2CThai%2CHabanero%20"
    /// response: 138000
    /// GET "http://localhost:5262/api/J2Q1/ChiliPepper?Ingredients=Mirasol%2CSerrano%2CThai%2C%20Habanero%20" 
    /// response: 96500
    /// GET "http://localhost:5262/api/J2Q1/ChiliPepper?Ingredients=Mirasol%2CSerrano%2CThai%2CHabanero%20"
    /// response: 96500  
    /// </example>


    [HttpPost(template: "Decompress")]
    public Ac(string Ingredients)
    {
        int heat = 0;
        string[] SHU = Ingredients.Split(",");

        for (int i = 0; i < SHU.Length; i++)
        {
            if (SHU[i] == "Poblano")
            {
                heat = heat + 1500;
            }
            else if (SHU[i] == "Mirasol")
            {
                heat = heat + 6000;
            }
            else if (SHU[i] == "Serrano")
            {
                heat = heat + 15500;
            }
            else if (SHU[i] == "Cayenne")
            {
                heat = heat + 40000;
            }
            else if (SHU[i] == "Thai")
            {
                heat = heat + 75000;
            }
            else if (SHU[i] == "Habanero")
            {
                heat = heat + 125000;
            }
        }
        return heat;
    }

}